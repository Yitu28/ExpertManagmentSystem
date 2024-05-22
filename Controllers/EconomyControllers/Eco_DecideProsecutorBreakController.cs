using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.EconomyModels;

namespace ExpertManagmentSystem.Controllers.EconomyControllers
{
    public class Eco_DecideProsecutorBreakController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_DecideProsecutorBreakController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_DecideProsecutorBreak
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eco_ProsecutorAppeals.Include(e => e.Cr_Crime_Type).Include(e => e.Eco_GeneralCourtDecission);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Eco_DecideProsecutorBreak/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_ProsecutorAppeals == null)
            {
                return NotFound();
            }

            var eco_ProsecutorAppeals = await _context.Eco_ProsecutorAppeals
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.Eco_GeneralCourtDecission)
                .FirstOrDefaultAsync(m => m.Eco_ProsecutorAppealsId == id);
            if (eco_ProsecutorAppeals == null)
            {
                return NotFound();
            }

            return View(eco_ProsecutorAppeals);
        }

        // GET: Eco_DecideProsecutorBreak/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["Eco_GeneralCourtDecissionId"] = new SelectList(_context.Eco_GeneralCourtDecission, "Eco_GeneralCourtDecissionId", "Eco_GeneralCourtDecissionId");
            return View();
        }

        // POST: Eco_DecideProsecutorBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_ProsecutorAppealsId,FileOpeningDate,ProsecutorNo,CourtNo,Applicant,Respondant,Cr_Crime_TypeId,CourtDecission,ExpertName,Eco_GeneralCourtDecissionId,MaleApplicant,FemaleApplicant,AppealStatus,FederalBreakingRequest")] Eco_ProsecutorAppeals eco_ProsecutorAppeals)
        {
            if (ModelState.IsValid)
            {
                eco_ProsecutorAppeals.Eco_ProsecutorAppealsId = Guid.NewGuid();
                _context.Add(eco_ProsecutorAppeals);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_ProsecutorAppeals.Cr_Crime_TypeId);
            ViewData["Eco_GeneralCourtDecissionId"] = new SelectList(_context.Eco_GeneralCourtDecission, "Eco_GeneralCourtDecissionId", "Eco_GeneralCourtDecissionId", eco_ProsecutorAppeals.Eco_GeneralCourtDecissionId);
            return View(eco_ProsecutorAppeals);
        }

        // GET: Eco_DecideProsecutorBreak/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_ProsecutorAppeals == null)
            {
                return NotFound();
            }

            var eco_ProsecutorAppeals = await _context.Eco_ProsecutorAppeals.FindAsync(id);
            if (eco_ProsecutorAppeals == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_ProsecutorAppeals.Cr_Crime_TypeId);
            ViewData["Eco_GeneralCourtDecissionId"] = new SelectList(_context.Eco_GeneralCourtDecission, "Eco_GeneralCourtDecissionId", "Eco_GeneralCourtDecissionId", eco_ProsecutorAppeals.Eco_GeneralCourtDecissionId);
            return View(eco_ProsecutorAppeals);
        }

        // POST: Eco_DecideProsecutorBreak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_ProsecutorAppealsId,FileOpeningDate,ProsecutorNo,CourtNo,Applicant,Respondant,Cr_Crime_TypeId,CourtDecission,ExpertName,Eco_GeneralCourtDecissionId,MaleApplicant,FemaleApplicant,AppealStatus,FederalBreakingRequest")] Eco_ProsecutorAppeals eco_ProsecutorAppeals)
        {
            if (id != eco_ProsecutorAppeals.Eco_ProsecutorAppealsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_ProsecutorAppeals);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_ProsecutorAppealsExists(eco_ProsecutorAppeals.Eco_ProsecutorAppealsId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_ProsecutorAppeals.Cr_Crime_TypeId);
            ViewData["Eco_GeneralCourtDecissionId"] = new SelectList(_context.Eco_GeneralCourtDecission, "Eco_GeneralCourtDecissionId", "Eco_GeneralCourtDecissionId", eco_ProsecutorAppeals.Eco_GeneralCourtDecissionId);
            return View(eco_ProsecutorAppeals);
        }

        // GET: Eco_DecideProsecutorBreak/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_ProsecutorAppeals == null)
            {
                return NotFound();
            }

            var eco_ProsecutorAppeals = await _context.Eco_ProsecutorAppeals
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.Eco_GeneralCourtDecission)
                .FirstOrDefaultAsync(m => m.Eco_ProsecutorAppealsId == id);
            if (eco_ProsecutorAppeals == null)
            {
                return NotFound();
            }

            return View(eco_ProsecutorAppeals);
        }

        // POST: Eco_DecideProsecutorBreak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_ProsecutorAppeals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_ProsecutorAppeals'  is null.");
            }
            var eco_ProsecutorAppeals = await _context.Eco_ProsecutorAppeals.FindAsync(id);
            if (eco_ProsecutorAppeals != null)
            {
                _context.Eco_ProsecutorAppeals.Remove(eco_ProsecutorAppeals);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_ProsecutorAppealsExists(Guid id)
        {
          return (_context.Eco_ProsecutorAppeals?.Any(e => e.Eco_ProsecutorAppealsId == id)).GetValueOrDefault();
        }
    }
}
