using MSSC.Web;

namespace MSSC.Web.Models;

public class Industry
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string ShortDescriptionAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> Challenges { get; set; } = new();
    public List<string> ChallengesAr { get; set; } = new();
    public List<string> Solutions { get; set; } = new();
    public List<string> SolutionsAr { get; set; } = new();
    public List<string> RelatedServices { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string ShortDescriptionLocalized => Lang.Pick(ShortDescription, ShortDescriptionAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
    public List<string> ChallengesLocalized => Lang.PickList(Challenges, ChallengesAr);
    public List<string> SolutionsLocalized => Lang.PickList(Solutions, SolutionsAr);
}

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string Industry { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public bool IsFeatured { get; set; }
}

public class Partner
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public string PartnerType { get; set; } = string.Empty;

    public string NameLocalized => Lang.Pick(Name, NameAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
}

public class CaseStudy
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string ClientNameAr { get; set; } = string.Empty;
    public string Industry { get; set; } = string.Empty;
    public string IndustryAr { get; set; } = string.Empty;
    public string Challenge { get; set; } = string.Empty;
    public string ChallengeAr { get; set; } = string.Empty;
    public string Solution { get; set; } = string.Empty;
    public string SolutionAr { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> ServicesUsed { get; set; } = new();
    public List<string> ServicesUsedAr { get; set; } = new();
    public List<string> Results { get; set; } = new();
    public List<string> ResultsAr { get; set; } = new();
    public List<string> Metrics { get; set; } = new();
    public List<string> MetricsAr { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string ClientNameLocalized => Lang.Pick(ClientName, ClientNameAr);
    public string IndustryLocalized => Lang.Pick(Industry, IndustryAr);
    public string ChallengeLocalized => Lang.Pick(Challenge, ChallengeAr);
    public string SolutionLocalized => Lang.Pick(Solution, SolutionAr);
    public List<string> ServicesUsedLocalized => Lang.PickList(ServicesUsed, ServicesUsedAr);
    public List<string> ResultsLocalized => Lang.PickList(Results, ResultsAr);
    public List<string> MetricsLocalized => Lang.PickList(Metrics, MetricsAr);
}
