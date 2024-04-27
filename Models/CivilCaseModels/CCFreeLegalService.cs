using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    // This Class Defines for Civil Case Managment 
    // For Free legal Services 
    // Sex Category with Enumerable List
    public enum Sex
    {
        ሴት,
        ወንድ
    }
    // Types Of Decision with Enumerable List
    public enum TypesofDecision
    {
        አሸናፊ, ተሸናፊ, ወደ_ፍርድ_ቤት, ስልጣን_ላለው
    }
    // ነፃ የህግ ድጋፍ አይነቶች ምድብ 
    public enum LegaServiceCategory
    {
        ይግባኝአመልካች, ይግባኝመልስ, ሰበርአመልካች, ሰበርተጠሪ, ቀጥታክስአመልካች, ቀጥታክስመልስ
    }
    public class CCFreeLegalService
    {
        [Key]
        public int Id { get; set; }
        // Presecutor's File Number 
        [Required]
        [StringLength(50)]
        [Display(Name = "የአቃቢ ህግ መዝግብ ቁጥር")]
        public string? FileNo { get; set; }

        // Courrt Record  Number 
        [Required]
        [StringLength(50)]
        [Display(Name = "የፍርድ ቤት መዝግብ ቁጥር")]
        public string? RecorNo { get; set; }

        // Legal Aid breaking response Openning Applicant
        [Required]
        [StringLength(50)]
        [Display(Name = "አመልካች")]
        public string? Applicant { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required]
        [StringLength(50)]
        [Display(Name = "ተጠሪ")]
        public string? Responder { get; set; }


        // Legal Aid breaking response Openning Sex
        [Required]
        [StringLength(50)]
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ፆታ")]
        public Sex? Sex { get; set; }

        // Legal Aid breaking response Openning Age
        [Required]
        [StringLength(50)]
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ዕድሜ")]
        public int? age { get; set; }

        // Legal Aid breaking response Openning Support Type
        [Required]
        [StringLength(50)]
        [Display(Name = "ነፃ የህግ ድጋፍ አይነት ")]
        public string? SupportType { get; set; }


        // Legal Aid breaking response Openning Date of Openning 
        [Required]
        [StringLength(50)]
        [Display(Name = "በዓቃቢ ህግ የተከፈተበት ቀን")]
        public DateOnly? Doo { get; set; }

        // Legal Aid breaking response Openning Types Off Issue        [Required]
        [StringLength(50)]
        [Display(Name = "የጉዳይ አይነት ")]
        public string? typesofIssue { get; set; }

        // Legal Aid breaking response Openning (apsm) Amount Per Birr / Square Meter
        [Required]
        [StringLength(50)]
        [Display(Name = "የገንዘብ መጠን")]
        public string? apsm { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required]
        [StringLength(50)]
        [Display(Name = "የሚገኝበት ዞን")]
        public string? AddressZone { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required]
        [StringLength(50)]
        [Display(Name = "የሚገኝበት ወረዳ ")]
        public string? AddressWoreda { get; set; }

        // Legal Aid breaking response Openning Name Of Expert
        [Required]
        [StringLength(50)]
        [Display(Name = "የሰራው ባለሙያ")]
        public Guid? ExpertId { get; set; }

        // Legal Aid breaking response Openning Date of Submission to Court 
        [Required]
        [StringLength(50)]
        [Display(Name = "ለፍርድ ቤት የቀረበበት ቀን")]
        public DateOnly? DosToc { get; set; }

        // Legal Aid breaking response Openning Date of Appointment 
        [Required]
        [StringLength(50)]
        [Display(Name = "ቀጠሮ")]
        public DateOnly? DoA { get; set; }

        // Legal Aid breaking response Openning Types Of Appointment 
        [Required]
        [StringLength(50)]
        [Display(Name = "የቀጠሮ አይነት")]
        public string? TypeofAppointment { get; set; }

        // Legal Aid breaking response Openning ተወስኖ ከሆነ ውሳኔው የተሰጠበት ቀን 
        [Required]
        [StringLength(50)]
        [Display(Name = "ተወስኖ ከሆነ የተወሰነበት ቀን")]
        public DateOnly? DoD { get; set; }

        // Legal Aid breaking response Openning የውሳኔው አይነት 
        [Required]
        [StringLength(50)]
        [Display(Name = "የውሳኔው አይነት")]
        public TypesofDecision? TypesofDecision { get; set; }


        // Legal Aid breaking response Openning Responder
        [Required]
        [StringLength(50)]
        [Display(Name = "ውሳኔውን የሰጠው ፍርድ ቤት")]
        public String? DecisionmadeBy { get; set; }



        [ForeignKey("SectrorsDepartmentId")]
        public Guid SectrorsDepartmentId { get; set; }
        public SectrorsDepartment? SectrorsDepartment { get; set; }

        public LegaServiceCategory? LegaServiceCategory { get; set; }
    }
}
