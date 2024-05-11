﻿using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class PerformanceChargeOpenning : Audit
    {
        [Required]
        [Display(Name = "የዐ/ግ ቁጥር")]
        public string ProsecutorsSRecordNumber { get; set; }

        [Required]
        [Display(Name = "የፍ/ቤት ህግ ቁጥር")]
        public string CourtRecordNumber { get; set; }

        [Required]
        [Display(Name = "የአፈጻጸም ከሳሽ")]
        public string Plaintiff { get; set; }

        [Required]
        [Display(Name = "የአፈጻጸም ተከሳሽ")]
        public string Accused { get; set; }
        public int MyProperty { get; set; }
        [Required]
        [Display(Name = "የተከፈተበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OpenningDate { get; set; }

        [Required]
        [Display(Name = "የጉዳዩ አይነት")]
        public string TypeOfIssue { get; set; }

        [Required]
        [Display(Name = "የተገልጋይ አይነት")]
        public string TypeOfCustomer { get; set; }

        [Required]
        [Display(Name = "በብር")]
        public Decimal AmountPerBirr { get; set; }

        [Required]
        [Display(Name = "በካሬ")]
        public decimal AmountPerSquerMetter { get; set; }

        //[Required]
        //[Display(Name = "የሚገበት ቦታ")]
        //public string CaseOwnerOrganization { get; set; }

        [Required]
        [Display(Name = "ዞን")]
        public string AddressZone { get; set; }

        [Required]
        [Display(Name = "ወረዳ")]
        public string AddressWoreda { get; set; }

        [Required]
        [Display(Name = "የሰራው ባለሙያ")]
        public string NameOfTheExpert { get; set; }

        [Required]
        [Display(Name = "የተመራበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateDirected { get; set; }

        [Required]
        [Display(Name = "ተሰርቶ የተመለሰበት ቀን")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime CompletionDate { get; set; }

        [Required]
        [Display(Name = "የወሰደበት ጊዜ")]
        public string TimeTakenToComplete { get; set; }

        [Required]
        [Display(Name = "በዐ/ህግ የተሰጠው ውሳኔ")]
        public string ProsecutorDecission { get; set; }
        public CivilCaseCategory CivilCaseCategory { get; set; }
        public virtual ICollection<DirectChargeFollowUp> DirectChargeFollowUps { get; set; }
    }
}
