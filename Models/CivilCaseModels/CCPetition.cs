using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class CCPetition
    {
        // Pet Stands for Petition
        [Key]
        public Guid CCPetitionId { get; set; }

        [Required(ErrorMessage = "የእባክዎን ዐቃቢ ህግ መዝገብ ቁጥር ይሙሉ")]
        [Display(Name = "የዐ/ህ/መ/ቁ.")]
        public string PeFileNo { get; set; }

        [Required(ErrorMessage = "የእባክዎን ህግ ምክር ጠያቂን ይሙሉ ")]
        [Display(Name = "የህግ ምክር ጠያቂ")]
        public string Pevicerequester { get; set; }

        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ ፈላጊ ፆታን ይምረጡ !")]

        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ፆታ")]   
        public Genders? PeGender { get; set; }

        // Legal Aid breaking response Openning Age
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ ፈላጊ ዕድሜን ይሙሉ !")]

        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ዕድሜ")]
        public int? PeAge { get; set; }

        // Legal Aid breaking response Openning Support Type
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ አይነትን ይሙሉ !")]

        [Display(Name = "ነፃ የህግ ድጋፍ አይነት ")]
        public SupportType? PeSupportType { get; set; }


        [Required(ErrorMessage = "የእባክዎን የመጣበት ቀን ይሙሉ")]
        [Display(Name = "የመጣበት ቀን")]
        public DateTime PeDoariv { get; set; }


        [Required(ErrorMessage = "የእባክዎን የህግ ምክር አይነትን ይሙሉ")]
        [Display(Name = "የህግ ምክር አይነት")]
        public String? PeTypes { get; set; }


        [Required(ErrorMessage = "እባክዎን የዞን አድራሻን ይሙሉ !")]
        [Display(Name = "ዞን")]
        public string? PeAddressZone { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን ወረዳ አድራሻን ይሙሉ !")]

        [Display(Name = "ወረዳ ")]
        public string? PeAddressWoreda { get; set; }


        [Required(ErrorMessage = "የእባክዎን መዝገቡን የስራው ባለሙያን ይሙሉ")]
        [Display(Name = "መዝገቡን የስራው ባለሙያ")]
        public string? PeExpertName { get; set; }

        [Required(ErrorMessage = "የእባክዎን የምክር አገልግሎት የተሰጠበትን ቀን ይሙሉ")]
        [Display(Name = "የምክር አገልግሎት የተሰጠበት ቀን")]
        public DateTime? PeDaos { get; set; }

        [Required(ErrorMessage = "የእባክዎን ተሰርቶ የተመለሰበትን ቀን ይሙሉ")]
        [Display(Name = "ተሰርቶ የተመለሰበት ቀን ")]
        public DateTime? PeDoare { get; set; }


        [Required(ErrorMessage = "የእባክዎን የፈጀውን ጊዜ ይሙሉ ")]
        [Display(Name = "የፈጀው ጊዜ")]
        public string? PeTimeTaken { get; set; }

        [Required(ErrorMessage = "የእባክዎን የዐቃቢ ህግ ወሳኔን ይሙሉ")]
        [Display(Name = "የዐቃቢ ህግ ውሳኔ")]
        public string? PePDecisoion { get; set; }


        [Required(ErrorMessage = "የእባክዎን የተመራለትን ተቋም ይሙሉ ")]
        [Display(Name = "የተመራለት ተቋም")]
        public string? PeAssignto { get; set; }


        public Guid? PeCreatedBy { get; set; }
        public Guid? PeUpdatededBy { get; set; }
        public Guid? PeDeletedBy { get; set; }

        public DateTime? PeCreatedAt { get; set; }
        public DateTime? PeEdittedAt { get; set; }
        public DateTime? PeDeletedAt { get; set; }


    }
}
