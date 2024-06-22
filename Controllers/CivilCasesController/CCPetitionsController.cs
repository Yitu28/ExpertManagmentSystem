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
    public class CCPetitionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CCPetitionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CCPetitions
        public async Task<IActionResult> Index()
        {
              return _context.CCPetition != null ? 
                          View(await _context.CCPetition.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CCPetition'  is null.");
        }

        // GET: CCPetitions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CCPetition == null)
            {
                return NotFound();
            }

            var cCPetition = await _context.CCPetition
                .FirstOrDefaultAsync(m => m.CCPetitionId == id);
            if (cCPetition == null)
            {
                return NotFound();
            }

            return View(cCPetition);
        }

        // GET: CCPetitions/Create
        public IActionResult Create()
        {
            //return View();
            CCPetition Pet = new();
            return PartialView("_CcPetCreateModalPartial", Pet);
        }

        // POST: CCPetitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CCPetition cCPetition)
        {
            if (!ModelState.IsValid)
            {
                cCPetition.CCPetitionId = Guid.NewGuid();
                _context.Add(cCPetition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //return View(cCPetition);
            return RedirectToAction(nameof(Index));
        }

        // GET: CCPetitions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCPetition == null)
            {
                return NotFound();
            }

            var cCPetition = await _context.CCPetition.FindAsync(id);
            if (cCPetition == null)
            {
                return NotFound();
            }
            return View(cCPetition);
        }

        // POST: CCPetitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, CCPetition cCPetition)
        {
            if (id != cCPetition.CCPetitionId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(cCPetition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CCPetitionExists(cCPetition.CCPetitionId))
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
            return View(cCPetition);
        }

        // GET: CCPetitions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CCPetition == null)
            {
                return NotFound();
            }

            var cCPetition = await _context.CCPetition
                .FirstOrDefaultAsync(m => m.CCPetitionId == id);
            if (cCPetition == null)
            {
                return NotFound();
            }

            return View(cCPetition);
        }

        // POST: CCPetitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CCPetition == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CCPetition'  is null.");
            }
            var cCPetition = await _context.CCPetition.FindAsync(id);
            if (cCPetition != null)
            {
                _context.CCPetition.Remove(cCPetition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CCPetitionExists(Guid id)
        {
          return (_context.CCPetition?.Any(e => e.CCPetitionId == id)).GetValueOrDefault();
        }
    }
}
