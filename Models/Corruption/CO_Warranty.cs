namespace ExpertManagmentSystem.Models.Corruption
{
    public class CO_Warranty
    {
        public int CO_WarrantyId { get; set; }
        public string? ProsecotorNo { get; set; }
        public string? ApplicantName { get; set; }
        public Gender Gender { get; set; }
        public int Amount { get; set; }
        public DateTime WarrantyDate { get; set; }
        public string? CourtNo  { get; set; }
        public string? Remark { get; set; }
    }
}
