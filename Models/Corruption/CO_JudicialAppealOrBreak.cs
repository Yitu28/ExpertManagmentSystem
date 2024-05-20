using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    
    public class CO_JudicialAppealOrBreak
    {
        [Key]
        public Guid CO_JudicialAppealOrBreakId { get; set; }

        [Display(Name = "የዐ/ህግ መ/ቁጥር")]
        public string? ProsecutorNo { get; set; }

        [Display(Name = "የፍ/ቤት መ/ቁጥር")]
        public string? SupremCourtNo { get; set; }

        //[Display(Name = "የፌ/ቤት መ/ቁጥር")]
        //public string? CourtNo { get; set; }

        [Display(Name = "ይግባኝ ባይ")]
        public string? Appellant { get; set; }

        [Display(Name = "መልስ ሰጭ")]
        public string? Answerer { get; set; }

        [Display(Name = "ፋይል የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }

        [Display(Name = "ወንጀሉ")]
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        [Display(Name = "የስር ፍ/ቤት ውሳኔ")]
        public string? LowerCourtDecision { get; set; }


        [Display(Name = "የዐ/ህግ አስተያየት")]
        public ProsecutorComment ProsecutorComment { get; set; }

        [Display(Name = "ልዩልዩ")]
        public string? Various { get; set; }
        

        [Display(Name = "አስተያየት የሰጠው ባለሙያ")]
        public string? ExpertOpinion { get; set; }

        //[Display(Name = "ብዛት")]
        //public int Amount { get; set; }

        //[Display(Name = "ቀጠሮ")]
        //public string? Appointment { get; set; }

        ////[Display(Name = "ወንጀል")]
        ////public CrimeDepartment CrimeType { get; set; }

        //[Display(Name = "ምርመራ")]
        //public string? Remark { get; set; }

        public J_AppealBreaking J_AppealOrBreak { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
        public virtual ICollection<CO_JudicialAppealOrBreakDecision>? CO_JudicialAppealOrBreakDecision { get; set; }

        //public string? UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }

    }
}
