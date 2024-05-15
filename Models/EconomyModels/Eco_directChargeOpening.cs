using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_directChargeOpening
    {
        public CrimeEconomy Ecocrime { get; set; }
        [Key]
        public Guid Eco_directChargeOpeningId { get; set; }
        [Display(Name = "መዝገብ የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }
         [Display(Name = "የፖ/መ/ቁ")]
        public string? PoliceNo { get; set; }
       [Display(Name = "የዐ/መ/ቁ")]
        public int ProsocuterNo { get; set; }
         [Display(Name = "የፍ/መ/ቁ ")]
        public string? CourtNo { get; set; }
       [Display(Name = "የተከሳሽ ስም")]
        public string? DefendantName { get; set; }
        [Display(Name = "የተከሳሽ ጾታ")]
        public string? DefendantGender { get; set; }
        
        [Display(Name = "ዞን")]
        public string? Zone { get; set; }
         [Display(Name = "ወረዳ")]
        public string? Woreda { get; set; }
        [Display(Name = "የተመራለት ባለሙያ")]
        public string? AdmissionExpert { get; set; }
       [Display(Name = "የተመራበት ቀን")]
        public DateTime AdmissitionDate { get; set; }
        [Display(Name = "የተመለሰበተ ቀን ")]
        public DateTime ReturnedDate { get; set; }
        [Display(Name = "የተሰጠ አስተያየት ")]
        public string? Comments { get; set; }
        
        [Display(Name = "የወንጀል አይነት ")]
        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }
        
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
    }
}
