using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.OrganizationalStructures;
using ExpertManagmentSystem.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace ExpertManagmentSystem.Controllers
{
    public class ReginalSectorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReginalSectorsController(ApplicationDbContext context,UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ReginalSectors
        public async Task<IActionResult> Index()
        {

            return _context.ReginaslSector != null ?
                        View(await _context.ReginaslSector.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.ReginaslSector'  is null.");

            //var user = await _userManager.GetUserAsync(User);

            //if (User.IsInRole("Super Administrator"))
            //{
            //    return _context.ReginaslSector != null ?
            //            View(await _context.ReginaslSector.ToListAsync()) :
            //            Problem("Entity set 'ApplicationDbContext.ReginaslSector'  is null.");
            //}
            //return View();
        }

            // GET: ReginalSectors/Details/5
            public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ReginaslSector == null)
            {
                return NotFound();
            }

            var reginalSector = await _context.ReginaslSector
                .FirstOrDefaultAsync(m => m.ReginalSectorId == id);
            if (reginalSector == null)
            {
                return NotFound();
            }

            return View(reginalSector);
        }

        // GET: ReginalSectors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ReginalSectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReginalSectorId,ReginalSectorName")] ReginalSector reginalSector)
        {
            if (ModelState.IsValid)
            {
                reginalSector.ReginalSectorId = Guid.NewGuid();
                _context.Add(reginalSector);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reginalSector);
        }


        public async Task<IActionResult> Regiondepartmentlist(Guid? id)
        {
            var applicationDbContext = _context.SectrorsDepartment.Where(z => z.DepartmentParentId == id).Where(z => z.DepartmentCategory == DepartmentCategory.ቢሮ);
            return View(await applicationDbContext.ToListAsync());
        }



        // GET: GetDepartmentByReginal ID/5
        public async Task<IActionResult> ReginalDepartment(Guid? id)
        {
            if (id == null || _context.ReginaslSector == null)
            {
                return NotFound();
            }

            var reginalSector = await _context.ReginaslSector.FindAsync(id);
            if (reginalSector == null)
            {
                return NotFound();
            }
            var model = new SectorDepartmentViewModels
            {
                DepartmentParentId = reginalSector.ReginalSectorId,
                DepartmentCategory = DepartmentCategory.ቢሮ                
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Createregdepartment([Bind("SectrorsDepartmentId,DepartmentName,DepartmentParentId,DepartmentCategory")] SectrorsDepartment sectrorsDepartment)
        {
            if (ModelState.IsValid)
            {
                sectrorsDepartment.SectrorsDepartmentId = Guid.NewGuid();
                sectrorsDepartment.DepartmentCategory = DepartmentCategory.ቢሮ;
                _context.Add(sectrorsDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sectrorsDepartment);
        }


        // GET: ReginalSectors/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ReginaslSector == null)
            {
                return NotFound();
            }

            var reginalSector = await _context.ReginaslSector.FindAsync(id);
            if (reginalSector == null)
            {
                return NotFound();
            }
            return View(reginalSector);
        }



        // POST: ReginalSectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ReginalSectorId,ReginalSectorName")] ReginalSector reginalSector)
        {
            if (id != reginalSector.ReginalSectorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reginalSector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReginalSectorExists(reginalSector.ReginalSectorId))
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
            return View(reginalSector);
        }

        // GET: ReginalSectors/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ReginaslSector == null)
            {
                return NotFound();
            }

            var reginalSector = await _context.ReginaslSector
                .FirstOrDefaultAsync(m => m.ReginalSectorId == id);
            if (reginalSector == null)
            {
                return NotFound();
            }

            return View(reginalSector);
        }

        // POST: ReginalSectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ReginaslSector == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ReginaslSector'  is null.");
            }
            var reginalSector = await _context.ReginaslSector.FindAsync(id);
            if (reginalSector != null)
            {
                _context.ReginaslSector.Remove(reginalSector);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReginalSectorExists(Guid id)
        {
          return (_context.ReginaslSector?.Any(e => e.ReginalSectorId == id)).GetValueOrDefault();
        }
    }
}
