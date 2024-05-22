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
    public class Eco_GeneralCourtDecissionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_GeneralCourtDecissionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_GeneralCourtDecission
        public async Task<IActionResult> Index()
        {
            
            return _context.Eco_GeneralCourtDecission != null ?
                          View(await _context.Eco_GeneralCourtDecission.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Eco_GeneralCourtDecission'  is null.");
        }

        // GET: Eco_GeneralCourtDecission/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_GeneralCourtDecission == null)
            {
                return NotFound();
            }

            var eco_GeneralCourtDecission = await _context.Eco_GeneralCourtDecission
               
                .FirstOrDefaultAsync(m => m.Eco_GeneralCourtDecissionId == id);
            if (eco_GeneralCourtDecission == null)
            {
                return NotFound();
            }

            return View(eco_GeneralCourtDecission);
        }

        // GET: Eco_GeneralCourtDecission/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: Eco_GeneralCourtDecission/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_GeneralCourtDecissionId,GeneralCourtDecissionName,Department")] Eco_GeneralCourtDecission eco_GeneralCourtDecission)
        {
            if (ModelState.IsValid)
            {
                eco_GeneralCourtDecission.Eco_GeneralCourtDecissionId = Guid.NewGuid();
                _context.Add(eco_GeneralCourtDecission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(eco_GeneralCourtDecission);
        }

        // GET: Eco_GeneralCourtDecission/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_GeneralCourtDecission == null)
            {
                return NotFound();
            }

            var eco_GeneralCourtDecission = await _context.Eco_GeneralCourtDecission.FindAsync(id);
            if (eco_GeneralCourtDecission == null)
            {
                return NotFound();
            }
            
            return View(eco_GeneralCourtDecission);
        }

        // POST: Eco_GeneralCourtDecission/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_GeneralCourtDecissionId,GeneralCourtDecissionName,Department")] Eco_GeneralCourtDecission eco_GeneralCourtDecission)
        {
            if (id != eco_GeneralCourtDecission.Eco_GeneralCourtDecissionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_GeneralCourtDecission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_GeneralCourtDecissionExists(eco_GeneralCourtDecission.Eco_GeneralCourtDecissionId))
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
           
            return View(eco_GeneralCourtDecission);
        }

        // GET: Eco_GeneralCourtDecission/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_GeneralCourtDecission == null)
            {
                return NotFound();
            }

            var eco_GeneralCourtDecission = await _context.Eco_GeneralCourtDecission
                
                .FirstOrDefaultAsync(m => m.Eco_GeneralCourtDecissionId == id);
            if (eco_GeneralCourtDecission == null)
            {
                return NotFound();
            }

            return View(eco_GeneralCourtDecission);
        }

        // POST: Eco_GeneralCourtDecission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_GeneralCourtDecission == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_GeneralCourtDecission'  is null.");
            }
            var eco_GeneralCourtDecission = await _context.Eco_GeneralCourtDecission.FindAsync(id);
            if (eco_GeneralCourtDecission != null)
            {
                _context.Eco_GeneralCourtDecission.Remove(eco_GeneralCourtDecission);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_GeneralCourtDecissionExists(Guid id)
        {
          return (_context.Eco_GeneralCourtDecission?.Any(e => e.Eco_GeneralCourtDecissionId == id)).GetValueOrDefault();
        }
    }
}
