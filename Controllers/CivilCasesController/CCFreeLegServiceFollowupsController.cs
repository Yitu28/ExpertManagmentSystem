using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;

namespace ExpertManagmentSystem.Controllers.CivilCasesController
{
    public class CCFreeLegServiceFollowupsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CCFreeLegServiceFollowupsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CCFreeLegServiceFollowups
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CCFreeLegServiceFollowup.Include(c => c.CCFreelServices);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CCFreeLegServiceFollowups/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CCFreeLegServiceFollowup == null)
            {
                return NotFound();
            }

            var cCFreeLegServiceFollowup = await _context.CCFreeLegServiceFollowup
                .Include(c => c.CCFreelServices)
                .FirstOrDefaultAsync(m => m.FreeLegServiceFollowupId == id);
            if (cCFreeLegServiceFollowup == null)
            {
                return NotFound();
            }

            return View(cCFreeLegServiceFollowup);
        }

        // GET: CCFreeLegServiceFollowups/Create
        public IActionResult Create()
        {
            ViewData["CCFreelServicesId"] = new SelectList(_context.CCFreelServices, "CCFreelServicesId", "Applicant");
            return View();
        }

        // POST: CCFreeLegServiceFollowups/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FreeLegServiceFollowupId,Doc,Doa,AppointmentType,DoD,DecisionStatus,Decisionmadeby,CCFreelServicesId,FollupCreatedBy,FollupUpdatededBy,FollupDeletedBy,FollupCreatedAt,FollupEdittedAt,FollupDeletedAt")] CCFreeLegServiceFollowup cCFreeLegServiceFollowup)
        {
            if (ModelState.IsValid)
            {
                cCFreeLegServiceFollowup.FreeLegServiceFollowupId = Guid.NewGuid();
                _context.Add(cCFreeLegServiceFollowup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CCFreelServicesId"] = new SelectList(_context.CCFreelServices, "CCFreelServicesId", "Applicant", cCFreeLegServiceFollowup.CCFreelServicesId);
            return View(cCFreeLegServiceFollowup);
        }

        // GET: CCFreeLegServiceFollowups/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCFreeLegServiceFollowup == null)
            {
                return NotFound();
            }

            var cCFreeLegServiceFollowup = await _context.CCFreeLegServiceFollowup.FindAsync(id);
            if (cCFreeLegServiceFollowup == null)
            {
                return NotFound();
            }
            ViewData["CCFreelServicesId"] = new SelectList(_context.CCFreelServices, "CCFreelServicesId", "Applicant", cCFreeLegServiceFollowup.CCFreelServicesId);
            return View(cCFreeLegServiceFollowup);
        }

        // POST: CCFreeLegServiceFollowups/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FreeLegServiceFollowupId,Doc,Doa,AppointmentType,DoD,DecisionStatus,Decisionmadeby,CCFreelServicesId,FollupCreatedBy,FollupUpdatededBy,FollupDeletedBy,FollupCreatedAt,FollupEdittedAt,FollupDeletedAt")] CCFreeLegServiceFollowup cCFreeLegServiceFollowup)
        {
            if (id != cCFreeLegServiceFollowup.FreeLegServiceFollowupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cCFreeLegServiceFollowup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CCFreeLegServiceFollowupExists(cCFreeLegServiceFollowup.FreeLegServiceFollowupId))
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
            ViewData["CCFreelServicesId"] = new SelectList(_context.CCFreelServices, "CCFreelServicesId", "Applicant", cCFreeLegServiceFollowup.CCFreelServicesId);
            return View(cCFreeLegServiceFollowup);
        }

        // GET: CCFreeLegServiceFollowups/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CCFreeLegServiceFollowup == null)
            {
                return NotFound();
            }

            var cCFreeLegServiceFollowup = await _context.CCFreeLegServiceFollowup
                .Include(c => c.CCFreelServices)
                .FirstOrDefaultAsync(m => m.FreeLegServiceFollowupId == id);
            if (cCFreeLegServiceFollowup == null)
            {
                return NotFound();
            }

            return View(cCFreeLegServiceFollowup);
        }

        // POST: CCFreeLegServiceFollowups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CCFreeLegServiceFollowup == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CCFreeLegServiceFollowup'  is null.");
            }
            var cCFreeLegServiceFollowup = await _context.CCFreeLegServiceFollowup.FindAsync(id);
            if (cCFreeLegServiceFollowup != null)
            {
                _context.CCFreeLegServiceFollowup.Remove(cCFreeLegServiceFollowup);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CCFreeLegServiceFollowupExists(Guid id)
        {
          return (_context.CCFreeLegServiceFollowup?.Any(e => e.FreeLegServiceFollowupId == id)).GetValueOrDefault();
        }
    }
}
