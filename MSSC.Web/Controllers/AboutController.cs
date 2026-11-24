using Microsoft.AspNetCore.Mvc;
using MSSC.Web;
using MSSC.Web.Data;
using MSSC.Web.Models;

namespace MSSC.Web.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        ViewData["Seo"] = new SeoModel
        {
            Title = Lang.T("About MSSC | Management System Solutions Co., Riyadh", "من نحن | شركة حلول النظم الإدارية MSSC"),
            Description = Lang.T("MSSC is a Riyadh-based institutional advisory and training firm. Its training arm is Horizon Solutions Training Center.",
                                 "شركة حلول النظم الإدارية (MSSC) شركة استشارات وتدريب مؤسسي مقرها الرياض، وذراعها التدريبية مركز آفاق الحلول للتدريب."),
            Keywords = Lang.T("about MSSC, management consulting firm, Saudi Arabia consulting, Riyadh consultants, Vision 2030", "عن MSSC، شركة استشارات إدارية، استشارات السعودية، مستشارو الرياض، رؤية 2030"),
            CanonicalUrl = "https://mssc.com.sa/about"
        };

        ViewBag.Stats = new Dictionary<string, string>
        {
            { "Years of Experience", "5+" },
            { "Projects Completed", "15+" },
            { "Satisfied Clients", "10+" },
            { "Expert Consultants", "50+" }
        };

        return View();
    }
}
