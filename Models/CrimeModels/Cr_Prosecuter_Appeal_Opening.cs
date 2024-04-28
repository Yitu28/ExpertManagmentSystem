using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Prosecuter_Appeal_Opening
    {
        public Guid Cr_Prosecuter_Appeal_OpeningId { get; set; }
        [NotMapped]
        public DateOnly Opening_Date { get; set; }
        public int Prosecuter_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string Crime_Type { get; set; }
        [NotMapped]
        public DateOnly Date_of_Appientment { get; set; }
        public string Zone { get; set; }
        public string Worked_Proffissional { get; set; }
        [NotMapped]
        public DateOnly Date_of_Administration { get; set; }
        [NotMapped]
        public TimeOnly Time { get; set; }
        [NotMapped]
        public DateOnly Date_of_Returen { get; set; }
        [NotMapped]
        public TimeOnly Returen_Time { get; set; }
        public string Prosecuter_Comments { get; set; }

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
