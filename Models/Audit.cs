using ExpertManagmentSystem.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models
{
    public class Audit
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EdittedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public string ApplicationUserUser { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
