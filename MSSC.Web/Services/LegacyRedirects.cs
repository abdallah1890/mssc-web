namespace MSSC.Web.Services;

public static class LegacyRedirects
{
    private static readonly Dictionary<string, string> Map = new(StringComparer.OrdinalIgnoreCase)
    {
        ["/consulting"] = "/framework",
        ["/consulting/asset-facility"] = "/offers",

        ["/services"] = "/offers",
        ["/services/strategy-management"] = "/framework",
        ["/services/change-management"] = "/offers",
        ["/services/portfolio-program-management"] = "/offers",
        ["/services/organizational-design"] = "/offers",
        ["/services/human-capital-development"] = "/training/corporate",
        ["/services/digital-transformation"] = "/offers",
        ["/projects"] = "/proof-hub",

        ["/about-us"] = "/about",
        ["/contact-us"] = "/contact",
        ["/strategy-management"] = "/framework",
        ["/governance-risk-compliance"] = "/framework",
        ["/change-management"] = "/offers",
        ["/portfolio-program-management"] = "/offers",
        ["/organizational-design"] = "/offers",
        ["/human-capital-development"] = "/training/corporate",
        ["/digital-transformation"] = "/offers",

        ["/how-to-implement-a-management-system-solution-in-your-business"] = "/framework",
        ["/how-to-evaluate-and-improve-your-existing-management-system-solution"] = "/framework",
    };

    private static readonly (string Prefix, string Target)[] Prefixes =
    {
        ("/services/", "/offers"),
        ("/projects/", "/proof-hub"),
        ("/consulting/", "/framework"),
    };

    public static string? Resolve(PathString path)
    {
        var value = path.Value;
        if (string.IsNullOrEmpty(value) || value == "/")
            return null;

        var key = value.TrimEnd('/');
        if (Map.TryGetValue(key, out var target))
            return target;

        foreach (var (prefix, prefixTarget) in Prefixes)
        {
            if (value.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return prefixTarget;
        }

        return null;
    }

    private static readonly string[] CanonicalDomains = { "mssc.com.sa" };

    // Returns the canonical absolute URL when the request used www. or plain http on a production domain.
    public static string? ResolveHost(HttpRequest request)
    {
        var host = request.Host.Host;
        var bare = host.StartsWith("www.", StringComparison.OrdinalIgnoreCase) ? host[4..] : host;
        if (!CanonicalDomains.Contains(bare, StringComparer.OrdinalIgnoreCase))
            return null;

        var needsHost = !ReferenceEquals(bare, host);
        if (!needsHost && request.IsHttps)
            return null;

        var prefix = LangRouting.Prefix(request.HttpContext);
        var path = prefix.Length > 0 && request.Path.Value == "/" ? string.Empty : request.Path.Value;
        return $"https://{bare}{prefix}{path}{request.QueryString}";
    }

    public static IApplicationBuilder UseLegacyRedirects(this IApplicationBuilder app) =>
        app.Use(async (context, next) =>
        {
            var canonical = ResolveHost(context.Request);
            if (canonical != null)
            {
                context.Response.Redirect(canonical, permanent: true);
                return;
            }

            var p = context.Request.Path.Value;
            if (HttpMethods.IsGet(context.Request.Method) && p is { Length: > 1 } && p.EndsWith('/'))
            {
                context.Response.Redirect(p.TrimEnd('/') + context.Request.QueryString, permanent: true);
                return;
            }

            var target = LegacyRedirects.Resolve(context.Request.Path);
            if (target != null)
            {
                context.Response.Redirect(target, permanent: true);
                return;
            }

            await next();
        });
}
