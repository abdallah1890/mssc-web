using Microsoft.AspNetCore.Mvc;
using MSSC.Web;
using MSSC.Web.Data;

namespace MSSC.Web.Controllers;

public class CareersController : Controller
{
    public IActionResult Index()
    {
        var jobs = CareerData.GetActiveJobs();
        var values = CareerData.GetCompanyValues();
        var benefits = CareerData.GetTeamBenefits();

        ViewBag.Jobs = jobs;
        ViewBag.Values = values;
        ViewBag.Benefits = benefits;
        ViewBag.Title = Lang.T("Careers at MSSC", "الوظائف | شركة حلول النظم الإدارية MSSC");
        ViewBag.Description = Lang.T("Join MSSC and help drive organizational excellence across Saudi Arabia. Explore current openings.",
                                     "انضم إلى شركة حلول النظم الإدارية (MSSC) وساهم في التميز المؤسسي في المملكة. اطّلع على الوظائف المتاحة.");
        return View();
    }

    [Route("careers/{slug}")]
    public IActionResult JobDetail(string slug)
    {
        var job = CareerData.GetJobBySlug(slug);
        if (job == null)
            return NotFound();

        var relatedJobs = CareerData.GetActiveJobs()
            .Where(j => j.Slug != slug)
            .Take(3)
            .ToList();

        ViewBag.RelatedJobs = relatedJobs;
        ViewBag.Title = $"{job.TitleLocalized} | " + Lang.T("Careers at MSSC", "وظائف MSSC");
        ViewBag.Description = job.DescriptionLocalized;
        return View(job);
    }

    [Route("careers/apply/{slug}")]
    public IActionResult Apply(string slug)
    {
        var job = CareerData.GetJobBySlug(slug);
        if (job == null)
            return NotFound();

        ViewBag.Title = Lang.T($"Apply for {job.Title} | MSSC Careers", $"التقديم على وظيفة {job.TitleLocalized} | MSSC");
        ViewBag.Description = Lang.T($"Submit your application for the {job.Title} position at MSSC.", $"قدّم طلبك لوظيفة {job.TitleLocalized} في شركة حلول النظم الإدارية (MSSC).");
        return View(job);
    }
}
