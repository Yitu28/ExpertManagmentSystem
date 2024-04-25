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

namespace ExpertManagmentSystem.Controllers
{
    public class ZonalSectorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ZonalSectorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ZonalSectors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ZonalSectors.Include(z => z.ReginalSector);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult>Zonedepartmentlist(Guid? id)
        {
            var applicationDbContext = _context.SectrorsDepartment.Where(z => z.DepartmentParentId == id).Where(z => z.DepartmentCategory == DepartmentCategory.መምሪያ);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: GetDepartmentByZonal ID/5
        public async Task<IActionResult> ZonalDepartment(Guid? id)
        {
            if (id == null || _context.ZonalSectors == null)
            {
                return NotFound();
            }

            var zonalSector = await _context.ZonalSectors.FindAsync(id);
            if (zonalSector == null)
            {
                return NotFound();
            }
            var model = new SectorDepartmentViewModels
            {
                DepartmentParentId = zonalSector.ZonalSectorId,
                DepartmentCategory = DepartmentCategory.መምሪያ
            };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Createzonedepartment([Bind("SectrorsDepartmentId,DepartmentName,DepartmentParentId,DepartmentCategory")] SectrorsDepartment sectrorsDepartment)
        {
            if (ModelState.IsValid)
            {
                sectrorsDepartment.SectrorsDepartmentId = Guid.NewGuid();
                sectrorsDepartment.DepartmentCategory = DepartmentCategory.መምሪያ;
                _context.Add(sectrorsDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sectrorsDepartment);
        }

        // GET: ZonalSectors/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ZonalSectors == null)
            {
                return NotFound();
            }

            var zonalSectors = await _context.ZonalSectors
                .Include(z => z.ReginalSector)
                .FirstOrDefaultAsync(m => m.ZonalSectorId == id);
            if (zonalSectors == null)
            {
                return NotFound();
            }

            return View(zonalSectors);
        }

        // GET: ZonalSectors/Create
        public IActionResult Create()
        {
            ViewData["ReginalSectorId"] = new SelectList(_context.ReginaslSector, "ReginalSectorId", "ReginalSectorName");
            return View();
        }

        // POST: ZonalSectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZonalSectorId,ZonalSectorName,ReginalSectorId")] ZonalSectors zonalSectors)
        {
            if (!ModelState.IsValid)
            {
                zonalSectors.ZonalSectorId = Guid.NewGuid();
                _context.Add(zonalSectors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ReginalSectorId"] = new SelectList(_context.ReginaslSector, "ReginalSectorId", "ReginalSectorId", zonalSectors.ReginalSectorId);
            return View(zonalSectors);
        }

        // GET: ZonalSectors/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ZonalSectors == null)
            {
                return NotFound();
            }

            var zonalSectors = await _context.ZonalSectors.FindAsync(id);
            if (zonalSectors == null)
            {
                return NotFound();
            }
            ViewData["ReginalSectorId"] = new SelectList(_context.ReginaslSector, "ReginalSectorId", "ReginalSectorName", zonalSectors.ReginalSectorId);
            return View(zonalSectors);
        }

        // POST: ZonalSectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ZonalSectorId,ZonalSectorName,ReginalSectorId")] ZonalSectors zonalSectors)
        {
            if (id != zonalSectors.ZonalSectorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zonalSectors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZonalSectorsExists(zonalSectors.ZonalSectorId))
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
            ViewData["ReginalSectorId"] = new SelectList(_context.ReginaslSector, "ReginalSectorId", "ReginalSectorId", zonalSectors.ReginalSectorId);
            return View(zonalSectors);
        }

        // GET: ZonalSectors/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ZonalSectors == null)
            {
                return NotFound();
            }

            var zonalSectors = await _context.ZonalSectors
                .Include(z => z.ReginalSector)
                .FirstOrDefaultAsync(m => m.ZonalSectorId == id);
            if (zonalSectors == null)
            {
                return NotFound();
            }

            return View(zonalSectors);
        }

        // POST: ZonalSectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ZonalSectors == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ZonalSectors'  is null.");
            }
            var zonalSectors = await _context.ZonalSectors.FindAsync(id);
            if (zonalSectors != null)
            {
                _context.ZonalSectors.Remove(zonalSectors);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZonalSectorsExists(Guid id)
        {
          return (_context.ZonalSectors?.Any(e => e.ZonalSectorId == id)).GetValueOrDefault();
        }
    }
}
