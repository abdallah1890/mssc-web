using MSSC.Web;

namespace MSSC.Web.Models;

public class JobOpening
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string DepartmentAr { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string LocationAr { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public string TypeAr { get; set; } = string.Empty;
    public string ExperienceLevel { get; set; } = string.Empty;
    public string ExperienceLevelAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public List<string> Responsibilities { get; set; } = new();
    public List<string> ResponsibilitiesAr { get; set; } = new();
    public List<string> Requirements { get; set; } = new();
    public List<string> RequirementsAr { get; set; } = new();
    public List<string> Benefits { get; set; } = new();
    public List<string> BenefitsAr { get; set; } = new();
    public DateTime PostedDate { get; set; }
    public DateTime? ClosingDate { get; set; }
    public bool IsActive { get; set; } = true;

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string DepartmentLocalized => Lang.Pick(Department, DepartmentAr);
    public string LocationLocalized => Lang.Pick(Location, LocationAr);
    public string TypeLocalized => Lang.Pick(Type, TypeAr);
    public string ExperienceLevelLocalized => Lang.Pick(ExperienceLevel, ExperienceLevelAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
    public List<string> ResponsibilitiesLocalized => Lang.PickList(Responsibilities, ResponsibilitiesAr);
    public List<string> RequirementsLocalized => Lang.PickList(Requirements, RequirementsAr);
    public List<string> BenefitsLocalized => Lang.PickList(Benefits, BenefitsAr);
}

public class JobApplication
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string CurrentPosition { get; set; } = string.Empty;
    public string LinkedInUrl { get; set; } = string.Empty;
    public string CoverLetter { get; set; } = string.Empty;
    public string ResumeUrl { get; set; } = string.Empty;
    public DateTime SubmittedDate { get; set; }
}

public class CompanyValue
{
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
}

public class TeamBenefit
{
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
}
