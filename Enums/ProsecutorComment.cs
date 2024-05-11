using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Enums
{
    public enum TypeOfPerformanceCgarge
    {
        [Display(Name = "መክፈቻ")]
        Openning,

        [Display(Name = "መልስ")]
        Response,
    }
    public enum CustomerType
    {
        [Display(Name = "የመንግስት")]
        GovernmentOrganization,

        [Display(Name = "ጾታ")]
        Gender,

        [Display(Name = "እድሜ")]
        Age,

        [Display(Name = "የማህበረሰብ ክፍሎች")]
        SocialParts        
    }

    public enum Gender
    {
        ወንድ, ሴት 
    }
    public enum ProsecutorComment
    {
        እንዲፀና, እንዲሻሻል, እንዲሻር  
    }
    public enum FileStatus
    {
        ነባር, አዲስ 
    }
    public enum FileEndResult
    {
        አሸናፊ, ተሸናፊ   
    }
    public enum FederalBreakingRequest
    {
        የተጠየቀ, ያልተጠየቀ 
    }
    public enum HighCourtDecission
    {
         በማፅናት, በማሻሻል, በመሻር 
    }
    public enum CivilCaseCategory
    {
        [Display(Name = "የቀጥታ ክስ መክፈቻ")]
        DirectChargeOpenning, 

        [Display(Name = "የቀጥታ ክስ መልስ")]
        DirectChargeResponseOpenning,

        [Display(Name = "ጠቅላይ ይግባኝ መክፈቻ")]
        GeneralAppealOpenning,

        [Display(Name = "ጠቅላይ ይግባኝ መልስ")]
        GeneralAppealResponseOpenning,

        [Display(Name = "ሰበር ተጠሪ መክፈቻ")]
        BreakingApplicantOpenning,

        [Display(Name = "ሰበር አመልካች መክፈቻ")]
        BreakingRespondentOpenning
    }
}
