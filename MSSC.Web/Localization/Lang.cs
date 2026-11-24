using System.Globalization;

namespace MSSC.Web;

public static class Lang
{
    public static readonly string[] Supported = { "ar", "en" };

    public static bool IsArabic =>
        CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ar";

    public static string Code => IsArabic ? "ar" : "en";

    public static string Dir => IsArabic ? "rtl" : "ltr";

    public static string OgLocale => IsArabic ? "ar_SA" : "en_US";

    public static string OtherCode => IsArabic ? "en" : "ar";

    public static string OtherLabel => IsArabic ? "English" : "العربية";

    public static string T(string en, string ar) =>
        IsArabic ? (string.IsNullOrWhiteSpace(ar) ? en : ar) : en;

    public static string Pick(string en, string ar) => T(en, ar);

    public static List<string> PickList(List<string> en, List<string> ar) =>
        IsArabic && ar is { Count: > 0 } ? ar : en;
}
