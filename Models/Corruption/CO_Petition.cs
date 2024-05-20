using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public class CO_Petition
    {
        public Guid CO_PetitionId { get; set; }

        [Display(Name = "የአቤቱታ አቅራቢው ስም")]
        public string? ComplainantsName { get; set; }

        [Display(Name = "ፆታ")]
        public Gender Gender { get; set; }

        [Display(Name = "ብዛት")]
        public int Amount { get; set; }

        [Display(Name = "ትዕዛዝ የተሰጥው ክፍል")]
        public string? OrderedClass { get; set; }

        [Display(Name = "የትዕዛዙ ይዘት")]
        public string? OrderContent { get; set; }

        [Display(Name = "የደብዳቤ ቁጥር")]
        public string? LetterNo { get; set; }

        [Display(Name = "የደብዳቤ ቀን")]
        public DateTime LetterDate { get; set; }

        [Display(Name = "የሰራው ባለሙያ ስም")]
        public string? ExpertName { get; set; }

        [Display(Name = "ምርመራ")]
        public string? Remark { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
    }
}
