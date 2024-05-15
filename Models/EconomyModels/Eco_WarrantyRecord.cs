using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_WarrantyRecord
    {
        public Guid Eco_WarrantyRecordId { get; set; }
        public DateTime OpeningDate {  get; set; }
        public int Prosocuters_No { get; set;}
        public int Police_No { get; set;}
        public int Court_No { get; set;}
        public string DefendentName { get; set;}
        public string Region { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public String ProsecutorComment { get; set; }
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]

        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

        //public PetWarranty PetWar { get; set; }


    }
}
