namespace ExpertManagmentSystem.Models.Corruption
{
    public enum AppealOrBreak {ሰበርይግባኝ, ይግባኝ  }
    public class CO_RegionalBreakAppeal
    {
        public int CO_RegionalBreakAppealId { get; set; }

        [Display(Name = "የፍ/ቤት ወ/መ/ቁጥር")]
        public string? CourtNo { get; set; }

        [Display(Name = "ይግባኝ ባይ/ ጠያቂ")]
        public string? Appellant { get; set; }

        [Display(Name = "መልስ ሰጭ")]
        public string? Answerer { get; set; }

        [Display(Name = "ወንጀሉ")]
        public string? CO_CrimeType { get; set; }

        [Display(Name = "ይግባኝ የተጠየቀበት ምክንያት")]
        public string? Reasons { get; set; }

        [Display(Name = "ፋይሉ የተከፈተበት ቀን")]
        public DateTime OpeningDate { get; set; }

        [Display(Name = "ፆታ")]
        public Gender Gender { get; set; }

        [Display(Name = "ብዛት")]
        public int Amount { get; set; }

        [Display(Name = "አድራሻ")]
        public string? Address { get; set; }

        [Display(Name = "ምርመራ")]
        public string? Remark { get; set; }


        public AppealOrBreak R_BreakingOrAppeal { get; set; }

    }
}
