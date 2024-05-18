using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.Corruption;
using ExpertManagmentSystem.ViewModels.CorruptionViewModel;

namespace ExpertManagmentSystem.Controllers.Corruption
{
    public class CO_CorruptionCourtDecisionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_CorruptionCourtDecisionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_CorruptionCourtDecision
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_CorruptionCourtDecision.Include(c => c.CO_CorruptionCarge).Include(c => c.CourtsDecision).Include(c => c.CO_CorruptionCarge.ProsecutorsDecision);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_CorruptionCourtDecision/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_CorruptionCourtDecision == null)
            {
                return NotFound();
            }

            var cO_CorruptionCourtDecision = await _context.CO_CorruptionCourtDecision
                .Include(c => c.CO_CorruptionCarge)
                .Include(c => c.CourtsDecision)
                .FirstOrDefaultAsync(m => m.CO_CorruptionCourtDecisionId == id);
            if (cO_CorruptionCourtDecision == null)
            {
                return NotFound();
            }

            return View(cO_CorruptionCourtDecision);
        }

        // GET: CO_CorruptionCourtDecision/Create
        public IActionResult Create()
        {
            ViewData["CO_CorruptionChargeId"] = new SelectList(_context.CO_CorruptionCharge, "CO_CorruptionChargeId", "CO_CorruptionChargeId");
            ViewData["CourtsDecisionId"] = new SelectList(_context.CourtsDecision, "CourtsDecisionId", "DecisionName");
            return View();
        }

        // POST: CO_CorruptionCourtDecision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CO_CorruptionProsecutorViewModel cO_CorruptionProsecutorVM, Guid id)
        {
            if (ModelState.IsValid)
            {
                cO_CorruptionProsecutorVM.CO_CorruptionChargeId = id;
                cO_CorruptionProsecutorVM.CO_CorruptionCourtDecisionId = Guid.NewGuid();
                CO_CorruptionCourtDecision ccd = new CO_CorruptionCourtDecision();
                ccd.CO_CorruptionChargeId = cO_CorruptionProsecutorVM.CO_CorruptionChargeId;
                ccd.CO_CorruptionCourtDecisionId = cO_CorruptionProsecutorVM.CO_CorruptionCourtDecisionId;
                ccd.CourtsDecisionId=cO_CorruptionProsecutorVM.CourtsDecisionId;

                _context.Add(ccd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CO_CorruptionChargeId"] = new SelectList(_context.CO_CorruptionCharge, "CO_CorruptionChargeId", "CO_CorruptionChargeId", cO_CorruptionProsecutorVM.CO_CorruptionChargeId);
            ViewData["CourtsDecisionId"] = new SelectList(_context.CourtsDecision, "CourtsDecisionId", "CourtsDecisionId", cO_CorruptionProsecutorVM.CourtsDecisionId);
            return RedirectToAction(nameof(Index));



        }

        // GET: CO_CorruptionCourtDecision/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_CorruptionCourtDecision == null)
            {
                return NotFound();
            }

            var cO_CorruptionCourtDecision = await _context.CO_CorruptionCourtDecision.FindAsync(id);
            if (cO_CorruptionCourtDecision == null)
            {
                return NotFound();
            }
            ViewData["CO_CorruptionChargeId"] = new SelectList(_context.CO_CorruptionCharge, "CO_CorruptionChargeId", "CO_CorruptionChargeId", cO_CorruptionCourtDecision.CO_CorruptionChargeId);
            ViewData["CourtsDecisionId"] = new SelectList(_context.CourtsDecision, "CourtsDecisionId", "CourtsDecisionId", cO_CorruptionCourtDecision.CourtsDecisionId);
            return View(cO_CorruptionCourtDecision);
        }

        // POST: CO_CorruptionCourtDecision/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_CorruptionCourtDecisionId,CO_CorruptionChargeId,CourtsDecisionId")] CO_CorruptionCourtDecision cO_CorruptionCourtDecision)
        {
            if (id != cO_CorruptionCourtDecision.CO_CorruptionCourtDecisionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_CorruptionCourtDecision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_CorruptionCourtDecisionExists(cO_CorruptionCourtDecision.CO_CorruptionCourtDecisionId))
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
            ViewData["CO_CorruptionChargeId"] = new SelectList(_context.CO_CorruptionCharge, "CO_CorruptionChargeId", "CO_CorruptionChargeId", cO_CorruptionCourtDecision.CO_CorruptionChargeId);
            ViewData["CourtsDecisionId"] = new SelectList(_context.CourtsDecision, "CourtsDecisionId", "CourtsDecisionId", cO_CorruptionCourtDecision.CourtsDecisionId);
            return View(cO_CorruptionCourtDecision);
        }

        // GET: CO_CorruptionCourtDecision/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_CorruptionCourtDecision == null)
            {
                return NotFound();
            }

            var cO_CorruptionCourtDecision = await _context.CO_CorruptionCourtDecision
                .Include(c => c.CO_CorruptionCarge)
                .Include(c => c.CourtsDecision)
                .FirstOrDefaultAsync(m => m.CO_CorruptionCourtDecisionId == id);
            if (cO_CorruptionCourtDecision == null)
            {
                return NotFound();
            }

            return View(cO_CorruptionCourtDecision);
        }

        // POST: CO_CorruptionCourtDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_CorruptionCourtDecision == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_CorruptionCourtDecision'  is null.");
            }
            var cO_CorruptionCourtDecision = await _context.CO_CorruptionCourtDecision.FindAsync(id);
            if (cO_CorruptionCourtDecision != null)
            {
                _context.CO_CorruptionCourtDecision.Remove(cO_CorruptionCourtDecision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_CorruptionCourtDecisionExists(Guid id)
        {
          return (_context.CO_CorruptionCourtDecision?.Any(e => e.CO_CorruptionCourtDecisionId == id)).GetValueOrDefault();
        }
    }
}
