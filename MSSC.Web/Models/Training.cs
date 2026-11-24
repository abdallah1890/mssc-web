using MSSC.Web;

namespace MSSC.Web.Models;

public class TrainingCategory
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
    public List<TrainingProgram> Programs { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string ShortDescriptionLocalized => Lang.Pick(ShortDescription, ShortDescriptionAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
}

public class TrainingProgram
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string CategorySlug { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string ShortDescriptionAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string DurationAr { get; set; } = string.Empty;
    public int DurationDays { get; set; }
    public string Level { get; set; } = string.Empty;
    public string LevelAr { get; set; } = string.Empty;
    public string DeliveryMode { get; set; } = string.Empty;
    public string DeliveryModeAr { get; set; } = string.Empty;
    public string DeliveryMethod { get; set; } = string.Empty;
    public string Language { get; set; } = "English & Arabic";
    public string Certification { get; set; } = string.Empty;
    public string CertificationAr { get; set; } = string.Empty;
    public bool CertificationOffered { get; set; }
    public bool IsFeatured { get; set; }
    public decimal Price { get; set; }
    public List<string> LearningObjectives { get; set; } = new();
    public List<string> LearningObjectivesAr { get; set; } = new();
    public List<string> TargetAudience { get; set; } = new();
    public List<string> TargetAudienceAr { get; set; } = new();
    public List<string> Prerequisites { get; set; } = new();
    public List<string> PrerequisitesAr { get; set; } = new();
    public List<ProgramModule> Modules { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string ShortDescriptionLocalized => Lang.Pick(ShortDescription, ShortDescriptionAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
    public string DurationLocalized => Lang.Pick(Duration, DurationAr);

    public string LevelLocalized => !Lang.IsArabic ? Level : Level switch
    {
        "Beginner" => "مبتدئ",
        "Intermediate" => "متوسط",
        "Advanced" => "متقدّم",
        "All Levels" => "جميع المستويات",
        _ => Lang.Pick(Level, LevelAr)
    };

    public string DeliveryModeLocalized => !Lang.IsArabic ? DeliveryMode : DeliveryMode switch
    {
        "Virtual" => "افتراضي",
        "Online" => "عبر الإنترنت",
        "In-Person" => "حضوري",
        "Onsite" => "حضوري",
        "Hybrid" => "مدمج",
        "Blended" => "مدمج",
        _ => Lang.Pick(DeliveryMode, DeliveryModeAr)
    };
    public string CertificationLocalized => Lang.Pick(Certification, CertificationAr);
    public List<string> LearningObjectivesLocalized => Lang.PickList(LearningObjectives, LearningObjectivesAr);
    public List<string> TargetAudienceLocalized => Lang.PickList(TargetAudience, TargetAudienceAr);
    public List<string> PrerequisitesLocalized => Lang.PickList(Prerequisites, PrerequisitesAr);
}

public class ProgramModule
{
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public int DurationHours { get; set; }
    public List<string> Topics { get; set; } = new();
    public List<string> TopicsAr { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
    public List<string> TopicsLocalized => Lang.PickList(Topics, TopicsAr);
}

public class Trainer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
    public string BioAr { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Specialization { get; set; } = string.Empty;
    public string SpecializationAr { get; set; } = string.Empty;
    public int YearsExperience { get; set; }
    public List<string> Specializations { get; set; } = new();
    public List<string> Certifications { get; set; } = new();
    public string LinkedIn { get; set; } = string.Empty;

    public string NameLocalized => Lang.Pick(Name, NameAr);
    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string BioLocalized => Lang.Pick(Bio, BioAr);
    public string SpecializationLocalized => Lang.Pick(Specialization, SpecializationAr);
}

public class TrainingSession
{
    public int Id { get; set; }
    public int ProgramId { get; set; }
    public string? PortalSessionId { get; set; }
    public string? PortalCourseId { get; set; }
    public string ProgramSlug { get; set; } = string.Empty;
    public string ProgramTitle { get; set; } = string.Empty;
    public string ProgramTitleAr { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Location { get; set; } = string.Empty;
    public string LocationAr { get; set; } = string.Empty;
    public string DeliveryMode { get; set; } = string.Empty;
    public string DeliveryModeAr { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int SeatsAvailable { get; set; }
    public int AvailableSeats { get; set; }
    public string Status { get; set; } = "Open";
    public string AccreditationBody { get; set; } = string.Empty;
    public int DurationDays { get; set; }

    public string ProgramTitleLocalized => Lang.Pick(ProgramTitle, ProgramTitleAr);
    public string LocationLocalized => Lang.Pick(Location, LocationAr);
    public string DeliveryModeLocalized => Lang.Pick(DeliveryMode, DeliveryModeAr);
}

public class Accreditation
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string NameAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string LogoUrl { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;

    public string NameLocalized => Lang.Pick(Name, NameAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
}
