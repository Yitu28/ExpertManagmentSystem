using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_prosecutorComment
    {
        public Guid Eco_prosecutorCommentId { get; set; }
        [Display(Name = "የዐ/ህግ አስተያየት አይነቶች ")]
        public string ProsecutorComment {  get; set; }
        [Display(Name = "ዲፓርትመንት ")]
       public Department Department { get; set; }
    }
}
