using ExpertManagmentSystem.Models.CivilCaseModels;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.OrganizationalStructures
{
    public enum DepartmentCategory
    {
        ቢሮ,
        መምሪያ,
        ጽህፈት_ቤት
    }
    public class SectrorsDepartment
    {
        [Key]
        [Required]
        public Guid SectrorsDepartmentId { get; set; }

        [Display(Name = "የስራ ክፍል")]
        public string? DepartmentName{ get; set; }
        public Guid DepartmentParentId { get; set; }
        public DepartmentCategory DepartmentCategory { get; set; }

        public virtual ICollection<CCFreeLegalService>? CCFreeLegalService { get; set; }
    }
  

    
}
