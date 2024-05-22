using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.DocumentModel
{
    public class Doc_WarrantyDocument
    {
        public Guid Doc_WarrantyDocumentId { get; set; }

        [Display(Name = "የአገልግሎት/የውል አይነት ")]
        [ForeignKey("Doc_serviceTypeId")]
        public Guid Doc_serviceTypeId { get; set; }
        public Doc_serviceType? Doc_serviceType { get; set; }
        [Display(Name = "የተገልጋይ ስም ")]
        public String? ServerName { get; set; }
        [Display(Name = "የተገልጋይ ጾታ ")]
        public Gender sex {  get; set; }
        [Display(Name = "የተገልጋይ እድሜ ")]
        public int serverAge { get; set; }
        [Display(Name = "የቴምብር ክፍያ ")]
        public double TemperFee { get; set; }
        [Display(Name = "የአገልግሎት  ክፍያ ")]
        public double ServiceFee { get; set;}
        [Display(Name = "አገልግሎት የሰጠው ባለሙያ ")]
        public string? Expert {  get; set; }
        [Display(Name = "የተከናወነበት ቀን ")]
        public DateTime workedDate { get; set; }
        [Display(Name = "ዲፓርትመንት  ")]
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
       

    }
}
