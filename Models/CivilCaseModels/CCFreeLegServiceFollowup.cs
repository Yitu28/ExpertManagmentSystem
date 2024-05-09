using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public enum DecisionStatus
    {
        [Display(Name = "አሸናፊ")]
        አሸናፊ,
        [Display(Name = "ተሸናፊ")]
        ተሸናፊ,
        [Display(Name = "ወደ ስር ቤት")]
        ወደ_ስር_ቤት,
        [Display(Name = "ስልጣን ላለው አካል")]
        ስልጣን_ላለው_አካል
    }
    public class CCFreeLegServiceFollowup
    {

        [Key]
        public Guid FreeLegServiceFollowupId { get; set; }

        [Required(ErrorMessage = "እባክዎን ለፍርድ ቤት የቀረበበት ቀን ይሙሉ !")]
        [Display(Name = "ፍርድ ቤት የቀረበበት ቀን")]
        public DateTime? Doc { get; set; }

        [Required(ErrorMessage = "እባክዎን የቀጠሮ ቀንን ይሙሉ !")]
        [Display(Name = "የቀጠሮ ቀን")]
        public DateTime? Doa { get; set; }


        [Required(ErrorMessage = "እባክዎን የቀጠሮ አይነት ይሙሉ !")]
        [Display(Name = "የቀጠሮ አይነት")]
        public string? AppointmentType { get; set; }



        [Display(Name = "ተወስኖ ከሆነ የተወሰነብት ቀን")]
        public DateTime? DoD { get; set; }

        [Display(Name = "የወሳኔ አይነት")]
        public DecisionStatus? DecisionStatus { get; set; }

        [Display(Name = "የወሳኔን የሰጠው ፍርድ ቤት")]
        public string? Decisionmadeby { get; set; }

        [ForeignKey("CCFreelServicesId")]
        public Guid CCFreelServicesId { get; set; }
        public CCFreelServices? CCFreelServices { get; set; }
    }
}
