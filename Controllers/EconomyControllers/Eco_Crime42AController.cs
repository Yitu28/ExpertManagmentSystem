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
    public class Eco_Crime42AController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_Crime42AController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_Crime42A
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eco_Crime42A.Include(e => e.Cr_Crime_Type).Include(e => e.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Eco_Crime42A/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_Crime42A == null)
            {
                return NotFound();
            }

            var eco_Crime42A = await _context.Eco_Crime42A
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_Crime42AId == id);
            if (eco_Crime42A == null)
            {
                return NotFound();
            }

            return View(eco_Crime42A);
        }

        // GET: Eco_Crime42A/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Eco_Crime42A/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_Crime42AId,RecordNo,PoliceRecordNo,DefendenNamet,Cr_Crime_TypeId,Zone,ProsecutorAdmissionDate,ProsecutorReturnedDate,AdmisstionOrderDate,Persistant,Abrogated,OrderedIssue,OnAdmission,NonOrderedIssue,SectrorsDepartmentId")] Eco_Crime42A eco_Crime42A)
        {
            if (ModelState.IsValid)
            {
                eco_Crime42A.Eco_Crime42AId = Guid.NewGuid();
                _context.Add(eco_Crime42A);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_Crime42A.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_Crime42A.SectrorsDepartmentId);
            return View(eco_Crime42A);
        }

        // GET: Eco_Crime42A/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_Crime42A == null)
            {
                return NotFound();
            }

            var eco_Crime42A = await _context.Eco_Crime42A.FindAsync(id);
            if (eco_Crime42A == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_Crime42A.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_Crime42A.SectrorsDepartmentId);
            return View(eco_Crime42A);
        }

        // POST: Eco_Crime42A/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_Crime42AId,RecordNo,PoliceRecordNo,DefendenNamet,Cr_Crime_TypeId,Zone,ProsecutorAdmissionDate,ProsecutorReturnedDate,AdmisstionOrderDate,Persistant,Abrogated,OrderedIssue,OnAdmission,NonOrderedIssue,SectrorsDepartmentId")] Eco_Crime42A eco_Crime42A)
        {
            if (id != eco_Crime42A.Eco_Crime42AId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_Crime42A);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_Crime42AExists(eco_Crime42A.Eco_Crime42AId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_Crime42A.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_Crime42A.SectrorsDepartmentId);
            return View(eco_Crime42A);
        }

        // GET: Eco_Crime42A/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_Crime42A == null)
            {
                return NotFound();
            }

            var eco_Crime42A = await _context.Eco_Crime42A
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_Crime42AId == id);
            if (eco_Crime42A == null)
            {
                return NotFound();
            }

            return View(eco_Crime42A);
        }

        // POST: Eco_Crime42A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_Crime42A == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_Crime42A'  is null.");
            }
            var eco_Crime42A = await _context.Eco_Crime42A.FindAsync(id);
            if (eco_Crime42A != null)
            {
                _context.Eco_Crime42A.Remove(eco_Crime42A);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_Crime42AExists(Guid id)
        {
          return (_context.Eco_Crime42A?.Any(e => e.Eco_Crime42AId == id)).GetValueOrDefault();
        }
    }
}
