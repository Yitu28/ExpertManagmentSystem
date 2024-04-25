using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.OrganizationalStructures
{
    public class ZonalSectors
    {
        [Key]
        public Guid ZonalSectorId { get; set; }

        [Display(Name = "የመምሪያ ስም")]
        public string? ZonalSectorName { get; set; }

        [Display(Name = "የቢሮ ስም")]

        [ForeignKey("ReginalSectorId")]
        public Guid ReginalSectorId { get; set; }
        public ReginalSector ReginalSector { get; set; }

        // public virtual ReginalSector? ReginalSector{ get; set; }

        //public virtual ICollection<WoredaSectors> WoredaSectors { get; set; }


    }
}
