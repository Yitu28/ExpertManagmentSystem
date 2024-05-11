using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.Corruption
{
    public enum Opinion { የፀና, የተሻረ }
    public class CO_Closed_SentInReverse
    {
        public Guid CO_Closed_SentInReverseId { get; set; }

        [Display(Name = "የዐ/ህግ መ/ቁጥር")]
        public string? ProsecutorNo { get; set; }

        [Display(Name = "የተከሳሽ ስም")]
        public string? Defenedant { get; set; }

        [Display(Name = "ዞን")]
        public string? DefenedantZone { get; set; }

        [Display(Name = "የተመዘገበበት ቀን")]
        public DateTime RegisterDate { get; set; }

        [Display(Name = "የተሰጠ አስተያየት")]
        public Opinion OpinionGiven { get; set; }
        public Guid SectrorsDepartmentId { get; set; }
        [ForeignKey(nameof(SectrorsDepartmentId))]
        public virtual SectrorsDepartment? SectrorsDepartment { get; set; }
    }
}
