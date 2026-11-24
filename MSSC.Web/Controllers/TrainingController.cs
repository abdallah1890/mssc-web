using Microsoft.AspNetCore.Mvc;
using MSSC.Web.Data;
using MSSC.Web.Models;
using MSSC.Web.Services;

namespace MSSC.Web.Controllers;

public class TrainingController : Controller
{
    private readonly IConfiguration _configuration;
    private readonly HstcApiClient _hstcApi;

    public TrainingController(IConfiguration configuration, HstcApiClient hstcApi)
    {
        _configuration = configuration;
        _hstcApi = hstcApi;
    }

    public IActionResult Index()
    {
        var categories = TrainingData.GetCategories();
        var upcomingSessions = TrainingData.GetUpcomingSessions();
        var trainers = TrainingData.GetTrainers();
        var accreditations = TrainingData.GetAccreditations();

        ViewBag.Categories = categories;
        ViewBag.UpcomingSessions = upcomingSessions;
        ViewBag.Trainers = trainers;
        ViewBag.Accreditations = accreditations;
        ViewBag.Title = Lang.T("Horizon Solutions Training Center | Accredited Courses in Riyadh", "مركز آفاق الحلول للتدريب | دورات معتمدة في الرياض");
        ViewBag.Description = Lang.T("Accredited IOSH, ISO, governance, quality and leadership courses in Riyadh and online, by the training arm of MSSC.",
                                     "دورات معتمدة في IOSH والأيزو والحوكمة والجودة والقيادة حضوريًا في الرياض وعن بُعد، من مركز آفاق الحلول للتدريب التابع لـ MSSC.");

        return View();
    }

    [Route("training/programs")]
    public IActionResult Programs()
    {
        var categories = TrainingData.GetCategories();
        ViewBag.Title = Lang.T("Training Programs | Horizon Solutions Training Center", "البرامج التدريبية | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("All training programs: health & safety, ISO standards, governance, quality excellence, leadership and management.",
                                     "جميع البرامج التدريبية: الصحة والسلامة المهنية، معايير الأيزو، الحوكمة، التميز والجودة، القيادة والإدارة.");
        return View(categories);
    }

    [Route("training/programs/{categorySlug}")]
    public IActionResult Category(string categorySlug)
    {
        var category = TrainingData.GetCategoryBySlug(categorySlug);
        if (category == null)
            return NotFound();

        ViewBag.Title = $"{category.TitleLocalized} | " + Lang.T("Horizon Training", "مركز آفاق الحلول للتدريب");
        ViewBag.Description = category.DescriptionLocalized;
        return View(category);
    }

    [Route("training/programs/{categorySlug}/{programSlug}")]
    public IActionResult Program(string categorySlug, string programSlug)
    {
        var category = TrainingData.GetCategoryBySlug(categorySlug);
        var program = TrainingData.GetProgramBySlug(categorySlug, programSlug);

        if (category == null || program == null)
            return NotFound();

        var upcomingSessions = TrainingData.GetUpcomingSessions()
            .Where(s => s.ProgramId == program.Id)
            .ToList();

        ViewBag.Category = category;
        ViewBag.UpcomingSessions = upcomingSessions;
        ViewBag.Title = $"{program.TitleLocalized} | " + Lang.T("Horizon Training", "مركز آفاق الحلول للتدريب");
        ViewBag.Description = program.DescriptionLocalized;
        return View(program);
    }

    [Route("training/schedule")]
    public async Task<IActionResult> Schedule(int page = 1)
    {
        const int pageSize = 10;
        var allSessions = await _hstcApi.GetUpcomingSessionsAsync()
            ?? TrainingData.GetUpcomingSessions().Where(s => s.StartDate >= DateTime.Today).ToList();
        allSessions = allSessions.OrderBy(s => s.StartDate).ToList();

        var totalItems = allSessions.Count;
        var totalPages = (int)System.Math.Ceiling(totalItems / (double)pageSize);
        if (totalPages < 1) totalPages = 1;
        if (page < 1) page = 1;
        if (page > totalPages) page = totalPages;

        var pageSessions = allSessions
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        ViewBag.Categories = TrainingData.GetCategories();
        ViewBag.CurrentPage = page;
        ViewBag.TotalPages = totalPages;
        ViewBag.PageSize = pageSize;
        ViewBag.TotalItems = totalItems;
        ViewBag.Title = Lang.T("Training Schedule & Upcoming Courses | Horizon Training", "جدول الدورات التدريبية القادمة | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Dates, delivery mode and fees of upcoming courses at Horizon Solutions Training Center. Register online.",
                                     "مواعيد الدورات القادمة وطريقة تقديمها ورسومها في مركز آفاق الحلول للتدريب، مع التسجيل والدفع الإلكتروني.");
        if (page > 1) SeoModel.NoIndex(ViewData, follow: true);
        return View(pageSessions);
    }

    [Route("training/trainers")]
    public IActionResult Trainers()
    {
        var trainers = TrainingData.GetTrainers();
        ViewBag.Title = Lang.T("Our Trainers | Horizon Solutions Training Center", "المدربون | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Meet our certified trainers and facilitators with extensive industry experience.",
                                     "تعرّف على مدربي مركز آفاق الحلول للتدريب المعتمدين وخبراتهم العملية.");
        return View(trainers);
    }

    [Route("training/corporate")]
    public IActionResult Corporate()
    {
        var categories = TrainingData.GetCategories();
        ViewBag.Categories = categories;
        ViewBag.Title = Lang.T("Corporate Training for Organizations | Horizon Training", "التدريب المؤسسي للشركات والجهات | آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Corporate training built around your organization: needs assessment, tailored programs and lasting capability.",
                                     "برامج تدريب مؤسسي تُبنى حول واقع مؤسستك: تقييم الاحتياجات، وتصميم البرامج، وقياس الأثر واستدامته.");
        return View();
    }

    [Route("training/accreditations")]
    public IActionResult Accreditations()
    {
        var accreditations = TrainingData.GetAccreditations();
        ViewBag.Title = Lang.T("Accreditations (IOSH, CPD, TVTC, ACMP) | Horizon Training", "الاعتمادات IOSH وCPD وTVTC | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Our programs are accredited by IOSH, CPD, TVTC and ACMP, ensuring recognized certificates.",
                                     "برامجنا معتمدة من IOSH وCPD والمؤسسة العامة للتدريب التقني والمهني (TVTC) وACMP بشهادات معترف بها.");
        return View(accreditations);
    }

    [Route("training/register")]
    public async Task<IActionResult> Register(string? sessionId, int? programId)
    {
        var portalSessions = await _hstcApi.GetUpcomingSessionsAsync();
        var portalCourses = portalSessions != null ? await _hstcApi.GetCourseOptionsAsync() : null;
        var portalMode = portalSessions != null && portalCourses != null;

        List<TrainingSession> sessionList;
        List<CourseOption> courseOptions;

        if (portalMode)
        {
            sessionList = portalSessions!;
            courseOptions = portalCourses!;
        }
        else
        {
            var programs = TrainingData.GetAllPrograms();
            sessionList = TrainingData.GetUpcomingSessions()
                .Where(s => s.StartDate >= DateTime.Today)
                .OrderBy(s => s.StartDate)
                .ToList();
            foreach (var s in sessionList)
            {
                s.PortalSessionId = s.Id.ToString();
                s.PortalCourseId = programs.FirstOrDefault(p => p.Title == s.ProgramTitle)?.Id.ToString() ?? "";
            }
            courseOptions = programs
                .Select(p => new CourseOption { Id = p.Id.ToString(), Title = p.Title, TitleAr = p.TitleAr })
                .ToList();
        }

        string? selectedSession = null;
        if (!string.IsNullOrEmpty(sessionId))
        {
            selectedSession = sessionList.FirstOrDefault(s => s.PortalSessionId == sessionId)?.PortalSessionId;
            if (selectedSession == null && int.TryParse(sessionId, out var legacyId))
            {
                var legacy = TrainingData.GetUpcomingSessions().FirstOrDefault(s => s.Id == legacyId);
                if (legacy != null)
                    selectedSession = sessionList.FirstOrDefault(s =>
                        s.StartDate.Date == legacy.StartDate.Date &&
                        s.ProgramTitle.Equals(legacy.ProgramTitle, StringComparison.OrdinalIgnoreCase))?.PortalSessionId;
            }
        }

        var selectedCourse = selectedSession != null
            ? sessionList.First(s => s.PortalSessionId == selectedSession).PortalCourseId
            : null;
        if (selectedCourse == null && programId.HasValue)
        {
            var legacyProgram = TrainingData.GetAllPrograms().FirstOrDefault(p => p.Id == programId.Value);
            selectedCourse = portalMode
                ? courseOptions.FirstOrDefault(c => c.Title.Equals(legacyProgram?.Title, StringComparison.OrdinalIgnoreCase))?.Id
                : programId.Value.ToString();
        }

        SeoModel.NoIndex(ViewData);
        ViewBag.PortalMode = portalMode;
        ViewBag.SessionList = sessionList;
        ViewBag.CourseOptions = courseOptions;
        ViewBag.SelectedSessionValue = selectedSession;
        ViewBag.SelectedCourseValue = selectedCourse;
        ViewBag.HstcApiUrl = _configuration["HstcApi:BaseUrl"] ?? "http://localhost:5050";
        ViewBag.Title = Lang.T("Register for a Course | Horizon Solutions Training Center", "التسجيل في دورة | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Register for an upcoming course and pay online by card, Apple Pay, Tamara or Tabby.",
                                     "سجّل في إحدى الدورات القادمة وادفع إلكترونيًا بالبطاقة أو Apple Pay أو تمارا أو تابي.");
        return View();
    }

    [Route("training/pay")]
    public IActionResult Pay(string? @ref)
    {
        SeoModel.NoIndex(ViewData);
        ViewBag.RegistrationId = @ref;
        ViewBag.HstcApiUrl = _configuration["HstcApi:BaseUrl"] ?? "http://localhost:5050";
        ViewBag.Title = Lang.T("Complete Payment | Horizon Solutions Training Center", "إتمام الدفع | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Complete your training registration payment securely.", "أكمل دفع رسوم تسجيلك في الدورة بأمان.");
        return View();
    }

    [Route("training/payment/callback")]
    public async Task<IActionResult> PaymentCallback(string? id, string? status, string? message)
    {
        HstcResult<HstcPaymentResult>? confirm = null;
        if (!string.IsNullOrEmpty(id))
            confirm = await _hstcApi.ConfirmPaymentAsync(id);

        var ok = confirm?.IsSuccessful == true &&
                 string.Equals(confirm.ResultObject?.Status, "Paid", StringComparison.OrdinalIgnoreCase);

        SeoModel.NoIndex(ViewData);
        ViewBag.PaymentOk = ok;
        ViewBag.PaymentResult = confirm?.ResultObject;
        ViewBag.PaymentError = ok ? null : (confirm?.ErrorEntry?.ErrorMessage ?? message);
        ViewBag.PaymentErrorAr = ok ? null : confirm?.ErrorEntry?.ErrorMessageAr;
        ViewBag.Title = Lang.T("Payment Result | Horizon Solutions Training Center", "نتيجة الدفع | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Training registration payment result.", "نتيجة دفع رسوم التسجيل في الدورة.");
        return View("PaymentResult");
    }

    [Route("training/payment/tamara/callback")]
    public async Task<IActionResult> TamaraPaymentCallback(string? orderId, string? paymentId, string? status)
    {
        HstcResult<HstcPaymentResult>? confirm = null;
        if (!string.Equals(status, "cancel", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(orderId))
            confirm = await _hstcApi.ConfirmTamaraPaymentAsync(orderId);

        var ok = confirm?.IsSuccessful == true &&
                 string.Equals(confirm.ResultObject?.Status, "Paid", StringComparison.OrdinalIgnoreCase);

        SeoModel.NoIndex(ViewData);
        ViewBag.PaymentOk = ok;
        ViewBag.PaymentResult = confirm?.ResultObject;
        ViewBag.PaymentError = ok
            ? null
            : (confirm?.ErrorEntry?.ErrorMessage
               ?? (string.Equals(status, "cancel", StringComparison.OrdinalIgnoreCase)
                   ? "Payment was cancelled."
                   : "We could not confirm your Tamara payment. If you were charged, please contact us."));
        ViewBag.PaymentErrorAr = ok
            ? null
            : (confirm?.ErrorEntry?.ErrorMessageAr
               ?? (string.Equals(status, "cancel", StringComparison.OrdinalIgnoreCase)
                   ? "تم إلغاء عملية الدفع."
                   : "تعذّر تأكيد دفعتك عبر تمارا. إذا تم خصم المبلغ فيرجى التواصل معنا."));
        ViewBag.Title = Lang.T("Payment Result | Horizon Solutions Training Center", "نتيجة الدفع | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Training registration payment result.", "نتيجة دفع رسوم التسجيل في الدورة.");
        return View("PaymentResult");
    }

    [Route("training/payment/tabby/callback")]
    public async Task<IActionResult> TabbyPaymentCallback(
        [FromQuery(Name = "payment_id")] string? tabbyPaymentId, string? paymentId, string? status)
    {
        HstcResult<HstcPaymentResult>? confirm = null;
        if (!string.Equals(status, "cancel", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(tabbyPaymentId))
            confirm = await _hstcApi.ConfirmTabbyPaymentAsync(tabbyPaymentId);

        var ok = confirm?.IsSuccessful == true &&
                 string.Equals(confirm.ResultObject?.Status, "Paid", StringComparison.OrdinalIgnoreCase);

        SeoModel.NoIndex(ViewData);
        ViewBag.PaymentOk = ok;
        ViewBag.PaymentResult = confirm?.ResultObject;
        ViewBag.PaymentError = ok
            ? null
            : (confirm?.ErrorEntry?.ErrorMessage
               ?? (string.Equals(status, "cancel", StringComparison.OrdinalIgnoreCase)
                   ? "Payment was cancelled."
                   : "We could not confirm your Tabby payment. If you were charged, please contact us."));
        ViewBag.PaymentErrorAr = ok
            ? null
            : (confirm?.ErrorEntry?.ErrorMessageAr
               ?? (string.Equals(status, "cancel", StringComparison.OrdinalIgnoreCase)
                   ? "تم إلغاء عملية الدفع."
                   : "تعذّر تأكيد دفعتك عبر تابي. إذا تم خصم المبلغ فيرجى التواصل معنا."));
        ViewBag.Title = Lang.T("Payment Result | Horizon Solutions Training Center", "نتيجة الدفع | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Training registration payment result.", "نتيجة دفع رسوم التسجيل في الدورة.");
        return View("PaymentResult");
    }

    [Route("training/delivery")]
    public IActionResult Delivery()
    {
        ViewBag.Title = Lang.T("Training Delivery: In-Person, Virtual & Blended | Horizon", "طرق تقديم التدريب: حضوري وعن بُعد ومدمج | آفاق الحلول");
        ViewBag.Description = Lang.T("Classroom, virtual, blended and on-site training options to suit your team and schedule.",
                                     "خيارات تدريب حضورية وافتراضية ومدمجة وفي مقر الجهة بما يناسب فريقك وجدولك.");
        return View();
    }

    [Route("training/contact")]
    public IActionResult Contact()
    {
        var categories = TrainingData.GetCategories();
        ViewBag.Categories = categories;
        ViewBag.Title = Lang.T("Contact the Training Team | Horizon Solutions Training Center", "تواصل مع فريق التدريب | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Training inquiries, corporate programs and registration help: +966 54 361 8430 (WhatsApp), training@mssc.com.sa.",
                                     "للاستفسار عن الدورات والتدريب المؤسسي والتسجيل: 0543618430 (واتساب) أو training@mssc.com.sa.");
        return View();
    }

    [Route("training/individual")]
    public IActionResult Individual()
    {
        ViewBag.Categories = TrainingData.GetCategories();
        ViewBag.Title = Lang.T("Courses for Individuals | Horizon Solutions Training Center", "دورات للأفراد | مركز آفاق الحلول للتدريب");
        ViewBag.Description = Lang.T("Open-enrollment accredited courses for professionals, with flexible online payment.",
                                     "دورات معتمدة مفتوحة التسجيل للمهنيين والأفراد، مع خيارات دفع إلكتروني مرنة.");
        return View();
    }

    [Route("training/about")]
    public IActionResult About()
    {
        ViewBag.Title = Lang.T("About Horizon Solutions Training Center | MSSC", "عن مركز آفاق الحلول للتدريب | التابع لـ MSSC");
        ViewBag.Description = Lang.T("Horizon Solutions Training Center is the training arm of MSSC. We measure success by capability that stays.",
                                     "مركز آفاق الحلول للتدريب هو الذراع التدريبية لشركة حلول النظم الإدارية (MSSC). نقيس النجاح بالقدرات التي تبقى.");
        return View();
    }
}
