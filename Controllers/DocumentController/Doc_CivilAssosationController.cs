using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.DocumentModel;

namespace ExpertManagmentSystem.Controllers.DocumentController
{
    public class Doc_CivilAssosationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Doc_CivilAssosationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Doc_CivilAssosation
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Doc_CivilAssosation.Include(d => d.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Doc_CivilAssosation/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Doc_CivilAssosation == null)
            {
                return NotFound();
            }

            var doc_CivilAssosation = await _context.Doc_CivilAssosation
                .Include(d => d.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CivilLicenseNo == id);
            if (doc_CivilAssosation == null)
            {
                return NotFound();
            }

            return View(doc_CivilAssosation);
        }

        // GET: Doc_CivilAssosation/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Doc_CivilAssosation/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CivilLicenseNo,AssosationName,Address,licensedDate,licensedUpdateDate,ServiceFee,RecietNo,AssosationAim,ManagerName,Phone,Expert,AssosationMember,gender,Age,DisablityStatus,SectrorsDepartmentId")] Doc_CivilAssosation doc_CivilAssosation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doc_CivilAssosation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", doc_CivilAssosation.SectrorsDepartmentId);
            return View(doc_CivilAssosation);
        }

        // GET: Doc_CivilAssosation/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Doc_CivilAssosation == null)
            {
                return NotFound();
            }

            var doc_CivilAssosation = await _context.Doc_CivilAssosation.FindAsync(id);
            if (doc_CivilAssosation == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", doc_CivilAssosation.SectrorsDepartmentId);
            return View(doc_CivilAssosation);
        }

        // POST: Doc_CivilAssosation/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CivilLicenseNo,AssosationName,Address,licensedDate,licensedUpdateDate,ServiceFee,RecietNo,AssosationAim,ManagerName,Phone,Expert,AssosationMember,gender,Age,DisablityStatus,SectrorsDepartmentId")] Doc_CivilAssosation doc_CivilAssosation)
        {
            if (id != doc_CivilAssosation.CivilLicenseNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doc_CivilAssosation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doc_CivilAssosationExists(doc_CivilAssosation.CivilLicenseNo))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", doc_CivilAssosation.SectrorsDepartmentId);
            return View(doc_CivilAssosation);
        }

        // GET: Doc_CivilAssosation/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Doc_CivilAssosation == null)
            {
                return NotFound();
            }

            var doc_CivilAssosation = await _context.Doc_CivilAssosation
                .Include(d => d.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CivilLicenseNo == id);
            if (doc_CivilAssosation == null)
            {
                return NotFound();
            }

            return View(doc_CivilAssosation);
        }

        // POST: Doc_CivilAssosation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Doc_CivilAssosation == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Doc_CivilAssosation'  is null.");
            }
            var doc_CivilAssosation = await _context.Doc_CivilAssosation.FindAsync(id);
            if (doc_CivilAssosation != null)
            {
                _context.Doc_CivilAssosation.Remove(doc_CivilAssosation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Doc_CivilAssosationExists(string id)
        {
          return (_context.Doc_CivilAssosation?.Any(e => e.CivilLicenseNo == id)).GetValueOrDefault();
        }
    }
}
