namespace MSSC.Web.Models;

public class HstcResult<T>
{
    public bool IsSuccessful { get; set; }
    public T? ResultObject { get; set; }
    public HstcResultError? ErrorEntry { get; set; }
}

public class HstcResultError
{
    public string? ErrorMessage { get; set; }
    public string? ErrorMessageAr { get; set; }
}

public class HstcPaymentResult
{
    public Guid PaymentId { get; set; }
    public Guid RegistrationId { get; set; }
    public Guid? EnrollmentId { get; set; }
    public string Status { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "SAR";
    public string? Method { get; set; }
    public string? Message { get; set; }
    public string? CourseTitle { get; set; }
    public string? CourseTitleAr { get; set; }
}

public class HstcSessionDto
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public string? CourseTitle { get; set; }
    public string? CourseTitleAr { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? DeliveryMode { get; set; }
    public string? Location { get; set; }
    public string? LocationAr { get; set; }
    public int AvailableSeats { get; set; }
    public decimal? Price { get; set; }
    public string? AccreditationBody { get; set; }
    public string? Status { get; set; }
}

public class HstcCourseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? TitleAr { get; set; }
    public bool IsActive { get; set; }
}

public class CourseOption
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? TitleAr { get; set; }
    public string TitleLocalized => Lang.Pick(Title, TitleAr ?? string.Empty);
}
