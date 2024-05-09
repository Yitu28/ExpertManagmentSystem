using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.Corruption;

namespace ExpertManagmentSystem.Controllers
{
    public class CO_CorruptionChargeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_CorruptionChargeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_CorruptionCharge
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_CorruptionCharge.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_CorruptionCharge/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_CorruptionCharge == null)
            {
                return NotFound();
            }

            var cO_CorruptionCharge = await _context.CO_CorruptionCharge
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_CorruptionChargeId == id);
            if (cO_CorruptionCharge == null)
            {
                return NotFound();
            }

            return View(cO_CorruptionCharge);
        }

        // GET: CO_CorruptionCharge/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_CorruptionCharge/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_CorruptionChargeId,prosecutorNo,InvestigationNo,DecisionType,DefendentName,Gender,Amount,DefendantJob,CrimeType,OpeningDate,InvestigationApproved,Remark,SectrorsDepartmentId")] CO_CorruptionCharge cO_CorruptionCharge)
        {
            if (ModelState.IsValid)
            {
                cO_CorruptionCharge.CO_CorruptionChargeId = Guid.NewGuid();
                _context.Add(cO_CorruptionCharge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_CorruptionCharge.SectrorsDepartmentId);
            return View(cO_CorruptionCharge);
        }

        // GET: CO_CorruptionCharge/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_CorruptionCharge == null)
            {
                return NotFound();
            }

            var cO_CorruptionCharge = await _context.CO_CorruptionCharge.FindAsync(id);
            if (cO_CorruptionCharge == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_CorruptionCharge.SectrorsDepartmentId);
            return View(cO_CorruptionCharge);
        }

        // POST: CO_CorruptionCharge/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_CorruptionChargeId,prosecutorNo,InvestigationNo,DecisionType,DefendentName,Gender,Amount,DefendantJob,CrimeType,OpeningDate,InvestigationApproved,Remark,SectrorsDepartmentId")] CO_CorruptionCharge cO_CorruptionCharge)
        {
            if (id != cO_CorruptionCharge.CO_CorruptionChargeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_CorruptionCharge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_CorruptionChargeExists(cO_CorruptionCharge.CO_CorruptionChargeId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_CorruptionCharge.SectrorsDepartmentId);
            return View(cO_CorruptionCharge);
        }

        // GET: CO_CorruptionCharge/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_CorruptionCharge == null)
            {
                return NotFound();
            }

            var cO_CorruptionCharge = await _context.CO_CorruptionCharge
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_CorruptionChargeId == id);
            if (cO_CorruptionCharge == null)
            {
                return NotFound();
            }

            return View(cO_CorruptionCharge);
        }

        // POST: CO_CorruptionCharge/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_CorruptionCharge == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_CorruptionCharge'  is null.");
            }
            var cO_CorruptionCharge = await _context.CO_CorruptionCharge.FindAsync(id);
            if (cO_CorruptionCharge != null)
            {
                _context.CO_CorruptionCharge.Remove(cO_CorruptionCharge);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_CorruptionChargeExists(Guid id)
        {
          return (_context.CO_CorruptionCharge?.Any(e => e.CO_CorruptionChargeId == id)).GetValueOrDefault();
        }
    }
}
