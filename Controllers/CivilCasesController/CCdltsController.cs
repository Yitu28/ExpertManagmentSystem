using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;
using Microsoft.AspNetCore.Identity;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Authorization;

namespace ExpertManagmentSystem.Controllers.CivilCasesController
{
    public class CCdltsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public CCdltsController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager, ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: CCdlts
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                var applicationDbContext = _context.CCdlt
                .Include(c => c.SectrorsDepartment)
                //.Where(c => c.CustomerCategory == CustomerCategory.ነፃ)
                .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
                .Where(c => c.SectrorsDepartment.DepartmentCategory == currentuser.DepartmentCategory);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት);
                return View(await applicationDbContext.ToListAsync());
            }

            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Include(c => c.WoredaSectors)
               .Include(c => c.ZonalSectors)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                var applicationDbContext = _context.CCdlt
                    .Include(c => c.WoredaSectors)
                    .Include(c => c.ZonalSectors)
                    .Include(c => c.SectrorsDepartment)
                    .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
                    .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት);
                return View(await applicationDbContext.ToListAsync());
            }
            
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ቢሮ);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.መምሪያ);
                return View(await applicationDbContext.ToListAsync());
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {

                var applicationDbContext = _context.CCdlt
               .Include(c => c.SectrorsDepartment)
               .Where(c => c.SectrorsDepartmentId == currentuser.UserDepartmentId)
               .Where(c => currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት);
                return View(await applicationDbContext.ToListAsync());
            }

            else
            {
                return View();
            }
        }

        // GET: CCdlts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CCdlt == null)
            {
                return NotFound();
            }

            var cCdlt = await _context.CCdlt
                .FirstOrDefaultAsync(m => m.CCdltId == id);
            if (cCdlt == null)
            {
                return NotFound();
            }

            return View(cCdlt);
        }

        // GET: CCdlts/Create
        [Authorize]
        public IActionResult Create()
        {
            //return View();
            ViewData["WoredaSectorsId"] = new SelectList(_context.WoredaSectors, "WoredaSectorsId", "WoredaSectorsName");
            CCdlt Dlt = new();
            return PartialView("_CcDltCreateModalPartial", Dlt);
        }

        // POST: CCdlts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CCdlt cCdlt)
        {
            var currentuser = await _userManager.GetUserAsync(User);
            if (User.IsInRole("Super Administrator"))
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Administrator") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }

            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Civil Cases") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }


            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ቢሮ)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.መምሪያ)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            else if (User.IsInRole("Civil Cases Expert") && currentuser.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት)
            {
                if (!ModelState.IsValid)
                {
                    cCdlt.CCdltId = Guid.NewGuid();
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    _context.Add(cCdlt);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CCdlts/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCdlt == null)
            {
                return NotFound();
            }

            var cCdlt = await _context.CCdlt.FindAsync(id);
            if (cCdlt == null)
            {
                return NotFound();
            }
            return View(cCdlt);
        }

        // POST: CCdlts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, CCdlt cCdlt)
        {
            if (id != cCdlt.CCdltId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    var currentuser = await _userManager.GetUserAsync(User);
                    cCdlt.SectrorsDepartmentId = currentuser.UserDepartmentId;
                    //cCdlt.DltUpdatededBy = currentuser.Id;
;                    _context.Update(cCdlt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CCdltExists(cCdlt.CCdltId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cCdlt);
        }

        // GET: CCdlts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CCdlt == null)
            {
                return NotFound();
            }

            var cCdlt = await _context.CCdlt
                .FirstOrDefaultAsync(m => m.CCdltId == id);
            if (cCdlt == null)
            {
                return NotFound();
            }

            return View(cCdlt);
        }

        // POST: CCdlts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CCdlt == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CCdlt'  is null.");
            }
            var cCdlt = await _context.CCdlt.FindAsync(id);
            if (cCdlt != null)
            {
                _context.CCdlt.Remove(cCdlt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CCdltExists(Guid id)
        {
          return (_context.CCdlt?.Any(e => e.CCdltId == id)).GetValueOrDefault();
        }
    }
}
