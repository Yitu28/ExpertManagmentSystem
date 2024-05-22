using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CivilCaseModels;
using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace ExpertManagmentSystem.Models.DocumentModel
{
    public class ProsecutorLisence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Display(Name ="የፍቃድ ቁጥር ")]
        public string LisenceNo { get; set; }
        [Display(Name = "የዐ/ህግ ስም ")]
        public string? ProsecutorName { get; set;}
        [Display(Name = "ጾታ ")]
        public Enums.Gender Gender { get; set; }
        [Display(Name = "እድሜ ")]
        public int Age { get; set; }
        [Display(Name = "አድራሻ  ")]
        public string? Address { get; set; }
        [Display(Name = "ስልክ ቁጥር  ")]
        public string? PhoneNo { get; set; }
        [Display(Name = "የትምህርት ደረጃ  ")]
        public string? EducationLevel { get; set; }
        [Display(Name = "የስራ ክፍል  ")]
        public Jobclass job {  get; set; }
        [Display(Name = "የሙያ ደረጃ  ")]
        public string? ProffissionalLevel { get; set; }
        [Display(Name = "ፍቃድ የተሰጠበት ቀን  ")]
        public DateTime GivingDate { get; set; }
        public virtual ICollection<ProsecutorLisenceUpdate>? GetProsecutorLisenceUpdates { get; set; }


    }
}
