using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class PerformanceChargeOpenning : Audit
    {
        [Display(Name = "የዐ/ህግ ቁጥር")]
        public string? ProsecutorsSRecordNumber { get; set; }

        [Display(Name = "የፍ/ቤት ህግ ቁጥር")]
        public string? CourtRecordNumber { get; set; }

        [Display(Name = "የአፈጻጸም ከሳሽ")]
        public string? Plaintiff { get; set; }

        [Display(Name = "የአፈጻጸም ተከሳሽ")]
        public string? Accused { get; set; }

        [Display(Name = "የተገልጋይ አይነት")]
        public CustomerType CustomerType { get; set; }

        [Display(Name = "የተከፈተበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? OpenningDate { get; set; }
       
        [Display(Name = "በብር")]
        public decimal? AmountInBirr { get; set; }

        [Display(Name = "በካሬ")]
        public decimal? AmountPerSquerMetter { get; set; }

        [Display(Name = "ዞን")]
        public string? AddressZone { get; set; }

        [Display(Name = "ወረዳ")]
        public string? AddressWoreda { get; set; }
        [Display(Name = "የአፈጻጸም ክስ አይነት")]
        public TypeOfPerformanceCharge TypeOfPerformanceCharge { get; set; }

        [Display(Name = "የተምራለት ባለሙያ")]
        public string? NameOfTheExpert { get; set; }

        [Display(Name = "የስራ ክፍል")]
        public Guid? SectorDepartmentId { get; set; }
        public SectrorsDepartment? SectorDepartment { get; set; }

        [Display(Name = "የፋይል ሁኔታ")]
        public PerformanceChargeStatus? PerformanceChargeStatus { get; set; }

        [Display(Name = "የጉዳዩ አይነት")]
        public CaseType? CaseType { get; set; }

        [Display(Name = "የውሳኔ አይነት")]
        public TypeOfDecission? TypeofDecission { get; set; }

        [Display(Name = "ጉዳዩ የቀረበበት ፍ/ቤት")]
        public string? NameOfCourtCasePresented { get; set; }
        public virtual ICollection<PerformanceChargeFollowUp> PerformanceChargeFollowUp { get; set; }
    }
}
