using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class DirectChargeFollowUp : Audit
    {
        [Required]
        [Display(Name = "ጉዳዩ የቀረበበት ፍ/ቤት የተጻፈለት ተቋም")]
        public string IssuedCourtWrittenForOrganization { get; set; }

        [Required]
        [Display(Name = "ለፍ/ቤት የቀረበበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateSubmittedToCourt { get; set; } 
        
        [Required]
        [Display(Name = "የቀጠሮ ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateApointmented { get; set; }

        [Required]
        [Display(Name = "የቀጠሮ አይነት")]        
        public string AppointmentType { get;}

        [Required]
        [Display(Name = "የተወሰነበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DecissionDate { get; set; }


        [Required]
        [Display(Name = "የውሳኔው አይነት")]
        public string TypeOfDecission { get; }
        
        [Required]
        [Display(Name = "ውሳኔውን የሰጠው ፍ/ቤት")]
        public string CourtDecided { get; }

        public Guid DirectChargeOppeningId { get; set; }
        [ForeignKey(nameof(DirectChargeOppeningId))]
        [ValidateNever]
        public DirectChargeOpenning? DirectChargeOpenning { get; set; }
    }
}
