using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.OrganizationalStructures;
using ExpertManagmentSystem.ViewModels;
using ExpertManagmentSystem.ViewModels.CivilCaseViewModels;
using ExpertManagmentSystem.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Internal;

namespace ExpertManagmentSystem.Controllers.CivilCasesController
{
    public class CCReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public CCReportsController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public JsonResult Zonedatalists()
        {
            var zonelists = _context.ZonalSectors.OrderBy(x => x.ZonalSectorName).ToList();
            return new JsonResult(zonelists);
        }

        public JsonResult Woredadatalists()
        {
            var zonelists = _context.WoredaSectors.OrderBy(x => x.WoredaSectorsName).ToList();
            return new JsonResult(zonelists);
        }

        public JsonResult Woredalists(Guid SectorZoneIds)
        {
            var zoneslist = _context.WoredaSectors.Where(e => e.ZonalSectors.ZonalSectorId == SectorZoneIds).ToList();
            return new JsonResult(zoneslist);
        }





        [Authorize]
        public IActionResult Indexo()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> ReportIndexo(DateTime? Reportfrom, DateTime? ReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup).Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup).Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                //if (startDate.HasValue && endDate.HasValue)
                var applicationDbContext = _context.CCFreelServices
                    .Include(c => c.SectrorsDepartment)
                    .Include(c => c.FreeLegServiceFollowup).Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                //}
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        

        [Authorize]
        public async Task<IActionResult> CourtReportIndexo(DateTime? CourtReportfrom, DateTime? CourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices).Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(a => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(a => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> RegReporto(DateTime? RegReportfrom, DateTime? RegReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> RegCourtReporto(DateTime? RegCourtReportfrom, DateTime? RegCourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> ZoneReporto(DateTime? ZoneReportsfrom, DateTime? ZoneReportsTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }

            // Zonal sectors User Roles
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> ZoneCourtReporto(DateTime? ZoneCourtReportfrom, DateTime? ZoneCourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> WoredaReporto(DateTime? WoredaReportfrom, DateTime? WoredaReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> WoredaCourtReporto(DateTime? WoredaCourtReportfrom, DateTime? WoredaCourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }


            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት).Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት).Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else
            {
                return View();
            }
        }




        [Authorize]
        public IActionResult Index()
        {
            return  View();
        }

        [Authorize]
        public async Task<IActionResult> ReportIndex(DateTime? Reportfrom, DateTime? ReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup).Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup).Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                //if (startDate.HasValue && endDate.HasValue)
                var applicationDbContext = _context.CCFreelServices
                    .Include(c => c.SectrorsDepartment)
                    .Include(c => c.FreeLegServiceFollowup).Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                //}
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= Reportfrom && x.Doo <= ReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> CourtReportIndex(DateTime? CourtReportfrom, DateTime? CourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices).Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(a => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(a => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.CCFreelServices)
               .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(a => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
               .Where(x => x.DoD >= CourtReportfrom && x.DoD <= CourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> RegReport(DateTime? RegReportfrom, DateTime? RegReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= RegReportfrom && x.Doo <= RegReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> RegCourtReport(DateTime? RegCourtReportfrom, DateTime? RegCourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= RegCourtReportfrom && x.DoD <= RegCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> ZoneReport(DateTime? ZoneReportsfrom, DateTime? ZoneReportsTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            
            // Zonal sectors User Roles
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= ZoneReportsfrom && x.Doo <= ZoneReportsfrom);
                return View(await applicationDbContext.ToListAsync());
            }            
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> ZoneCourtReport(DateTime? ZoneCourtReportfrom, DateTime? ZoneCourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= ZoneCourtReportfrom && x.DoD <= ZoneCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }


        [Authorize]
        public async Task<IActionResult> WoredaReport(DateTime? WoredaReportfrom, DateTime? WoredaReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.FreeLegServiceFollowup)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.Doo >= WoredaReportfrom && x.Doo <= WoredaReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        public async Task<IActionResult> WoredaCourtReport(DateTime? WoredaCourtReportfrom, DateTime? WoredaCourtReportTo)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId != currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory != DepartmentCategory.ቢሮ && currentuser.DepartmentCategory != DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c =>  currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c =>  currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }


            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c =>  currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
                .Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት).Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                var applicationDbContext = _context.CCFreeLegServiceFollowup
                .Include(c => c.SectrorsDepartment)
                .Include(c => c.CCFreelServices)
                .Where(a => a.SectrorsDepartment.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት).Where(x => x.DoD >= WoredaCourtReportfrom && x.DoD <= WoredaCourtReportTo);
                return View(await applicationDbContext.ToListAsync());
            }

            else
            {
                return View();
            }
        }
    }
}
