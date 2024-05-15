using ExpertManagmentSystem.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class PerformanceChargeFollowUp : Audit
    {
        [Display(Name = "የተምራለት ባለሙያ")]
        public string? NameOfTheExpert { get; set; }

        [Display(Name = "ጉዳዩ የቀረበበት ፍ/ቤት")]
        public string? NameOfCourtCasePresented { get; set; }

        [Display(Name = "የቀጠሮ አይነት")]
        public string? ApointmentType { get; set; }

        [Display(Name = "ቀጠሮ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ApointmentDate { get; set; }

        [Display(Name = "ተወሰኖ ከሆነ")]
        public bool? HasDecissionMade { get; set; }

        [Display(Name = "ውሳኔ")]
        public TypeOfDecission? TypeOfDecission { get; set; }

        [Display(Name = "ውሳኔውን የሰጠው")]
        public string? DecidedBy { get; set; }

        [Display(Name = "ገቢ የሆነ ገንዘብ")]
        public decimal? MoneyGained { get; set; }

        [Display(Name = "ንብረት")]
        public string? ProperyClosed { get; set; }

        [Display(Name = "በልዩዩ ምክኛት")]
        public string? DiffrenetReasons { get; set; }

        public Guid? PerformanceChargeOpenningId { get; set; }
        [ForeignKey(nameof(PerformanceChargeOpenningId))]
        [ValidateNever]
        public PerformanceChargeOpenning PerformanceChargeOpenning { get; set; }
    }
}
