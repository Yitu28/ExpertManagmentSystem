using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_Crime42A
    {
        [Key]
        public Guid Eco_Crime42AId { get; set; }
        [Display(Name = "መ/ቁ")]
        public string RecordNo { get; set; }
        [Display(Name = "የፖሊስ መ/ቁ")]
        public string PoliceRecordNo { get; set; }
        [Display(Name = "የተከሳሽ ስም")]
        public string DefendenNamet { get; set; }
        [Display(Name = "የተፈጸመው ወንጀል")]
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }
        [Display(Name = "ዞን")]
        public string Zone { get; set; }
        [Display(Name = "ለዓ/ህግ የተሰጠበት ቀን")]
        public DateTime ProsecutorAdmissionDate { get; set; }
        [Display(Name = "ከዓ/ህግ የተመለሰበት ቀን")]
        public DateTime ProsecutorReturnedDate { get; set; }
        [Display(Name = "የምርመራ መዝገብ ወደ ክልል እንዲላክ ትዛዝ የተመለሰበት ቀን")]
        public DateTime AdmisstionOrderDate { get; set; }
        [Display(Name = "አግባብ ሆኖ በመገኘቱ የጸና")]
        public string Persistant {  get; set; }
        [Display(Name = "ክስ እንዲመሰረት ለበታች ዓ/ህግ ትዛዝ የተሰጠበት")]
        public string Abrogated {  get; set; }
        [Display(Name = "ነጥቦች እንዲማሉ ትዛዘ የተሰጠበት")]
        public string OrderedIssue { get; set; }
        [Display(Name = "በመመርመር ላይ ያለ")]
        public string OnAdmission {  get; set; }
        [Display(Name = "ትዛዝ የተሰጠበት መዝገብ ለበላይ ዓ/ህግ ያልተላከ")]
        public string NonOrderedIssue {  get; set; }
        [Display(Name = "ዲፓርትመንት")]
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
