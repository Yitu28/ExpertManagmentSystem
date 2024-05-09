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
    public class CO_PetitionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_PetitionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_Petition
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_Petition.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_Petition/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_Petition == null)
            {
                return NotFound();
            }

            var cO_Petition = await _context.CO_Petition
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_PetitionId == id);
            if (cO_Petition == null)
            {
                return NotFound();
            }

            return View(cO_Petition);
        }

        // GET: CO_Petition/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_Petition/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_PetitionId,ComplainantsName,Gender,Amount,OrderedClass,OrderContent,LetterNo,LetterDate,ExpertName,Remark,SectrorsDepartmentId")] CO_Petition cO_Petition)
        {
            if (ModelState.IsValid)
            {
                cO_Petition.CO_PetitionId = Guid.NewGuid();
                _context.Add(cO_Petition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Petition.SectrorsDepartmentId);
            return View(cO_Petition);
        }

        // GET: CO_Petition/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_Petition == null)
            {
                return NotFound();
            }

            var cO_Petition = await _context.CO_Petition.FindAsync(id);
            if (cO_Petition == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Petition.SectrorsDepartmentId);
            return View(cO_Petition);
        }

        // POST: CO_Petition/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_PetitionId,ComplainantsName,Gender,Amount,OrderedClass,OrderContent,LetterNo,LetterDate,ExpertName,Remark,SectrorsDepartmentId")] CO_Petition cO_Petition)
        {
            if (id != cO_Petition.CO_PetitionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_Petition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_PetitionExists(cO_Petition.CO_PetitionId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_Petition.SectrorsDepartmentId);
            return View(cO_Petition);
        }

        // GET: CO_Petition/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_Petition == null)
            {
                return NotFound();
            }

            var cO_Petition = await _context.CO_Petition
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_PetitionId == id);
            if (cO_Petition == null)
            {
                return NotFound();
            }

            return View(cO_Petition);
        }

        // POST: CO_Petition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_Petition == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_Petition'  is null.");
            }
            var cO_Petition = await _context.CO_Petition.FindAsync(id);
            if (cO_Petition != null)
            {
                _context.CO_Petition.Remove(cO_Petition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_PetitionExists(Guid id)
        {
          return (_context.CO_Petition?.Any(e => e.CO_PetitionId == id)).GetValueOrDefault();
        }
    }
}
