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
    public class WoredaSectorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WoredaSectorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WoredaSectors
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WoredaSectors.Include(w => w.ZonalSectors);
            return View(await applicationDbContext.ToListAsync());
        }


        public async Task<IActionResult> Woredadepartmentlist(Guid? id)
        {
            var applicationDbContext = _context.SectrorsDepartment.Where(z => z.DepartmentParentId == id).Where(z => z.DepartmentCategory == DepartmentCategory.ጽህፈት_ቤት);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: GetDepartmentByReginal ID/5
        public async Task<IActionResult> Woredadepartment(Guid? id)
        {
            if (id == null || _context.WoredaSectors == null)
            {
                return NotFound();
            }

            var woredaSector = await _context.WoredaSectors.FindAsync(id);
            if (woredaSector == null)
            {
                return NotFound();
            }
            var model = new SectorDepartmentViewModels
            {
                DepartmentParentId = woredaSector.WoredaSectorsId,
                DepartmentCategory = DepartmentCategory.ጽህፈት_ቤት

            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateWoredadepartment([Bind("SectrorsDepartmentId,DepartmentName,DepartmentParentId,DepartmentCategory")] SectrorsDepartment sectrorsDepartment)
        {
            if (ModelState.IsValid)
            {
                sectrorsDepartment.DepartmentCategory = DepartmentCategory.ጽህፈት_ቤት;
                sectrorsDepartment.SectrorsDepartmentId = Guid.NewGuid();
                _context.Add(sectrorsDepartment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sectrorsDepartment);
        }



        // GET: WoredaSectors/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.WoredaSectors == null)
            {
                return NotFound();
            }

            var woredaSectors = await _context.WoredaSectors
                .Include(w => w.ZonalSectors)
                .FirstOrDefaultAsync(m => m.WoredaSectorsId == id);
            if (woredaSectors == null)
            {
                return NotFound();
            }

            return View(woredaSectors);
        }

        // GET: WoredaSectors/Create
        public IActionResult Create()
        {
            ViewData["ZonalSectorsId"] = new SelectList(_context.ZonalSectors, "ZonalSectorId", "ZonalSectorName");
            return View();
        }

        // POST: WoredaSectors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WoredaSectorsId,WoredaSectorsName,ZonalSectorsId")] WoredaSectors woredaSectors)
        {
            if (!ModelState.IsValid)
            {
                woredaSectors.WoredaSectorsId = Guid.NewGuid();
                _context.Add(woredaSectors);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ZonalSectorsId"] = new SelectList(_context.ZonalSectors, "ZonalSectorId", "ZonalSectorId", woredaSectors.ZonalSectorsId);
            return View(woredaSectors);
        }

        // GET: WoredaSectors/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.WoredaSectors == null)
            {
                return NotFound();
            }

            var woredaSectors = await _context.WoredaSectors.FindAsync(id);
            if (woredaSectors == null)
            {
                return NotFound();
            }
            ViewData["ZonalSectorsId"] = new SelectList(_context.ZonalSectors, "ZonalSectorId", "ZonalSectorName", woredaSectors.ZonalSectorsId);
            return View(woredaSectors);
        }

        // POST: WoredaSectors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("WoredaSectorsId,WoredaSectorsName,ZonalSectorsId")] WoredaSectors woredaSectors)
        {
            if (id != woredaSectors.WoredaSectorsId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(woredaSectors);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WoredaSectorsExists(woredaSectors.WoredaSectorsId))
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
            ViewData["ZonalSectorsId"] = new SelectList(_context.ZonalSectors, "ZonalSectorId", "ZonalSectorId", woredaSectors.ZonalSectorsId);
            return View(woredaSectors);
        }

        // GET: WoredaSectors/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.WoredaSectors == null)
            {
                return NotFound();
            }

            var woredaSectors = await _context.WoredaSectors
                .Include(w => w.ZonalSectors)
                .FirstOrDefaultAsync(m => m.WoredaSectorsId == id);
            if (woredaSectors == null)
            {
                return NotFound();
            }

            return View(woredaSectors);
        }

        // POST: WoredaSectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.WoredaSectors == null)
            {
                return Problem("Entity set 'ApplicationDbContext.WoredaSectors'  is null.");
            }
            var woredaSectors = await _context.WoredaSectors.FindAsync(id);
            if (woredaSectors != null)
            {
                _context.WoredaSectors.Remove(woredaSectors);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WoredaSectorsExists(Guid id)
        {
          return (_context.WoredaSectors?.Any(e => e.WoredaSectorsId == id)).GetValueOrDefault();
        }
    }
}
