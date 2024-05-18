using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ExpertManagmentSystem.Enums;


namespace ExpertManagmentSystem.Models.Corruption
{
    public class CO_Petition
    {
        public Guid CO_PetitionId { get; set; }

        [Display(Name = "መ/ቁጥር")]
        public string? RecordNo { get; set; }

        [Display(Name = "የአቤቱታ አቅራቢው ስም")]
        public string? ComplainantsName { get; set; }

        [Display(Name = "የተፈፀመው ወንጀል")]
        public string? CrimeCommitted { get; set; }

        [Display(Name = "ቅሬታ የቀረበበት አካል")]
        public string? ComplaintBody { get; set; }

        [Display(Name = "የደብዳቤ ቁጥር")]
        public string? LetterNo { get; set; }

        [Display(Name = "የደብዳቤ ቀን")]
        public DateTime LetterDate { get; set; }

        [Display(Name = "ዞን/ክልል")]
        public string? Zone { get; set; }




        //[Display(Name = "የሰራው ባለሙያ ስም")]
        //public string? ExpertName { get; set; }

        //[Display(Name = "የተሰጠበት ቀን")]
        //public DateTime IssueDate { get; set; }

        //[Display(Name = "የተመለሰበት ቀን")]
        //public DateTime ReturnDate { get; set; }

        //[Display(Name = "የተሰጠ ውሳኔ")]
        //public Guid ProsecutorsDecisionId { get; set; }
        //[ForeignKey(nameof(ProsecutorsDecisionId))]
        //public virtual ProsecutorsDecision? ProsecutorsDecision { get; set; }

        //[Display(Name = "ብዛት")]
        //public int Amount { get; set; }

        //[Display(Name = "ትዕዛዝ የተሰጥው ክፍል")]
        //public string? OrderedClass { get; set; }

        //[Display(Name = "የትዕዛዙ ይዘት")]
        //public string? OrderContent { get; set; }

        //[Display(Name = "የደብዳቤ ቁጥር")]
        //public string? LetterNo { get; set; }

        //[Display(Name = "የደብዳቤ ቀን")]
        //public DateTime LetterDate { get; set; }

        

        //[Display(Name = "ምርመራ")]
        //public string? Remark { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }

        //public string? UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public virtual ICollection<CO_PetitionFollowUp>? CO_PetitionFollowUp { get; set; }
    }
}
