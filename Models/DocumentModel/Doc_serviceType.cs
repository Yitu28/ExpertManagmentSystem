using System.ComponentModel.DataAnnotations;

namespace ExpertManagmentSystem.Models.DocumentModel
{
    public class Doc_serviceType
    {
        public Guid Doc_serviceTypeId {  get; set; }
        [Display(Name = "የአገልግሎት ስም ")]
        public string Doc_serviceTypeName { get; set; }
        public virtual ICollection<Doc_WarrantyDocument> Doc_WarrantyDocument { get; set; }

    }
}
