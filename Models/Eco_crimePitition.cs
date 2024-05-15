using ExpertManagmentSystem.Models.CrimeModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ExpertManagmentSystem.OrganizationalStructures;

namespace ExpertManagmentSystem.Models
{
    public class Eco_crimePitition
    {
        public Guid Eco_crimePititionId { get; set; }
        [Display(Name = "የአመልካች ስም")]
        public string ApplicantName { get; set; }

        [Display(Name = "የተፈጸመው ወንጀል")]
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }
        [Display(Name = "ቅሬታ የቀረበበት አካል ")]
        public string PititionPresentBody { get; set; }
        [Display(Name = "ዐ/ህግ ")]
        public string Prosecutor {  get; set; }
        [Display(Name = "የተመራለት ቀን")]
        public DateTime IssuedDate { get; set; }
        [Display(Name = "የተመለሰበት ቀን ")]
        public DateTime ReturedDate { get; set; }
        [Display(Name = "የተሰጠ ውሳኔ")]
        public string Decission { get; set; }
        [Display(Name = "የተሰጠው ውሳኔ ትዛዘ")]
        public string DecissionOrder { get; set; }
        [Display(Name = "የተሰጠው ውሳኔ ፍጸሜ ያገኘ ")]
        public string DecissionStatus { get; set; }
        [Display(Name = "ዞን/ክልል")]
        public string Address { get; set; }
        [Display(Name = "ዲፓርትመንት")]
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
    }
}
