﻿using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    // This Class Defines for Civil Case Managment 
    // For Free legal Services 
    
    public class CCFreelServices
    {
        [Key]
        public Guid CCFreelServicesId { get; set; }
        // Presecutor's File Number 
        [Required(ErrorMessage = "እባክዎን የአቃቢ ህግ መዝገብ ቁጥርን ይሙሉ !")]
        [Display(Name = "የአቃቢ ህግ መዝገብ ቁጥር")]
        public string? FileNo { get; set; }

        // Courrt Record  Number 
        [Required(ErrorMessage = "እባክዎን የፍርድ ቤት መዝገብ ቁጥርን ይሙሉ !")]
        
        [Display(Name = "የፍርድ ቤት መዝገብ ቁጥር")]
        public string? RecorNo { get; set; }

        // Legal Aid breaking response Openning Applicant
        [Required(ErrorMessage = "እባክዎን የአመልካችን ስም ይሙሉ !")]
        
        [Display(Name = "አመልካች")]
        public string? Applicant { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን የተጠሪን ስም ይሙሉ !")]
        [Display(Name = "ተጠሪ")]
        public string? Responder { get; set; }


        // Legal Aid breaking response Openning Sex
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ ፈላጊ ፆታን ይምረጡ !")]
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ፆታ")]
        public Genders? Gender { get; set; }

        // Legal Aid breaking response Openning Age
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ ፈላጊ ዕድሜን ይሙሉ !")]
        [Display(Name = "ነፃ የህግ ድጋፍ ፈላጊ ዕድሜ")]
        public int? Age { get; set; }

        // Legal Aid breaking response Openning Support Type
        [Required(ErrorMessage = "እባክዎን ነፃ የህግ ድጋፍ አይነትን ይሙሉ !")]
        [Display(Name = "ነፃ የህግ ድጋፍ አይነት ")]
        public SupportType? SupportType { get; set; }


        // Legal Aid breaking response Openning Date of Openning 
        [Required(ErrorMessage = "እባክዎን በዓቃቢ ህግ የተከፈተበት ቀንን ይሙሉ !")]
        [Display(Name = "በዓቃቢ ህግ የተከፈተበት ቀን")]
        public DateTime? Doo { get; set; }

        // Legal Aid breaking response Openning Types Off Issue
        [Required(ErrorMessage = "እባክዎን የጉዳዩን አይነት ይሙሉ !")]
        [Display(Name = "የጉዳይ አይነት ")]
        public string? typesofIssue { get; set; }

        // Legal Aid breaking response Openning (apsm) Amount Per Birr / Square Meter
        [Required(ErrorMessage = "እባክዎን የገንዘብ መጠንን ይሙሉ !")]
        [Display(Name = "የገንዘብ መጠን")]
        public string? apsm { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን የሚገኝበት ዞንን ይሙሉ !")]
        [Display(Name = "የሚገኝበት ዞን")]
        public string? AddressZone { get; set; }

        // Legal Aid breaking response Openning Responder
        [Required(ErrorMessage = "እባክዎን የሚገኝበት ወረዳን ይሙሉ !")]
        [Display(Name = "የሚገኝበት ወረዳ ")]
        public string? AddressWoreda { get; set; }

        // Legal Aid breaking response Openning Name Of Expert
        [Required(ErrorMessage = "እባክዎን የተመራለትን ባለሙያ ይሙሉ !")]
        [Display(Name = "የተመራለት ባለሙያ")]
        public string? ExpertName { get; set; }


        // Legal Aid breaking response Openning Date of Assignments 
        [Required(ErrorMessage = "እባክዎን የተመራበትን ቀን ይሙሉ !")]
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


        public Guid? CCServCreatedBy { get; set; }
        public Guid? CCServUpdatededBy { get; set; }
        public Guid? CCServDeletedBy { get; set; }

        public DateTime? CCServCreatedAt { get; set; }
        public DateTime? CCServEdittedAt { get; set; }
        public DateTime? CCServDeletedAt { get; set; }

        [ForeignKey("SectrorsDepartmentId")]
        public Guid SectrorsDepartmentId { get; set; }
        public SectrorsDepartment? SectrorsDepartment { get; set; }
        public FreelCategory? FreelCategory { get; set; }

        public virtual ICollection<CCFreeLegServiceFollowup>? FreeLegServiceFollowup { get; set; }
    }
}