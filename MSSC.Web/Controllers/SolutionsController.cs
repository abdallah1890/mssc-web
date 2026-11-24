using Microsoft.AspNetCore.Mvc;
using MSSC.Web;

namespace MSSC.Web.Controllers;

public class SolutionsController : Controller
{
    [Route("framework")]
    public IActionResult Framework()
    {
        ViewBag.Title = Lang.T("The MSSC Framework | Six Pillars, One Operating System", "إطار عمل MSSC | ست ركائز لنظام تشغيل مؤسسي واحد");
        ViewBag.Description = Lang.T("A connected model integrating governance, performance management, capability development and standards readiness into one operating system.",
                                     "نموذج مؤسسي مترابط يدمج الحوكمة وإدارة الأداء وبناء القدرات والجاهزية للمعايير الدولية في نظام تشغيلي واحد.");
        return View();
    }

    [Route("government-solutions")]
    public IActionResult Government()
    {
        ViewBag.Title = Lang.T("Governance & Performance for Government Entities | MSSC", "حوكمة وأداء الجهات الحكومية | شركة حلول النظم الإدارية");
        ViewBag.Description = Lang.T("We help government and semi-government entities build governance structures, performance systems and institutional capability for Vision 2030.",
                                     "نساعد الجهات الحكومية وشبه الحكومية على بناء هياكل الحوكمة وأنظمة إدارة الأداء والقدرات المؤسسية بما يدعم رؤية 2030.");
        return View();
    }

    [Route("enterprise-solutions")]
    public IActionResult Enterprise()
    {
        ViewBag.Title = Lang.T("Corporate Governance & Performance for Enterprises | MSSC", "حوكمة الشركات وإدارة الأداء للمؤسسات | MSSC");
        ViewBag.Description = Lang.T("We help enterprises build governance, performance discipline and institutional capability to scale operations consistently.",
                                     "نساعد الشركات على بناء البنية التشغيلية الداخلية — الحوكمة وانضباط الأداء والقدرات المؤسسية — للتوسع بثبات.");
        return View();
    }

    [Route("offers")]
    public IActionResult Offers()
    {
        ViewBag.Title = Lang.T("Six Focused Advisory Offers | MSSC", "ستة عروض استشارية متخصصة | شركة حلول النظم الإدارية");
        ViewBag.Description = Lang.T("Six focused offers, each addressing a specific institutional challenge with practical outputs your organization can implement and sustain.",
                                     "ستة عروض استشارية، صُممت كل منها لمعالجة تحدٍ مؤسسي محدد وتقديم مخرجات عملية قابلة للتطبيق والاستدامة داخل مؤسستك.");
        return View();
    }

    [Route("proof-hub")]
    public IActionResult ProofHub()
    {
        ViewBag.Clients = MSSC.Web.Data.IndustryData.GetClients();
        ViewBag.Partners = MSSC.Web.Data.IndustryData.GetPartners();
        ViewBag.CaseStudies = MSSC.Web.Data.IndustryData.GetCaseStudies();
        ViewBag.Title = Lang.T("Proof Hub | MSSC Results, Sectors & Accreditations", "مركز الأدلة | نتائج واعتمادات شركة حلول النظم الإدارية");
        ViewBag.Description = Lang.T("50+ engagements, 8+ sectors, 15+ years, 2,000+ trainees: MSSC case results and accreditations (IOSH, ACMP, CPD, TVTC).",
                                     "أكثر من 50 مشروعًا و8 قطاعات و15 عامًا و2,000 متدرب: نتائج مشاريع MSSC واعتماداتها (IOSH وACMP وCPD وTVTC).");
        return View();
    }
}
