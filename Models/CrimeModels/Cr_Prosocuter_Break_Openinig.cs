using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Prosocuter_Break_Openinig
    {
        public Guid Cr_Prosocuter_Break_OpeninigId { get; set; }
        [NotMapped]
        public DateTime Openinig_Date { get; set; }
        public int Prosocuter_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }
        public string Crime_Type { get; set; }
        public DateTime Date_of_Appointment { get; set; }
        public string Zone { get; set; }
        public string Worked_Proffesional { get; set; }
        public DateTime Date_of_Administration { get; set; }
        [NotMapped]
        public TimeOnly Time { get; set; }
        public DateTime Date_of_returen { get; set; }
        [NotMapped]
        public TimeOnly Returen_Time { get; set; }
        public string Prosocuter_Comment { get; set; }

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

    }
}
