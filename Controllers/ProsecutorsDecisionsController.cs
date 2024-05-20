using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models;

namespace ExpertManagmentSystem.Controllers
{
    public class ProsecutorsDecisionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProsecutorsDecisionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProsecutorsDecisions
        public async Task<IActionResult> Index()
        {
              return _context.ProsecutorsDecision != null ? 
                          View(await _context.ProsecutorsDecision.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ProsecutorsDecision'  is null.");
        }

        // GET: ProsecutorsDecisions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ProsecutorsDecision == null)
            {
                return NotFound();
            }

            var prosecutorsDecision = await _context.ProsecutorsDecision
                .FirstOrDefaultAsync(m => m.ProsecutorsDecisionId == id);
            if (prosecutorsDecision == null)
            {
                return NotFound();
            }

            return View(prosecutorsDecision);
        }

        // GET: ProsecutorsDecisions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProsecutorsDecisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProsecutorsDecisionId,DecisionName")] ProsecutorsDecision prosecutorsDecision)
        {
            if (ModelState.IsValid)
            {
                prosecutorsDecision.ProsecutorsDecisionId = Guid.NewGuid();
                _context.Add(prosecutorsDecision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prosecutorsDecision);
        }

        // GET: ProsecutorsDecisions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ProsecutorsDecision == null)
            {
                return NotFound();
            }

            var prosecutorsDecision = await _context.ProsecutorsDecision.FindAsync(id);
            if (prosecutorsDecision == null)
            {
                return NotFound();
            }
            return View(prosecutorsDecision);
        }

        // POST: ProsecutorsDecisions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProsecutorsDecisionId,DecisionName")] ProsecutorsDecision prosecutorsDecision)
        {
            if (id != prosecutorsDecision.ProsecutorsDecisionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prosecutorsDecision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProsecutorsDecisionExists(prosecutorsDecision.ProsecutorsDecisionId))
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
            return View(prosecutorsDecision);
        }

        // GET: ProsecutorsDecisions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ProsecutorsDecision == null)
            {
                return NotFound();
            }

            var prosecutorsDecision = await _context.ProsecutorsDecision
                .FirstOrDefaultAsync(m => m.ProsecutorsDecisionId == id);
            if (prosecutorsDecision == null)
            {
                return NotFound();
            }

            return View(prosecutorsDecision);
        }

        // POST: ProsecutorsDecisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ProsecutorsDecision == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProsecutorsDecision'  is null.");
            }
            var prosecutorsDecision = await _context.ProsecutorsDecision.FindAsync(id);
            if (prosecutorsDecision != null)
            {
                _context.ProsecutorsDecision.Remove(prosecutorsDecision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProsecutorsDecisionExists(Guid id)
        {
          return (_context.ProsecutorsDecision?.Any(e => e.ProsecutorsDecisionId == id)).GetValueOrDefault();
        }
    }
}
