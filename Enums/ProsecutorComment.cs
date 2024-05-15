using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Enums
{
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
