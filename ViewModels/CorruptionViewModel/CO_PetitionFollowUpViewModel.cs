using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.Corruption;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.ViewModels.CorruptionViewModel
{
    //public enum PetitionDecision
    //{
    //    ውሳኔ_ያገኘ, ትእዛዝ_የተሰጠበት, በቀጠሮ_ላይ_ያለ
    //}
    //public enum ComeanEnd
    //{
    //    ያገኘ, ያላገኘ
    //}
    public class CO_PetitionFollowUpViewModel
    {
        public Guid CO_PetitionFollowUpId { get; set; }
        public Guid CO_PetitionId { get; set; }

        //[Display(Name = "መ/ቁጥር")]
        //public string? RecordNo { get; set; }

        //[Display(Name = "የአቤቱታ አቅራቢው ስም")]
        //public string? ComplainantsName { get; set; }

        //[Display(Name = "የተፈፀመው ወንጀል")]
        //public string? CrimeCommitted { get; set; }

        //[Display(Name = "ቅሬታ የቀረበበት አካል")]
        //public string? ComplaintBody { get; set; }

        //[Display(Name = "የደብዳቤ ቁጥር")]
        //public string? LetterNo { get; set; }

        //[Display(Name = "የደብዳቤ ቀን")]
        //public DateTime LetterDate { get; set; }

        //[Display(Name = "ዞን/ክልል")]
        //public string? Zone { get; set; }




        [Display(Name = "የሰራው ባለሙያ ስም")]
        public string? ExpertName { get; set; }

        [Display(Name = "የተሰጠበት ቀን")]
        public DateTime IssueDate { get; set; }

        [Display(Name = "የተመለሰበት ቀን")]
        public DateTime ReturnDate { get; set; }


        [Display(Name = "የተሰጠ ውሳኔ")]
        public PetitionDecision PetitionDecision { get; set; }

        [Display(Name = "ፍፃሜ ያገኘ")]
        public ComeanEnd ComeanEnd { get; set; }
        
        public Guid SectrorsDepartmentId { get; set; }
        

        public virtual CO_Petition CO_Petition { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
