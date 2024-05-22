using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.ViewModels.ViewDocument
{
    public class ViewProsecutorLisense
    {

        public string LisenceNo { get; set; }
        public string? ProsecutorName { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public string? PhoneNo { get; set; }
        public string? EducationLevel { get; set; }
        public Jobclass job { get; set; }
        public string? ProffissionalLevel { get; set; }
        public DateTime GivingDate { get; set; }
        public Guid ProsecutorLisenceUpdateId { get; set; }

        public string LisenceLevel { get; set; }
        public FreeServant people { get; set; }
        public string FreeServantGender { get; set; }
        public string FreeServantAge { get; set; }
        public DisablityStatus disablity { get; set; }
        public string DisablityType { get; set; }
        public string IssuedLevel { get; set; }
        public FileEndResult decide { get; set; }
        public string OnAppointment { get; set; }
        public double MoneyAmmount { get; set; }
        public double PayedtaxAmount { get; set; }
        public double ServicePayed { get; set; }
        public DateTime lisenceUpdateDate { get; set; }
    }
}
