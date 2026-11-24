using Microsoft.AspNetCore.Mvc;
using MSSC.Web;
using MSSC.Web.Models;

namespace MSSC.Web.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewData["Seo"] = new SeoModel
        {
            Title = Lang.T("Contact MSSC | Request an Institutional Readiness Diagnostic", "تواصل معنا | اطلب تشخيص الجاهزية المؤسسية من MSSC"),
            Description = Lang.T("Contact MSSC in Riyadh: +966 11 450 0896, info@mssc.com.sa. Training & WhatsApp: +966 54 361 8430.",
                                 "تواصل مع شركة حلول النظم الإدارية (MSSC) بالرياض: 0114500896 أو info@mssc.com.sa. للتدريب وواتساب: 0543618430."),
            Keywords = Lang.T("contact MSSC, consulting contact, Riyadh office, management consulting Saudi Arabia", "تواصل MSSC، تواصل استشارات، مكتب الرياض، استشارات إدارية السعودية"),
            CanonicalUrl = "https://mssc.com.sa/contact"
        };

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Submit(ContactFormModel model)
    {
        if (!ModelState.IsValid)
        {
            TempData["Error"] = Lang.T("Please fill in all required fields.", "يُرجى تعبئة جميع الحقول المطلوبة.");
            return RedirectToAction("Index");
        }

        TempData["Success"] = Lang.T("Thank you for your message. We will contact you shortly.", "شكراً لرسالتك. سنتواصل معك قريباً.");
        return RedirectToAction("Index");
    }
}
