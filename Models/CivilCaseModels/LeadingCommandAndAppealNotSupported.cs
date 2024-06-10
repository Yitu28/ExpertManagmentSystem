using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class LeadingCommandAndAppealNotSupported : Audit
    {
        [Display(Name = "የዐ/ግ ቁጥር")]
        public string? ProsecutorRecordNumber { get; set; }

        [Display(Name = "የፍ/ቤት ህግ ቁጥር")]
        public string? CourtRecordNumber { get; set; }

        [Display(Name = "ከሳሽ")]
        public string? Plaintiff { get; set; }

        [Display(Name = "ተከሳሽ")]
        public string? Accused { get; set; }

        [Display(Name = "የተከፈተበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? OpenningDate { get; set; }

        [Display(Name = "የጉዳዩ አይነት")]
        public string? TypeOfIssue { get; set; }
        [Display(Name = "የጉዳዩ አይነት")]
        public LeadingCommandAndUnSupportAppeal? LeadingCommandAndUnSupportAppeal { get; set; }

        [Display(Name = "በብር")]
        public decimal? AmountPerBirr { get; set; }

        [Display(Name = "በካሬ")]
        public decimal? AmountPerSquerMetter { get; set; }
        [Display(Name = "ዐ/ህ ድጋፍ የሚሰጠው አካል")]
        public string? ProsecutorSupportTo { get; set; }

        [Display(Name = "ዞን")]
        public string? AddressZone { get; set; }

        [Display(Name = "ወረዳ")]
        public string? AddressWoreda { get; set; }

        [Display(Name = "የሰራው ባለሙያ")]
        public string? NameOfTheExpert { get; set; }

        //[Display(Name = "የተመራበት ቀን")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //public DateTime? DateDirected { get; set; }

        [Display(Name = "ተሰርቶ የተመለሰበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CompletionDate { get; set; }

        [Display(Name = "የወሰደበት ጊዜ")]
        public string TimeTakenToComplete { get; set; }

        [Display(Name = "በዐ/ህግ የተሰጠው ውሳኔ")]
        public string? ProsecutorDecission { get; set; }
        [Display(Name = "የሰነድ ምርመራ አይነት")]
        public ContractInvestigationDocumentType? ContractInvestigationDocumentType { get; set; }
        [Display(Name = "የሰነድ ሁኔታ")]
        public ContractInvestigationDocumentStatus? ContractInvestigationDocumentStatus { get; set; }
        public Guid? SectorDepartmentId { get; set; }
        public SectrorsDepartment? SectorDepartment { get; set; }
    }
}
