using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class CCLegaladvices
    {
        // Lad Stands for Legal Advice 
        [Key]
        public Guid CCLegaladvicesId { get; set; }

        [Required(ErrorMessage = "የእባክዎን ዐቃቢ ህግ መዝገብ ቁጥር ይሙሉ")]
        [Display(Name = "የዐ/ህ/መ/ቁ.")]
        public string? LadFileNo { get; set; }

        [Required(ErrorMessage = "የእባክዎን ህግ ምክር ጠያቂን ይሙሉ ")]
        [Display(Name = "የህግ ምክር ጠያቂ")]
        public string? Ladvicerequester { get; set; }

        [Required(ErrorMessage = "የእባክዎን የመጣበት ቀን ይሙሉ")]
        [Display(Name = "የመጣበት ቀን")]
        public DateTime? LadDoariv { get; set; }


        [Required(ErrorMessage = "የእባክዎን የህግ ምክር አይነትን ይሙሉ")]
        [Display(Name = "የህግ ምክር አይነት")]
        public String? LadTypes { get; set; }

        [Required(ErrorMessage = "የእባክዎን የገንዘብ መጠንን በብር ይሙሉ ")]
        [Display(Name = "የገንዘብ መጠን በብር")]
        public int? LadAmountBirr { get; set; }

        [Required(ErrorMessage = "የእባክዎን የገንዘብ መጠንን በካሬ የሙሉ ")]
        [Display(Name = "የገንዘብ መጠን በካሬ")]
        public int? LadAmountKarie { get; set; }

        [Required(ErrorMessage = "እባክዎን የዞን አድራሻን ይሙሉ !")]

        [Display(Name = "ዞን")]
        public string? LadAddressZone { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን ወረዳ አድራሻን ይሙሉ !")]

        [Display(Name = "ወረዳ ")]
        public string? LadAddressWoreda { get; set; }


        [Required(ErrorMessage = "የእባክዎን መዝገቡን የስራው ባለሙያን ይሙሉ")]
        [Display(Name = "መዝገቡን የስራው ባለሙያ")]
        public string? LadExpertName { get; set; }

        [Required(ErrorMessage = "የእባክዎን የምክር አገልግሎት የተሰጠበትን ቀን ይሙሉ")]
        [Display(Name = "የምክር አገልግሎት የተሰጠበት ቀን")]
        public DateTime? LadDaos { get; set; }

        [Required(ErrorMessage = "የእባክዎን ተሰርቶ የተመለሰበትን ቀን ይሙሉ")]
        [Display(Name = "ተሰርቶ የተመለሰበት ቀን ")]
        public DateTime? LadDoare { get; set; }


        [Required(ErrorMessage = "የእባክዎን የፈጀውን ጊዜ ይሙሉ ")]
        [Display(Name = "የፈጀው ጊዜ")]
        public string? LadTimeTaken { get; set; }

        [Required(ErrorMessage = "የእባክዎን የዐቃቢ ህግ ወሳኔን ይሙሉ")]
        [Display(Name = "የዐቃቢ ህግ ውሳኔ")]
        public string? LadPDecisoion { get; set; }


        [Required(ErrorMessage = "የእባክዎን የተመራለትን ተቋም ይሙሉ ")]
        [Display(Name = "የተመራለት ተቋም")]
        public string? LadAssignto { get; set; }

        public Guid? LadCreatedBy { get; set; }
        public Guid? LaddatededBy { get; set; }
        public Guid? LadDeletedBy { get; set; }

        public DateTime? LadCreatedAt { get; set; }
        public DateTime? LadEdittedAt { get; set; }
        public DateTime? LadDeletedAt { get; set; }
    }
}
