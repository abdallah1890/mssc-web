using System.Globalization;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Localization;
using MSSC.Web.Services;
using WebMarkupMin.AspNetCore8;

var builder = WebApplication.CreateBuilder(args);

var mvcBuilder = builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment())
{
    mvcBuilder.AddRazorRuntimeCompilation();
}

var supportedCultures = new[] { new CultureInfo("ar"), new CultureInfo("en") };
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("ar");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders = new List<IRequestCultureProvider>
    {
        new CustomRequestCultureProvider(ctx => Task.FromResult<ProviderCultureResult?>(
            new ProviderCultureResult(MSSC.Web.Services.LangRouting.IsEnglish(ctx) ? "en" : "ar")))
    };
});

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
    options.KnownNetworks.Clear();
    options.KnownProxies.Clear();
});

builder.Services.AddWebMarkupMin(options =>
{
    options.AllowMinificationInDevelopmentEnvironment = false;
    options.AllowCompressionInDevelopmentEnvironment = false;
    options.DisablePoweredByHttpHeaders = true;
})
.AddHtmlMinification();

builder.Services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));

builder.Services.AddResponseCaching();

builder.Services.AddMemoryCache();
builder.Services.AddHttpClient("hstc", c => c.Timeout = TimeSpan.FromSeconds(5));
builder.Services.AddScoped<MSSC.Web.Services.HstcApiClient>();

var app = builder.Build();

app.UseForwardedHeaders();

app.UseLangPrefix();

app.UseRequestLocalization();

app.UseLegacyRedirects();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles(new StaticFileOptions
{
    OnPrepareResponse = ctx =>
    {
        ctx.Context.Response.Headers.Append("Cache-Control", "public,max-age=31536000");
    }
});

app.UseResponseCaching();
app.UseRouting();
app.UseAuthorization();
app.UseWebMarkupMin();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapGet("/set-language", (string culture, string? returnUrl) =>
{
    // Legacy cookie-based switcher: send old links to the path-based language URLs.
    var target = string.IsNullOrEmpty(returnUrl) || !returnUrl.StartsWith('/') || returnUrl.StartsWith("//") ? "/" : returnUrl;
    if (target == "/en" || target.StartsWith("/en/") || target.StartsWith("/en?"))
        target = target[3..].StartsWith('/') ? target[3..] : "/" + target[3..];
    if (culture == "en")
        target = target == "/" ? "/en" : "/en" + target;
    return Results.LocalRedirect(target, permanent: true);
});

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

app.Run();
