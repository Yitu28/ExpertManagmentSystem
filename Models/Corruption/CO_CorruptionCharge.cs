using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public enum CO_CrimeType { በመሬት, በፍት, በግብርናበታክስ, በግዥ, በሌሎች  }
    public class CO_CorruptionCharge
    {
        public Guid CO_CorruptionChargeId { get; set; }

        [Display(Name = "የዐ/ህግ ወ/መ/ቁጥር")]
        public string? prosecutorNo { get; set; }

        [Display(Name = "የምርመራ ወ/መ/ቁጥር")]
        public string? InvestigationNo { get; set; }

        [Display(Name = "የዐ/ህጉ ውሳኔ")]
        public string? DecisionType { get; set; }

        [Display(Name = "የተከሳሽ/ሾች ሙሉ ስም")]
        public string? DefendentName { get; set; }

        [Display(Name = "ፆታ")]
        public Gender Gender { get; set; }

        [Display(Name = "ብዛት")]
        public int Amount { get; set; }

        [Display(Name = "የተከሳሽ/ሾች መደበኛ ስራ")]
        public string? DefendantJob { get; set; }

        [Display(Name = "የተከሰሰበት/የተከሰሱበት የወንጀል ዓይነትቁጥር")]
        public CO_CrimeType CrimeType { get; set; }

        [Display(Name = "ፋይሉ የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }

        [Display(Name = "ምርመራው የተጣራው")]
        public string? InvestigationApproved { get; set; }

        [Display(Name = "የዐ/መ/ቁጥር")]
        public string? Remark { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
