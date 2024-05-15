using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.Corruption;
using ExpertManagmentSystem.OrganizationalStructures;

namespace ExpertManagmentSystem.Controllers
{
    public class CO_FirstOrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_FirstOrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_FirstOrder
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_FirstOrder.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_FirstOrder/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_FirstOrder == null)
            {
                return NotFound();
            }

            var cO_FirstOrder = await _context.CO_FirstOrder
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_FirstOrderId == id);
            if (cO_FirstOrder == null)
            {
                return NotFound();
            }

            return View(cO_FirstOrder);
        }

        // GET: CO_FirstOrder/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_FirstOrder/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_FirstOrderId,ProsecotorRecordNo,ZoneProsecotorRecordNo,DefendantName,Zone,OpeningDate,Gender,Amount,Comment,Remark,SectrorsDepartmentId")] CO_FirstOrder cO_FirstOrder)
        {
            if (ModelState.IsValid)
            {
                cO_FirstOrder.CO_FirstOrderId = Guid.NewGuid();
                _context.Add(cO_FirstOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FirstOrder.SectrorsDepartmentId);
            return View(cO_FirstOrder);
        }

        // GET: CO_FirstOrder/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_FirstOrder == null)
            {
                return NotFound();
            }

            var cO_FirstOrder = await _context.CO_FirstOrder.FindAsync(id);
            if (cO_FirstOrder == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FirstOrder.SectrorsDepartmentId);
            return View(cO_FirstOrder);
        }

        // POST: CO_FirstOrder/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_FirstOrderId,ProsecotorRecordNo,ZoneProsecotorRecordNo,DefendantName,Zone,OpeningDate,Gender,Amount,Comment,Remark,SectrorsDepartmentId")] CO_FirstOrder cO_FirstOrder)
        {
            if (id != cO_FirstOrder.CO_FirstOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_FirstOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_FirstOrderExists(cO_FirstOrder.CO_FirstOrderId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_FirstOrder.SectrorsDepartmentId);
            return View(cO_FirstOrder);
        }

        // GET: CO_FirstOrder/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_FirstOrder == null)
            {
                return NotFound();
            }

            var cO_FirstOrder = await _context.CO_FirstOrder
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_FirstOrderId == id);
            if (cO_FirstOrder == null)
            {
                return NotFound();
            }

            return View(cO_FirstOrder);
        }

        // POST: CO_FirstOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_FirstOrder == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_FirstOrder'  is null.");
            }
            var cO_FirstOrder = await _context.CO_FirstOrder.FindAsync(id);
            if (cO_FirstOrder != null)
            {
                _context.CO_FirstOrder.Remove(cO_FirstOrder);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_FirstOrderExists(Guid id)
        {
          return (_context.CO_FirstOrder?.Any(e => e.CO_FirstOrderId == id)).GetValueOrDefault();
        }
    }
}
