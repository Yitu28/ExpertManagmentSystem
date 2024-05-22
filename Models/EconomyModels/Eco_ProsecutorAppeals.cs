using ExpertManagmentSystem.Models.CrimeModels;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ExpertManagmentSystem.Enums;

namespace ExpertManagmentSystem.Models.EconomyModels
{
    public class Eco_ProsecutorAppeals
    {
        public Guid Eco_ProsecutorAppealsId { get; set; }
        public DateTime FileOpeningDate { get; set; }
        public string ProsecutorNo { get; set; }
        public string CourtNo { get; set; }
        public string Applicant { get; set; }
        public string Respondant { get; set; }

        [Display(Name = "የወንጀል አይነት ")]

        public Guid Cr_Crime_TypeId { get; set; }
        [ForeignKey(nameof(Cr_Crime_TypeId))]
        public virtual Cr_Crime_Type? Cr_Crime_Type { get; set; }

        [Display(Name = "የስር/ፍ/ቤት ውሳኔ  ")]
        public string? CourtDecission { get; set; }
        [Display(Name = "አስተያየት የሰጠው ባለሙያ  ")]
        public string? ExpertName { get; set; }
        [Display(Name = "የጠ/ፍ/ቤት ውሳኔ  ")]
        public Guid Eco_GeneralCourtDecissionId { get; set; }
        [ForeignKey(nameof(Eco_GeneralCourtDecissionId))]
        public virtual Eco_GeneralCourtDecission? Eco_GeneralCourtDecission { get; set; }

        public string? MaleApplicant { get; set; }
        public string? FemaleApplicant { get; set; }
        [Display(Name = "የይግባኝ ሁኔታ ")]
        public ProsecutorsAppealStatus AppealStatus { get; set; }
        [Display(Name = "ለሰበር/ለፌደራል የተጠየቀ ")]
        public FederalBreakingRequest FederalBreakingRequest { get; set; }
    }
}