using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class AllDepartmentWarrantyModel
    {
        public Guid AllDepartmentWarrantyModelId { get; set; }
        public DateTime OpeninigDate { get; set; }
        public string? ProcsecuterNo { get; set; }
        public string? PoliceRecordNo { get; set; }
        public string CourtNo { get; set; }
        public string ApplicantName { get; set; }
        public Gender Gender { get; set; }
        public string? WhereItCameFrom { get; set; }
        public DateTime DateOfDirectedToProsecuter { get; set; }
        public DateTime DateOfDoneAndReturned { get; set; }
        public Cr_ProsecutorComment Cr_ProsecutorComment { get; set; }

        //Make a relationship
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
