using MSSC.Web;

namespace MSSC.Web.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string CategoryAr { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Client { get; set; } = string.Empty;
    public string ClientAr { get; set; } = string.Empty;
    public string Duration { get; set; } = string.Empty;
    public string DurationAr { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public List<string> TagsAr { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
    public string CategoryLocalized => Lang.Pick(Category, CategoryAr);
    public string ClientLocalized => Lang.Pick(Client, ClientAr);
    public string DurationLocalized => Lang.Pick(Duration, DurationAr);
    public List<string> TagsLocalized => Lang.PickList(Tags, TagsAr);
}

public class Service
{
    public int Id { get; set; }
    public string Slug { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string ShortDescription { get; set; } = string.Empty;
    public string ShortDescriptionAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> Features { get; set; } = new();
    public List<string> FeaturesAr { get; set; } = new();
    public List<ServiceOffering> Offerings { get; set; } = new();

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string ShortDescriptionLocalized => Lang.Pick(ShortDescription, ShortDescriptionAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
    public List<string> FeaturesLocalized => Lang.PickList(Features, FeaturesAr);
}

public class ServiceOffering
{
    public string Title { get; set; } = string.Empty;
    public string TitleAr { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DescriptionAr { get; set; } = string.Empty;

    public string TitleLocalized => Lang.Pick(Title, TitleAr);
    public string DescriptionLocalized => Lang.Pick(Description, DescriptionAr);
}

public class TeamMember
{
    public string Name { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
}

public class Testimonial
{
    public string ClientName { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public int Rating { get; set; } = 5;
}

public class ContactFormModel
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;
    public string Service { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
