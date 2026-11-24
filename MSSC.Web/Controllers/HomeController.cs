using Microsoft.AspNetCore.Mvc;
using MSSC.Web;
using MSSC.Web.Data;
using MSSC.Web.Models;

namespace MSSC.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Seo"] = new SeoModel
        {
            Title = Lang.T("MSSC | Governance & Performance Consulting in Riyadh", "شركة حلول النظم الإدارية MSSC | استشارات الحوكمة بالرياض"),
            Description = Lang.T("Management System Solutions Co. (MSSC), Riyadh: governance, performance management, ISO readiness and capability building for government and enterprise.",
                                 "شركة حلول النظم الإدارية (MSSC) بالرياض: استشارات الحوكمة وإدارة الأداء وجاهزية الأيزو وبناء القدرات للجهات الحكومية والشركات، مع تدريب معتمد."),
            Keywords = Lang.T("governance consulting Riyadh, performance management, KPIs, ISO consulting, EFQM, institutional excellence, Saudi Arabia, Vision 2030", "استشارات الحوكمة الرياض، إدارة الأداء المؤسسي، مؤشرات الأداء، استشارات الأيزو، التميز المؤسسي، شركة حلول النظم الإدارية، رؤية 2030"),
            CanonicalUrl = "https://mssc.com.sa/",
            OgImage = "/images/og-image.jpg"
        };

        return View();
    }

    [Route("privacy")]
    public IActionResult Privacy()
    {
        ViewBag.Title = Lang.T("Privacy Policy | MSSC", "سياسة الخصوصية | شركة حلول النظم الإدارية MSSC");
        ViewBag.Description = Lang.T("How MSSC collects, uses and protects your personal data.", "كيف تجمع شركة حلول النظم الإدارية (MSSC) بياناتك الشخصية وتستخدمها وتحميها.");
        return View();
    }

    [Route("cookie-policy")]
    public IActionResult CookiePolicy()
    {
        ViewBag.Title = Lang.T("Cookie Policy | MSSC", "سياسة ملفات الارتباط | شركة حلول النظم الإدارية MSSC");
        ViewBag.Description = Lang.T("How the MSSC website uses cookies and similar technologies.", "كيف يستخدم موقع شركة حلول النظم الإدارية (MSSC) ملفات الارتباط والتقنيات المشابهة.");
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}
