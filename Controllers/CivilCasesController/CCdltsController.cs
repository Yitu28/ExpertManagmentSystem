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
    public class CCdltsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CCdltsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CCdlts  Comments 
        public async Task<IActionResult> Index()
        {
              return _context.CCdlt != null ? 
                          View(await _context.CCdlt.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CCdlt'  is null.");
        }

        // GET: CCdlts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CCdlt == null)
            {
                return NotFound();
            }

            var cCdlt = await _context.CCdlt
                .FirstOrDefaultAsync(m => m.CCdltId == id);
            if (cCdlt == null)
            {
                return NotFound();
            }

            return View(cCdlt);
        }

        // GET: CCdlts/Create
        public IActionResult Create()
        {
            //return View();
            CCdlt Dlt = new();
            return PartialView("_CcDltCreateModalPartial", Dlt);
        }

        // POST: CCdlts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CCdlt cCdlt)
        {
            if (ModelState.IsValid)
            {
                cCdlt.CCdltId = Guid.NewGuid();
                _context.Add(cCdlt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CCdlts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCdlt == null)
            {
                return NotFound();
            }

            var cCdlt = await _context.CCdlt.FindAsync(id);
            if (cCdlt == null)
            {
                return NotFound();
            }
            return View(cCdlt);
        }

        // POST: CCdlts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CCdltId,DltFileNo,DltRecorNo,DltApplicant,DltResponder,DltGender,DltAge,DltSupportType,DltDoo,DlttypesofIssue,DltAmountBirr,DltAmountKarie,DltAddressZone,DltAddressWoreda,DltExpertName,DltDoAss,DltDoRet,DltLOS,DltPDecission,DltAssignto")] CCdlt cCdlt)
        {
            if (id != cCdlt.CCdltId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cCdlt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CCdltExists(cCdlt.CCdltId))
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
            return View(cCdlt);
        }

        // GET: CCdlts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CCdlt == null)
            {
                return NotFound();
            }

            var cCdlt = await _context.CCdlt
                .FirstOrDefaultAsync(m => m.CCdltId == id);
            if (cCdlt == null)
            {
                return NotFound();
            }

            return View(cCdlt);
        }

        // POST: CCdlts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CCdlt == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CCdlt'  is null.");
            }
            var cCdlt = await _context.CCdlt.FindAsync(id);
            if (cCdlt != null)
            {
                _context.CCdlt.Remove(cCdlt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CCdltExists(Guid id)
        {
          return (_context.CCdlt?.Any(e => e.CCdltId == id)).GetValueOrDefault();
        }
    }
}
