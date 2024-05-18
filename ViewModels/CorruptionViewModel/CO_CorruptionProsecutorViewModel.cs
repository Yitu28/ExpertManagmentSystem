using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models;
using ExpertManagmentSystem.Models.Corruption;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.ViewModels.CorruptionViewModel
{
    public class CO_CorruptionProsecutorViewModel
    {
        public Guid CO_CorruptionCourtDecisionId { get; set; }
        public Guid CO_CorruptionChargeId { get; set; }

        [Display(Name = "የፍ/ቤት ውሳኔ")]
        public Guid CourtsDecisionId { get; set; }
        [ForeignKey(nameof(CourtsDecisionId))]
        public virtual CourtsDecision? CourtsDecision { get; set; }



        public virtual CO_CorruptionCharge? CO_CorruptionCharge { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
