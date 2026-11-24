using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MSSC.Web.Models;

public class SeoModel
{
    public const string SiteUrl = "https://mssc.com.sa";

    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Keywords { get; set; } = string.Empty;
    public string CanonicalUrl { get; set; } = string.Empty;
    public string OgImage { get; set; } = string.Empty;
    public string OgType { get; set; } = "website";
    public string Robots { get; set; } = "index, follow";
    public string AlternateAr { get; set; } = string.Empty;
    public string AlternateEn { get; set; } = string.Empty;
    public string OtherLangUrl { get; set; } = "/";

    public static void NoIndex(ViewDataDictionary viewData, bool follow = false) =>
        viewData["Robots"] = follow ? "noindex, follow" : "noindex, nofollow";

    public static SeoModel Resolve(ViewDataDictionary viewData, HttpRequest request,
        string defaultTitle, string defaultDescription, string defaultOgImage)
    {
        var seo = viewData["Seo"] as SeoModel ?? new SeoModel
        {
            Title = viewData["Title"] as string ?? string.Empty,
            Description = viewData["Description"] as string ?? string.Empty
        };

        if (viewData["Robots"] is string robots)
            seo.Robots = robots;

        if (string.IsNullOrWhiteSpace(seo.Title))
            seo.Title = defaultTitle;
        seo.Description = Truncate(string.IsNullOrWhiteSpace(seo.Description) ? defaultDescription : seo.Description);

        var path = (request.Path.Value?.TrimEnd('/') ?? string.Empty).ToLowerInvariant();
        var english = Services.LangRouting.IsEnglish(request.HttpContext);
        seo.AlternateAr = SiteUrl + (path.Length == 0 ? "/" : path);
        seo.AlternateEn = SiteUrl + Services.LangRouting.EnPrefix + path;
        seo.OtherLangUrl = (english ? (path.Length == 0 ? "/" : path) : Services.LangRouting.EnPrefix + path)
                           + request.QueryString;

        if (english)
            seo.CanonicalUrl = seo.AlternateEn;
        else if (string.IsNullOrWhiteSpace(seo.CanonicalUrl))
            seo.CanonicalUrl = seo.AlternateAr;

        var image = string.IsNullOrWhiteSpace(seo.OgImage) ? defaultOgImage : seo.OgImage;
        seo.OgImage = image.StartsWith("http", StringComparison.OrdinalIgnoreCase) ? image : SiteUrl + image;

        return seo;
    }

    private static string Truncate(string text, int max = 158)
    {
        text = text.Trim();
        if (text.Length <= max)
            return text;

        var cut = text.LastIndexOf(' ', max - 1);
        return text[..(cut > 0 ? cut : max - 1)].TrimEnd(',', '،', ';', ':', '-', '—', ' ') + "…";
    }
}
