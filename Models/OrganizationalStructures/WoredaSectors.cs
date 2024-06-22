using ExpertManagmentSystem.Models.CivilCaseModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.OrganizationalStructures
{
    public class WoredaSectors
    {
        [Key]
        public Guid WoredaSectorsId { get; set; }
        [Display(Name = "የጽህፈት ቤት ስም")]
        public string WoredaSectorsName { get; set; }

        [Display(Name = "የመምሪያ ስም")]

        [ForeignKey("ZonalSectorsId")]
        public Guid ZonalSectorsId { get; set; }
        public ZonalSectors ZonalSectors { get; set; }


        public virtual ICollection<CCFreelServices>? CCFreelServices { get; set; }
        public virtual ICollection<CCdlt>? CCdlt { get; set; }
        public virtual ICollection<CCLegaladvices>? CCLegaladvices { get; set; }
        public virtual ICollection<CCPetition>? CCPetition { get; set; }



    }
}
