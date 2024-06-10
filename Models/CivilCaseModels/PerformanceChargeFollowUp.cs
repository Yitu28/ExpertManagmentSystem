﻿using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.Models.CivilCaseModels
{
    public class PerformanceChargeFollowUp : Audit
    {
        [Display(Name = "የቀጠሮ አይነት")]
        public string? ApointmentType { get; set; }

        [Display(Name = "ቀጠሮ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ApointmentDate { get; set; }

        [Display(Name = "ተወሰኖ ከሆነ")]
        public bool? HasDecissionMade { get; set; }

        [Display(Name = "ውሳኔ")]
        public TypeOfDecission? TypeOfDecission { get; set; }

        [Display(Name = "ውሳኔውን የሰጠው")]
        public string? DecidedBy { get; set; }

        [Display(Name = "ገቢ የሆነ ገንዘብ")]
        public decimal? MoneyGained { get; set; }

        [Display(Name = "ንብረት")]
        public string? ProperyClosed { get; set; }

        [Display(Name = "በልዩዩ ምክኛት")]
        public string? DiffrenetReasons { get; set; }
        public bool? HasBeenAppointed { get; set; }

        [Display(Name = "የፋይል ሁኔታ")]
        public PerformanceChargeStatus PerformanceChargeStatus { get; set; }

        [Display(Name = "የአፈጻጸም ክስ")]
        public Guid? PerformanceChargeOpenningId { get; set; }
        [ForeignKey(nameof(PerformanceChargeOpenningId))]
        [ValidateNever]
        public PerformanceChargeOpenning PerformanceChargeOpenning { get; set; }

        [Display(Name = "የስራ ክፍል")]
        public Guid? SectorDepartmentId { get; set; }
        public SectrorsDepartment? SectorDepartment { get; set; }
    }
}
