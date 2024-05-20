using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    
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
        public TypeofDecision? DecisionStatus { get; set; }

        [Display(Name = "የወሳኔን የሰጠው ፍርድ ቤት")]
        public string? Decisionmadeby { get; set; }

        [ForeignKey("CCFreelServicesId")]
        public Guid CCFreelServicesId { get; set; }
        public CCFreelServices? CCFreelServices { get; set; }

        public Guid? FollupCreatedBy { get; set; }
        public Guid? FollupUpdatededBy { get; set; }
        public Guid? FollupDeletedBy { get; set; }

        public DateTime? FollupCreatedAt { get; set; }
        public DateTime? FollupEdittedAt { get; set; }
        public DateTime? FollupDeletedAt { get; set; }
    }
}
