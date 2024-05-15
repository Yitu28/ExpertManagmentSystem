using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.ViewModels.CrimeViewModels
{
    public class AllCrimeAppealOpninigAndFollowUpViewModel
    {
        
        public int Cr_CrimeFollowUpModelId { get; set; }
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
        public DateTime OpeninigDate { get; set; }
        public string? ProcsecuterNo { get; set; }
        public string CourtNo { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string? Zone { get; set; }
        public AppealType? AppealType { get; set; }


        //Crime Types Relation Ship
        public Guid Cr_Crime_TypeId { get; set; }       
       public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; } 
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }


    }
}
