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
    public class CO_RegionalBreakAppealController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_RegionalBreakAppealController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_RegionalBreakAppeal
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_RegionalBreakAppeal.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_RegionalBreakAppeal/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_RegionalBreakAppeal == null)
            {
                return NotFound();
            }

            var cO_RegionalBreakAppeal = await _context.CO_RegionalBreakAppeal
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_RegionalBreakAppealId == id);
            if (cO_RegionalBreakAppeal == null)
            {
                return NotFound();
            }

            return View(cO_RegionalBreakAppeal);
        }

        // GET: CO_RegionalBreakAppeal/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_RegionalBreakAppeal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_RegionalBreakAppealId,CourtNo,Appellant,Answerer,CO_CrimeType,Reasons,OpeningDate,Gender,Amount,Address,Remark,R_BreakingOrAppeal,SectrorsDepartmentId")] CO_RegionalBreakAppeal cO_RegionalBreakAppeal)
        {
            if (ModelState.IsValid)
            {
                cO_RegionalBreakAppeal.CO_RegionalBreakAppealId = Guid.NewGuid();
                cO_RegionalBreakAppeal.R_BreakingOrAppeal = AppealOrBreak.ሰበርይግባኝ;
                _context.Add(cO_RegionalBreakAppeal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_RegionalBreakAppeal.SectrorsDepartmentId);
            return View(cO_RegionalBreakAppeal);
        }

        // GET: CO_RegionalBreakAppeal/Create
        public IActionResult RegionalAppealCreate()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_RegionalBreakAppeal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegionalAppealCreate([Bind("CO_RegionalBreakAppealId,CourtNo,Appellant,Answerer,CO_CrimeType,Reasons,OpeningDate,Gender,Amount,Address,Remark,R_BreakingOrAppeal,SectrorsDepartmentId")] CO_RegionalBreakAppeal cO_RegionalBreakAppeal)
        {
            if (ModelState.IsValid)
            {

                cO_RegionalBreakAppeal.CO_RegionalBreakAppealId = Guid.NewGuid();
                cO_RegionalBreakAppeal.R_BreakingOrAppeal = AppealOrBreak.ይግባኝ;
                _context.Add(cO_RegionalBreakAppeal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_RegionalBreakAppeal.SectrorsDepartmentId);
            return View(cO_RegionalBreakAppeal);
        }

        // GET: CO_RegionalBreakAppeal/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_RegionalBreakAppeal == null)
            {
                return NotFound();
            }

            var cO_RegionalBreakAppeal = await _context.CO_RegionalBreakAppeal.FindAsync(id);
            if (cO_RegionalBreakAppeal == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_RegionalBreakAppeal.SectrorsDepartmentId);
            return View(cO_RegionalBreakAppeal);
        }

        // POST: CO_RegionalBreakAppeal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_RegionalBreakAppealId,CourtNo,Appellant,Answerer,CO_CrimeType,Reasons,OpeningDate,Gender,Amount,Address,Remark,R_BreakingOrAppeal,SectrorsDepartmentId")] CO_RegionalBreakAppeal cO_RegionalBreakAppeal)
        {
            if (id != cO_RegionalBreakAppeal.CO_RegionalBreakAppealId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_RegionalBreakAppeal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_RegionalBreakAppealExists(cO_RegionalBreakAppeal.CO_RegionalBreakAppealId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_RegionalBreakAppeal.SectrorsDepartmentId);
            return View(cO_RegionalBreakAppeal);
        }

        // GET: CO_RegionalBreakAppeal/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_RegionalBreakAppeal == null)
            {
                return NotFound();
            }

            var cO_RegionalBreakAppeal = await _context.CO_RegionalBreakAppeal
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_RegionalBreakAppealId == id);
            if (cO_RegionalBreakAppeal == null)
            {
                return NotFound();
            }

            return View(cO_RegionalBreakAppeal);
        }

        // POST: CO_RegionalBreakAppeal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_RegionalBreakAppeal == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_RegionalBreakAppeal'  is null.");
            }
            var cO_RegionalBreakAppeal = await _context.CO_RegionalBreakAppeal.FindAsync(id);
            if (cO_RegionalBreakAppeal != null)
            {
                _context.CO_RegionalBreakAppeal.Remove(cO_RegionalBreakAppeal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_RegionalBreakAppealExists(Guid id)
        {
          return (_context.CO_RegionalBreakAppeal?.Any(e => e.CO_RegionalBreakAppealId == id)).GetValueOrDefault();
        }
    }
}
