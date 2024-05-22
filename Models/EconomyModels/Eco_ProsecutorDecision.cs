
using ExpertManagmentSystem.Enums;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_ProsecutorDecision
    {
        public Guid Eco_ProsecutorDecisionId {  get; set; }
        [Display(Name = "የዐ/ህግ ውሳኔ አይነቶች ")]
        public string? ProsecutorDecisionName { get; set; }
        public Department Dept { get; set; }
       

    }
}
