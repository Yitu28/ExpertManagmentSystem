using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Direct_Charge_Opening
    {
        public Guid Cr_Direct_Charge_OpeningId { get; set; }
        public DateTime Opening_Date { get; set; }
        public int Police_Record_No { get; set; }
        public int Prosocuter_Record_No { get; set; }
        public int Court_record_No { get; set; }
        public string Defendant_Name { get; set; }
        public string Defendant_Sex { get; set; }
        public string Type_of_Crime { get; set; }
        public string zone { get; set; }
        public string Worda { get; set; }
        public string Kebele { get; set; }
        public string Addmision_Expert { get; set; }
        public string Expert_Signature { get; set; }
        [NotMapped]
        public DateOnly Date_Of_Administration { get; set; }
        [NotMapped]
        public TimeOnly Time_Of_Administration { get; set; }

        public DateTime Date_Of_Returen_and_Mode { get; set; }
        [NotMapped]
        public TimeOnly Time_Of_Returen_and_Mode { get; set; }
        public string Comments { get; set; }
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }




    }
}
