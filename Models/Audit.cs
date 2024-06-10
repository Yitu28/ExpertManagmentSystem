using ExpertManagmentSystem.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models
{
    public class Audit
    {
        public Guid Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? EdittedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? EditedBy { get; set; }
        public string? ApplicationUserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
