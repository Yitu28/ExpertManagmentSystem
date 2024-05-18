using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using ExpertManagmentSystem.Models.Corruption;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Crime_Type
    {
        public Guid Cr_Crime_TypeId { get; set; }
        public string? CrimeTypeName { get; set; }
        public CrimeDepartment CrimeDepartment { get; set; }

        public virtual ICollection<Cr_Decided_Judicial_and_Prosecuter>? Cr_Decided_Judicial_and_Prosecuters { get; set; }
        public virtual ICollection<Cr_JudicalAppealDirectCharege>? Cr_JudicalAppealDirectChareges { get; set; }

        //public virtual ICollection<CO_JudicialAppealOrBreak>? CO_JudicialAppealOrBreak { get; set; }
        //public virtual ICollection<CO_RegionalBreakAppeal>? CO_RegionalBreakAppeal { get; set; }
        //public virtual ICollection<CO_CorruptionCharge>? CO_CorruptionCharge { get; set; }





    }
}
