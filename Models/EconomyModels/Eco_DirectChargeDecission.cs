using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_DirectChargeDecission
    {
        public CrimeEconomy Ecocrime { get; set; }
        [Key]
        public Guid Eco_DirectChargeDecissionId { get; set; }
        [Display(Name = "መዝገብ የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }
        [Display(Name = "የፖ/መ/ቁ")]
        public string? PoliceNo { get; set; }
        [Display(Name = "የዐ/መ/ቁ")]
        public int ProsocuterNo { get; set; }
        [Display(Name = "የፍ/መ/ቁ ")]
        public string? CourtNo { get; set; }
        [Display(Name = "የተከሳሽ ስም")]
        public string? DefendantName { get; set; }
       [Display(Name = "የተከሳሽ ጾታ")]
        public Gender DefendantGender { get; set; }
          [Display(Name = "የተከሳሽ እድሜ ")]
        public int DefendantAge { get; set; }
       [Display(Name = "የከሳሽ ስም")]
        public string RespodentName { get; set; }
       [Display(Name = "የከሳሽ ጾታ")]
        public Gender RespodentGender { get; set; }
         [Display(Name = "የከሳሽ እድሜ")]
        public int RespodentAge { get;set; }
       [Display(Name = "ዞን")]
        public string? Zone { get; set; }
         [Display(Name = "ወረዳ")]
        public string? Woreda { get; set; }
       [Display(Name = "የተመራለት ባለሙያ")]
        public string? AdmissionExpert { get; set; }
        [Display(Name = "የምስክር ብዛት")]
        public int NumberOfWitnesses { get; set; }
        [Display(Name = "ኢግዚቢት")]  
         public string? Exhibit { get; set; }
        [Display(Name = "የዐ/ህግ ውሳኔ አይነት ")]
       
        public Guid Eco_ProsecutorDecisionId { get; set; }
        [ForeignKey(nameof(Eco_ProsecutorDecisionId))]
        public virtual Eco_ProsecutorDecision? Eco_ProsecutorDecision { get; set; }
        [Display(Name = "የወንጀል አይነት ")]

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }
       
        [Display(Name = "ዲፓርትመንት  ")]
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }




    }
}
