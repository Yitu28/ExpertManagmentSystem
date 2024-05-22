using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class ContractInvestigation : Audit
    {
        [Display(Name = "የዐ/ግ/መ ቁጥር")]
        public string? ProsecutorIdentityNumber { get; set; }

        [Display(Name = "ውል ሰጭ")]
        public string? Contractor { get; set; }

        [Display(Name = "ውል ተቀባይ")]
        public string? ContractReciepient { get; set; }

        [Display(Name = "የተከፈተበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? OpenningDate { get; set; }

        [Display(Name = "የውል አይነት")]
        public string? TypeOfContract { get; set; }

        [Display(Name = "የገንዘብ መጠን")]
        public decimal? AmountPerMoney { get; set; }

        [Display(Name = "እንዲመረመርለት የጠየቀው ተቋም")]
        public string? TheInstitutionRequestedForExamination { get; set; }

        [Display(Name = "የተመራለት ባለሙያ")]
        public string? NameOfTheExpert { get; set; }

        [Display(Name = "ተሰርቶ የተመለሰበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? CompletionDate { get; set; }

        [Display(Name = "የወሰደበት ጊዜ")]
        public string TimeTakenToComplete { get; set; }
    }
}
