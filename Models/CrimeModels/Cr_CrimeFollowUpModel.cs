using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_CrimeFollowUpModel
    {
        public Guid Cr_CrimeFollowUpModelId { get; set; }        
        public Cr_ProsecutorComment? Cr_ProsecutorComment { get; set; }
        public string? Other { get; set; }
        public string? WhoLawyeCommented { get; set; }
        public HighCourtDecission HighCourtDecission { get; set; }
        public string? OtherCourtDecition { get; set; }
        public string? WhoJudgeCommentedOnDecision { get; set; }
        public int NumberOfFemaleAppellants { get; set; }
        public int NumberOfMaleAppellants { get; set; }
        public FileStatus FileStatus { get; set; }
        public FileEndResult FileEndResult { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime FileIssuedDate { get; set; }
        public DateTime FileReturnedDate { get; set; }
        public FederalBreakingRequest FederalBreakingRequest { get; set; }


        public Guid Cr_JudicalAppealOpeningId { get; set; }
        [ForeignKey(nameof(Cr_JudicalAppealOpeningId))]
        public virtual Cr_JudicalAppealOpening? Cr_JudicalAppealOpening { get; set; }

    }
}
