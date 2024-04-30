using ExpertManagmentSystem.OrganizationalStructures;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Crime_Type
    {
        public Guid Cr_Crime_TypeId { get; set; }
        public string CrimeTypeName { get; set; }

        public virtual ICollection<Cr_Decided_Judicial_and_Prosecuter>? Cr_Decided_Judicial_and_Prosecuters { get; set; }
        public virtual ICollection<Cr_JudicalAppealDirectCharege>? Cr_JudicalAppealDirectChareges { get; set; }

  



    }
}
