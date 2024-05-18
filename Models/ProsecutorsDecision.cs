using ExpertManagmentSystem.Models.Corruption;

namespace ExpertManagmentSystem.Models
{
    public class ProsecutorsDecision
    {
        public Guid ProsecutorsDecisionId { get; set; }
        public string? DecisionName { get; set; }
        public virtual ICollection<CO_CorruptionCharge>? CO_CorruptionCharge { get; set; }
    }
    public class CourtsDecision
    {
        public Guid CourtsDecisionId { get; set; }
        public string? DecisionName { get; set; }
        public virtual ICollection<CO_CorruptionCharge>? CO_CorruptionCharge { get; set; }
    }
}
