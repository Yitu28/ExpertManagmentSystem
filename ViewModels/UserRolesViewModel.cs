using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Policy;
using ExpertManagmentSystem.OrganizationalStructures;

namespace ExpertManagmentSystem.ViewModels
{

    public class UserRolesViewModel
    {

        [Required(ErrorMessage = "እባክዎን የተጠቃሚውን ሙሉ ስም ይፃፉ !")]
        [Display(Name = "ሙሉ ስም")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "እባክዎን የኢሜል አድራሻ ይሙሉ !")]
        [EmailAddress(ErrorMessage = "እባክዎን የኢሜል መስፈርትን መሰረት አድርገው ኢሜል ይሙሉ !")]
        [Display(Name = "ኢሜል")]
        public string? Email { get; set; }

        public string? UserName { get; set; }

        public string UserId { get; set; }

        public Guid UserParentId { get; set; }

        public Guid UserDepartmentId { get; set; }

        public DepartmentCategory DepartmentCategory { get; set; }

        [Required(ErrorMessage = "እባክዎን የይለፍ ቃልዎን ይሙሉ !")]
        [StringLength(100, ErrorMessage = "የይለፍ ቃል ሲሞሉ {0} ቢያንስ {2} እና ቢበዛ {1} አሃዝ ያለው መሆን አልበት ", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "የይለፍ ቃል")]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "የይለፍ ቃል ያረጋግጡ")]
        [Compare("Password", ErrorMessage = "የይለፍ ቃል ለማረጋገጥ አልተዛመደም እባክዎን በትክክል ይሙሉ")]
        public string? ConfirmPassword { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
