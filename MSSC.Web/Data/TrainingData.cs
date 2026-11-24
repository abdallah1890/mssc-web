using MSSC.Web.Models;

namespace MSSC.Web.Data;

public static class TrainingData
{
    public static List<TrainingCategory> GetCategories() => new()
    {
        new TrainingCategory
        {
            Id = 1,
            Slug = "information-technology",
            Name = "Information Technology",
            Title = "Information Technology",
            TitleAr = "تقنية المعلومات",
            ShortDescription = "Master digital transformation technologies and modern IT skills for the digital age.",
            ShortDescriptionAr = "أتقن تقنيات التحول الرقمي ومهارات تقنية المعلومات الحديثة للعصر الرقمي.",
            Description = "Our IT training programs equip professionals with cutting-edge skills in digital transformation, business intelligence, and automation technologies essential for today's digital economy.",
            DescriptionAr = "تُجهّز برامجنا التدريبية في تقنية المعلومات المهنيين بمهارات متقدّمة في التحول الرقمي وذكاء الأعمال وتقنيات الأتمتة الضرورية للاقتصاد الرقمي اليوم.",
            Icon = "fa-microchip",
            ImageUrl = "/images/training/it.jpg",
            Programs = new()
            {
                new TrainingProgram
                {
                    Id = 1,
                    Slug = "digital-transformation",
                    ImageUrl = "/images/training/programs/digital-transformation.jpg",
                    CategorySlug = "information-technology",
                    Category = "Information Technology",
                    Title = "Digital Transformation Technologies",
                    TitleAr = "تقنيات التحول الرقمي",
                    ShortDescription = "Lead organizational digital transformation with emerging technologies.",
                    Description = "This comprehensive program covers the fundamentals and advanced concepts of digital transformation, including cloud computing, IoT, AI, and data analytics for business innovation.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "Digital Transformation Professional",
                    CertificationOffered = true,
                    IsFeatured = true,
                    Price = 1500,
                    LearningObjectives = new() { "Understand digital transformation frameworks", "Evaluate emerging technologies", "Develop digital strategy", "Lead change initiatives", "Measure digital maturity" },
                    TargetAudience = new() { "IT Managers", "Business Leaders", "Digital Strategists", "Innovation Managers" },
                    Prerequisites = new() { "Basic IT knowledge", "Management experience" },
                    Modules = new()
                    {
                        new() { Title = "Digital Transformation Fundamentals", Duration = "1 Day", DurationHours = 8, Description = "Introduction to digital transformation concepts and frameworks", Topics = new() { "Digital Economy Overview", "Key Technologies", "Business Impact" } },
                        new() { Title = "Cloud & Data Technologies", Duration = "1 Day", DurationHours = 8, Description = "Cloud computing and data management strategies", Topics = new() { "Cloud Models", "Big Data", "Analytics" } },
                        new() { Title = "AI & Automation", Duration = "1 Day", DurationHours = 8, Description = "AI applications and process automation", Topics = new() { "Machine Learning", "RPA", "AI Use Cases" } },
                        new() { Title = "Digital Strategy", Duration = "1 Day", DurationHours = 8, Description = "Developing and implementing digital strategy", Topics = new() { "Strategy Frameworks", "Digital Roadmap", "Change Management" } },
                        new() { Title = "Implementation & Measurement", Duration = "1 Day", DurationHours = 8, Description = "Executing digital initiatives and measuring success", Topics = new() { "Project Execution", "KPIs", "Digital Maturity" } }
                    }
                },
                new TrainingProgram
                {
                    Id = 2,
                    Slug = "smart-business-tools",
                    ImageUrl = "/images/training/programs/smart-business-tools.jpg",
                    CategorySlug = "information-technology",
                    Title = "Smart Business Management Tools",
                    TitleAr = "أدوات إدارة الأعمال الذكية",
                    ShortDescription = "Master modern business tools for enhanced productivity and decision-making.",
                    Description = "Learn to leverage advanced business tools including ERP systems, CRM platforms, business intelligence dashboards, and collaboration technologies for improved organizational efficiency.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Beginner",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "Business Tools Specialist",
                    CertificationOffered = true,
                    Price = 1500,
                    LearningObjectives = new() { "Navigate ERP systems", "Utilize CRM platforms", "Create BI dashboards", "Optimize workflows", "Enable collaboration" },
                    TargetAudience = new() { "Business Analysts", "Operations Staff", "Administrative Professionals", "Team Leaders" },
                    Prerequisites = new() { "Computer literacy", "Basic business knowledge" }
                },
                new TrainingProgram
                {
                    Id = 3,
                    Slug = "automation-digital-analysis",
                    ImageUrl = "/images/training/programs/automation-digital-analysis.jpg",
                    CategorySlug = "information-technology",
                    Title = "Automation & Digital Analysis Skills",
                    TitleAr = "مهارات الأتمتة والتحليل الرقمي",
                    ShortDescription = "Develop automation and data analysis capabilities for process optimization.",
                    Description = "This program covers RPA (Robotic Process Automation), data analysis techniques, process automation, and digital reporting skills essential for modern business operations.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "Automation Specialist",
                    CertificationOffered = true,
                    Price = 1700,
                    LearningObjectives = new() { "Design automated workflows", "Analyze business data", "Implement RPA solutions", "Create digital reports", "Optimize processes" },
                    TargetAudience = new() { "Process Analysts", "IT Professionals", "Operations Managers", "Quality Specialists" },
                    Prerequisites = new() { "Basic Excel skills", "Process knowledge" }
                }
            }
        },
        new TrainingCategory
        {
            Id = 2,
            Slug = "management-leadership",
            Name = "Management & Leadership",
            Title = "Management & Leadership",
            TitleAr = "الإدارة والقيادة",
            ShortDescription = "Develop leadership capabilities and management excellence for organizational success.",
            ShortDescriptionAr = "طوّر قدرات القيادة والتميّز الإداري لتحقيق النجاح المؤسسي.",
            Description = "Our management and leadership programs develop the skills needed to lead teams, manage organizations, and drive strategic initiatives in today's complex business environment.",
            Icon = "fa-building-columns",
            ImageUrl = "/images/training/leadership.jpg",
            Programs = new()
            {
                new TrainingProgram
                {
                    Id = 4,
                    Slug = "corporate-governance",
                    ImageUrl = "/images/training/programs/corporate-governance.jpg",
                    CategorySlug = "management-leadership",
                    Category = "Management & Leadership",
                    Title = "Certified Corporate Governance Professional",
                    TitleAr = "محترف حوكمة الشركات المعتمد",
                    ShortDescription = "Achieve professional certification in corporate governance principles and practices.",
                    Description = "This CPD-accredited program covers board effectiveness, regulatory compliance, stakeholder management, and governance frameworks essential for corporate leadership and oversight.",
                    Duration = "5 Days",
                    DurationDays = 5,
                    Level = "Advanced",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "Certified Corporate Governance Professional (CPD)",
                    CertificationOffered = true,
                    IsFeatured = true,
                    Price = 2500,
                    LearningObjectives = new() { "Apply governance frameworks", "Enhance board effectiveness", "Manage stakeholder relations", "Ensure regulatory compliance", "Drive ethical leadership" },
                    TargetAudience = new() { "Board Members", "Senior Executives", "Compliance Officers", "Corporate Secretaries" },
                    Prerequisites = new() { "Management experience", "Governance awareness" }
                },
                new TrainingProgram
                {
                    Id = 5,
                    Slug = "ccmp",
                    ImageUrl = "/images/training/programs/ccmp.jpg",
                    CategorySlug = "management-leadership",
                    Category = "Management & Leadership",
                    Title = "Certified Change Management Professional (CCMP)",
                    TitleAr = "محترف إدارة التغيير المعتمد",
                    ShortDescription = "Earn the globally recognized CCMP credential from ACMP.",
                    Description = "This ACMP-accredited program prepares professionals for the Certified Change Management Professional (CCMP) credential, covering change management methodologies, stakeholder engagement, and organizational transformation strategies.",
                    Duration = "5 Days",
                    DurationDays = 5,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "Certified Change Management Professional (ACMP)",
                    CertificationOffered = true,
                    IsFeatured = true,
                    Price = 5000,
                    LearningObjectives = new() { "Apply change management frameworks", "Engage stakeholders effectively", "Plan and execute change initiatives", "Measure change adoption", "Prepare for CCMP exam" },
                    TargetAudience = new() { "Change Managers", "Project Managers", "HR Professionals", "Consultants" },
                    Prerequisites = new() { "Change management experience", "Professional background" }
                },
                new TrainingProgram
                {
                    Id = 14,
                    Slug = "ccme",
                    ImageUrl = "/images/training/programs/ccme.jpg",
                    CategorySlug = "management-leadership",
                    Category = "Management & Leadership",
                    Title = "Certified Change Management Expert (CCME)",
                    TitleAr = "خبير إدارة التغيير المعتمد",
                    ShortDescription = "Advance to expert-level change management practice with CPD-accredited certification.",
                    Description = "This CPD-accredited program develops advanced change management capabilities for senior practitioners, covering enterprise transformation, change portfolio governance, and leading complex organizational change at scale.",
                    Duration = "5 Days",
                    DurationDays = 5,
                    Level = "Advanced",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "Certified Change Management Expert (CPD)",
                    CertificationOffered = true,
                    IsFeatured = true,
                    Price = 2500,
                    LearningObjectives = new() { "Lead enterprise-wide change programs", "Govern change portfolios", "Coach change leaders", "Embed change capability in organizations", "Measure transformation outcomes" },
                    TargetAudience = new() { "Senior Change Managers", "Transformation Leaders", "Program Directors", "Change Consultants" },
                    Prerequisites = new() { "CCMP or equivalent change credential", "5+ years change management experience" }
                }
            }
        },
        new TrainingCategory
        {
            Id = 3,
            Slug = "health-safety",
            Name = "Health & Safety",
            Title = "Health & Safety",
            TitleAr = "الصحة والسلامة",
            ShortDescription = "Build a culture of safety through comprehensive occupational health and safety training.",
            ShortDescriptionAr = "ابنِ ثقافة سلامة عبر تدريب شامل في الصحة والسلامة المهنية.",
            Description = "Our health and safety programs equip professionals with knowledge and skills to create safe workplaces, manage risks, and respond to emergencies effectively.",
            Icon = "fa-shield-halved",
            ImageUrl = "/images/training/safety.jpg",
            Programs = new()
            {
                new TrainingProgram
                {
                    Id = 6,
                    Slug = "iosh-managing-safely",
                    ImageUrl = "/images/training/programs/iosh-managing-safely.jpg",
                    CategorySlug = "health-safety",
                    Category = "Health & Safety",
                    Title = "IOSH Managing Safely",
                    TitleAr = "إدارة السلامة - IOSH",
                    ShortDescription = "Gain the internationally recognized IOSH Managing Safely qualification.",
                    Description = "This IOSH-accredited program provides managers and supervisors with the knowledge and skills to manage health and safety in their teams, covering risk assessment, hazard control, and safety legislation.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "IOSH Managing Safely Certificate",
                    CertificationOffered = true,
                    IsFeatured = true,
                    Price = 1200,
                    LearningObjectives = new() { "Assess workplace risks", "Control common hazards", "Understand safety responsibilities", "Investigate incidents", "Measure safety performance" },
                    TargetAudience = new() { "Managers", "Supervisors", "Team Leaders", "Safety Officers" },
                    Prerequisites = new() { "Management or supervisory role", "Basic safety awareness" }
                },
                new TrainingProgram
                {
                    Id = 7,
                    Slug = "iso-45001-internal-audit",
                    ImageUrl = "/images/training/programs/iso-45001-internal-audit.jpg",
                    CategorySlug = "health-safety",
                    Category = "Health & Safety",
                    Title = "ISO 45001 Internal Audit",
                    TitleAr = "التدقيق الداخلي ISO 45001",
                    ShortDescription = "Master internal auditing for occupational health and safety management systems.",
                    Description = "This IRCA-approved program trains participants to plan, conduct, and report internal audits of ISO 45001 Occupational Health and Safety Management Systems.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 45001 Internal Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    Price = 1500,
                    LearningObjectives = new() { "Interpret ISO 45001 requirements", "Plan internal audits", "Conduct audit interviews", "Report audit findings", "Follow up on corrective actions" },
                    TargetAudience = new() { "Internal Auditors", "Safety Officers", "OHS Managers", "Quality Professionals" },
                    Prerequisites = new() { "Basic knowledge of ISO 45001", "OHS awareness" }
                }
            }
        },
        new TrainingCategory
        {
            Id = 4,
            Slug = "quality-excellence",
            Name = "Quality & Excellence",
            Title = "Quality & Organizational Excellence",
            TitleAr = "الجودة والتميز المؤسسي",
            ShortDescription = "Achieve operational excellence through quality management and continuous improvement.",
            ShortDescriptionAr = "حقّق التميّز التشغيلي عبر إدارة الجودة والتحسين المستمر.",
            Description = "Our quality and excellence programs develop capabilities in quality management, process improvement, and organizational excellence frameworks for sustainable performance.",
            Icon = "fa-clipboard-check",
            ImageUrl = "/images/training/quality.jpg",
            Programs = new()
            {
                new TrainingProgram
                {
                    Id = 8,
                    Slug = "iso-9001-internal-audit",
                    ImageUrl = "/images/training/programs/iso-9001-internal-audit.jpg",
                    CategorySlug = "quality-excellence",
                    Category = "Quality & Excellence",
                    Title = "ISO 9001 Internal Audit",
                    TitleAr = "التدقيق الداخلي ISO 9001",
                    ShortDescription = "Master internal auditing for quality management systems.",
                    Description = "This IRCA-approved program trains participants to plan, conduct, and report internal audits of ISO 9001 Quality Management Systems effectively.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 9001 Internal Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    Price = 1500,
                    LearningObjectives = new() { "Interpret ISO 9001 requirements", "Plan internal audits", "Conduct audit interviews", "Report audit findings", "Follow up on corrective actions" },
                    TargetAudience = new() { "Internal Auditors", "Quality Managers", "Process Owners", "Quality Professionals" },
                    Prerequisites = new() { "Basic knowledge of ISO 9001", "Quality awareness" }
                },
                new TrainingProgram
                {
                    Id = 9,
                    Slug = "iso-9001-lead-auditor",
                    ImageUrl = "/images/training/programs/iso-9001-lead-auditor.jpg",
                    CategorySlug = "quality-excellence",
                    Category = "Quality & Excellence",
                    Title = "ISO 9001 Lead Auditor",
                    TitleAr = "مدقق رئيسي ISO 9001",
                    ShortDescription = "Become a certified lead auditor for quality management systems.",
                    Description = "This IRCA-approved program develops the skills to lead ISO 9001 certification audits, covering audit planning, execution, reporting, and team management.",
                    Duration = "5 Days",
                    DurationDays = 5,
                    Level = "Advanced",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 9001 Lead Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    IsFeatured = true,
                    Price = 2800,
                    LearningObjectives = new() { "Lead certification audits", "Manage audit teams", "Apply audit techniques", "Report to certification bodies", "Evaluate management systems" },
                    TargetAudience = new() { "Lead Auditors", "Quality Managers", "Certification Body Auditors", "Consultants" },
                    Prerequisites = new() { "ISO 9001 knowledge", "Internal audit experience" }
                },
                new TrainingProgram
                {
                    Id = 10,
                    Slug = "iso-14001-internal-audit",
                    ImageUrl = "/images/training/programs/iso-14001-internal-audit.jpg",
                    CategorySlug = "quality-excellence",
                    Category = "Quality & Excellence",
                    Title = "ISO 14001 Internal Audit",
                    TitleAr = "التدقيق الداخلي ISO 14001",
                    ShortDescription = "Master internal auditing for environmental management systems.",
                    Description = "This IRCA-approved program trains participants to plan, conduct, and report internal audits of ISO 14001 Environmental Management Systems.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 14001 Internal Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    Price = 1500,
                    LearningObjectives = new() { "Interpret ISO 14001 requirements", "Plan environmental audits", "Assess environmental compliance", "Report audit findings", "Follow up on corrective actions" },
                    TargetAudience = new() { "Internal Auditors", "Environmental Managers", "EHS Professionals", "Quality Professionals" },
                    Prerequisites = new() { "Basic knowledge of ISO 14001", "Environmental awareness" }
                },
                new TrainingProgram
                {
                    Id = 11,
                    Slug = "iso-14001-lead-auditor",
                    ImageUrl = "/images/training/programs/iso-14001-lead-auditor.jpg",
                    CategorySlug = "quality-excellence",
                    Category = "Quality & Excellence",
                    Title = "ISO 14001 Lead Auditor",
                    TitleAr = "مدقق رئيسي ISO 14001",
                    ShortDescription = "Become a certified lead auditor for environmental management systems.",
                    Description = "This IRCA-approved program develops the skills to lead ISO 14001 certification audits, covering environmental audit planning, execution, reporting, and team management.",
                    Duration = "5 Days",
                    DurationDays = 5,
                    Level = "Advanced",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 14001 Lead Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    Price = 2800,
                    LearningObjectives = new() { "Lead environmental audits", "Manage audit teams", "Evaluate environmental compliance", "Report to certification bodies", "Assess management systems" },
                    TargetAudience = new() { "Lead Auditors", "Environmental Managers", "Certification Body Auditors", "EHS Consultants" },
                    Prerequisites = new() { "ISO 14001 knowledge", "Internal audit experience" }
                },
                new TrainingProgram
                {
                    Id = 12,
                    Slug = "iso-50001-internal-audit",
                    ImageUrl = "/images/training/programs/iso-50001-internal-audit.jpg",
                    CategorySlug = "quality-excellence",
                    Category = "Quality & Excellence",
                    Title = "ISO 50001 Internal Audit",
                    TitleAr = "التدقيق الداخلي ISO 50001",
                    ShortDescription = "Master internal auditing for energy management systems.",
                    Description = "This IRCA-approved program trains participants to plan, conduct, and report internal audits of ISO 50001 Energy Management Systems.",
                    Duration = "3 Days",
                    DurationDays = 3,
                    Level = "Intermediate",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 50001 Internal Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    Price = 1500,
                    LearningObjectives = new() { "Interpret ISO 50001 requirements", "Plan energy audits", "Assess energy performance", "Report audit findings", "Follow up on corrective actions" },
                    TargetAudience = new() { "Internal Auditors", "Energy Managers", "Facility Managers", "Sustainability Professionals" },
                    Prerequisites = new() { "Basic knowledge of ISO 50001", "Energy management awareness" }
                },
                new TrainingProgram
                {
                    Id = 13,
                    Slug = "iso-50001-lead-auditor",
                    ImageUrl = "/images/training/programs/iso-50001-lead-auditor.jpg",
                    CategorySlug = "quality-excellence",
                    Category = "Quality & Excellence",
                    Title = "ISO 50001 Lead Auditor",
                    TitleAr = "مدقق رئيسي ISO 50001",
                    ShortDescription = "Become a certified lead auditor for energy management systems.",
                    Description = "This IRCA-approved program develops the skills to lead ISO 50001 certification audits, covering energy audit planning, execution, reporting, and team management.",
                    Duration = "5 Days",
                    DurationDays = 5,
                    Level = "Advanced",
                    DeliveryMode = "Virtual",
                    DeliveryMethod = "Virtual",
                    Language = "English & Arabic",
                    Certification = "ISO 50001 Lead Auditor (IRCA Approved)",
                    CertificationOffered = true,
                    Price = 2800,
                    LearningObjectives = new() { "Lead energy audits", "Manage audit teams", "Evaluate energy performance", "Report to certification bodies", "Assess management systems" },
                    TargetAudience = new() { "Lead Auditors", "Energy Managers", "Certification Body Auditors", "Sustainability Consultants" },
                    Prerequisites = new() { "ISO 50001 knowledge", "Internal audit experience" }
                }
            }
        }
    };

    public static List<Trainer> GetTrainers() => new()
    {
        new Trainer
        {
            Id = 1,
            Name = "Dr. Ahmed Al-Rashid",
            Title = "Senior Strategy Consultant",
            Bio = "Dr. Ahmed has over 20 years of experience in strategic management and organizational transformation. He holds a PhD in Business Administration and has led numerous Vision 2030 alignment projects.",
            ImageUrl = "/images/trainers/trainer1.jpg",
            Specializations = new() { "Strategic Management", "Organizational Transformation", "Leadership Development" },
            Certifications = new() { "PMP", "Six Sigma Black Belt", "EFQM Assessor" }
        },
        new Trainer
        {
            Id = 2,
            Name = "Eng. Fatima Al-Zahrani",
            Title = "Quality & Excellence Expert",
            Bio = "Eng. Fatima is a certified EFQM and ISO Lead Auditor with 15 years of experience helping organizations achieve excellence and certification across multiple standards.",
            ImageUrl = "/images/trainers/trainer2.jpg",
            Specializations = new() { "ISO Standards", "EFQM", "Quality Management" },
            Certifications = new() { "ISO 9001 Lead Auditor", "EFQM Assessor", "TQM Professional" }
        },
        new Trainer
        {
            Id = 3,
            Name = "Mr. Khalid Al-Otaibi",
            Title = "HR & Leadership Specialist",
            Bio = "Khalid is a seasoned HR professional with extensive experience in talent development, succession planning, and leadership programs across government and private sectors.",
            ImageUrl = "/images/trainers/trainer3.jpg",
            Specializations = new() { "Leadership Development", "Talent Management", "HR Strategy" },
            Certifications = new() { "SHRM-SCP", "CIPD Level 7", "Executive Coach" }
        },
        new Trainer
        {
            Id = 4,
            Name = "Dr. Sara Al-Mansour",
            Title = "Digital Transformation Consultant",
            Bio = "Dr. Sara specializes in digital transformation and IT strategy, helping organizations leverage technology for business innovation and operational excellence.",
            ImageUrl = "/images/trainers/trainer4.jpg",
            Specializations = new() { "Digital Transformation", "IT Strategy", "Business Analytics" },
            Certifications = new() { "TOGAF", "ITIL Expert", "AWS Solutions Architect" }
        },
        new Trainer
        {
            Id = 5,
            Name = "Eng. Mohammed Al-Harbi",
            Title = "Health & Safety Director",
            Bio = "Eng. Mohammed has 18 years of experience in occupational health and safety, having implemented safety management systems across industrial and construction sectors.",
            ImageUrl = "/images/trainers/trainer5.jpg",
            Specializations = new() { "Occupational Safety", "Risk Management", "Emergency Response" },
            Certifications = new() { "CSP", "NEBOSH Diploma", "ISO 45001 Lead Auditor" }
        }
    };

    public static List<Accreditation> GetAccreditations() => new()
    {
        new Accreditation { Id = 1, Name = "IOSH", Description = "Institution of Occupational Safety and Health — the world's largest professional health and safety membership organization. Internationally recognized and accepted by employers across government and private sector organizations worldwide.", DescriptionAr = "مؤسسة السلامة والصحة المهنية (IOSH) — أكبر منظمة عضوية مهنية في مجال الصحة والسلامة على مستوى العالم. معترف بها دوليًا ومقبولة لدى جهات التوظيف في مؤسسات القطاعين الحكومي والخاص حول العالم.", LogoUrl = "/images/accreditations/iosh.png", Website = "https://iosh.com" },
        new Accreditation { Id = 2, Name = "ACMP", Description = "Association of Change Management Professionals — global professional body for change management. The CCMP credential is the most widely recognized certification in the field.", DescriptionAr = "جمعية محترفي إدارة التغيير (ACMP) — الهيئة المهنية العالمية لإدارة التغيير. وتُعدّ شهادة CCMP الأوسع اعترافًا في هذا المجال.", LogoUrl = "/images/accreditations/acmp.png", Website = "https://www.acmpglobal.org" },
        new Accreditation { Id = 3, Name = "CPD", Description = "Continuing Professional Development — internationally recognized framework for structured, outcome-based professional learning. Recognized by professional associations and employers as evidence of active development.", DescriptionAr = "التطوير المهني المستمر (CPD) — إطار معترف به دوليًا للتعلّم المهني المنظّم القائم على المخرجات. تعترف به الجمعيات المهنية وجهات التوظيف كدليل على التطوير الفعّال والمستمر.", LogoUrl = "/images/accreditations/cpd.png", Website = "https://cpduk.co.uk" },
        new Accreditation { Id = 4, Name = "TVTC", Description = "Technical and Vocational Training Corporation — Saudi Arabia's national authority for vocational training accreditation. TVTC registration is a requirement for inclusion in approved vendor lists for government and semi-government procurement.", DescriptionAr = "المؤسسة العامة للتدريب التقني والمهني (TVTC) — الجهة الوطنية المعنية باعتماد التدريب المهني في المملكة العربية السعودية. ويُعدّ التسجيل لدى المؤسسة شرطًا للإدراج في قوائم المورّدين المعتمدين للمشتريات الحكومية وشبه الحكومية.", LogoUrl = "/images/accreditations/tvtc.svg", Website = "https://www.tvtc.gov.sa" }
    };

    public static List<TrainingSession> GetUpcomingSessions() => new()
    {
        new TrainingSession { Id = 1, ProgramTitle = "Certified Corporate Governance Professional", StartDate = new DateTime(2026, 4, 5), EndDate = new DateTime(2026, 4, 9), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 2, ProgramTitle = "IOSH Managing Safely", StartDate = new DateTime(2026, 4, 12), EndDate = new DateTime(2026, 4, 14), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IOSH", Price = 1200, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 3, ProgramTitle = "Digital Transformation Technologies", StartDate = new DateTime(2026, 4, 19), EndDate = new DateTime(2026, 4, 21), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 4, ProgramTitle = "ISO 9001 Internal Audit", StartDate = new DateTime(2026, 5, 3), EndDate = new DateTime(2026, 5, 5), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 5, ProgramTitle = "Certified Change Management Expert (CCME)", StartDate = new DateTime(2026, 5, 10), EndDate = new DateTime(2026, 5, 14), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 6, ProgramTitle = "ISO 14001 Internal Audit", StartDate = new DateTime(2026, 5, 17), EndDate = new DateTime(2026, 5, 19), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 7, ProgramTitle = "ISO 9001 Lead Auditor", StartDate = new DateTime(2026, 6, 7), EndDate = new DateTime(2026, 6, 11), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 2800, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 8, ProgramTitle = "Certified Strategic Management Professional (CSMP)", StartDate = new DateTime(2026, 6, 7), EndDate = new DateTime(2026, 6, 11), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 9, ProgramTitle = "Smart Business Management Tools", StartDate = new DateTime(2026, 6, 14), EndDate = new DateTime(2026, 6, 16), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 10, ProgramTitle = "ISO 45001 Internal Audit", StartDate = new DateTime(2026, 6, 21), EndDate = new DateTime(2026, 6, 23), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 11, ProgramTitle = "Certified Corporate Governance Professional", StartDate = new DateTime(2026, 7, 5), EndDate = new DateTime(2026, 7, 9), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 12, ProgramTitle = "IOSH Managing Safely", StartDate = new DateTime(2026, 7, 12), EndDate = new DateTime(2026, 7, 14), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IOSH", Price = 1200, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 13, ProgramTitle = "Certified Change Management Professional (CCMP)", StartDate = new DateTime(2026, 7, 19), EndDate = new DateTime(2026, 7, 23), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "ACMP", Price = 5000, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 14, ProgramTitle = "Digital Transformation Technologies", StartDate = new DateTime(2026, 7, 26), EndDate = new DateTime(2026, 7, 28), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 15, ProgramTitle = "Certified Change Management Expert (CCME)", StartDate = new DateTime(2026, 8, 2), EndDate = new DateTime(2026, 8, 6), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 16, ProgramTitle = "Certified Supply Chain Professional (CSCP)", StartDate = new DateTime(2026, 8, 2), EndDate = new DateTime(2026, 8, 6), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 17, ProgramTitle = "Smart Business Management Tools", StartDate = new DateTime(2026, 8, 9), EndDate = new DateTime(2026, 8, 11), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 18, ProgramTitle = "Certified Change Management Professional (CCMP)", StartDate = new DateTime(2026, 8, 23), EndDate = new DateTime(2026, 8, 27), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "ACMP", Price = 5000, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 19, ProgramTitle = "ISO 14001 Lead Auditor", StartDate = new DateTime(2026, 9, 6), EndDate = new DateTime(2026, 9, 10), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 2800, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 20, ProgramTitle = "Digital Transformation Technologies", StartDate = new DateTime(2026, 9, 13), EndDate = new DateTime(2026, 9, 15), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 21, ProgramTitle = "ISO 50001 Internal Audit", StartDate = new DateTime(2026, 9, 20), EndDate = new DateTime(2026, 9, 22), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 22, ProgramTitle = "Smart Business Management Tools", StartDate = new DateTime(2026, 9, 27), EndDate = new DateTime(2026, 9, 29), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 23, ProgramTitle = "Certified Corporate Governance Professional", StartDate = new DateTime(2026, 10, 4), EndDate = new DateTime(2026, 10, 8), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 24, ProgramTitle = "IOSH Managing Safely", StartDate = new DateTime(2026, 10, 11), EndDate = new DateTime(2026, 10, 13), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IOSH", Price = 1200, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 25, ProgramTitle = "Automation & Digital Analysis Skills", StartDate = new DateTime(2026, 10, 18), EndDate = new DateTime(2026, 10, 20), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "—", Price = 1700, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 26, ProgramTitle = "Certified Change Management Professional (CCMP)", StartDate = new DateTime(2026, 10, 25), EndDate = new DateTime(2026, 10, 29), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "ACMP", Price = 5000, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 27, ProgramTitle = "Certified Change Management Expert (CCME)", StartDate = new DateTime(2026, 11, 1), EndDate = new DateTime(2026, 11, 5), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 28, ProgramTitle = "ISO 50001 Lead Auditor", StartDate = new DateTime(2026, 11, 8), EndDate = new DateTime(2026, 11, 12), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 2800, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 29, ProgramTitle = "Certified Strategic Management Professional (CSMP)", StartDate = new DateTime(2026, 11, 8), EndDate = new DateTime(2026, 11, 12), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 30, ProgramTitle = "ISO 9001 Internal Audit", StartDate = new DateTime(2026, 11, 22), EndDate = new DateTime(2026, 11, 24), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 1500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 31, ProgramTitle = "Certified Supply Chain Professional (CSCP)", StartDate = new DateTime(2026, 12, 6), EndDate = new DateTime(2026, 12, 10), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "CPD", Price = 2500, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 32, ProgramTitle = "Certified Change Management Professional (CCMP)", StartDate = new DateTime(2026, 12, 6), EndDate = new DateTime(2026, 12, 10), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "ACMP", Price = 5000, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 33, ProgramTitle = "ISO 9001 Lead Auditor", StartDate = new DateTime(2026, 12, 13), EndDate = new DateTime(2026, 12, 17), DurationDays = 5, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 2800, SeatsAvailable = 20, Status = "Open" },
        new TrainingSession { Id = 34, ProgramTitle = "ISO 14001 Internal Audit", StartDate = new DateTime(2026, 12, 27), EndDate = new DateTime(2026, 12, 29), DurationDays = 3, Location = "Online", DeliveryMode = "Virtual", AccreditationBody = "IRCA Approved Centre", Price = 1500, SeatsAvailable = 20, Status = "Open" }
    };

    public static TrainingCategory? GetCategoryBySlug(string slug) =>
        GetCategories().FirstOrDefault(c => c.Slug == slug);

    public static TrainingProgram? GetProgramBySlug(string categorySlug, string programSlug) =>
        GetCategories()
            .FirstOrDefault(c => c.Slug == categorySlug)?
            .Programs.FirstOrDefault(p => p.Slug == programSlug);

    public static List<TrainingProgram> GetAllPrograms() =>
        GetCategories().SelectMany(c => c.Programs).ToList();
}
