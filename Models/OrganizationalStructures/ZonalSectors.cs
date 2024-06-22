using ExpertManagmentSystem.Models.CivilCaseModels;
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

        public virtual ICollection<CCFreelServices>? CCFreelServices { get; set; }
        public virtual ICollection<CCdlt>? CCdlt { get; set; }
        public virtual ICollection<CCLegaladvices>? CCLegaladvices { get; set; }
        public virtual ICollection<CCPetition>? CCPetition { get; set; }


    }
}
