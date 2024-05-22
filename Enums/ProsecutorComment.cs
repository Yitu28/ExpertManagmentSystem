using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Enums
{
    public enum Gender
    {
        ወንድ, ሴት 
    }
    public enum Department
    {
        Crime, Corruption,Economy,Fithavhier,documentation
    }
    public enum ProsecutorComment
    {
        እንዲፀና, እንዲሻሻል, እንዲሻር  
    }
    public enum Jobclass
    {
        [Display(Name = "የክልል ዐ/ህግ  ")]
        regional_prosecutor,
        [Display(Name = "የክልል ዳኛ ")]
        Regional_cout,
        [Display(Name = "የዞን ዐ/ህግ  ")]
        zonal_prosecutor,
        [Display(Name = "የዞን ዳኛ   ")]
        zonal_Court,
        [Display(Name = "የወረዳ ዐ/ህግ  ")]
        Woreda_prosecutor,
        [Display(Name = "የወረዳ  ዳኛ ")]
        woreda_court,
        [Display(Name = "ሌሎች  ")]
        Others,
    }
    public enum FreeServant
    {
        ከሳሽ , ተከሳሽ 
    }
    public enum DisablityStatus
    {
        ጉዳተኛ, ጉዳትአልባ
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
    public enum ProsecutorsAppealStatus
    {
         አዲስ , ነባር , አሸናፊ ,ተሸናፊ  
    }
    public enum CrimeEconomy
    {
        CrimeDept, EconomyDept
    }
    //public enum PetWarranty
    //{
    //    Warranty, pitition
    //}
    public enum EcochargeAge
    {
      
         [Display(Name = "እስከ 29 ዓመት ")]
        Under_29,
        [Display(Name = "ከ 29 ዓመት በላይ ")]
        Above_29,
        [Display(Name = "ከ 60 ዓመት በላይ ")]
        Above_60


    }
    public enum CivilCaseCategory
    {
        DirectChargeOpenning, DirectChargeResponseOpenning, GeneralAppealOpenning,GeneralAppealResponseOpenning, BrekingApplicantOpenning, BrekingRespondentOpenning
    }
}
