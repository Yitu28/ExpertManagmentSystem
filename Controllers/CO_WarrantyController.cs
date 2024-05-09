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
    public class CO_WarrantyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_WarrantyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_Warranty
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_Warranty.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_Warranty/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CO_Warranty == null)
            {
                return NotFound();
            }

            var cO_Warranty = await _context.CO_Warranty
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_WarrantyId == id);
            if (cO_Warranty == null)
            {
                return NotFound();
            }

            return View(cO_Warranty);
        }

        // GET: CO_Warranty/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_Warranty/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_WarrantyId,ProsecotorNo,ApplicantName,Gender,Amount,WarrantyDate,CourtNo,Remark,SectrorsDepartmentId")] CO_Warranty cO_Warranty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cO_Warranty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Warranty.SectrorsDepartmentId);
            return View(cO_Warranty);
        }

        // GET: CO_Warranty/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CO_Warranty == null)
            {
                return NotFound();
            }

            var cO_Warranty = await _context.CO_Warranty.FindAsync(id);
            if (cO_Warranty == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Warranty.SectrorsDepartmentId);
            return View(cO_Warranty);
        }

        // POST: CO_Warranty/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CO_WarrantyId,ProsecotorNo,ApplicantName,Gender,Amount,WarrantyDate,CourtNo,Remark,SectrorsDepartmentId")] CO_Warranty cO_Warranty)
        {
            if (id != cO_Warranty.CO_WarrantyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_Warranty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_WarrantyExists(cO_Warranty.CO_WarrantyId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Warranty.SectrorsDepartmentId);
            return View(cO_Warranty);
        }

        // GET: CO_Warranty/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CO_Warranty == null)
            {
                return NotFound();
            }

            var cO_Warranty = await _context.CO_Warranty
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_WarrantyId == id);
            if (cO_Warranty == null)
            {
                return NotFound();
            }

            return View(cO_Warranty);
        }

        // POST: CO_Warranty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CO_Warranty == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_Warranty'  is null.");
            }
            var cO_Warranty = await _context.CO_Warranty.FindAsync(id);
            if (cO_Warranty != null)
            {
                _context.CO_Warranty.Remove(cO_Warranty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_WarrantyExists(int id)
        {
          return (_context.CO_Warranty?.Any(e => e.CO_WarrantyId == id)).GetValueOrDefault();
        }
    }
}
