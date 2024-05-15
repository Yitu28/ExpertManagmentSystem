using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CrimeModels;

namespace ExpertManagmentSystem.Controllers.CrimeControllers
{
    public class Cr_CrimeFollowUpModelController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Cr_CrimeFollowUpModelController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cr_CrimeFollowUpModel
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cr_CrimeFollowUpModels.Include(c => c.Cr_JudicalAppealOpening);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cr_CrimeFollowUpModel/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Cr_CrimeFollowUpModels == null)
            {
                return NotFound();
            }

            var cr_CrimeFollowUpModel = await _context.Cr_CrimeFollowUpModels
                .Include(c => c.Cr_JudicalAppealOpening)
                .FirstOrDefaultAsync(m => m.Cr_CrimeFollowUpModelId == id);
            if (cr_CrimeFollowUpModel == null)
            {
                return NotFound();
            }

            return View(cr_CrimeFollowUpModel);
        }

        // GET: Cr_CrimeFollowUpModel/Create
        public IActionResult Create()
        {
            ViewData["Cr_JudicalAppealOpeningId"] = new SelectList(_context.Cr_JudicalAppealOpenings, "Cr_JudicalAppealOpeningId", "Cr_JudicalAppealOpeningId");
            return View();
        }

        // POST: Cr_CrimeFollowUpModel/Create   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cr_CrimeFollowUpModelId,Cr_ProsecutorComment,Other,WhoLawyeCommented,HighCourtDecission,OtherCourtDecition,WhoJudgeCommentedOnDecision,NumberOfFemaleAppellants,NumberOfMaleAppellants,FileStatus,FileEndResult,DateOfAppointment,FileIssuedDate,FileReturnedDate,FederalBreakingRequest,Cr_JudicalAppealOpeningId")] Cr_CrimeFollowUpModel cr_CrimeFollowUpModel)
        {
            if (ModelState.IsValid)
            {
                cr_CrimeFollowUpModel.Cr_CrimeFollowUpModelId = Guid.NewGuid();
                _context.Add(cr_CrimeFollowUpModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_JudicalAppealOpeningId"] = new SelectList(_context.Cr_JudicalAppealOpenings, "Cr_JudicalAppealOpeningId", "Cr_JudicalAppealOpeningId", cr_CrimeFollowUpModel.Cr_JudicalAppealOpeningId);
            return View(cr_CrimeFollowUpModel);
        }

        // GET: Cr_CrimeFollowUpModel/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Cr_CrimeFollowUpModels == null)
            {
                return NotFound();
            }

            var cr_CrimeFollowUpModel = await _context.Cr_CrimeFollowUpModels.FindAsync(id);
            if (cr_CrimeFollowUpModel == null)
            {
                return NotFound();
            }
            ViewData["Cr_JudicalAppealOpeningId"] = new SelectList(_context.Cr_JudicalAppealOpenings, "Cr_JudicalAppealOpeningId", "Cr_JudicalAppealOpeningId", cr_CrimeFollowUpModel.Cr_JudicalAppealOpeningId);
            return View(cr_CrimeFollowUpModel);
        }

        // POST: Cr_CrimeFollowUpModel/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Cr_CrimeFollowUpModelId,Cr_ProsecutorComment,Other,WhoLawyeCommented,HighCourtDecission,OtherCourtDecition,WhoJudgeCommentedOnDecision,NumberOfFemaleAppellants,NumberOfMaleAppellants,FileStatus,FileEndResult,DateOfAppointment,FileIssuedDate,FileReturnedDate,FederalBreakingRequest,Cr_JudicalAppealOpeningId")] Cr_CrimeFollowUpModel cr_CrimeFollowUpModel)
        {
            if (id != cr_CrimeFollowUpModel.Cr_CrimeFollowUpModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cr_CrimeFollowUpModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cr_CrimeFollowUpModelExists(cr_CrimeFollowUpModel.Cr_CrimeFollowUpModelId))
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
            ViewData["Cr_JudicalAppealOpeningId"] = new SelectList(_context.Cr_JudicalAppealOpenings, "Cr_JudicalAppealOpeningId", "Cr_JudicalAppealOpeningId", cr_CrimeFollowUpModel.Cr_JudicalAppealOpeningId);
            return View(cr_CrimeFollowUpModel);
        }

        // GET: Cr_CrimeFollowUpModel/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Cr_CrimeFollowUpModels == null)
            {
                return NotFound();
            }

            var cr_CrimeFollowUpModel = await _context.Cr_CrimeFollowUpModels
                .Include(c => c.Cr_JudicalAppealOpening)
                .FirstOrDefaultAsync(m => m.Cr_CrimeFollowUpModelId == id);
            if (cr_CrimeFollowUpModel == null)
            {
                return NotFound();
            }

            return View(cr_CrimeFollowUpModel);
        }

        // POST: Cr_CrimeFollowUpModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Cr_CrimeFollowUpModels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cr_CrimeFollowUpModels'  is null.");
            }
            var cr_CrimeFollowUpModel = await _context.Cr_CrimeFollowUpModels.FindAsync(id);
            if (cr_CrimeFollowUpModel != null)
            {
                _context.Cr_CrimeFollowUpModels.Remove(cr_CrimeFollowUpModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cr_CrimeFollowUpModelExists(Guid id)
        {
          return (_context.Cr_CrimeFollowUpModels?.Any(e => e.Cr_CrimeFollowUpModelId == id)).GetValueOrDefault();
        }
    }
}
