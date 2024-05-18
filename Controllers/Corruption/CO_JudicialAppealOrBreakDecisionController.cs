using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.Corruption;
using ExpertManagmentSystem.ViewModels.CorruptionViewModel;

namespace ExpertManagmentSystem.Controllers.Corruption
{
    public class CO_JudicialAppealOrBreakDecisionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_JudicialAppealOrBreakDecisionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_JudicialAppealOrBreakDecision
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_JudicialAppealOrBreakDecision.Include(c => c.CO_JudicialAppealOrBreak).Include(c => c.CO_JudicialAppealOrBreak.SectrorsDepartment).Where(c => c.CO_JudicialAppealOrBreak.J_AppealOrBreak == J_AppealBreaking.ፍርደኛ_ይግባኝ);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> BreakIndex()
        {
            var applicationDbContext = _context.CO_JudicialAppealOrBreakDecision.Include(c => c.CO_JudicialAppealOrBreak).Include(c => c.CO_JudicialAppealOrBreak.SectrorsDepartment).Where(c => c.CO_JudicialAppealOrBreak.J_AppealOrBreak == J_AppealBreaking.ፍርደኛ_ሰበር);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_JudicialAppealOrBreakDecision/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_JudicialAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            var cO_JudicialAppealOrBreakDecision = await _context.CO_JudicialAppealOrBreakDecision
                .Include(c => c.CO_JudicialAppealOrBreak)
                .FirstOrDefaultAsync(m => m.CO_JudicialAppealOrBreakDecisionId == id);
            if (cO_JudicialAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            return View(cO_JudicialAppealOrBreakDecision);
        }

        // GET: CO_JudicialAppealOrBreakDecision/Create
        public IActionResult Create()
        {
            ViewData["CO_JudicialAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_JudicialAppealOrBreakId", "CO_JudicialAppealOrBreakId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_JudicialAppealOrBreakDecision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CO_JudicialAppealOrBreakViewModel cO_JudicialAppealOrBreakVM, Guid id)
        {
            if (ModelState.IsValid)
            {
                cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakId = id;
                cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakDecisionId = Guid.NewGuid();

                CO_JudicialAppealOrBreakDecision jab = new CO_JudicialAppealOrBreakDecision();
                jab.CO_JudicialAppealOrBreakId = cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakId;
                jab.CO_JudicialAppealOrBreakDecisionId = cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakDecisionId;
                jab.CourtDecision = cO_JudicialAppealOrBreakVM.CourtDecision;
                jab.ExpertOpinion = cO_JudicialAppealOrBreakVM.ExpertOpinion;
                jab.Various = cO_JudicialAppealOrBreakVM.Various;
                jab.NewExisting = cO_JudicialAppealOrBreakVM.NewExisting;
                jab.WinnerLoser = cO_JudicialAppealOrBreakVM.WinnerLoser;
                jab.FederalRequested = cO_JudicialAppealOrBreakVM.FederalRequested;
                jab.SectrorsDepartmentId = cO_JudicialAppealOrBreakVM.SectrorsDepartmentId;
                _context.Add(jab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CO_JudicialAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_JudicialAppealOrBreakId", "CO_JudicialAppealOrBreakId", cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakId);
            return RedirectToAction(nameof(Index));
        }


        // GET: CO_JudicialAppealOrBreakDecision/Create
        public IActionResult BreakCreate()
        {
            ViewData["CO_JudicialAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_JudicialAppealOrBreakId", "CO_JudicialAppealOrBreakId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_JudicialAppealOrBreakDecision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BreakCreate(CO_JudicialAppealOrBreakViewModel cO_JudicialAppealOrBreakVM, Guid id)
        {
            if (ModelState.IsValid)
            {
                cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakId = id;
                cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakDecisionId = Guid.NewGuid();

                CO_JudicialAppealOrBreakDecision jab = new CO_JudicialAppealOrBreakDecision();
                jab.CO_JudicialAppealOrBreakId = cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakId;
                jab.CO_JudicialAppealOrBreakDecisionId = cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakDecisionId;
                jab.CourtDecision = cO_JudicialAppealOrBreakVM.CourtDecision;
                jab.ExpertOpinion = cO_JudicialAppealOrBreakVM.ExpertOpinion;
                jab.Various = cO_JudicialAppealOrBreakVM.Various;
                jab.NewExisting = cO_JudicialAppealOrBreakVM.NewExisting;
                jab.WinnerLoser = cO_JudicialAppealOrBreakVM.WinnerLoser;
                jab.FederalRequested = cO_JudicialAppealOrBreakVM.FederalRequested;
                jab.SectrorsDepartmentId = cO_JudicialAppealOrBreakVM.SectrorsDepartmentId;
                _context.Add(jab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CO_JudicialAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_JudicialAppealOrBreakId", "CO_JudicialAppealOrBreakId", cO_JudicialAppealOrBreakVM.CO_JudicialAppealOrBreakId);
            return RedirectToAction(nameof(Index));
        }

        // GET: CO_JudicialAppealOrBreakDecision/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_JudicialAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            var cO_JudicialAppealOrBreakDecision = await _context.CO_JudicialAppealOrBreakDecision.FindAsync(id);
            if (cO_JudicialAppealOrBreakDecision == null)
            {
                return NotFound();
            }
            ViewData["CO_JudicialAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_JudicialAppealOrBreakId", "CO_JudicialAppealOrBreakId", cO_JudicialAppealOrBreakDecision.CO_JudicialAppealOrBreakId);
            return View(cO_JudicialAppealOrBreakDecision);
        }

        // POST: CO_JudicialAppealOrBreakDecision/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_JudicialAppealOrBreakDecisionId,CO_JudicialAppealOrBreakId,CourtDecision,ExpertOpinion,Various,NewExisting,WinnerLoser,FederalRequested,SectrorsDepartmentId")] CO_JudicialAppealOrBreakDecision cO_JudicialAppealOrBreakDecision)
        {
            if (id != cO_JudicialAppealOrBreakDecision.CO_JudicialAppealOrBreakDecisionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_JudicialAppealOrBreakDecision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_JudicialAppealOrBreakDecisionExists(cO_JudicialAppealOrBreakDecision.CO_JudicialAppealOrBreakDecisionId))
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
            ViewData["CO_JudicialAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_JudicialAppealOrBreakId", "CO_JudicialAppealOrBreakId", cO_JudicialAppealOrBreakDecision.CO_JudicialAppealOrBreakId);
            return View(cO_JudicialAppealOrBreakDecision);
        }

        // GET: CO_JudicialAppealOrBreakDecision/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_JudicialAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            var cO_JudicialAppealOrBreakDecision = await _context.CO_JudicialAppealOrBreakDecision
                .Include(c => c.CO_JudicialAppealOrBreak)
                .FirstOrDefaultAsync(m => m.CO_JudicialAppealOrBreakDecisionId == id);
            if (cO_JudicialAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            return View(cO_JudicialAppealOrBreakDecision);
        }

        // POST: CO_JudicialAppealOrBreakDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_JudicialAppealOrBreakDecision == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_JudicialAppealOrBreakDecision'  is null.");
            }
            var cO_JudicialAppealOrBreakDecision = await _context.CO_JudicialAppealOrBreakDecision.FindAsync(id);
            if (cO_JudicialAppealOrBreakDecision != null)
            {
                _context.CO_JudicialAppealOrBreakDecision.Remove(cO_JudicialAppealOrBreakDecision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_JudicialAppealOrBreakDecisionExists(Guid id)
        {
          return (_context.CO_JudicialAppealOrBreakDecision?.Any(e => e.CO_JudicialAppealOrBreakDecisionId == id)).GetValueOrDefault();
        }
    }
}
