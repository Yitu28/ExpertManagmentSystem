using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public enum DecisionStatus { pending, decision  }
    public class CO_CorruptionCharge
    {
        public Guid CO_CorruptionChargeId { get; set; }

        [Display(Name = "የዐ/ህግ መ/ቁጥር")]
        public string? prosecutorNo { get; set; }

        [Display(Name = "የፖ/መ/ቁጥር")]
        public string? InvestigationNo { get; set; }
        [Display(Name = "የፍ/መ/ቁጥር")]
        public string? CourtNo { get; set; }

        //[Display(Name = "የዐ/ህጉ ውሳኔ")]
        //public string? DecisionType { get; set; }

        [Display(Name = "የተከሳሽ/ሾች ሙሉ ስም")]
        public string? DefendentName { get; set; }

        [Display(Name = "ፆታ")]
        public Gender Gender { get; set; }
        [Display(Name = "እድሜ")]
        public int Age { get; set; }

        [Display(Name = "የተበዳይ ሙሉ ስም")]
        public string? ApplicantName { get; set; }

        [Display(Name = "ፆታ")]
        public Gender ApplicantGender { get; set; }
        [Display(Name = "እድሜ")]
        public int ApplicantAge { get; set; }

        [Display(Name = "ብዛት")]
        public int Amount { get; set; }

        //[Display(Name = "የተከሳሽ/ሾች መደበኛ ስራ")]
        //public string? DefendantJob { get; set; }

        [Display(Name = "ፋይሉ የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }

        [Display(Name = "ዞን")]
        public string? Zone { get; set; }
        [Display(Name = "ወረዳ")]
        public string? Woreda { get; set; }
        [Display(Name = "ቀበሌ")]
        public string? Kebele { get; set; }
        [Display(Name = "የተከሰሰበት/የተከሰሱበት የወንጀል ዓይነት")]
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        [Display(Name = "የተመራለት ባለሙያ")]
        public string? ExpertName { get; set; }

        [Display(Name = "የምስክር ቁጥር")]
        public int NumberofWitnesses { get; set; }

        [Display(Name = "ኤግዚቢት")]
        public string? Exhibit { get; set; }

        [Display(Name = "የዐ/ህግ ውሳኔ")]
        public Guid ProsecutorsDecisionId { get; set; }
        [ForeignKey(nameof(ProsecutorsDecisionId))]
        public virtual ProsecutorsDecision? ProsecutorsDecision { get; set; }

        
        public DecisionStatus? DecisionStatus { get; set; }


        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
        
        //public string? UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }

        

    }
    
}
