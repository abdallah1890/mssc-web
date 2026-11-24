using MSSC.Web.Models;

namespace MSSC.Web.Data;

public static class CareerData
{
    public static List<JobOpening> GetJobOpenings() => new()
    {
        new JobOpening
        {
            Id = 1,
            Slug = "senior-management-consultant",
            Title = "Senior Management Consultant",
            Department = "Consulting",
            Location = "Riyadh, Saudi Arabia",
            Type = "Full-time",
            ExperienceLevel = "Senior",
            Description = "We are seeking an experienced Senior Management Consultant to lead strategic consulting engagements for government and private sector clients. You will drive transformation initiatives aligned with Vision 2030.",
            Responsibilities = new()
            {
                "Lead complex consulting engagements from inception to delivery",
                "Develop strategic recommendations and implementation roadmaps",
                "Build and maintain senior client relationships",
                "Mentor and develop junior consultants",
                "Contribute to business development and proposal writing",
                "Ensure quality delivery and client satisfaction"
            },
            Requirements = new()
            {
                "Master's degree in Business, Management, or related field",
                "8+ years of management consulting experience",
                "Strong track record in strategy and transformation projects",
                "Excellent communication skills in English and Arabic",
                "Experience with Saudi government sector preferred",
                "Professional certifications (CMC, PMP) preferred"
            },
            Benefits = new()
            {
                "Competitive salary with performance bonus",
                "Health insurance for employee and family",
                "Professional development allowance",
                "Annual leave and travel allowance",
                "Career growth opportunities"
            },
            PostedDate = DateTime.Now.AddDays(-5),
            IsActive = true
        },
        new JobOpening
        {
            Id = 2,
            Slug = "iso-lead-auditor",
            Title = "ISO Lead Auditor",
            Department = "International Standards",
            Location = "Riyadh, Saudi Arabia",
            Type = "Full-time",
            ExperienceLevel = "Mid",
            Description = "Join our International Standards team as an ISO Lead Auditor to conduct certification audits and support clients in achieving ISO management system certifications.",
            Responsibilities = new()
            {
                "Conduct ISO certification and surveillance audits",
                "Perform gap assessments and readiness reviews",
                "Develop audit plans and prepare comprehensive reports",
                "Provide guidance on ISO standards implementation",
                "Maintain auditor competency and certifications",
                "Support business development activities"
            },
            Requirements = new()
            {
                "Bachelor's degree in Engineering, Quality, or related field",
                "5+ years of experience in quality management",
                "Lead Auditor certification (ISO 9001, 14001, or 45001)",
                "Knowledge of multiple ISO management systems",
                "Strong analytical and communication skills",
                "Willingness to travel within Saudi Arabia"
            },
            Benefits = new()
            {
                "Competitive compensation package",
                "Certification and training support",
                "Health insurance coverage",
                "Performance-based incentives",
                "Travel allowance"
            },
            PostedDate = DateTime.Now.AddDays(-10),
            IsActive = true
        },
        new JobOpening
        {
            Id = 3,
            Slug = "training-manager",
            Title = "Training Manager",
            Department = "Training Center",
            Location = "Riyadh, Saudi Arabia",
            Type = "Full-time",
            ExperienceLevel = "Senior",
            Description = "We are looking for a Training Manager to lead our Training Center operations, develop training programs, and manage a team of trainers and coordinators.",
            Responsibilities = new()
            {
                "Manage Training Center operations and team",
                "Develop and update training curriculum",
                "Build relationships with corporate training clients",
                "Ensure training quality and participant satisfaction",
                "Manage training schedules and resource allocation",
                "Drive revenue growth and profitability"
            },
            Requirements = new()
            {
                "Bachelor's degree in HR, Education, or Business",
                "7+ years of experience in corporate training",
                "Proven track record in training program development",
                "Strong leadership and team management skills",
                "Excellent presentation and facilitation abilities",
                "Knowledge of Saudi labor market and Nitaqat"
            },
            Benefits = new()
            {
                "Leadership role with growth potential",
                "Competitive salary and bonus structure",
                "Comprehensive benefits package",
                "Professional development opportunities",
                "Work with leading Saudi organizations"
            },
            PostedDate = DateTime.Now.AddDays(-3),
            IsActive = true
        },
        new JobOpening
        {
            Id = 4,
            Slug = "hr-consultant",
            Title = "HR Consultant",
            Department = "Human Capital",
            Location = "Jeddah, Saudi Arabia",
            Type = "Full-time",
            ExperienceLevel = "Mid",
            Description = "Join our Human Capital team as an HR Consultant to support clients with HR strategy, organizational development, and talent management solutions.",
            Responsibilities = new()
            {
                "Conduct HR assessments and gap analyses",
                "Design compensation and benefits structures",
                "Develop performance management systems",
                "Support organizational restructuring projects",
                "Create HR policies and procedures",
                "Deliver HR training programs"
            },
            Requirements = new()
            {
                "Bachelor's degree in HR, Business, or Psychology",
                "5+ years of HR consulting or senior HR role experience",
                "Knowledge of Saudi labor law and regulations",
                "Experience with job evaluation methodologies",
                "Strong analytical and project management skills",
                "CIPD, SHRM, or equivalent certification preferred"
            },
            Benefits = new()
            {
                "Competitive package with benefits",
                "Work-life balance",
                "Learning and development support",
                "Health insurance",
                "Performance incentives"
            },
            PostedDate = DateTime.Now.AddDays(-7),
            IsActive = true
        },
        new JobOpening
        {
            Id = 5,
            Slug = "business-development-executive",
            Title = "Business Development Executive",
            Department = "Business Development",
            Location = "Riyadh, Saudi Arabia",
            Type = "Full-time",
            ExperienceLevel = "Entry",
            Description = "We are seeking a dynamic Business Development Executive to identify new business opportunities, generate leads, and support proposal development.",
            Responsibilities = new()
            {
                "Identify and pursue new business opportunities",
                "Generate and qualify sales leads",
                "Support proposal and RFP response preparation",
                "Maintain CRM and sales pipeline tracking",
                "Attend industry events and networking functions",
                "Conduct market research and competitor analysis"
            },
            Requirements = new()
            {
                "Bachelor's degree in Business or Marketing",
                "2-3 years of B2B sales or business development experience",
                "Excellent communication and networking skills",
                "Proficiency in MS Office and CRM systems",
                "Self-motivated with target-driven mindset",
                "Valid Saudi driving license"
            },
            Benefits = new()
            {
                "Base salary plus commission",
                "Health insurance",
                "Career development path",
                "Training and mentoring",
                "Company vehicle allowance"
            },
            PostedDate = DateTime.Now.AddDays(-14),
            IsActive = true
        }
    };

    public static List<CompanyValue> GetCompanyValues() => new()
    {
        new CompanyValue
        {
            Title = "Excellence",
            Description = "We pursue excellence in everything we do, delivering exceptional quality and value to our clients.",
            Icon = "fa-star"
        },
        new CompanyValue
        {
            Title = "Integrity",
            Description = "We act with honesty, transparency, and ethical conduct in all our business dealings.",
            Icon = "fa-shield-halved"
        },
        new CompanyValue
        {
            Title = "Innovation",
            Description = "We embrace creativity and continuous improvement to solve complex business challenges.",
            Icon = "fa-lightbulb"
        },
        new CompanyValue
        {
            Title = "Collaboration",
            Description = "We work as partners with our clients and colleagues to achieve shared success.",
            Icon = "fa-handshake"
        },
        new CompanyValue
        {
            Title = "Impact",
            Description = "We focus on creating lasting positive impact for our clients, people, and community.",
            Icon = "fa-chart-line"
        }
    };

    public static List<TeamBenefit> GetTeamBenefits() => new()
    {
        new TeamBenefit
        {
            Title = "Competitive Compensation",
            Description = "We offer market-competitive salaries with performance-based bonuses and annual reviews.",
            Icon = "fa-coins"
        },
        new TeamBenefit
        {
            Title = "Health & Wellness",
            Description = "Comprehensive health insurance for employees and their families, plus wellness programs.",
            Icon = "fa-heart-pulse"
        },
        new TeamBenefit
        {
            Title = "Learning & Development",
            Description = "Continuous learning opportunities including certifications, training, and conference attendance.",
            Icon = "fa-graduation-cap"
        },
        new TeamBenefit
        {
            Title = "Career Growth",
            Description = "Clear career paths with mentorship, regular feedback, and promotion opportunities.",
            Icon = "fa-stairs"
        },
        new TeamBenefit
        {
            Title = "Work-Life Balance",
            Description = "Flexible working arrangements, generous leave policy, and respect for personal time.",
            Icon = "fa-scale-balanced"
        },
        new TeamBenefit
        {
            Title = "Impactful Work",
            Description = "Work on meaningful projects with leading organizations driving Vision 2030.",
            Icon = "fa-rocket"
        }
    };

    public static JobOpening? GetJobBySlug(string slug) =>
        GetJobOpenings().FirstOrDefault(j => j.Slug == slug);

    public static List<JobOpening> GetActiveJobs() =>
        GetJobOpenings().Where(j => j.IsActive).ToList();

    public static List<JobOpening> GetJobsByDepartment(string department) =>
        GetJobOpenings().Where(j => j.Department == department && j.IsActive).ToList();
}
