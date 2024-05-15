using ExpertManagmentSystem.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models
{
    public class Audit
    {
        public Guid Id { get; set; }
<<<<<<< HEAD
        public DateTime CreatedAt { get; set; }
        public DateTime EdittedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public string ApplicationUserUser { get; set; }
=======
        public DateTime? CreatedAt { get; set; }
        public DateTime? EdittedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? ApplicationUserUser { get; set; }
>>>>>>> 4c8794817593bd4c18309f86c4832bd63a5f5879
        public virtual ApplicationUser? ApplicationUser { get; set; }
    }
}
