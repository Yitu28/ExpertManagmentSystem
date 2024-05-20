using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.Corruption;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.ViewModels.CorruptionViewModel
{
    public class CO_JudicialAppealOrBreakViewModel
    {

        public Guid CO_JudicialAppealOrBreakDecisionId { get; set; }

        public Guid CO_JudicialAppealOrBreakId { get; set; }

        [Display(Name = "የጠ/ፍ/ቤት ውሳኔ")]
        public HighCourtDecission CourtDecision { get; set; }

        [Display(Name = "አስተያየት የሰጠው ባለሙያ")]
        public string? ExpertOpinion { get; set; }
        [Display(Name = "ልዩልዩ")]
        public string? Various { get; set; }
        [Display(Name = "አዲስ/ነባር")]
        public FileStatus NewExisting { get; set; }

        [Display(Name = "አሸናፊ/ተሸናፊ")]
        public FileEndResult WinnerLoser { get; set; }

        [Display(Name = "ለሰበር/ ለፌደራል የተጠየቀ")]
        public FederalBreakingRequest FederalRequested { get; set; }


        public Guid SectrorsDepartmentId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public virtual CO_JudicialAppealOrBreak? CO_JudicialAppealOrBreak { get; set; }



    }
}
