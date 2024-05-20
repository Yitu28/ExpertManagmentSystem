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
    public class CO_ProsecutorAppealOrBreakDecisionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_ProsecutorAppealOrBreakDecisionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_ProsecutorAppealOrBreakDecision
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_ProsecutorAppealOrBreakDecision.Include(c => c.CO_ProsecutorAppealOrBreak.Cr_Crime_Type).Include(c => c.CO_ProsecutorAppealOrBreak.SectrorsDepartment).Where(c => c.CO_ProsecutorAppealOrBreak.F_AppealOrBreak == AppealBreaking.ዐቃቤ_ህግ_ግባኝ);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_ProsecutorAppealOrBreak
        public async Task<IActionResult> BreakIndex()
        {
            var applicationDbContext = _context.CO_ProsecutorAppealOrBreakDecision.Include(c => c.CO_ProsecutorAppealOrBreak.Cr_Crime_Type).Include(c => c.CO_ProsecutorAppealOrBreak.SectrorsDepartment).Where(c => c.CO_ProsecutorAppealOrBreak.F_AppealOrBreak == AppealBreaking.ዐቃቤ_ህግ_ሰበር);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_ProsecutorAppealOrBreakDecision/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_ProsecutorAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            var cO_ProsecutorAppealOrBreakDecision = await _context.CO_ProsecutorAppealOrBreakDecision
                .FirstOrDefaultAsync(m => m.CO_ProsecutorAppealOrBreakDecisionId == id);
            if (cO_ProsecutorAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            return View(cO_ProsecutorAppealOrBreakDecision);
        }

        // GET: CO_ProsecutorAppealOrBreakDecision/Create
        public IActionResult Create()
        {
            ViewData["CO_ProsecutorAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_ProsecutorAppealOrBreakId", "CO_ProsecutorAppealOrBreakId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_ProsecutorAppealOrBreakDecision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CO_ProsecutorAppealOrBreakViewModel cO_ProsecutorAppealOrBreakVM, Guid id)
        {
            if (ModelState.IsValid)
            {
                cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakId = id;
                cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakDecisionId = Guid.NewGuid();

                CO_ProsecutorAppealOrBreakDecision pab = new CO_ProsecutorAppealOrBreakDecision();
                pab.CO_ProsecutorAppealOrBreakId = cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakId;
                pab.CO_ProsecutorAppealOrBreakDecisionId = cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakDecisionId;
                pab.CourtDecision = cO_ProsecutorAppealOrBreakVM.CourtDecision;
                pab.ExpertOpinion = cO_ProsecutorAppealOrBreakVM.ExpertOpinion;
                pab.Various = cO_ProsecutorAppealOrBreakVM.Various;
                pab.NewExisting = cO_ProsecutorAppealOrBreakVM.NewExisting;
                pab.WinnerLoser = cO_ProsecutorAppealOrBreakVM.WinnerLoser;
                pab.FederalRequested = cO_ProsecutorAppealOrBreakVM.FederalRequested;
                pab.SectrorsDepartmentId = cO_ProsecutorAppealOrBreakVM.SectrorsDepartmentId;
                _context.Add(pab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CO_ProsecutorAppealOrBreakId"] = new SelectList(_context.CO_ProsecutorAppealOrBreak, "CO_ProsecutorAppealOrBreakId", "CO_ProsecutorAppealOrBreakId", cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakId);

            return RedirectToAction(nameof(Index));
        }

        // GET: CO_ProsecutorAppealOrBreakDecision/Create
        public IActionResult BreakCreate()
        {
            ViewData["CO_ProsecutorAppealOrBreakId"] = new SelectList(_context.CO_JudicialAppealOrBreak, "CO_ProsecutorAppealOrBreakId", "CO_ProsecutorAppealOrBreakId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_ProsecutorAppealOrBreakDecision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BreakCreate(CO_ProsecutorAppealOrBreakViewModel cO_ProsecutorAppealOrBreakVM, Guid id)
        {
            if (ModelState.IsValid)
            {
                cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakId = id;
                cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakDecisionId = Guid.NewGuid();

                CO_ProsecutorAppealOrBreakDecision pab = new CO_ProsecutorAppealOrBreakDecision();
                pab.CO_ProsecutorAppealOrBreakId = cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakId;
                pab.CO_ProsecutorAppealOrBreakDecisionId = cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakDecisionId;
                pab.CourtDecision = cO_ProsecutorAppealOrBreakVM.CourtDecision;
                pab.ExpertOpinion = cO_ProsecutorAppealOrBreakVM.ExpertOpinion;
                pab.Various = cO_ProsecutorAppealOrBreakVM.Various;
                pab.NewExisting = cO_ProsecutorAppealOrBreakVM.NewExisting;
                pab.WinnerLoser = cO_ProsecutorAppealOrBreakVM.WinnerLoser;
                pab.FederalRequested = cO_ProsecutorAppealOrBreakVM.FederalRequested;
                pab.SectrorsDepartmentId = cO_ProsecutorAppealOrBreakVM.SectrorsDepartmentId;
                _context.Add(pab);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CO_ProsecutorAppealOrBreakId"] = new SelectList(_context.CO_ProsecutorAppealOrBreak, "CO_ProsecutorAppealOrBreakId", "CO_ProsecutorAppealOrBreakId", cO_ProsecutorAppealOrBreakVM.CO_ProsecutorAppealOrBreakId);

            return RedirectToAction(nameof(Index));
        }
        // GET: CO_ProsecutorAppealOrBreakDecision/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_ProsecutorAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            var cO_ProsecutorAppealOrBreakDecision = await _context.CO_ProsecutorAppealOrBreakDecision.FindAsync(id);
            if (cO_ProsecutorAppealOrBreakDecision == null)
            {
                return NotFound();
            }
            return View(cO_ProsecutorAppealOrBreakDecision);
        }

        // POST: CO_ProsecutorAppealOrBreakDecision/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_ProsecutorAppealOrBreakDecisionId,CO_ProsecutorAppealOrBreakId,F_AppealOrBreak,ExpertOpinion,Various,NewExisting,WinnerLoser,FederalRequested,SectrorsDepartmentId")] CO_ProsecutorAppealOrBreakDecision cO_ProsecutorAppealOrBreakDecision)
        {
            if (id != cO_ProsecutorAppealOrBreakDecision.CO_ProsecutorAppealOrBreakDecisionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_ProsecutorAppealOrBreakDecision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_ProsecutorAppealOrBreakDecisionExists(cO_ProsecutorAppealOrBreakDecision.CO_ProsecutorAppealOrBreakDecisionId))
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
            return View(cO_ProsecutorAppealOrBreakDecision);
        }

        // GET: CO_ProsecutorAppealOrBreakDecision/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_ProsecutorAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            var cO_ProsecutorAppealOrBreakDecision = await _context.CO_ProsecutorAppealOrBreakDecision
                .FirstOrDefaultAsync(m => m.CO_ProsecutorAppealOrBreakDecisionId == id);
            if (cO_ProsecutorAppealOrBreakDecision == null)
            {
                return NotFound();
            }

            return View(cO_ProsecutorAppealOrBreakDecision);
        }

        // POST: CO_ProsecutorAppealOrBreakDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_ProsecutorAppealOrBreakDecision == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_ProsecutorAppealOrBreakDecision'  is null.");
            }
            var cO_ProsecutorAppealOrBreakDecision = await _context.CO_ProsecutorAppealOrBreakDecision.FindAsync(id);
            if (cO_ProsecutorAppealOrBreakDecision != null)
            {
                _context.CO_ProsecutorAppealOrBreakDecision.Remove(cO_ProsecutorAppealOrBreakDecision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_ProsecutorAppealOrBreakDecisionExists(Guid id)
        {
          return (_context.CO_ProsecutorAppealOrBreakDecision?.Any(e => e.CO_ProsecutorAppealOrBreakDecisionId == id)).GetValueOrDefault();
        }
    }
}
