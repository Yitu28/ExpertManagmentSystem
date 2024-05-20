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
    public class Cr_Crime_TypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Cr_Crime_TypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cr_Crime_Type
        public async Task<IActionResult> Index()
        {
              return _context.Cr_Crime_Types != null ? 
                          View(await _context.Cr_Crime_Types.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Cr_Crime_Types'  is null.");
        }

        // GET: Cr_Crime_Type/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Cr_Crime_Types == null)
            {
                return NotFound();
            }

            var cr_Crime_Type = await _context.Cr_Crime_Types
                .FirstOrDefaultAsync(m => m.Cr_Crime_TypeId == id);
            if (cr_Crime_Type == null)
            {
                return NotFound();
            }

            return View(cr_Crime_Type);
        }

        // GET: Cr_Crime_Type/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cr_Crime_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cr_Crime_TypeId,CrimeTypeName,CrimeDepartment")] Cr_Crime_Type cr_Crime_Type)
        {
            if (ModelState.IsValid)
            {
                cr_Crime_Type.Cr_Crime_TypeId = Guid.NewGuid();
                _context.Add(cr_Crime_Type);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cr_Crime_Type);
        }

        // GET: Cr_Crime_Type/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Cr_Crime_Types == null)
            {
                return NotFound();
            }

            var cr_Crime_Type = await _context.Cr_Crime_Types.FindAsync(id);
            if (cr_Crime_Type == null)
            {
                return NotFound();
            }
            return View(cr_Crime_Type);
        }

        // POST: Cr_Crime_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Cr_Crime_TypeId,CrimeTypeName,CrimeDepartment")] Cr_Crime_Type cr_Crime_Type)
        {
            if (id != cr_Crime_Type.Cr_Crime_TypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cr_Crime_Type);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cr_Crime_TypeExists(cr_Crime_Type.Cr_Crime_TypeId))
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
            return View(cr_Crime_Type);
        }

        // GET: Cr_Crime_Type/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Cr_Crime_Types == null)
            {
                return NotFound();
            }

            var cr_Crime_Type = await _context.Cr_Crime_Types
                .FirstOrDefaultAsync(m => m.Cr_Crime_TypeId == id);
            if (cr_Crime_Type == null)
            {
                return NotFound();
            }

            return View(cr_Crime_Type);
        }

        // POST: Cr_Crime_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Cr_Crime_Types == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cr_Crime_Types'  is null.");
            }
            var cr_Crime_Type = await _context.Cr_Crime_Types.FindAsync(id);
            if (cr_Crime_Type != null)
            {
                _context.Cr_Crime_Types.Remove(cr_Crime_Type);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cr_Crime_TypeExists(Guid id)
        {
          return (_context.Cr_Crime_Types?.Any(e => e.Cr_Crime_TypeId == id)).GetValueOrDefault();
        }
    }
}
