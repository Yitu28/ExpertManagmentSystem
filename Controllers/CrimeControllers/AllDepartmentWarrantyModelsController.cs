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
    public class AllDepartmentWarrantyModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AllDepartmentWarrantyModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AllDepartmentWarrantyModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AllDepartmentWarrantyModels.Include(a => a.Cr_Crime_Type).Include(a => a.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: All Department File a complaint Models
        public async Task<IActionResult> ComplaintIndex()
        {
            var applicationDbContext = _context.AllDepartmentWarrantyModels.Include(a => a.Cr_Crime_Type).Include(a => a.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AllDepartmentWarrantyModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.AllDepartmentWarrantyModels == null)
            {
                return NotFound();
            }

            var allDepartmentWarrantyModel = await _context.AllDepartmentWarrantyModels
                .Include(a => a.Cr_Crime_Type)
                .Include(a => a.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.AllDepartmentWarrantyModelId == id);
            if (allDepartmentWarrantyModel == null)
            {
                return NotFound();
            }

            return View(allDepartmentWarrantyModel);
        }

        // GET: All Department Warranty Models Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_allWarantyPartialCreate", Laaos);
            
        }

        // POST: AllDepartmentWarrantyModels/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AllDepartmentWarrantyModelId,OpeninigDate,ProcsecuterNo,PoliceRecordNo,CourtNo,ApplicantName,Gender,WhereItCameFrom,DateOfDirectedToProsecuter,DateOfDoneAndReturned,Cr_ProsecutorComment,Cr_Crime_TypeId,SectrorsDepartmentId")] AllDepartmentWarrantyModel allDepartmentWarrantyModel)
        {
            if (ModelState.IsValid)
            {
                allDepartmentWarrantyModel.AllDepartmentWarrantyModelId = Guid.NewGuid();
                _context.Add(allDepartmentWarrantyModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", allDepartmentWarrantyModel.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", allDepartmentWarrantyModel.SectrorsDepartmentId);
            return View(allDepartmentWarrantyModel);
        }

        // GET: All Department Compliant Models Create
        public IActionResult CompliantCreate()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_allCompliantPartialCreate", Laaos);

        }

        // POST: All Department Compliant Models Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompliantCreate([Bind("AllDepartmentWarrantyModelId,OpeninigDate,ProcsecuterNo,PoliceRecordNo,CourtNo,ApplicantName,Gender,WhereItCameFrom,DateOfDirectedToProsecuter,DateOfDoneAndReturned,Cr_ProsecutorComment,Cr_Crime_TypeId,SectrorsDepartmentId")] AllDepartmentWarrantyModel allDepartmentWarrantyModel)
        {
            if (ModelState.IsValid)
            {
                allDepartmentWarrantyModel.AllDepartmentWarrantyModelId = Guid.NewGuid();
                _context.Add(allDepartmentWarrantyModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ComplaintIndex));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", allDepartmentWarrantyModel.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", allDepartmentWarrantyModel.SectrorsDepartmentId);
            return View(allDepartmentWarrantyModel);
        }

        // GET: AllDepartmentWarrantyModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.AllDepartmentWarrantyModels == null)
            {
                return NotFound();
            }

            var allDepartmentWarrantyModel = await _context.AllDepartmentWarrantyModels.FindAsync(id);
            if (allDepartmentWarrantyModel == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", allDepartmentWarrantyModel.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", allDepartmentWarrantyModel.SectrorsDepartmentId);
            return View(allDepartmentWarrantyModel);
        }

        // POST: AllDepartmentWarrantyModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("AllDepartmentWarrantyModelId,OpeninigDate,ProcsecuterNo,PoliceRecordNo,CourtNo,ApplicantName,Gender,WhereItCameFrom,DateOfDirectedToProsecuter,DateOfDoneAndReturned,Cr_ProsecutorComment,Cr_Crime_TypeId,SectrorsDepartmentId")] AllDepartmentWarrantyModel allDepartmentWarrantyModel)
        {
            if (id != allDepartmentWarrantyModel.AllDepartmentWarrantyModelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(allDepartmentWarrantyModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AllDepartmentWarrantyModelExists(allDepartmentWarrantyModel.AllDepartmentWarrantyModelId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", allDepartmentWarrantyModel.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", allDepartmentWarrantyModel.SectrorsDepartmentId);
            return View(allDepartmentWarrantyModel);
        }

        // GET: AllDepartmentWarrantyModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.AllDepartmentWarrantyModels == null)
            {
                return NotFound();
            }

            var allDepartmentWarrantyModel = await _context.AllDepartmentWarrantyModels
                .Include(a => a.Cr_Crime_Type)
                .Include(a => a.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.AllDepartmentWarrantyModelId == id);
            if (allDepartmentWarrantyModel == null)
            {
                return NotFound();
            }

            return View(allDepartmentWarrantyModel);
        }

        // POST: AllDepartmentWarrantyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.AllDepartmentWarrantyModels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AllDepartmentWarrantyModels'  is null.");
            }
            var allDepartmentWarrantyModel = await _context.AllDepartmentWarrantyModels.FindAsync(id);
            if (allDepartmentWarrantyModel != null)
            {
                _context.AllDepartmentWarrantyModels.Remove(allDepartmentWarrantyModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AllDepartmentWarrantyModelExists(Guid id)
        {
          return (_context.AllDepartmentWarrantyModels?.Any(e => e.AllDepartmentWarrantyModelId == id)).GetValueOrDefault();
        }
    }
}
