using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class CCdlt
    {

        // Dlt Stands for Directed to Laweryer 
        [Key]
        public Guid CCdltId { get; set; }

        [Required(ErrorMessage = "የእባክዎን ዐቃቢ ህግ መዝገብ ቁጥር ይሙሉ")]
        [Display(Name = "የዐ/ህ/መ/ቁ.")]
        public String? DltFileNo { get; set; }

        // Courrt Record  Number 
        [Required(ErrorMessage = "እባክዎን የፍርድ ቤት መዝገብ ቁጥርን ይሙሉ !")]

        [Display(Name = "የፍርድ ቤት መዝገብ ቁጥር")]
        public string? DltRecorNo { get; set; }

        [Required(ErrorMessage = "የእባክዎን አመልካች ይሙሉ ")]
        [Display(Name = "አመልካች")]
        public string? DltApplicant { get; set; }

        [Required(ErrorMessage = "እባክዎን የመልስ ሰጭን ስም ይሙሉ !")]

        [Display(Name = "መልስ ሰጭ")]
        public string? DltResponder { get; set; }


        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ ፈላጊ ፆታን ይምረጡ !")]
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ፆታ")]
        public Genders? DltGender { get; set; }

        // Legal Aid breaking response Openning Age
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ ፈላጊ ዕድሜን ይሙሉ !")]
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ዕድሜ")]
        public int? DltAge { get; set; }

        // Legal Aid breaking response Openning Support Type
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ አይነትን ይሙሉ !")]
        [Display(Name = "ነፃ የህግ ድጋፍ አይነት ")]
        public SupportType? DltSupportType { get; set; }


        // Legal Aid breaking response Openning Date of Openning 
        [Required(ErrorMessage = "እባክዎን በዓቃቢ ህግ የተከፈተበት ቀንን ይሙሉ !")]
        [Display(Name = "በዓቃቢ ህግ የተከፈተበት ቀን")]
        public DateTime? DltDoo { get; set; }

        // Legal Aid breaking response Openning Types Off Issue
        [Required(ErrorMessage = "እባክዎን የጉዳዩን አይነት ይሙሉ !")]
        [Display(Name = "የጉዳይ አይነት ")]
        public string? DlttypesofIssue { get; set; }

        // Legal Aid breaking response Openning (apsm) Amount Per Birr / Square Meter
        [Required(ErrorMessage = "የእባክዎን የገንዘብ መጠንን በብር ይሙሉ ")]
        [Display(Name = "የገንዘብ መጠን በብር")]
        public int DltAmountBirr { get; set; }

        [Required(ErrorMessage = "የእባክዎን የገንዘብ መጠንን በካሬ የሙሉ ")]
        [Display(Name = "የገንዘብ መጠን በካሬ")]
        public int DltAmountKarie { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን የሚገኝበት ዞንን ይሙሉ !")]
        [Display(Name = "የሚገኝበት ዞን")]
        public string? DltAddressZone { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን የሚገኝበት ወረዳን ይሙሉ !")]
        [Display(Name = "የሚገኝበት ወረዳ ")]
        public string? DltAddressWoreda { get; set; }

        // Legal Aid breaking response Openning Name Of Expert
        [Required(ErrorMessage = "እባክዎን የተመራለትን ባለሙያ ይሙሉ !")]
        [Display(Name = "የተመራለት ባለሙያ")]
        public string? DltExpertName { get; set; }


        // Legal Aid breaking response Openning Date of Assignments 
        [Required(ErrorMessage = "እባክዎን የተመራበትን ቀን ይሙሉ !")]
        [Display(Name = "የተመራበት ቀን")]
        public DateTime? DltDoAss { get; set; }


        // Legal Aid breaking response Openning Date of Return 
        //
        [Display(Name = "ተሰርቶ የተመለሰበት ቀን")]
        public DateTime? DltDoRet { get; set; }

        // Legal Aid breaking response Openning Taken Time
        //
        [Display(Name = "የፈጀው ጊዜ")]
        public string? DltLOS { get; set; }


        // Legal Aid breaking response Openning Date of Presecutor Decisions 
        
        [Display(Name = "በአቃቢ ህግ የተሰጠ ውሳኔ ")]
        public string? DltPDecission { get; set; }


        [Required(ErrorMessage = "የእባክዎን የተመራለትን ጠበቃ ይሙሉ ")]
        [Display(Name = "የተመራለት ጠበቃ")]
        public string? DltAssignto { get; set; }


        public Guid? DltCreatedBy { get; set; }
        public Guid? DltUpdatededBy { get; set; }
        public Guid? DltDeletedBy { get; set; }

        public DateTime? DltCreatedAt { get; set; }
        public DateTime? DltEdittedAt { get; set; }
        public DateTime? DltDeletedAt { get; set; }
    }
}
