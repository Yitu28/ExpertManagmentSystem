using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ExpertManagmentSystem.Controllers
{
    public class PerformanceChargeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PerformanceChargeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(Guid id, PerformanceChargeListViewModel performanceChargeListViewModel)
        {
            var pcf = _context.PerformanceChargeFollowUps.ToList();
            var performanceChargeOpennings  = _context.PerformanceChargeOpennings.ToList();
            var performanceChargeFollwUps  = _context.PerformanceChargeFollowUps.ToList();
            return View(pcf);
        }
    }
}
