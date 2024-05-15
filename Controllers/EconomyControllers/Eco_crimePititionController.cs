using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models;

namespace ExpertManagmentSystem.Controllers.EconomyControllers
{
    public class Eco_crimePititionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_crimePititionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_crimePitition
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eco_crimePitition.Include(e => e.Cr_Crime_Type).Include(e => e.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Eco_crimePitition/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_crimePitition == null)
            {
                return NotFound();
            }

            var eco_crimePitition = await _context.Eco_crimePitition
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_crimePititionId == id);
            if (eco_crimePitition == null)
            {
                return NotFound();
            }

            return View(eco_crimePitition);
        }

        // GET: Eco_crimePitition/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Eco_crimePitition/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_crimePititionId,ApplicantName,Cr_Crime_TypeId,PititionPresentBody,Prosecutor,IssuedDate,ReturedDate,Decission,DecissionOrder,DecissionStatus,Address,SectrorsDepartmentId")] Eco_crimePitition eco_crimePitition)
        {
            if (ModelState.IsValid)
            {
                eco_crimePitition.Eco_crimePititionId = Guid.NewGuid();
                _context.Add(eco_crimePitition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_crimePitition.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_crimePitition.SectrorsDepartmentId);
            return View(eco_crimePitition);
        }

        // GET: Eco_crimePitition/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_crimePitition == null)
            {
                return NotFound();
            }

            var eco_crimePitition = await _context.Eco_crimePitition.FindAsync(id);
            if (eco_crimePitition == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_crimePitition.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_crimePitition.SectrorsDepartmentId);
            return View(eco_crimePitition);
        }

        // POST: Eco_crimePitition/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_crimePititionId,ApplicantName,Cr_Crime_TypeId,PititionPresentBody,Prosecutor,IssuedDate,ReturedDate,Decission,DecissionOrder,DecissionStatus,Address,SectrorsDepartmentId")] Eco_crimePitition eco_crimePitition)
        {
            if (id != eco_crimePitition.Eco_crimePititionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_crimePitition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_crimePititionExists(eco_crimePitition.Eco_crimePititionId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_crimePitition.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_crimePitition.SectrorsDepartmentId);
            return View(eco_crimePitition);
        }

        // GET: Eco_crimePitition/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_crimePitition == null)
            {
                return NotFound();
            }

            var eco_crimePitition = await _context.Eco_crimePitition
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_crimePititionId == id);
            if (eco_crimePitition == null)
            {
                return NotFound();
            }

            return View(eco_crimePitition);
        }

        // POST: Eco_crimePitition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_crimePitition == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_crimePitition'  is null.");
            }
            var eco_crimePitition = await _context.Eco_crimePitition.FindAsync(id);
            if (eco_crimePitition != null)
            {
                _context.Eco_crimePitition.Remove(eco_crimePitition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_crimePititionExists(Guid id)
        {
          return (_context.Eco_crimePitition?.Any(e => e.Eco_crimePititionId == id)).GetValueOrDefault();
        }
    }
}
