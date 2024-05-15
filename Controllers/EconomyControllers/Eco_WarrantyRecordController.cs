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
    public class Eco_WarrantyRecordController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_WarrantyRecordController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_WarrantyRecord
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eco_WarrantyRecord.Include(e => e.Cr_Crime_Type).Include(e => e.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }
       

        // GET: Eco_WarrantyRecord/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_WarrantyRecord == null)
            {
                return NotFound();
            }

            var eco_WarrantyRecord = await _context.Eco_WarrantyRecord
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_WarrantyRecordId == id);
            if (eco_WarrantyRecord == null)
            {
                return NotFound();
            }

            return View(eco_WarrantyRecord);
        }

        // GET: Eco_WarrantyRecord/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Eco_WarrantyRecord/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_WarrantyRecordId,OpeningDate,Prosocuters_No,Police_No,Court_No,DefendentName,Region,Zone,Woreda,CrimeType,AdmissionDate,ReturnDate,ProsecutorComment,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_WarrantyRecord eco_WarrantyRecord)
        {
            if (ModelState.IsValid)
            {
                eco_WarrantyRecord.Eco_WarrantyRecordId = Guid.NewGuid();
               // eco_WarrantyRecord.PetWar = Enums.PetWarranty.Warranty;

                _context.Add(eco_WarrantyRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_WarrantyRecord.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_WarrantyRecord.SectrorsDepartmentId);
            return View(eco_WarrantyRecord);
        }

        


        // GET: Eco_WarrantyRecord/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_WarrantyRecord == null)
            {
                return NotFound();
            }

            var eco_WarrantyRecord = await _context.Eco_WarrantyRecord.FindAsync(id);
            if (eco_WarrantyRecord == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_WarrantyRecord.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_WarrantyRecord.SectrorsDepartmentId);
            return View(eco_WarrantyRecord);
        }

        // POST: Eco_WarrantyRecord/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_WarrantyRecordId,OpeningDate,Prosocuters_No,Police_No,Court_No,DefendentName,Region,Zone,Woreda,CrimeType,AdmissionDate,ReturnDate,ProsecutorComment,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_WarrantyRecord eco_WarrantyRecord)
        {
            if (id != eco_WarrantyRecord.Eco_WarrantyRecordId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_WarrantyRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_WarrantyRecordExists(eco_WarrantyRecord.Eco_WarrantyRecordId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_WarrantyRecord.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_WarrantyRecord.SectrorsDepartmentId);
            return View(eco_WarrantyRecord);
        }

        // GET: Eco_WarrantyRecord/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_WarrantyRecord == null)
            {
                return NotFound();
            }

            var eco_WarrantyRecord = await _context.Eco_WarrantyRecord
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_WarrantyRecordId == id);
            if (eco_WarrantyRecord == null)
            {
                return NotFound();
            }

            return View(eco_WarrantyRecord);
        }

        // POST: Eco_WarrantyRecord/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_WarrantyRecord == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_WarrantyRecord'  is null.");
            }
            var eco_WarrantyRecord = await _context.Eco_WarrantyRecord.FindAsync(id);
            if (eco_WarrantyRecord != null)
            {
                _context.Eco_WarrantyRecord.Remove(eco_WarrantyRecord);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_WarrantyRecordExists(Guid id)
        {
          return (_context.Eco_WarrantyRecord?.Any(e => e.Eco_WarrantyRecordId == id)).GetValueOrDefault();
        }
    }
}
