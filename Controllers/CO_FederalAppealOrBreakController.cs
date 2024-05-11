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
    public class CO_FederalAppealOrBreakController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_FederalAppealOrBreakController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_FederalAppealOrBreak
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_FederalAppealOrBreak.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_FederalAppealOrBreak/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_FederalAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_FederalAppealOrBreak = await _context.CO_FederalAppealOrBreak
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_FederalAppealId == id);
            if (cO_FederalAppealOrBreak == null)
            {
                return NotFound();
            }

            return View(cO_FederalAppealOrBreak);
        }


        // GET: CO_FederalAppealOrBreak/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_FederalAppealOrBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_FederalAppealId,ProsecutorNo,SupremCourtNo,CourtNo,Appellant,Answerer,OpeningDate,Gender,Amount,Appointment,CrimeType,Remark,F_AppealOrBreak,SectrorsDepartmentId")] CO_FederalAppealOrBreak cO_FederalAppealOrBreak)
        {
            if (ModelState.IsValid)
            {
                cO_FederalAppealOrBreak.CO_FederalAppealId = Guid.NewGuid();
                cO_FederalAppealOrBreak.F_AppealOrBreak = AppealBreaking.ሰበር;
                _context.Add(cO_FederalAppealOrBreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FederalAppealOrBreak.SectrorsDepartmentId);
            return View(cO_FederalAppealOrBreak);
        }


        // GET: CO_FederalAppealOrBreak/Create
        public IActionResult FederalAppealCreate()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_FederalAppealOrBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FederalAppealCreate([Bind("CO_FederalAppealId,ProsecutorNo,SupremCourtNo,CourtNo,Appellant,Answerer,OpeningDate,Gender,Amount,Appointment,CrimeType,Remark,F_AppealOrBreak,SectrorsDepartmentId")] CO_FederalAppealOrBreak cO_FederalAppealOrBreak)
        {
            if (ModelState.IsValid)
            {
                cO_FederalAppealOrBreak.CO_FederalAppealId = Guid.NewGuid();
                cO_FederalAppealOrBreak.F_AppealOrBreak = AppealBreaking.ይግባኝ;
                _context.Add(cO_FederalAppealOrBreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FederalAppealOrBreak.SectrorsDepartmentId);
            return View(cO_FederalAppealOrBreak);
        }

        // GET: CO_FederalAppealOrBreak/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_FederalAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_FederalAppealOrBreak = await _context.CO_FederalAppealOrBreak.FindAsync(id);
            if (cO_FederalAppealOrBreak == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FederalAppealOrBreak.SectrorsDepartmentId);
            return View(cO_FederalAppealOrBreak);
        }

        // POST: CO_FederalAppealOrBreak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_FederalAppealId,ProsecutorNo,SupremCourtNo,CourtNo,Appellant,Answerer,OpeningDate,Gender,Amount,Appointment,CrimeType,Remark,F_AppealOrBreak,SectrorsDepartmentId")] CO_FederalAppealOrBreak cO_FederalAppealOrBreak)
        {
            if (id != cO_FederalAppealOrBreak.CO_FederalAppealId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_FederalAppealOrBreak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_FederalAppealOrBreakExists(cO_FederalAppealOrBreak.CO_FederalAppealId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FederalAppealOrBreak.SectrorsDepartmentId);
            return View(cO_FederalAppealOrBreak);
        }

        // GET: CO_FederalAppealOrBreak/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_FederalAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_FederalAppealOrBreak = await _context.CO_FederalAppealOrBreak
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_FederalAppealId == id);
            if (cO_FederalAppealOrBreak == null)
            {
                return NotFound();
            }

            return View(cO_FederalAppealOrBreak);
        }

        // POST: CO_FederalAppealOrBreak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_FederalAppealOrBreak == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_FederalAppealOrBreak'  is null.");
            }
            var cO_FederalAppealOrBreak = await _context.CO_FederalAppealOrBreak.FindAsync(id);
            if (cO_FederalAppealOrBreak != null)
            {
                _context.CO_FederalAppealOrBreak.Remove(cO_FederalAppealOrBreak);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_FederalAppealOrBreakExists(Guid id)
        {
          return (_context.CO_FederalAppealOrBreak?.Any(e => e.CO_FederalAppealId == id)).GetValueOrDefault();
        }
    }
}
