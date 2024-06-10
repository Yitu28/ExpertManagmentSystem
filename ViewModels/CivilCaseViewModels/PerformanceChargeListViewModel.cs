using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.CivilCaseModels;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpertManagmentSystem.ViewModels
{
    public class PerformanceChargeListViewModel
    {        
        public IEnumerable<PerformanceChargeOpenning> PerformanceChargeOpennings { get; set; }
        public IEnumerable<PerformanceChargeFollowUp> PerformanceChargeFollowUps { get; set; }
    }
}
