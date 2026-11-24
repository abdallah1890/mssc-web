using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml.Linq;
using MSSC.Web.Data;
using MSSC.Web.Models;

namespace MSSC.Web.Controllers;

public class SeoController : Controller
{
    private static readonly string[] StaticPages =
    {
        "/",
        "/about",
        "/framework",
        "/government-solutions",
        "/enterprise-solutions",
        "/offers",
        "/proof-hub",
        "/contact",
        "/training",
        "/training/programs",
        "/training/schedule",
        "/training/corporate",
        "/training/individual",
        "/training/accreditations",
        "/training/delivery",
        "/training/about",
        "/training/contact",
        "/training/trainers",
        "/clients-partners",
        "/case-studies",
        "/careers",
    };

    // Content is static C#, so the last deploy is the best available "last modified" signal.
    private static readonly string LastMod =
        System.IO.File.GetLastWriteTimeUtc(typeof(SeoController).Assembly.Location).ToString("yyyy-MM-dd");

    [Route("sitemap.xml")]
    [ResponseCache(Duration = 86400)]
    public IActionResult Sitemap()
    {
        XNamespace ns = "http://www.sitemaps.org/schemas/sitemap/0.9";

        var paths = new List<string>(StaticPages);
        foreach (var category in TrainingData.GetCategories())
        {
            paths.Add($"/training/programs/{category.Slug}");
            paths.AddRange(category.Programs.Select(p => $"/training/programs/{category.Slug}/{p.Slug}"));
        }

        paths.AddRange(IndustryData.GetCaseStudies().Select(c => $"/case-studies/{c.Slug}"));
        paths.AddRange(CareerData.GetActiveJobs().Select(j => $"/careers/{j.Slug}"));

        XNamespace xhtml = "http://www.w3.org/1999/xhtml";

        XElement Alt(string lang, string href) => new(xhtml + "link",
            new XAttribute("rel", "alternate"), new XAttribute("hreflang", lang), new XAttribute("href", href));

        IEnumerable<XElement> Entries(string path)
        {
            var ar = SeoModel.SiteUrl + path;
            var en = SeoModel.SiteUrl + (path == "/" ? "/en" : "/en" + path);
            foreach (var loc in new[] { ar, en })
                yield return new XElement(ns + "url",
                    new XElement(ns + "loc", loc),
                    new XElement(ns + "lastmod", LastMod),
                    Alt("ar-SA", ar), Alt("en", en), Alt("x-default", ar));
        }

        var sitemap = new XDocument(
            new XDeclaration("1.0", "UTF-8", null),
            new XElement(ns + "urlset",
                new XAttribute(XNamespace.Xmlns + "xhtml", xhtml),
                paths.Distinct().SelectMany(Entries))
        );

        return Content(sitemap.ToString(), "application/xml", Encoding.UTF8);
    }

    [Route("robots.txt")]
    [ResponseCache(Duration = 86400)]
    public IActionResult Robots()
    {
        var robotsContent = @"# Robots.txt for MSSC Website
User-agent: *
Allow: /
Disallow: /admin/
Disallow: /api/
Disallow: /set-language
Disallow: /training/pay
Disallow: /training/payment/

# AI assistants and AI search (ChatGPT, Gemini, Perplexity, Claude) are welcome
User-agent: GPTBot
Allow: /

User-agent: OAI-SearchBot
Allow: /

User-agent: ChatGPT-User
Allow: /

User-agent: Google-Extended
Allow: /

User-agent: PerplexityBot
Allow: /

User-agent: ClaudeBot
Allow: /

User-agent: Claude-SearchBot
Allow: /

Sitemap: https://mssc.com.sa/sitemap.xml
";

        return Content(robotsContent, "text/plain", Encoding.UTF8);
    }

    [Route("llms.txt")]
    [ResponseCache(Duration = 86400)]
    public IActionResult LlmsTxt()
    {
        var sb = new StringBuilder();
        sb.AppendLine("# Management System Solutions Co. (MSSC) — شركة حلول النظم الإدارية");
        sb.AppendLine();
        sb.AppendLine("> MSSC is an institutional advisory and training firm based in Riyadh, Saudi Arabia. It builds governance, performance management, capability development and standards-readiness (ISO) systems for government, semi-government and enterprise organizations, aligned with Saudi Vision 2030. Its training arm is Horizon Solutions Training Center (مركز آفاق الحلول للتدريب), which delivers accredited courses in Riyadh and online.");
        sb.AppendLine();
        sb.AppendLine("Key facts:");
        sb.AppendLine("- Legal name: Management System Solutions Co. (MSSC); Arabic: شركة حلول النظم الإدارية");
        sb.AppendLine("- Training arm: Horizon Solutions Training Center (مركز آفاق الحلول للتدريب), a division of MSSC — both names refer to the same organization");
        sb.AppendLine("- Location: Al Imam Saud Ibn Faysal Rd, Riyadh 12363, Saudi Arabia");
        sb.AppendLine("- Corporate contact: +966 11 450 0896, info@mssc.com.sa");
        sb.AppendLine("- Training contact: +966 54 361 8430 (phone & WhatsApp), training@mssc.com.sa");
        sb.AppendLine("- Track record: 50+ engagements, 8+ sectors, 15+ years, 2,000+ professionals trained");
        sb.AppendLine("- Training accreditations: IOSH, CPD, TVTC (Technical and Vocational Training Corporation), ACMP");
        sb.AppendLine("- Languages: Arabic and English");
        sb.AppendLine();
        sb.AppendLine("## Advisory");
        sb.AppendLine($"- [The MSSC Framework]({SeoModel.SiteUrl}/framework): six connected pillars that integrate governance, performance management, capability development and standards readiness into one institutional operating system");
        sb.AppendLine($"- [Government solutions]({SeoModel.SiteUrl}/government-solutions): governance structures, performance systems and institutional capability for government and semi-government entities");
        sb.AppendLine($"- [Enterprise solutions]({SeoModel.SiteUrl}/enterprise-solutions): governance, performance discipline and capability for companies scaling their operations");
        sb.AppendLine($"- [Six focused offers]({SeoModel.SiteUrl}/offers): advisory offers, each addressing one institutional challenge, starting with the Institutional Readiness Diagnostic");
        sb.AppendLine($"- [Proof Hub]({SeoModel.SiteUrl}/proof-hub): engagement results, sectors served and accreditations");
        sb.AppendLine($"- [About MSSC]({SeoModel.SiteUrl}/about)");
        sb.AppendLine($"- [Contact / request a diagnostic]({SeoModel.SiteUrl}/contact)");
        sb.AppendLine();
        sb.AppendLine("## Training (Horizon Solutions Training Center)");
        sb.AppendLine($"- [Training home]({SeoModel.SiteUrl}/training)");
        sb.AppendLine($"- [Course schedule with dates and fees]({SeoModel.SiteUrl}/training/schedule)");
        sb.AppendLine($"- [Corporate training]({SeoModel.SiteUrl}/training/corporate)");
        sb.AppendLine($"- [Courses for individuals]({SeoModel.SiteUrl}/training/individual)");
        sb.AppendLine($"- [Accreditations]({SeoModel.SiteUrl}/training/accreditations)");
        sb.AppendLine($"- [Register for a course]({SeoModel.SiteUrl}/training/register)");
        sb.AppendLine();
        sb.AppendLine("## Training programs");
        foreach (var category in TrainingData.GetCategories())
        {
            sb.AppendLine($"- [{category.Title} ({category.TitleAr})]({SeoModel.SiteUrl}/training/programs/{category.Slug}): {string.Join("; ", category.Programs.Select(p => p.Title))}");
        }
        sb.AppendLine();
        sb.AppendLine("## Social profiles");
        sb.AppendLine("- LinkedIn: https://www.linkedin.com/company/horizon.mssc");
        sb.AppendLine("- Instagram: https://www.instagram.com/horizon.mssc/");
        sb.AppendLine("- X: https://x.com/horizonmssc");
        sb.AppendLine("- Facebook: https://www.facebook.com/horizon.mssc");
        sb.AppendLine("- Snapchat: https://www.snapchat.com/add/horizon.mssc");

        return Content(sb.ToString(), "text/plain", Encoding.UTF8);
    }
}
