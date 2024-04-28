using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Judical_Appeal_Opening
    {
        public Guid Cr_Judical_Appeal_OpeningId { get; set; }
        public DateTime Openinig_data { get; set; }
        public int Prosocuters_No { get; set; }
        public int Court_No { get; set; }
        public string Applicant { get; set; }
        public string Respondent { get; set; }
        public string CrimeType { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string Zone { get; set; }
        public string Worked_Profesional { get; set; }
        public DateTime Date_of_Administration { get; set; }
        public DateTime Time { get; set; }
        public DateTime Date_of_Returen { get; set; }
        public DateTime Returen { get; set; }
        public string Prosocuter_Comments { get; set; }

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }





    }
}
