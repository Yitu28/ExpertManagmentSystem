using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    //public enum Gender { ወንድ, ሴት }

    public class CO_FirstOrder
    {
        public Guid CO_FirstOrderId { get; set; }

        [Display(Name = "የዐ/ህግ መ/ቁጥር")]
        public string? ProsecotorRecordNo { get; set; }

        [Display(Name = "የዞን ዐ/ህግ መ/ቁጥር")]
        public string? ZoneProsecotorRecordNo { get; set; }

        [Display(Name = "የተከሳሽ ስም")]
        public string? DefendantName { get; set; }

        [Display(Name = "ዞን")]
        public string? Zone { get; set; }

        [Display(Name = "ፋይሉ የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }

        [Display(Name = "ፆታ")]
        public Gender Gender { get; set; }

        [Display(Name = "ብዛት")]
        public string? Amount { get; set; }

        [Display(Name = "የተሰጠ አስተያየት")]
        public string? Comment { get; set; }

        [Display(Name = "ምርመራ")]
        public string? Remark { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
