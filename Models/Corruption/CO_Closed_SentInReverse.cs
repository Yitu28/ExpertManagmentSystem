using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public enum Opinion { የፀና, የተሻረ }
    public class CO_Closed_SentInReverse
    {
        public Guid CO_Closed_SentInReverseId { get; set; }

        [Display(Name = "የዐ/ህግ መ/ቁጥር")]
        public string? ProsecutorNo { get; set; }

        [Display(Name = "የተከሳሽ ስም")]
        public string? Defenedant { get; set; }

        [Display(Name = "የተፈፀመው ወንጀል")]
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        [Display(Name = "የፖሊስ መ/ቁጥር")]
        public string? PoliceNo { get; set; }

        [Display(Name = "ዞን")]
        public string? DefenedantZone { get; set; }

        [Display(Name = "የተሰጠበት ቀን")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "የተመለሰበት ቀን")]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "የተሰጠ ውሳኔ")]
        public Guid ProsecutorsDecisionId { get; set; }
        [ForeignKey(nameof(ProsecutorsDecisionId))]
        public virtual ProsecutorsDecision? ProsecutorsDecision { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
        //public string? UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
