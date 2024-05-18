using ExpertManagmentSystem.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.Corruption
{
    public class CO_CorruptionCourtDecision
    {
        public Guid CO_CorruptionCourtDecisionId { get; set; }
        public Guid CO_CorruptionChargeId { get; set; }

        [Display(Name = "የፍ/ቤት ውሳኔ")]
        public Guid CourtsDecisionId { get; set; }
        [ForeignKey(nameof(CourtsDecisionId))]
        public virtual CourtsDecision? CourtsDecision { get; set; }



        public virtual CO_CorruptionCharge? CO_CorruptionCarge { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
