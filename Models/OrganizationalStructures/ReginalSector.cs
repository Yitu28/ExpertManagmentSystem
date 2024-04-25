

using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.OrganizationalStructures
{
    public class ReginalSector
    {
        [Key]
        public Guid ReginalSectorId { get; set; }
        [Display(Name ="የቢሮ ስም")]
        public string ReginalSectorName { get; set; }
        public virtual ICollection<ZonalSectors>? ZonalSectors { get; set; }



    }
}
