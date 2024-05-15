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
    public class CCLegaladvicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CCLegaladvicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CCLegaladvices
        public async Task<IActionResult> Index()
        {
              return _context.CCLegaladvices != null ? 
                          View(await _context.CCLegaladvices.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CCLegaladvices'  is null.");
        }

        // GET: CCLegaladvices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CCLegaladvices == null)
            {
                return NotFound();
            }

            var cCLegaladvices = await _context.CCLegaladvices
                .FirstOrDefaultAsync(m => m.CCLegaladvicesId == id);
            if (cCLegaladvices == null)
            {
                return NotFound();
            }

            return View(cCLegaladvices);
        }

        // GET: CCLegaladvices/Create
        public IActionResult Create()
        {
            //return View();

            CCLegaladvices Lad = new();
            return PartialView("_CcLegaladCreateModalPartial", Lad);
        }

        // POST: CCLegaladvices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CCLegaladvicesId,LadFileNo,Ladvicerequester,LadDoariv,LadTypes,LadAmountBirr,LadAmountKarie,LadAddressZone,LadAddressWoreda,LadExpertName,LadDaos,LadDoare,LadTimeTaken,LadPDecisoion,LadAssignto")] CCLegaladvices cCLegaladvices)
        {
            if (ModelState.IsValid)
            {
                cCLegaladvices.CCLegaladvicesId = Guid.NewGuid();
                _context.Add(cCLegaladvices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cCLegaladvices);
        }

        // GET: CCLegaladvices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCLegaladvices == null)
            {
                return NotFound();
            }

            var cCLegaladvices = await _context.CCLegaladvices.FindAsync(id);
            if (cCLegaladvices == null)
            {
                return NotFound();
            }
            return View(cCLegaladvices);
        }

        // POST: CCLegaladvices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CCLegaladvicesId,LadFileNo,Ladvicerequester,LadDoariv,LadTypes,LadAmountBirr,LadAmountKarie,LadAddressZone,LadAddressWoreda,LadExpertName,LadDaos,LadDoare,LadTimeTaken,LadPDecisoion,LadAssignto")] CCLegaladvices cCLegaladvices)
        {
            if (id != cCLegaladvices.CCLegaladvicesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cCLegaladvices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CCLegaladvicesExists(cCLegaladvices.CCLegaladvicesId))
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
            return View(cCLegaladvices);
        }

        // GET: CCLegaladvices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CCLegaladvices == null)
            {
                return NotFound();
            }

            var cCLegaladvices = await _context.CCLegaladvices
                .FirstOrDefaultAsync(m => m.CCLegaladvicesId == id);
            if (cCLegaladvices == null)
            {
                return NotFound();
            }

            return View(cCLegaladvices);
        }

        // POST: CCLegaladvices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CCLegaladvices == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CCLegaladvices'  is null.");
            }
            var cCLegaladvices = await _context.CCLegaladvices.FindAsync(id);
            if (cCLegaladvices != null)
            {
                _context.CCLegaladvices.Remove(cCLegaladvices);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CCLegaladvicesExists(Guid id)
        {
          return (_context.CCLegaladvices?.Any(e => e.CCLegaladvicesId == id)).GetValueOrDefault();
        }
    }
}
