using Microsoft.Extensions.Caching.Memory;
using MSSC.Web.Models;

namespace MSSC.Web.Services;

public class HstcApiClient
{
    private static readonly TimeSpan CacheTtl = TimeSpan.FromMinutes(5);

    private readonly IHttpClientFactory _factory;
    private readonly IMemoryCache _cache;
    private readonly string _baseUrl;

    public HstcApiClient(IHttpClientFactory factory, IMemoryCache cache, IConfiguration config)
    {
        _factory = factory;
        _cache = cache;
        _baseUrl = (config["HstcApi:BaseUrl"] ?? "http://localhost:5050").TrimEnd('/');
    }

    public async Task<List<TrainingSession>?> GetUpcomingSessionsAsync()
    {
        return await _cache.GetOrCreateAsync("hstc:sessions", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = CacheTtl;
            var dtos = await GetAsync<List<HstcSessionDto>>("/api/public/sessions?PageSize=100");
            if (dtos == null || dtos.Count == 0) return null;

            var i = 0;
            return dtos
                .OrderBy(s => s.StartDate)
                .Select(s => new TrainingSession
                {
                    Id = ++i,
                    PortalSessionId = s.Id.ToString(),
                    PortalCourseId = s.CourseId.ToString(),
                    ProgramTitle = s.CourseTitle ?? string.Empty,
                    ProgramTitleAr = s.CourseTitleAr ?? string.Empty,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    DurationDays = Math.Max(1, (s.EndDate.Date - s.StartDate.Date).Days + 1),
                    Location = string.IsNullOrEmpty(s.Location) ? "Online" : s.Location,
                    LocationAr = string.IsNullOrEmpty(s.LocationAr) ? "عن بُعد" : s.LocationAr,
                    DeliveryMode = s.DeliveryMode == "InPerson" ? "In-Person" : "Virtual",
                    DeliveryModeAr = s.DeliveryMode == "InPerson" ? "حضوري" : "افتراضي",
                    Price = s.Price ?? 0,
                    SeatsAvailable = s.AvailableSeats,
                    AvailableSeats = s.AvailableSeats,
                    AccreditationBody = string.IsNullOrEmpty(s.AccreditationBody) ? "—" : s.AccreditationBody,
                    Status = s.Status ?? "Open"
                })
                .ToList();
        });
    }

    public async Task<List<CourseOption>?> GetCourseOptionsAsync()
    {
        return await _cache.GetOrCreateAsync("hstc:courses", async entry =>
        {
            entry.AbsoluteExpirationRelativeToNow = CacheTtl;
            var dtos = await GetAsync<List<HstcCourseDto>>("/api/public/courses?PageSize=100");
            if (dtos == null || dtos.Count == 0) return null;

            return dtos
                .Where(c => c.IsActive)
                .OrderBy(c => c.Title)
                .Select(c => new CourseOption { Id = c.Id.ToString(), Title = c.Title, TitleAr = c.TitleAr })
                .ToList();
        });
    }

    public async Task<HstcResult<HstcPaymentResult>?> ConfirmPaymentAsync(string moyasarPaymentId)
    {
        try
        {
            var client = _factory.CreateClient();
            client.Timeout = TimeSpan.FromSeconds(60);
            var resp = await client.PostAsJsonAsync(
                _baseUrl + "/api/public/payments/confirm",
                new { moyasarPaymentId });
            return await resp.Content.ReadFromJsonAsync<HstcResult<HstcPaymentResult>>();
        }
        catch
        {
            return null;
        }
    }

    public async Task<HstcResult<HstcPaymentResult>?> ConfirmTamaraPaymentAsync(string tamaraOrderId)
    {
        try
        {
            var client = _factory.CreateClient();
            client.Timeout = TimeSpan.FromSeconds(60);
            var resp = await client.PostAsJsonAsync(
                _baseUrl + "/api/public/payments/tamara/confirm",
                new { orderId = tamaraOrderId });
            return await resp.Content.ReadFromJsonAsync<HstcResult<HstcPaymentResult>>();
        }
        catch
        {
            return null;
        }
    }

    public async Task<HstcResult<HstcPaymentResult>?> ConfirmTabbyPaymentAsync(string tabbyPaymentId)
    {
        try
        {
            var client = _factory.CreateClient();
            client.Timeout = TimeSpan.FromSeconds(60);
            var resp = await client.PostAsJsonAsync(
                _baseUrl + "/api/public/payments/tabby/confirm",
                new { paymentId = tabbyPaymentId });
            return await resp.Content.ReadFromJsonAsync<HstcResult<HstcPaymentResult>>();
        }
        catch
        {
            return null;
        }
    }

    private async Task<T?> GetAsync<T>(string path) where T : class
    {
        try
        {
            var client = _factory.CreateClient("hstc");
            var result = await client.GetFromJsonAsync<HstcResult<T>>(_baseUrl + path);
            return result?.IsSuccessful == true ? result.ResultObject : null;
        }
        catch
        {
            return null;
        }
    }
}
