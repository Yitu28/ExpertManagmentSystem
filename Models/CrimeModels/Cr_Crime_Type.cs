using ExpertManagmentSystem.OrganizationalStructures;

namespace ExpertManagmentSystem.Models.CrimeModels
{
    public class Cr_Crime_Type
    {
        public Guid Cr_Crime_TypeId { get; set; }
        public string CrimeTypeName { get; set; }
        public virtual ICollection<Cr_Decided_Judical_Break>? Cr_Decided_Judical_Break { get; set; }
        public virtual ICollection<Cr_Decide_Judicial_Appeal>? Cr_Decide_Judicial_Appeal { get; set; }
        public virtual ICollection<Cr_Decided_Prosecuter_Appeal>? Cr_Decided_Prosecuter_Appeal { get; set; }
        public virtual ICollection<Cr_Decided_Prosecuter_Break>? Cr_Decided_Prosecuter_Break { get; set; }
        public virtual ICollection<Cr_Direct_Chare_Decission>? Cr_Direct_Chare_Decission { get; set; }
        public virtual ICollection<Cr_Direct_Charge_Opening>? Cr_Direct_Charge_Opening { get; set; }
        public virtual ICollection<Cr_Judical_Appeal_Opening>? Cr_Judical_Appeal_Opening { get; set; }
        public virtual ICollection<Cr_Judical_Break_Opening>? Cr_Judical_Break_Opening { get; set; }
        public virtual ICollection<Cr_Prosecuter_Appeal_Opening>? Cr_Prosecuter_Appeal_Opening { get; set; }
        public virtual ICollection<Cr_Prosocuter_Break_Openinig>? Cr_Prosocuter_Break_Openinig { get; set; }
  



    }
}
