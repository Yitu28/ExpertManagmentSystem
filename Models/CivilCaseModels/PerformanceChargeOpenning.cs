using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class PerformanceChargeOpenning : Audit
    {
        [Display(Name = "የዐ/ግ ቁጥር")]
        public string ProsecutorsSRecordNumber { get; set; }

        [Display(Name = "የፍ/ቤት ህግ ቁጥር")]
        public string CourtRecordNumber { get; set; }

        [Display(Name = "የአፈጻጸም ከሳሽ")]
        public string Plaintiff { get; set; }

        [Display(Name = "የአፈጻጸም ተከሳሽ")]
        public string Accused { get; set; }

        [Display(Name = "የተገልጋይ አይነት")]
        public CustomerType CustomerType { get; set; }

        [Display(Name = "የተከፈተበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OpenningDate { get; set; }
       
        [Display(Name = "በብር")]
        public decimal? AmountInBirr { get; set; }

        [Display(Name = "በካሬ")]
        public decimal? AmountPerSquerMetter { get; set; }

        //[Display(Name = "የሚገበት ቦታ")]
        //public string CaseOwnerOrganization { get; set; }

        [Display(Name = "ዞን")]
        public string AddressZone { get; set; }

        [Display(Name = "ወረዳ")]
        public string AddressWoreda { get; set; }
        public TypeOfPerformanceCgarge TypeOfPerformanceCgarge { get; set; }
        public virtual ICollection<PerformanceChargeFollowUp> PerformanceChargeFollowUp { get; set; }
    }
}
