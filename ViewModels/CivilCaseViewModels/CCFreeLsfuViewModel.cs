using ExpertManagmentSystem.Models.CivilCaseModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Enums;

namespace ExpertManagmentSystem.ViewModels.CivilCaseViewModels
{
    [Keyless]
    public class CCFreeLsfuViewModel
    {
        [Display(Name = "ፍርድ ቤት የቀረበበት ቀን")]
        public DateTime? Doc { get; set; }

        public Guid FreeLegServiceFollowupId { get; set; }
        [Display(Name = "የቀጠሮ ቀን")]
        public DateTime? Doa { get; set; }


       
        [Display(Name = "የቀጠሮ አይነት")]
        public string? AppointmentType { get; set; }



        [Display(Name = "ተወስኖ ከሆነ የተወሰነበት ቀን")]
        public DateTime? DoD { get; set; }

        [Display(Name = "የወሳኔ አይነት")]
        public DecisionStatus? DecisionStatus { get; set; }

        [Display(Name = "የወሳኔን የሰጠው ፍርድ ቤት")]
        public string? Decisionmadeby { get; set; }


        // CC Free Legal Srvice Model

        public Guid CCFreelServicesId { get; set; }
        // Presecutor's File Number 
        [Display(Name = "የአቃቢ ህግ መዝገብ ቁጥር")]
        public string? FileNo { get; set; }

        // Courrt Record  Number 
        
        [Display(Name = "የፍርድ ቤት መዝገብ ቁጥር")]
        public string? RecorNo { get; set; }

        // Legal Aid breaking response Openning Applicant
        
        [Display(Name = "አመልካች")]
        public string? Applicant { get; set; }

        // Legal Aid breaking response Openning Responder
        [Display(Name = "ተጠሪ")]
        public string? Responder { get; set; }


        // Legal Aid breaking response Openning Sex
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ፆታ")]
        public Gender? Gender { get; set; }

        // Legal Aid breaking response Openning Age
        
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ዕድሜ")]
        public AgeRange? age { get; set; }

        // Legal Aid breaking response Openning Support Type
       

        [Display(Name = "ነፃ የህግ ድጋፍ አይነት ")]
        public SupportType? SupportType { get; set; }


        // Legal Aid breaking response Openning Date of Openning 
        
        [Display(Name = "በዓቃቢ ህግ የተከፈተበት ቀን")]
        public DateTime? Doo { get; set; }

        // Legal Aid breaking response Openning Types Off Issue
        

        [Display(Name = "የጉዳይ አይነት ")]
        public string? typesofIssue { get; set; }

        // Legal Aid breaking response Openning (apsm) Amount Per Birr / Square Meter
       

        [Display(Name = "የገንዘብ መጠን")]
        public string? apsm { get; set; }

        // Legal Aid breaking response Openning Responder
        

        [Display(Name = "የሚገኝበት ዞን")]
        public string? AddressZone { get; set; }

        // Legal Aid breaking response Openning Responder
        

        [Display(Name = "የሚገኝበት ወረዳ ")]
        public string? AddressWoreda { get; set; }

        // Legal Aid breaking response Openning Name Of Expert
        
        
        [Display(Name = "የተመራለት ባለሙያ")]
        public string? ExpertName { get; set; }


        // Legal Aid breaking response Openning Date of Assignments 
        
        [Display(Name = "የተመራበት ቀን")]
        public DateTime? DoAss { get; set; }


        // Legal Aid breaking response Openning Date of Return 
        //
        [Display(Name = "ተሰርቶ የተመለሰበት ቀን")]
        public DateTime? DoRet { get; set; }

        // Legal Aid breaking response Openning Taken Time
        //
        [Display(Name = "የፈጀው ጊዜ")]
        public string? LOS { get; set; }


        // Legal Aid breaking response Openning Date of Presecutor Decisions 
        
        [Display(Name = "በአቃቢ ህግ የተሰጠ ውሳኔ ")]
        public string? PDecission { get; set; }

        [ForeignKey("SectrorsDepartmentId")]
        public Guid SectrorsDepartmentId { get; set; }
        public SectrorsDepartment? SectrorsDepartment { get; set; }
        public FreelCategory? FreelCategory { get; set; }

    }
}
