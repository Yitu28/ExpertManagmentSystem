using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.EconomyModels;

namespace ExpertManagmentSystem.Controllers.EconomyControllers
{
    public class Eco_DirectChargeDecissionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_DirectChargeDecissionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_DirectChargeDecission
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Eco_DirectChargeDecission.Include(e => e.Eco_ProsecutorDecision).Include(e => e.Eco_ProsecutorDecision).Include(e => e.SectrorsDepartment).Where(a => a.Ecocrime == Enums.CrimeEconomy.EconomyDept);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Cr_Index()
        {
            var applicationDbContext = _context.Eco_DirectChargeDecission.Include(e => e.Eco_ProsecutorDecision).Include(e => e.Eco_ProsecutorDecision).Include(e => e.SectrorsDepartment).Where(a => a.Ecocrime == Enums.CrimeEconomy.CrimeDept);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Eco_DirectChargeDecission/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_DirectChargeDecission == null)
            {
                return NotFound();
            }

            var eco_DirectChargeDecission = await _context.Eco_DirectChargeDecission
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_DirectChargeDecissionId == id);
            if (eco_DirectChargeDecission == null)
            {
                return NotFound();
            }

            return View(eco_DirectChargeDecission);
        }

        // GET: Eco_DirectChargeDecission/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            ViewData["Eco_ProsecutorDecisionId"] = new SelectList(_context.Eco_ProsecutorDecision, "Eco_ProsecutorDecisionId", "ProsecutorDecisionName");
            return View();
        }

        // POST: Eco_DirectChargeDecission/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_DirectChargeOpeningId,OpeningDate,PoliceNo,ProsocuterNo,CourtNo,DefendantName,DefendantGender,DefendantAge,RespodentName,RespodentGender,RespodentAge,Zone,Woreda,AdmissionExpert,NumberOfWitnesses,Exhibit,ProsecutorDecission,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_DirectChargeDecission eco_DirectChargeDecission)
        {
            if (ModelState.IsValid)
            {
                eco_DirectChargeDecission.Eco_DirectChargeDecissionId = Guid.NewGuid();
                eco_DirectChargeDecission.Ecocrime = Enums.CrimeEconomy.EconomyDept;
                
                _context.Add(eco_DirectChargeDecission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_DirectChargeDecission.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_DirectChargeDecission.SectrorsDepartmentId);
            ViewData["Eco_ProsecutorDecisionId"] = new SelectList(_context.Eco_ProsecutorDecision, "Eco_ProsecutorDecisionId", "Eco_ProsecutorDecisionId", eco_DirectChargeDecission.Eco_ProsecutorDecisionId);
            return View(eco_DirectChargeDecission);
        }

        // GET: Eco_DirectChargeDecission/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_DirectChargeDecission == null)
            {
                return NotFound();
            }

            var eco_DirectChargeDecission = await _context.Eco_DirectChargeDecission.FindAsync(id);
            if (eco_DirectChargeDecission == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName", eco_DirectChargeDecission.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName", eco_DirectChargeDecission.SectrorsDepartmentId);
            ViewData["Eco_ProsecutorDecisionId"] = new SelectList(_context.Eco_ProsecutorDecision, "Eco_ProsecutorDecisionId", "ProsecutorDecisionName", eco_DirectChargeDecission.Eco_ProsecutorDecisionId);
            return View(eco_DirectChargeDecission);
        }

        // POST: Eco_DirectChargeDecission/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_DirectChargeOpeningId,OpeningDate,PoliceNo,ProsocuterNo,CourtNo,DefendantName,DefendantGender,DefendantAge,RespodentName,RespodentGender,RespodentAge,Zone,Woreda,AdmissionExpert,NumberOfWitnesses,Exhibit,ProsecutorDecission,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_DirectChargeDecission eco_DirectChargeDecission)
        {
            if (id != eco_DirectChargeDecission.Eco_DirectChargeDecissionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_DirectChargeDecission);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_DirectChargeDecissionExists(eco_DirectChargeDecission.Eco_DirectChargeDecissionId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName", eco_DirectChargeDecission.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName", eco_DirectChargeDecission.SectrorsDepartmentId);
            ViewData["Eco_ProsecutorDecisionId"] = new SelectList(_context.Eco_ProsecutorDecision, "Eco_ProsecutorDecisionId", "ProsecutorDecisionName", eco_DirectChargeDecission.Eco_ProsecutorDecisionId);
            return View(eco_DirectChargeDecission);
        }

        // GET: Eco_DirectChargeDecission/Create
        public IActionResult Cr_Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            ViewData["Eco_ProsecutorDecisionId"] = new SelectList(_context.Eco_ProsecutorDecision, "Eco_ProsecutorDecisionId", "ProsecutorDecisionName");
            return View();
        }

        // POST: Eco_DirectChargeDecission/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cr_Create([Bind("Eco_DirectChargeOpeningId,OpeningDate,PoliceNo,ProsocuterNo,CourtNo,DefendantName,DefendantGender,DefendantAge,RespodentName,RespodentGender,RespodentAge,Zone,Woreda,AdmissionExpert,NumberOfWitnesses,Exhibit,ProsecutorDecission,Cr_Crime_TypeId,SectrorsDepartmentId")] Eco_DirectChargeDecission eco_DirectChargeDecission)
        {
            if (ModelState.IsValid)
            {
                eco_DirectChargeDecission.Eco_DirectChargeDecissionId = Guid.NewGuid();
                eco_DirectChargeDecission.Ecocrime = Enums.CrimeEconomy.CrimeDept;

                _context.Add(eco_DirectChargeDecission);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", eco_DirectChargeDecission.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", eco_DirectChargeDecission.SectrorsDepartmentId);
            ViewData["Eco_ProsecutorDecisionId"] = new SelectList(_context.Eco_ProsecutorDecision, "Eco_ProsecutorDecisionId", "Eco_ProsecutorDecisionId", eco_DirectChargeDecission.Eco_ProsecutorDecisionId);
            return View(eco_DirectChargeDecission);
        }


        // GET: Eco_DirectChargeDecission/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_DirectChargeDecission == null)
            {
                return NotFound();
            }

            var eco_DirectChargeDecission = await _context.Eco_DirectChargeDecission
                .Include(e => e.Cr_Crime_Type)
                .Include(e => e.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Eco_DirectChargeDecissionId == id);
            if (eco_DirectChargeDecission == null)
            {
                return NotFound();
            }

            return View(eco_DirectChargeDecission);
        }

        // POST: Eco_DirectChargeDecission/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Eco_DirectChargeDecission == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_DirectChargeDecission'  is null.");
            }
            var eco_DirectChargeDecission = await _context.Eco_DirectChargeDecission.FindAsync(id);
            if (eco_DirectChargeDecission != null)
            {
                _context.Eco_DirectChargeDecission.Remove(eco_DirectChargeDecission);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_DirectChargeDecissionExists(Guid id)
        {
          return (_context.Eco_DirectChargeDecission?.Any(e => e.Eco_DirectChargeDecissionId == id)).GetValueOrDefault();
        }
    }
}
