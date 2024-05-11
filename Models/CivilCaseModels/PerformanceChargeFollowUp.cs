using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class PerformanceChargeFollowUp : Audit
    {
        [Display(Name = "የተምራለት ባለሙያ")]
        public string NameOfTheExpert { get; set; }

        [Display(Name = "ጉዳዩ የቀረበበት ፍ/ቤት")]
        public string NameOfCourtCasePresented { get; set; }

        [Display(Name = "የቀጠሮ አይነት")]
        public string ApointmentType { get; set; }

        [Display(Name = "ቀጠሮ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ApointmentDate { get; set; }

        [Display(Name = "ለፍ/ቤት የተመራበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateDirectedToCourt { get; set; }

        [Display(Name = "ተሰርቶ የተመለሰበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CompletionDate { get; set; }

        [Display(Name = "የወሰደበት ጊዜ")]
        public string TimeTakenToComplete { get; set; }

        [Display(Name = "በዐ/ህግ የተሰጠው ውሳኔ")]
        public string ProsecutorDecission { get; set; }

        public Guid PerformanceChargeOpenningId { get; set; }
        [ForeignKey(nameof(PerformanceChargeOpenningId))]
        [ValidateNever]
        public PerformanceChargeOpenning PerformanceChargeOpenning { get; set; }
    }
}
