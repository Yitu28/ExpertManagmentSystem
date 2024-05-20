using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public enum AppealBreaking
    {
        ሰበር, ይግባኝ
    }
    public class CO_FederalAppealOrBreak
    {
        [Key]
        public Guid CO_FederalAppealId { get; set; }

        [Display(Name = "የዐ/መ/ቁጥር")]
        public string? ProsecutorNo { get; set; }

        [Display(Name = "የጠቅላይ ፍ/ቤት መ/ቁጥር")]
        public string? SupremCourtNo { get; set; }

        [Display(Name = "የፌ/ቤት መ/ቁጥር")]
        public string? CourtNo { get; set; }

        [Display(Name = "ይግባኝ ባይ")]
        public string? Appellant { get; set; }

        [Display(Name = "መልስ ሰጭ")]
        public string? Answerer { get; set; }

        [Display(Name = "ፋይል የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }

        [Display(Name = "ዖታ")]
        public Gender Gender { get; set; }

        [Display(Name = "ብዛት")]
        public int Amount { get; set; }

        [Display(Name = "ቀጠሮ")]
        public string? Appointment { get; set; }

        [Display(Name = "ወንጀል")]
        public string? CrimeType { get; set; }

        [Display(Name = "ምርመራ")]
        public string? Remark { get; set; }
        
        public AppealBreaking F_AppealOrBreak { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
