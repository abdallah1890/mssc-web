namespace MSSC.Web.Services;

public static class Tracking
{
    private static readonly string[] GoogleSites = { "Mssc", "Hstc" };

    public record GoogleIds(string GtmId, string Ga4Id, string SiteVerification);

    public static GoogleIds Google(IConfiguration config, HttpContext context)
    {
        var host = context.Request.Host.Host ?? string.Empty;
        foreach (var site in GoogleSites)
        {
            var section = config.GetSection($"Analytics:{site}");
            if (HostMatches(host, section["Host"], emptyMatchesAll: false))
                return new GoogleIds(
                    Clean(section["GtmId"]),
                    Clean(section["Ga4Id"]),
                    Clean(section["SiteVerification"]));
        }
        return new GoogleIds("", "", "");
    }

    public static string Pixel(IConfiguration config, HttpContext context, string name)
    {
        var section = config.GetSection($"Analytics:{name}");
        var id = Clean(section["PixelId"]);
        return id.Length > 0 && HostMatches(context.Request.Host.Host ?? string.Empty, section["Hosts"], emptyMatchesAll: true)
            ? id
            : string.Empty;
    }

    private static bool HostMatches(string requestHost, string? hosts, bool emptyMatchesAll)
    {
        var allowed = (hosts ?? string.Empty)
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (allowed.Length == 0)
            return emptyMatchesAll;

        return allowed.Any(h =>
            requestHost.Equals(h, StringComparison.OrdinalIgnoreCase)
            || requestHost.EndsWith("." + h, StringComparison.OrdinalIgnoreCase));
    }

    private static string Clean(string? value)
    {
        var v = (value ?? string.Empty).Trim();
        return v.All(c => char.IsAsciiLetterOrDigit(c) || c is '-' or '_') ? v : string.Empty;
    }
}
