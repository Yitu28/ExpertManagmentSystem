using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.DocumentModel
{
    public class Doc_CivilAssosation
    {
        [Key]
        public string CivilLicenseNo { get; set; }
        [Display(Name = "የድርጅቱ ስም ")]
        public string AssosationName { get; set; }
        [Display(Name = "አድራሻ ")]
        public string Address {  get; set; }
        [Display(Name = "የታደሰበት ቀን ")]
        public DateTime licensedDate{ get; set; }
        [Display(Name = "የሚታደስበት ቀን")]
        public DateTime licensedUpdateDate { get; set; }
        [Display(Name = "የአገልግሎት ክፍያ ")]
        public double ServiceFee { get; set; }
        [Display(Name = "ደረሰኝ ቁጥር ")]
        public int RecietNo { get; set; }
        [Display(Name = "ይማህበሩ አላማ")]
        public string? AssosationAim { get; set; }
        [Display(Name = "የድርጅት መሪ ስም ")]
        public string? ManagerName { get; set; }
        [Display(Name = "ስልክ")]
        public string? Phone {  get; set; }
        [Display(Name = "የሰራው ባለሙያ ")]
        public string? Expert {  get; set; }
        [Display(Name = "የድርጅቱ መስራቾች ")]
        public string? AssosationMember { get; set; }
        [Display(Name = "ጾታ")]
        public Gender gender { get; set; }
        [Display(Name = "እድሜ ")]
        public int Age {  get; set; }
        [Display(Name = "የአካል ጉዳት ሁኔታ")]
        public DisablityStatus DisablityStatus { get; set;}

        [Display(Name = "ዲፓርትመንት  ")]
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
    }
}
