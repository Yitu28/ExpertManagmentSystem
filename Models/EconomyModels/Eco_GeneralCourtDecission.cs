using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_GeneralCourtDecission
    {
       public Guid Eco_GeneralCourtDecissionId { get; set; }
        [Display(Name = "የጠቅላይ ፍርድ ቤት ውሳኔ አይነቶች ")]
        public string GeneralCourtDecissionName {  get; set; }
        [Display(Name = "ዲፓርትመንት  ")]
        public Department Department { get; set; }

    }
}
