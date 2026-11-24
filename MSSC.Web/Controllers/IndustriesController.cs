using Microsoft.AspNetCore.Mvc;
using MSSC.Web;
using MSSC.Web.Data;

namespace MSSC.Web.Controllers;

public class IndustriesController : Controller
{
    [Route("clients-partners")]
    public IActionResult ClientsPartners()
    {
        var clients = IndustryData.GetClients();
        var partners = IndustryData.GetPartners();
        var caseStudies = IndustryData.GetCaseStudies();

        ViewBag.Clients = clients;
        ViewBag.Partners = partners;
        ViewBag.CaseStudies = caseStudies;
        ViewBag.Title = Lang.T("Clients & Partners | MSSC", "العملاء والشركاء | شركة حلول النظم الإدارية MSSC");
        ViewBag.Description = Lang.T("Organizations across Saudi Arabia that MSSC works with on consulting and training.",
                                     "الجهات والمؤسسات التي تعمل معها شركة حلول النظم الإدارية (MSSC) في الاستشارات والتدريب داخل المملكة.");
        return View();
    }

    [Route("case-studies")]
    public IActionResult CaseStudies()
    {
        var caseStudies = IndustryData.GetCaseStudies();
        ViewBag.Title = Lang.T("Case Studies | MSSC", "دراسات الحالة | شركة حلول النظم الإدارية MSSC");
        ViewBag.Description = Lang.T("How MSSC has helped organizations in Saudi Arabia achieve their strategic objectives.",
                                     "كيف ساعدت شركة حلول النظم الإدارية (MSSC) المؤسسات في المملكة على تحقيق أهدافها الاستراتيجية.");
        return View(caseStudies);
    }

    [Route("case-studies/{slug}")]
    public IActionResult CaseStudyDetail(string slug)
    {
        var caseStudy = IndustryData.GetCaseStudyBySlug(slug);
        if (caseStudy == null)
            return NotFound();

        ViewBag.Title = $"{caseStudy.TitleLocalized} | " + Lang.T("MSSC Case Study", "دراسة حالة MSSC");
        ViewBag.Description = caseStudy.ChallengeLocalized;
        return View(caseStudy);
    }
}
