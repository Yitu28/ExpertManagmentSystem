using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_JudicalAppealOpening
    {
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
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }




    }
}
