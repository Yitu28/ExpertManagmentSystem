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
    public class CourtsDecisionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourtsDecisionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CourtsDecisions
        public async Task<IActionResult> Index()
        {
              return _context.CourtsDecision != null ? 
                          View(await _context.CourtsDecision.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CourtsDecision'  is null.");
        }

        // GET: CourtsDecisions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CourtsDecision == null)
            {
                return NotFound();
            }

            var courtsDecision = await _context.CourtsDecision
                .FirstOrDefaultAsync(m => m.CourtsDecisionId == id);
            if (courtsDecision == null)
            {
                return NotFound();
            }

            return View(courtsDecision);
        }

        // GET: CourtsDecisions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourtsDecisions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourtsDecisionId,DecisionName")] CourtsDecision courtsDecision)
        {
            if (ModelState.IsValid)
            {
                courtsDecision.CourtsDecisionId = Guid.NewGuid();
                _context.Add(courtsDecision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courtsDecision);
        }

        // GET: CourtsDecisions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CourtsDecision == null)
            {
                return NotFound();
            }

            var courtsDecision = await _context.CourtsDecision.FindAsync(id);
            if (courtsDecision == null)
            {
                return NotFound();
            }
            return View(courtsDecision);
        }

        // POST: CourtsDecisions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CourtsDecisionId,DecisionName")] CourtsDecision courtsDecision)
        {
            if (id != courtsDecision.CourtsDecisionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courtsDecision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourtsDecisionExists(courtsDecision.CourtsDecisionId))
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
            return View(courtsDecision);
        }

        // GET: CourtsDecisions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CourtsDecision == null)
            {
                return NotFound();
            }

            var courtsDecision = await _context.CourtsDecision
                .FirstOrDefaultAsync(m => m.CourtsDecisionId == id);
            if (courtsDecision == null)
            {
                return NotFound();
            }

            return View(courtsDecision);
        }

        // POST: CourtsDecisions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CourtsDecision == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CourtsDecision'  is null.");
            }
            var courtsDecision = await _context.CourtsDecision.FindAsync(id);
            if (courtsDecision != null)
            {
                _context.CourtsDecision.Remove(courtsDecision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourtsDecisionExists(Guid id)
        {
          return (_context.CourtsDecision?.Any(e => e.CourtsDecisionId == id)).GetValueOrDefault();
        }
    }
}
