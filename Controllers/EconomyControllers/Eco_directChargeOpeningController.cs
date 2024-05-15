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
    public class Eco_directChargeOpeningController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_directChargeOpeningController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_directChargeOpening
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eco_directChargeOpening.Include(e => e.Cr_Crime_Type).Include(e => e.SectrorsDepartment).Where(a => a.Ecocrime == Enums.CrimeEconomy.EconomyDept);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Cr_Index()
        {
            var applicationDbContext = _context.Eco_directChargeOpening.Include(e => e.Cr_Crime_Type).Include(e => e.SectrorsDepartment).Where(a => a.Ecocrime == Enums.CrimeEconomy.CrimeDept);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Eco_directChargeOpening/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_directChargeOpening == null)
            {
                return NotFound();
            }

            var eco_directChargeOpening = await _context.Eco_directChargeOpening
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_directChargeOpeningId == id);
            if (eco_directChargeOpening == null)
            {
                return NotFound();
            }

            return View(eco_directChargeOpening);
        }

        // GET: Eco_directChargeOpening/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Eco_directChargeOpening/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_directChargeOpeningId,OpeningDate,PoliceNo,ProsocuterNo,CourtNo,DefendantName,DefendantGender,Zone,Woreda,AdmissionExpert,AdmissitionDate,ReturnedDate,Comments,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_directChargeOpening eco_directChargeOpening)
        {
            if (ModelState.IsValid)
            {
                eco_directChargeOpening.Eco_directChargeOpeningId = Guid.NewGuid();
                eco_directChargeOpening.Ecocrime = Enums.CrimeEconomy.EconomyDept;
                _context.Add(eco_directChargeOpening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName", eco_directChargeOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_directChargeOpening.SectrorsDepartmentId);
            return View(eco_directChargeOpening);
        }
        public IActionResult Cr_Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Eco_directChargeOpening/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cr_Create([Bind("Eco_directChargeOpeningId,OpeningDate,PoliceNo,ProsocuterNo,CourtNo,DefendantName,DefendantGender,Zone,Woreda,AdmissionExpert,AdmissitionDate,ReturnedDate,Comments,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_directChargeOpening eco_directChargeOpening)
        {
            if (ModelState.IsValid)
            {
                eco_directChargeOpening.Eco_directChargeOpeningId = Guid.NewGuid();
                eco_directChargeOpening.Ecocrime = Enums.CrimeEconomy.CrimeDept;
;                _context.Add(eco_directChargeOpening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName", eco_directChargeOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_directChargeOpening.SectrorsDepartmentId);
            return View(eco_directChargeOpening);
        }
        // GET: Eco_directChargeOpening/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_directChargeOpening == null)
            {
                return NotFound();
            }

            var eco_directChargeOpening = await _context.Eco_directChargeOpening.FindAsync(id);
            if (eco_directChargeOpening == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName", eco_directChargeOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_directChargeOpening.SectrorsDepartmentId);
            return View(eco_directChargeOpening);
        }

        // POST: Eco_directChargeOpening/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_directChargeOpeningId,OpeningDate,PoliceNo,ProsocuterNo,CourtNo,DefendantName,DefendantGender,Zone,Woreda,AdmissionExpert,AdmissitionDate,ReturnedDate,Comments,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_directChargeOpening eco_directChargeOpening)
        {
            if (id != eco_directChargeOpening.Eco_directChargeOpeningId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_directChargeOpening);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_directChargeOpeningExists(eco_directChargeOpening.Eco_directChargeOpeningId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName", eco_directChargeOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_directChargeOpening.SectrorsDepartmentId);
            return View(eco_directChargeOpening);
        }

        // GET: Eco_directChargeOpening/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_directChargeOpening == null)
            {
                return NotFound();
            }

            var eco_directChargeOpening = await _context.Eco_directChargeOpening
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_directChargeOpeningId == id);
            if (eco_directChargeOpening == null)
            {
                return NotFound();
            }

            return View(eco_directChargeOpening);
        }

        // POST: Eco_directChargeOpening/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_directChargeOpening == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_directChargeOpening'  is null.");
            }
            var eco_directChargeOpening = await _context.Eco_directChargeOpening.FindAsync(id);
            if (eco_directChargeOpening != null)
            {
                _context.Eco_directChargeOpening.Remove(eco_directChargeOpening);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_directChargeOpeningExists(Guid id)
        {
          return (_context.Eco_directChargeOpening?.Any(e => e.Eco_directChargeOpeningId == id)).GetValueOrDefault();
        }
    }
}
