

using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.ViewModels
{
    [Keyless]
    public class SectorDepartmentViewModels
    {
        public Guid ReginalSectorId { get; set; }
        public string? ReginalSectorName { get; set; }

        public Guid ZonalSectorId { get; set; }
        public string? ZonalSectorName { get; set; }

        public Guid WoredaSectorsId { get; set; }
        public string? WoredaSectorsName { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public Guid DepartmentParentId { get; set; }
        public DepartmentCategory DepartmentCategory { get; set; }


        //[Display(Name = "ኢሜል")]
        //public string? Email { get; set; }
        //[DataType(DataType.Password)]
        //[Display(Name = "የይለፍ ቃል")]
        //public string? Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "የይለፍ ቃል ያረጋግጡ")]
        //[Compare("Password", ErrorMessage = "የይለፍ ቃል ለማረጋገጥ አልተዛመደም እባክዎን በትክክል ይሙሉ")]
        //public string? ConfirmPassword { get; set; }

        //[Required(ErrorMessage = "እባክዎን የተጠቃሚውን ሙሉ ስም ይፃፉ !")]
        //[Display(Name = "ሙሉ ስም")]
        //public string? FullName { get; set; }
        //public Guid UserParentId { get; set; }
        //public Guid UserDepartmentId { get; set; }

    }
}
