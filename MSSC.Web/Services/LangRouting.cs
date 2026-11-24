using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MSSC.Web.Services;

/// <summary>
/// Path-based language routing: Arabic lives at the root, English under /en/.
/// The /en prefix is stripped before routing so controllers stay language-agnostic.
/// </summary>
public static class LangRouting
{
    public const string EnPrefix = "/en";
    private const string ItemKey = "LangPrefix";

    public static bool IsEnglish(HttpContext context) => context.Items.ContainsKey(ItemKey);

    public static string Prefix(HttpContext context) => IsEnglish(context) ? EnPrefix : string.Empty;

    public static string Localize(HttpContext context, string path)
    {
        if (!IsEnglish(context) || !NeedsPrefix(path))
            return path;
        return path == "/" ? EnPrefix : EnPrefix + path;
    }

    internal static bool NeedsPrefix(string href)
    {
        if (string.IsNullOrEmpty(href) || href[0] != '/' || href.StartsWith("//"))
            return false;

        var end = href.IndexOfAny(new[] { '?', '#' });
        var path = end >= 0 ? href[..end] : href;

        if (path == EnPrefix || path.StartsWith(EnPrefix + "/", StringComparison.OrdinalIgnoreCase))
            return false;
        if (path.StartsWith("/set-language", StringComparison.OrdinalIgnoreCase) ||
            path.StartsWith("/health", StringComparison.OrdinalIgnoreCase))
            return false;

        var lastSegment = path[(path.LastIndexOf('/') + 1)..];
        return !lastSegment.Contains('.'); // static files and sitemap.xml / robots.txt are not localized
    }

    public static IApplicationBuilder UseLangPrefix(this IApplicationBuilder app) =>
        app.Use(async (context, next) =>
        {
            var english = false;

            if (context.Request.Path.StartsWithSegments(EnPrefix, out var rest))
            {
                english = true;
                context.Request.Path = rest.HasValue && rest.Value != "/" ? rest : new PathString("/");
            }
            else if (!HttpMethods.IsGet(context.Request.Method) && !HttpMethods.IsHead(context.Request.Method) &&
                     Uri.TryCreate(context.Request.Headers.Referer.ToString(), UriKind.Absolute, out var referer) &&
                     (referer.AbsolutePath == EnPrefix || referer.AbsolutePath.StartsWith(EnPrefix + "/", StringComparison.OrdinalIgnoreCase)))
            {
                // Form posts from English pages stay English.
                english = true;
            }

            if (english)
            {
                context.Items[ItemKey] = EnPrefix;
                context.Response.OnStarting(() =>
                {
                    var status = context.Response.StatusCode;
                    if (status is >= 300 and < 400 &&
                        context.Response.Headers.Location.ToString() is { Length: > 0 } location &&
                        NeedsPrefix(location))
                    {
                        context.Response.Headers.Location = Localize(context, location);
                    }
                    return Task.CompletedTask;
                });
            }

            await next();
        });
}

/// <summary>Prefixes root-relative anchors with /en when rendering the English site.</summary>
[HtmlTargetElement("a", Attributes = "href")]
public class LangLinkTagHelper : TagHelper
{
    [ViewContext, HtmlAttributeNotBound]
    public ViewContext ViewContext { get; set; } = default!;

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        if (output.Attributes.ContainsName("data-no-lang"))
        {
            output.Attributes.RemoveAll("data-no-lang");
            return;
        }

        if (!LangRouting.IsEnglish(ViewContext.HttpContext))
            return;

        var href = output.Attributes["href"]?.Value?.ToString();
        if (href != null && LangRouting.NeedsPrefix(href))
            output.Attributes.SetAttribute("href", LangRouting.Localize(ViewContext.HttpContext, href));
    }
}
