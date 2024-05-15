using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.Corruption;

namespace ExpertManagmentSystem.Controllers
{
    public class CO_Closed_SentInReverseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_Closed_SentInReverseController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_Closed_SentInReverse
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_Closed_SentInReverse.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_Closed_SentInReverse/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_Closed_SentInReverse == null)
            {
                return NotFound();
            }

            var cO_Closed_SentInReverse = await _context.CO_Closed_SentInReverse
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_Closed_SentInReverseId == id);
            if (cO_Closed_SentInReverse == null)
            {
                return NotFound();
            }

            return View(cO_Closed_SentInReverse);
        }

        // GET: CO_Closed_SentInReverse/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_Closed_SentInReverse/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_Closed_SentInReverseId,ProsecutorNo,Defenedant,DefenedantZone,RegisterDate,OpinionGiven,SectrorsDepartmentId")] CO_Closed_SentInReverse cO_Closed_SentInReverse)
        {
            if (ModelState.IsValid)
            {
                cO_Closed_SentInReverse.CO_Closed_SentInReverseId = Guid.NewGuid();
                _context.Add(cO_Closed_SentInReverse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Closed_SentInReverse.SectrorsDepartmentId);
            return View(cO_Closed_SentInReverse);
        }

        // GET: CO_Closed_SentInReverse/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_Closed_SentInReverse == null)
            {
                return NotFound();
            }

            var cO_Closed_SentInReverse = await _context.CO_Closed_SentInReverse.FindAsync(id);
            if (cO_Closed_SentInReverse == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Closed_SentInReverse.SectrorsDepartmentId);
            return View(cO_Closed_SentInReverse);
        }

        // POST: CO_Closed_SentInReverse/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_Closed_SentInReverseId,ProsecutorNo,Defenedant,DefenedantZone,RegisterDate,OpinionGiven,SectrorsDepartmentId")] CO_Closed_SentInReverse cO_Closed_SentInReverse)
        {
            if (id != cO_Closed_SentInReverse.CO_Closed_SentInReverseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_Closed_SentInReverse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_Closed_SentInReverseExists(cO_Closed_SentInReverse.CO_Closed_SentInReverseId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Closed_SentInReverse.SectrorsDepartmentId);
            return View(cO_Closed_SentInReverse);
        }

        // GET: CO_Closed_SentInReverse/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_Closed_SentInReverse == null)
            {
                return NotFound();
            }

            var cO_Closed_SentInReverse = await _context.CO_Closed_SentInReverse
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_Closed_SentInReverseId == id);
            if (cO_Closed_SentInReverse == null)
            {
                return NotFound();
            }

            return View(cO_Closed_SentInReverse);
        }

        // POST: CO_Closed_SentInReverse/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_Closed_SentInReverse == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_Closed_SentInReverse'  is null.");
            }
            var cO_Closed_SentInReverse = await _context.CO_Closed_SentInReverse.FindAsync(id);
            if (cO_Closed_SentInReverse != null)
            {
                _context.CO_Closed_SentInReverse.Remove(cO_Closed_SentInReverse);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_Closed_SentInReverseExists(Guid id)
        {
          return (_context.CO_Closed_SentInReverse?.Any(e => e.CO_Closed_SentInReverseId == id)).GetValueOrDefault();
        }
    }
}
