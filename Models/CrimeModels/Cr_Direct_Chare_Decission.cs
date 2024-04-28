using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Direct_Chare_Decission
    {
        public Guid Cr_Direct_Chare_DecissionId { get; set; }
        [NotMapped]
        public DateOnly OpeningDate { get; set; }
        public int PoliceRecordNo { get; set; }
        public int ProsecuterRecordNo { get; set; }
        public int CourtRecordNo { get; set; }
        public string? DefendantName { get; set; }
        public string? Sex { get; set; }
        public string? Age { get; set; }
        public string TypeOfCrime { get; set; }
        public string Zone { get; set; }
        public string Worda { get; set; }
        public string Kebele { get; set; }
        public string AdministrationExper { get; set; }
        public string YemisikirAmount { get; set; }
        public string Egzibit { get; set; }
        public string ProsecuterDesition { get; set; }

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }


    }
}
