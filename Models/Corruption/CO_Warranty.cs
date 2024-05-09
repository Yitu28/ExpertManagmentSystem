using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public class CO_Warranty
    {
        public int CO_WarrantyId { get; set; }

        [Display(Name = "የዐ/ህግ መ/ቁጥር")]
        public string? ProsecotorNo { get; set; }

        [Display(Name = "የዋስትና ጠያቂው ስም ")]
        public string? ApplicantName { get; set; }

        [Display(Name = "ፆታ")]
        public Gender Gender { get; set; }

        [Display(Name = "ብዛት")]
        public int Amount { get; set; }

        [Display(Name = "ቀን")]
        public DateTime WarrantyDate { get; set; }

        [Display(Name = "የፍ/ቤት ወ/መ/ቁጥር")]
        public string? CourtNo  { get; set; }

        [Display(Name = "ምርመራ")]
        public string? Remark { get; set; }

        [Display(Name = "SD")]
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
    }
}
