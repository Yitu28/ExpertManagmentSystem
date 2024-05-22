using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.EconomyModels;
using System.ComponentModel.DataAnnotations.Schema;
using ExpertManagmentSystem.ViewModels.ViewDocument;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.DocumentModel
{
    public class ProsecutorLisenceUpdate
    {
        public Guid ProsecutorLisenceUpdateId { get; set; }
        [Display(Name = "የፍቃድ ቁጥር ")]
        public string LisenceNo { get; set; }
        [ForeignKey(nameof(LisenceNo))]
       public virtual ProsecutorLisence? ProsecutorLisence { get; set; }
        [Display(Name = "የፍቃድ ደረጃ  ")]
        public string? LisenceLevel { get; set; }
        [Display(Name = "ነጻ የህግ ድጋፍ የተደረገላቸው የህብረተሰብ ክፍሎች  ")]
        public FreeServant people { get; set; }
        [Display(Name = "የተገልጋይ ጾታ ")]
        public Gender FreeServantGender { get; set; }
        [Display(Name = "የተገልጋይ እድሜ  ")]
        public string FreeServantAge { get; set; }
        [Display(Name = "የአካል ጉዳት ሁኔታ ")]
        public DisablityStatus disablity { get; set; }
        [Display(Name = "የጉዳዩ አይነት  ")]
        public string IssuedType { get; set; }
        [Display(Name = "የጉዳዩ ደረጃ ")]
        public string IssuedLevel { get; set; }
        [Display(Name = "ውሳኔ ያገኘ  ")]
        public FileEndResult decide {  get; set; }
        [Display(Name = "በቀጠሮ ላይ ያለ  ")]
        public string OnAppointment {  get; set; }
        [Display(Name = "የገንዘብ መጠን ")]
        public double MoneyAmmount { get; set; }
        [Display(Name = "ለእድሳት የተከፈለ ግብር  ")]
        public double PayedtaxAmount { get; set; }
        [Display(Name = "የአገልግሎት ክፍያ  ")]
        public double  ServicePayed { get; set; }
        [Display(Name = "የታደሰበት ቀን ")]
        public DateTime lisenceUpdateDate { get; set; }



    }
}
