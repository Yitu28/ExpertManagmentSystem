using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Decided_Judicial_and_Prosecuter
    {


        public Guid Cr_Decided_Judicial_and_ProsecuterId { get; set; }
        [Display(Name = "")]
       
        public DateTime OpeningDate { get; set; }
        public int ProsocuterNo { get; set; }
        public int Court_No { get; set; }
        public string? Applicant { get; set; }
        public string? Respondant { get; set; }
        public string? CrimeType { get; set; }      
        public ProsecutorComment? ProsecutorComment { get; set; }
        public string? Other { get; set; }
        public string? WhoLawyeCommented { get; set; }
        public  HighCourtDecission HighCourtDecission { get; set; }
        public string? OtherCourtDecition { get; set; }
        public string? WhoJudgeCommentedOnDecision { get; set; }
        public int NumberOfFemaleAppellants { get; set; }
        public int NumberOfMaleAppellants { get; set; }
        public FileStatus FileStatus { get; set; }
        public FileEndResult FileEndResult { get; set; }
        public FederalBreakingRequest FederalBreakingRequest { get; set; }






        //Crime Types Relation Ship
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

        
    }
}
