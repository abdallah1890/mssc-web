using MSSC.Web.Models;

namespace MSSC.Web.Data;

public static class IndustryData
{
    public static List<Industry> GetIndustries() => new()
    {
        new Industry
        {
            Id = 1,
            Slug = "government",
            Title = "Government & Public Sector",
            TitleAr = "القطاع الحكومي والعام",
            ShortDescription = "Supporting Vision 2030 through digital transformation, governance excellence, and public service optimization.",
            Description = "We partner with government entities to modernize operations, enhance citizen services, and achieve Vision 2030 objectives. Our expertise spans strategic planning, digital transformation, and organizational excellence for ministries, authorities, and public institutions.",
            Icon = "fa-landmark",
            ImageUrl = "/images/industries/government.jpg",
            Challenges = new()
            {
                "Complex stakeholder management across multiple agencies",
                "Balancing efficiency with regulatory compliance",
                "Digital transformation of legacy systems",
                "Attracting and retaining skilled workforce",
                "Meeting Vision 2030 transformation targets"
            },
            Solutions = new()
            {
                "Strategic planning aligned with national objectives",
                "E-government and digital service implementation",
                "Performance management and KPI frameworks",
                "Change management and organizational restructuring",
                "Capacity building and Saudization programs"
            },
            RelatedServices = new() { "strategy", "governance", "human-capital", "international-standards" }
        },
        new Industry
        {
            Id = 2,
            Slug = "healthcare",
            Title = "Healthcare & Life Sciences",
            TitleAr = "الرعاية الصحية وعلوم الحياة",
            ShortDescription = "Enhancing healthcare delivery through quality management, operational excellence, and patient safety standards.",
            Description = "We help healthcare organizations deliver exceptional patient care while meeting stringent regulatory requirements. Our solutions address clinical quality, operational efficiency, and strategic growth in hospitals, clinics, and pharmaceutical companies.",
            Icon = "fa-hospital",
            ImageUrl = "/images/industries/healthcare.jpg",
            Challenges = new()
            {
                "Maintaining quality while managing costs",
                "Achieving international healthcare accreditations",
                "Patient safety and clinical risk management",
                "Healthcare workforce development and retention",
                "Integration of healthcare technologies"
            },
            Solutions = new()
            {
                "JCI and CBAHI accreditation preparation",
                "Clinical quality management systems",
                "Patient experience improvement programs",
                "Healthcare leadership development",
                "Medical equipment lifecycle management"
            },
            RelatedServices = new() { "international-standards", "human-capital", "asset-facility" }
        },
        new Industry
        {
            Id = 3,
            Slug = "energy",
            Title = "Energy & Utilities",
            TitleAr = "الطاقة والمرافق",
            ShortDescription = "Driving operational excellence and sustainability in energy production, distribution, and utility services.",
            Description = "We support energy and utility companies in optimizing operations, ensuring safety, and transitioning to sustainable practices. Our expertise covers oil & gas, power generation, water utilities, and renewable energy sectors.",
            Icon = "fa-bolt",
            ImageUrl = "/images/industries/energy.jpg",
            Challenges = new()
            {
                "Operational safety and environmental compliance",
                "Asset reliability and maintenance optimization",
                "Energy transition and sustainability goals",
                "Workforce competency and succession planning",
                "Regulatory compliance across jurisdictions"
            },
            Solutions = new()
            {
                "ISO 14001 and ISO 45001 implementation",
                "Asset management per ISO 55001",
                "Enterprise risk management frameworks",
                "Technical training and competency development",
                "Sustainability strategy and reporting"
            },
            RelatedServices = new() { "international-standards", "asset-facility", "governance" }
        },
        new Industry
        {
            Id = 4,
            Slug = "financial-services",
            Title = "Financial Services",
            TitleAr = "الخدمات المالية",
            ShortDescription = "Strengthening governance, risk management, and operational resilience in banking and financial institutions.",
            Description = "We help banks, insurance companies, and financial institutions build robust governance frameworks, manage risk effectively, and achieve operational excellence while meeting regulatory requirements.",
            Icon = "fa-building-columns",
            ImageUrl = "/images/industries/financial.jpg",
            Challenges = new()
            {
                "Evolving regulatory requirements (SAMA, CMA)",
                "Cybersecurity and data protection",
                "Digital banking transformation",
                "Risk management and compliance",
                "Customer experience enhancement"
            },
            Solutions = new()
            {
                "GRC framework development",
                "Business continuity management (ISO 22301)",
                "Information security management (ISO 27001)",
                "Operational excellence programs",
                "Leadership and talent development"
            },
            RelatedServices = new() { "governance", "international-standards", "human-capital" }
        },
        new Industry
        {
            Id = 5,
            Slug = "manufacturing",
            Title = "Manufacturing & Industrial",
            TitleAr = "التصنيع والقطاع الصناعي",
            ShortDescription = "Optimizing manufacturing operations through quality management, lean practices, and Industry 4.0 adoption.",
            Description = "We partner with manufacturers to enhance productivity, ensure quality, and embrace digital transformation. Our solutions span process optimization, quality management, and workforce development for diverse industrial sectors.",
            Icon = "fa-industry",
            ImageUrl = "/images/industries/manufacturing.jpg",
            Challenges = new()
            {
                "Global competition and cost pressures",
                "Quality consistency and defect reduction",
                "Skilled labor shortage and training needs",
                "Industry 4.0 technology adoption",
                "Supply chain resilience"
            },
            Solutions = new()
            {
                "ISO 9001 quality management systems",
                "Lean manufacturing and Six Sigma",
                "Total productive maintenance (TPM)",
                "Industrial training programs",
                "Digital transformation roadmaps"
            },
            RelatedServices = new() { "international-standards", "asset-facility", "strategy" }
        },
        new Industry
        {
            Id = 6,
            Slug = "education",
            Title = "Education & Training",
            TitleAr = "التعليم والتدريب",
            ShortDescription = "Transforming educational institutions through strategic planning, quality assurance, and organizational development.",
            Description = "We help universities, schools, and training organizations achieve academic excellence, operational efficiency, and sustainable growth. Our expertise covers accreditation, curriculum development, and institutional effectiveness.",
            Icon = "fa-graduation-cap",
            ImageUrl = "/images/industries/education.jpg",
            Challenges = new()
            {
                "Achieving and maintaining accreditation",
                "Adapting to evolving education trends",
                "Faculty development and retention",
                "Student outcomes and employability",
                "Technology integration in learning"
            },
            Solutions = new()
            {
                "Institutional accreditation preparation",
                "Strategic planning and governance",
                "Quality assurance systems",
                "Faculty development programs",
                "Performance management frameworks"
            },
            RelatedServices = new() { "strategy", "human-capital", "international-standards" }
        },
        new Industry
        {
            Id = 7,
            Slug = "retail-hospitality",
            Title = "Retail & Hospitality",
            TitleAr = "التجزئة والضيافة",
            ShortDescription = "Elevating customer experience and operational excellence in retail chains, hotels, and hospitality businesses.",
            Description = "We help retail and hospitality organizations deliver exceptional customer experiences while optimizing operations and developing talent. Our solutions address service quality, operational efficiency, and brand consistency.",
            Icon = "fa-hotel",
            ImageUrl = "/images/industries/hospitality.jpg",
            Challenges = new()
            {
                "Customer experience consistency",
                "High employee turnover",
                "Seasonal demand management",
                "Multi-location standardization",
                "Digital commerce integration"
            },
            Solutions = new()
            {
                "Service excellence programs",
                "Mystery shopping and quality audits",
                "Staff training and development",
                "Performance management systems",
                "Customer feedback management"
            },
            RelatedServices = new() { "human-capital", "strategy", "international-standards" }
        },
        new Industry
        {
            Id = 8,
            Slug = "construction",
            Title = "Construction & Real Estate",
            TitleAr = "البناء والعقارات",
            ShortDescription = "Supporting mega projects and real estate development through project management excellence and safety standards.",
            Description = "We partner with construction companies and real estate developers to deliver projects safely, on time, and within budget. Our expertise covers project management, safety compliance, and asset management for the built environment.",
            Icon = "fa-hard-hat",
            ImageUrl = "/images/industries/construction.jpg",
            Challenges = new()
            {
                "Project delays and cost overruns",
                "Safety compliance and incident prevention",
                "Quality control across subcontractors",
                "Skilled workforce availability",
                "Sustainability and green building requirements"
            },
            Solutions = new()
            {
                "Project management office (PMO) setup",
                "ISO 45001 safety management",
                "Contractor management systems",
                "Technical training programs",
                "Facility management for delivered assets"
            },
            RelatedServices = new() { "asset-facility", "international-standards", "human-capital" }
        }
    };

    public static List<Client> GetClients() => new()
    {
        new Client { Id = 1, Name = "Ministry of Municipal, Rural Affairs and Housing", NameAr = "وزارة الشؤون البلدية والقروية والإسكان", Industry = "Government", LogoUrl = "/images/clients/ministry-municipal-rural-housing.png", IsFeatured = true },
        new Client { Id = 2, Name = "General Transport Authority", NameAr = "الهيئة العامة للنقل", Industry = "Government", LogoUrl = "/images/clients/general-transport-authority.png", IsFeatured = true },
        new Client { Id = 3, Name = "Authority for Persons with Disabilities", NameAr = "هيئة رعاية الأشخاص ذوي الإعاقة", Industry = "Government", LogoUrl = "/images/clients/disability-authority-apd.png", IsFeatured = true },
        new Client { Id = 4, Name = "Ministry of National Guard", NameAr = "وزارة الحرس الوطني", Industry = "Government", LogoUrl = "/images/clients/ministry-national-guard.png", IsFeatured = true },
        new Client { Id = 5, Name = "Royal Protocol", NameAr = "المراسم الملكية", Industry = "Government", LogoUrl = "/images/clients/royal-protocol.png", IsFeatured = true },
        new Client { Id = 6, Name = "Ministry of Finance", NameAr = "وزارة المالية", Industry = "Government", LogoUrl = "/images/clients/ministry-finance.png", IsFeatured = true },
        new Client { Id = 7, Name = "Saudi Tourism Authority", NameAr = "الهيئة العامة للسياحة والتراث الوطني", Industry = "Government", LogoUrl = "/images/clients/tourism-heritage-authority.png", IsFeatured = true },
        new Client { Id = 8, Name = "Ministry of Commerce", NameAr = "وزارة التجارة", Industry = "Government", LogoUrl = "/images/clients/ministry-commerce.png", IsFeatured = true },
        new Client { Id = 9, Name = "Ministry of Human Resources and Social Development", NameAr = "وزارة الموارد البشرية والتنمية الاجتماعية", Industry = "Government", LogoUrl = "/images/clients/ministry-hr-social-development.png", IsFeatured = true },
        new Client { Id = 10, Name = "Saline Water Conversion Corporation", NameAr = "المؤسسة العامة لتحلية المياه المالحة", Industry = "Government", LogoUrl = "/images/clients/swcc.png", IsFeatured = true },
        new Client { Id = 11, Name = "Capital Market Authority", NameAr = "هيئة السوق المالية", Industry = "Government", LogoUrl = "/images/clients/capital-market-authority.png", IsFeatured = true },
        new Client { Id = 12, Name = "Saudi Standards, Metrology and Quality Organization", NameAr = "الهيئة السعودية للمواصفات والمقاييس والجودة", Industry = "Government", LogoUrl = "/images/clients/saso.png", IsFeatured = true },
        new Client { Id = 13, Name = "King Abdulaziz Quality Award", NameAr = "جائزة الملك عبدالعزيز للجودة", Industry = "Government", LogoUrl = "/images/clients/king-abdulaziz-quality-award.png", IsFeatured = true },
        new Client { Id = 14, Name = "Ministry of Industry and Mineral Resources", NameAr = "وزارة الصناعة والثروة المعدنية", Industry = "Government", LogoUrl = "/images/clients/ministry-industry-mineral.png", IsFeatured = true },
        new Client { Id = 15, Name = "Al-Ahsa Development Authority", NameAr = "هيئة تطوير الأحساء", Industry = "Government", LogoUrl = "/images/clients/ahsa.png", IsFeatured = true },
        new Client { Id = 16, Name = "Saudi Electronic University", NameAr = "الجامعة السعودية الإلكترونية", Industry = "Education", LogoUrl = "/images/clients/saudi-electronic-university.png", IsFeatured = true },
        new Client { Id = 17, Name = "Imam Abdulrahman Bin Faisal University", NameAr = "جامعة الإمام عبدالرحمن بن فيصل", Industry = "Education", LogoUrl = "/images/clients/imam-abdulrahman-university.png", IsFeatured = true },
        new Client { Id = 18, Name = "King Saud bin Abdulaziz University for Health Sciences", NameAr = "جامعة الملك سعود بن عبدالعزيز للعلوم الصحية", Industry = "Education", LogoUrl = "/images/clients/ksau-hs.svg", IsFeatured = true },
        new Client { Id = 19, Name = "University of Hafr Al-Batin", NameAr = "جامعة حفر الباطن", Industry = "Education", LogoUrl = "/images/clients/uhb.png", IsFeatured = true },
        new Client { Id = 20, Name = "Almarai Company", NameAr = "شركة المراعي", Industry = "Manufacturing", LogoUrl = "/images/clients/almarai.png", IsFeatured = true },
        new Client { Id = 21, Name = "National Water Company", NameAr = "شركة المياه الوطنية", Industry = "Energy", LogoUrl = "/images/clients/national-water-company.png", IsFeatured = true }
    };

    public static List<Partner> GetPartners() => new()
    {
        new Partner
        {
            Id = 1,
            Name = "Blackbird Training Center",
            NameAr = "مركز بلاك بيرد للتدريب",
            Description = "Professional training center providing comprehensive development programs.",
            LogoUrl = "/images/partners/image24.png",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 2,
            Name = "Prosci",
            Description = "Global leader in change management research, training and certification.",
            LogoUrl = "/images/partners/image25.png",
            Website = "https://www.prosci.com",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 3,
            Name = "University of Oxford",
            Description = "World-renowned institution for executive education and leadership development.",
            LogoUrl = "/images/partners/image26.png",
            Website = "https://www.ox.ac.uk",
            PartnerType = "Academic"
        },
        new Partner
        {
            Id = 4,
            Name = "Meirc Training & Consulting",
            Description = "Leading training provider in the Middle East offering professional development programs.",
            LogoUrl = "/images/partners/image27.png",
            Website = "https://www.meirc.com",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 5,
            Name = "Technical Development Center",
            NameAr = "مركز التطوير التقني للتدريب",
            Description = "Specialized center for technical and professional training programs.",
            LogoUrl = "/images/partners/image28.png",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 6,
            Name = "Institute of Public Administration",
            NameAr = "معهد الإدارة العامة",
            Description = "Saudi government institution for public sector training and development.",
            LogoUrl = "/images/partners/image29.png",
            Website = "https://www.ipa.edu.sa",
            PartnerType = "Government"
        },
        new Partner
        {
            Id = 7,
            Name = "Saudi Council of Engineers",
            NameAr = "الهيئة السعودية للمهندسين",
            Description = "Professional body for engineering accreditation and development in Saudi Arabia.",
            LogoUrl = "/images/partners/image30.png",
            Website = "https://www.saudieng.sa",
            PartnerType = "Professional"
        },
        new Partner
        {
            Id = 8,
            Name = "The KPI Institute",
            Description = "Global research institute for performance management and KPI best practices.",
            LogoUrl = "/images/partners/image31.png",
            Website = "https://www.kpiinstitute.org",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 9,
            Name = "LPC - Leadership & Performance Center",
            Description = "Center specialized in leadership development and organizational performance.",
            LogoUrl = "/images/partners/image32.png",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 10,
            Name = "Partner 10",
            Description = "Strategic partner for professional development and training solutions.",
            LogoUrl = "/images/partners/image33.png",
            PartnerType = "Strategic"
        },
        new Partner
        {
            Id = 11,
            Name = "Partner 11",
            Description = "Training partner for specialized professional programs.",
            LogoUrl = "/images/partners/image34.png",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 12,
            Name = "Partner 12",
            Description = "Accredited center for professional certification programs.",
            LogoUrl = "/images/partners/image35.png",
            PartnerType = "Training"
        },
        new Partner
        {
            Id = 13,
            Name = "Partner 13",
            Description = "Strategic alliance partner for management consulting and training.",
            LogoUrl = "/images/partners/image36.jpeg",
            PartnerType = "Strategic"
        }
    };

    public static List<CaseStudy> GetCaseStudies() => new()
    {
        new CaseStudy
        {
            Id = 1,
            Slug = "government-digital-transformation",
            Title = "Digital Transformation for Government Ministry",
            TitleAr = "التحول الرقمي لوزارة حكومية",
            ClientName = "Ministry of Communications",
            ClientNameAr = "وزارة الاتصالات",
            Industry = "Government",
            IndustryAr = "القطاع الحكومي",
            Challenge = "Legacy systems hindering service delivery and citizen satisfaction, with manual processes causing delays and errors.",
            ChallengeAr = "أنظمة قديمة تعيق تقديم الخدمات ورضا المستفيدين، مع عمليات يدوية تسبّب تأخيرات وأخطاء.",
            Solution = "Comprehensive digital transformation strategy including e-services portal, process automation, and change management program.",
            SolutionAr = "استراتيجية تحول رقمي شاملة تشمل بوابة خدمات إلكترونية، وأتمتة العمليات، وبرنامج إدارة التغيير.",
            Results = new() { "70% reduction in service delivery time", "85% citizen satisfaction score", "ISO 9001 certification achieved" },
            ResultsAr = new() { "خفض زمن تقديم الخدمة بنسبة 70%", "نسبة رضا المستفيدين 85%", "الحصول على شهادة ISO 9001" },
            ImageUrl = "/images/case-studies/gov-digital.jpg",
            ServicesUsed = new() { "Strategy", "Digital Transformation", "Change Management" },
            ServicesUsedAr = new() { "الاستراتيجية", "التحول الرقمي", "إدارة التغيير" },
            Metrics = new() { "70% faster service delivery", "85% satisfaction score", "ISO 9001 certified" },
            MetricsAr = new() { "خدمة أسرع بنسبة 70%", "رضا 85%", "معتمد ISO 9001" }
        },
        new CaseStudy
        {
            Id = 2,
            Slug = "healthcare-accreditation",
            Title = "JCI Accreditation for Major Hospital",
            TitleAr = "اعتماد JCI لمستشفى كبير",
            ClientName = "Regional Medical Center",
            ClientNameAr = "مركز طبي إقليمي",
            Industry = "Healthcare",
            IndustryAr = "الرعاية الصحية",
            Challenge = "Hospital needed to achieve JCI accreditation within 18 months while maintaining operations and improving patient safety.",
            ChallengeAr = "احتاج المستشفى إلى الحصول على اعتماد JCI خلال 18 شهراً مع الحفاظ على سير العمليات وتحسين سلامة المرضى.",
            Solution = "Gap analysis, quality management system implementation, staff training, and continuous improvement program aligned with JCI standards.",
            SolutionAr = "تحليل الفجوات، وتطبيق نظام إدارة الجودة، وتدريب الكوادر، وبرنامج تحسين مستمر متوائم مع معايير JCI.",
            Results = new() { "JCI accreditation on first attempt", "40% reduction in patient safety incidents", "Improved staff competency" },
            ResultsAr = new() { "اعتماد JCI من المحاولة الأولى", "خفض حوادث سلامة المرضى بنسبة 40%", "تحسّن كفاءة الكوادر" },
            ImageUrl = "/images/case-studies/healthcare-jci.jpg",
            ServicesUsed = new() { "International Standards", "Training", "Quality Management" },
            ServicesUsedAr = new() { "المعايير الدولية", "التدريب", "إدارة الجودة" },
            Metrics = new() { "JCI accredited", "40% fewer incidents", "95% staff trained" },
            MetricsAr = new() { "معتمد JCI", "حوادث أقل بنسبة 40%", "تدريب 95% من الكوادر" }
        },
        new CaseStudy
        {
            Id = 3,
            Slug = "energy-asset-management",
            Title = "Asset Management Excellence for Energy Company",
            TitleAr = "تميّز إدارة الأصول لشركة طاقة",
            ClientName = "National Power Company",
            ClientNameAr = "شركة الطاقة الوطنية",
            Industry = "Energy",
            IndustryAr = "الطاقة",
            Challenge = "Aging infrastructure, unplanned downtime, and rising maintenance costs threatening operational reliability and profitability.",
            ChallengeAr = "بنية تحتية متقادمة، وتوقفات غير مخطّطة، وارتفاع تكاليف الصيانة تهدّد موثوقية التشغيل والربحية.",
            Solution = "ISO 55001-aligned asset management system, predictive maintenance implementation, and technical workforce development.",
            SolutionAr = "نظام إدارة أصول متوائم مع ISO 55001، وتطبيق الصيانة التنبؤية، وتطوير الكوادر الفنية.",
            Results = new() { "25% reduction in maintenance costs", "99.5% plant availability", "ISO 55001 certification" },
            ResultsAr = new() { "خفض تكاليف الصيانة بنسبة 25%", "جاهزية المنشأة 99.5%", "شهادة ISO 55001" },
            ImageUrl = "/images/case-studies/energy-asset.jpg",
            ServicesUsed = new() { "Asset Management", "ISO Standards", "Technical Training" },
            ServicesUsedAr = new() { "إدارة الأصول", "معايير ISO", "التدريب الفني" },
            Metrics = new() { "25% cost reduction", "99.5% availability", "ISO 55001 certified" },
            MetricsAr = new() { "خفض التكاليف 25%", "جاهزية 99.5%", "معتمد ISO 55001" }
        },
        new CaseStudy
        {
            Id = 4,
            Slug = "manufacturing-lean",
            Title = "Lean Transformation for Manufacturing Plant",
            TitleAr = "التحول الرشيق لمصنع",
            ClientName = "Industrial Manufacturing Co.",
            ClientNameAr = "شركة تصنيع صناعي",
            Industry = "Manufacturing",
            IndustryAr = "التصنيع",
            Challenge = "High production waste, inconsistent quality, and low equipment effectiveness impacting competitiveness and profitability.",
            ChallengeAr = "هدر إنتاج مرتفع، وجودة غير متّسقة، وكفاءة معدّات منخفضة تؤثّر على التنافسية والربحية.",
            Solution = "Lean manufacturing program including value stream mapping, 5S implementation, TPM, and continuous improvement culture.",
            SolutionAr = "برنامج تصنيع رشيق يشمل رسم خرائط تدفق القيمة، وتطبيق 5S، والصيانة الإنتاجية الشاملة (TPM)، وثقافة التحسين المستمر.",
            Results = new() { "30% productivity improvement", "50% waste reduction", "OEE increased to 85%" },
            ResultsAr = new() { "تحسّن الإنتاجية بنسبة 30%", "خفض الهدر بنسبة 50%", "رفع الكفاءة الكلية للمعدّات إلى 85%" },
            ImageUrl = "/images/case-studies/manufacturing-lean.jpg",
            ServicesUsed = new() { "Operational Excellence", "Training", "Quality Management" },
            ServicesUsedAr = new() { "التميّز التشغيلي", "التدريب", "إدارة الجودة" },
            Metrics = new() { "30% productivity gain", "50% waste reduction", "85% OEE achieved" },
            MetricsAr = new() { "زيادة إنتاجية 30%", "خفض هدر 50%", "كفاءة معدّات 85%" }
        },
        new CaseStudy
        {
            Id = 5,
            Slug = "bank-grc",
            Title = "GRC Framework for Regional Bank",
            TitleAr = "إطار الحوكمة وإدارة المخاطر والامتثال لبنك إقليمي",
            ClientName = "Saudi Regional Bank",
            ClientNameAr = "بنك سعودي إقليمي",
            Industry = "Financial Services",
            IndustryAr = "الخدمات المالية",
            Challenge = "Fragmented governance, risk, and compliance processes creating regulatory risks and operational inefficiencies.",
            ChallengeAr = "عمليات حوكمة ومخاطر وامتثال مجزّأة تخلق مخاطر تنظيمية وعدم كفاءة تشغيلية.",
            Solution = "Integrated GRC framework development, risk management system implementation, and compliance automation.",
            SolutionAr = "تطوير إطار متكامل للحوكمة وإدارة المخاطر والامتثال، وتطبيق نظام إدارة المخاطر، وأتمتة الامتثال.",
            Results = new() { "100% regulatory compliance", "60% reduction in audit findings", "Enhanced board reporting" },
            ResultsAr = new() { "امتثال تنظيمي 100%", "خفض ملاحظات التدقيق بنسبة 60%", "تحسين تقارير مجلس الإدارة" },
            ImageUrl = "/images/case-studies/bank-grc.jpg",
            ServicesUsed = new() { "GRC", "Risk Management", "Compliance" },
            ServicesUsedAr = new() { "الحوكمة والمخاطر والامتثال", "إدارة المخاطر", "الامتثال" },
            Metrics = new() { "100% compliance", "60% fewer findings", "Enhanced reporting" },
            MetricsAr = new() { "امتثال 100%", "ملاحظات أقل 60%", "تقارير محسّنة" }
        }
    };

    public static Industry? GetIndustryBySlug(string slug) =>
        GetIndustries().FirstOrDefault(i => i.Slug == slug);

    public static List<Client> GetFeaturedClients() =>
        GetClients().Where(c => c.IsFeatured).ToList();

    public static CaseStudy? GetCaseStudyBySlug(string slug) =>
        GetCaseStudies().FirstOrDefault(cs => cs.Slug == slug);
}
