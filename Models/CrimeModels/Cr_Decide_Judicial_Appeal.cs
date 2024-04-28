using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Decide_Judicial_Appeal
    {
        public Guid Cr_Decide_Judicial_AppealId { get; set; }
        public DateTime Opening_Date { get; set; }
        public int Prosocuter_No { get; set; }
        public int CourtNo { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string CrimeType { get; set; }
        public string CourtDesitions { get; set; }
        public string ProsocuterFocus { get; set; }
        public string Other { get; set; }
        public string ExpertsToProsecuter { get; set; }
        public string ExpertsToCourt { get; set; }
        public int AmountOfAppealMale { get; set; }
        public int AmountOfAppealFemale { get; set; }
        public string EventStatus { get; set; }
        public string ToFederal { get; set; }

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }





    }
}
