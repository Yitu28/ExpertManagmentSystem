using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Enums;
using ExpertManagmentSystem.Models.Corruption;

namespace ExpertManagmentSystem.Controllers.Corruption
{
    public class CO_ProsecutorAppealOrBreakController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_ProsecutorAppealOrBreakController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_ProsecutorAppealOrBreak
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_ProsecutorAppealOrBreak.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment).Where(c => c.F_AppealOrBreak == AppealBreaking.ዐቃቤ_ህግ_ግባኝ);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_ProsecutorAppealOrBreak
        public async Task<IActionResult> BreakIndex()
        {
            var applicationDbContext = _context.CO_ProsecutorAppealOrBreak.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment).Where(c => c.F_AppealOrBreak == AppealBreaking.ዐቃቤ_ህግ_ሰበር);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_ProsecutorAppealOrBreak/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_ProsecutorAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_ProsecutorAppealOrBreak = await _context.CO_ProsecutorAppealOrBreak
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_ProsecutorAppealOrBreakId == id);
            if (cO_ProsecutorAppealOrBreak == null)
            {
                return NotFound();
            }

            return View(cO_ProsecutorAppealOrBreak);
        }

        // GET: CO_ProsecutorAppealOrBreak/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_ProsecutorAppealOrBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_ProsecutorAppealOrBreakId,ProsecutorNo,SupremCourtNo,Appellant,Answerer,OpeningDate,Cr_Crime_TypeId,LowerCourtDecision,ProsecutorComment,Various,ExpertOpinion,F_AppealOrBreak,SectrorsDepartmentId")] CO_ProsecutorAppealOrBreak cO_ProsecutorAppealOrBreak)
        {
            if (ModelState.IsValid)
            {

                cO_ProsecutorAppealOrBreak.CO_ProsecutorAppealOrBreakId = Guid.NewGuid();
                cO_ProsecutorAppealOrBreak.F_AppealOrBreak = AppealBreaking.ዐቃቤ_ህግ_ግባኝ;
                _context.Add(cO_ProsecutorAppealOrBreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_ProsecutorAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_ProsecutorAppealOrBreak.SectrorsDepartmentId);
            return View(cO_ProsecutorAppealOrBreak);
        }

        // GET: CO_ProsecutorAppealOrBreak/Create
        public IActionResult BreakCreate()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_ProsecutorAppealOrBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BreakCreate([Bind("CO_ProsecutorAppealOrBreakId,ProsecutorNo,SupremCourtNo,Appellant,Answerer,OpeningDate,Cr_Crime_TypeId,LowerCourtDecision,ProsecutorComment,Various,ExpertOpinion,F_AppealOrBreak,SectrorsDepartmentId")] CO_ProsecutorAppealOrBreak cO_ProsecutorAppealOrBreak)
        {
            if (ModelState.IsValid)
            {
                cO_ProsecutorAppealOrBreak.CO_ProsecutorAppealOrBreakId = Guid.NewGuid();
                cO_ProsecutorAppealOrBreak.F_AppealOrBreak = AppealBreaking.ዐቃቤ_ህግ_ሰበር;
                _context.Add(cO_ProsecutorAppealOrBreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_ProsecutorAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_ProsecutorAppealOrBreak.SectrorsDepartmentId);
            return View(cO_ProsecutorAppealOrBreak);
        }


        // GET: CO_ProsecutorAppealOrBreak/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_ProsecutorAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_ProsecutorAppealOrBreak = await _context.CO_ProsecutorAppealOrBreak.FindAsync(id);
            if (cO_ProsecutorAppealOrBreak == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_ProsecutorAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_ProsecutorAppealOrBreak.SectrorsDepartmentId);
            return View(cO_ProsecutorAppealOrBreak);
        }

        // POST: CO_ProsecutorAppealOrBreak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_ProsecutorAppealOrBreakId,ProsecutorNo,SupremCourtNo,Appellant,Answerer,OpeningDate,Cr_Crime_TypeId,LowerCourtDecision,ProsecutorComment,Various,ExpertOpinion,F_AppealOrBreak,SectrorsDepartmentId")] CO_ProsecutorAppealOrBreak cO_ProsecutorAppealOrBreak)
        {
            if (id != cO_ProsecutorAppealOrBreak.CO_ProsecutorAppealOrBreakId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_ProsecutorAppealOrBreak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_ProsecutorAppealOrBreakExists(cO_ProsecutorAppealOrBreak.CO_ProsecutorAppealOrBreakId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_ProsecutorAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_ProsecutorAppealOrBreak.SectrorsDepartmentId);
            return View(cO_ProsecutorAppealOrBreak);
        }

        // GET: CO_ProsecutorAppealOrBreak/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_ProsecutorAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_ProsecutorAppealOrBreak = await _context.CO_ProsecutorAppealOrBreak
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_ProsecutorAppealOrBreakId == id);
            if (cO_ProsecutorAppealOrBreak == null)
            {
                return NotFound();
            }

            return View(cO_ProsecutorAppealOrBreak);
        }

        // POST: CO_ProsecutorAppealOrBreak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_ProsecutorAppealOrBreak == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_ProsecutorAppealOrBreak'  is null.");
            }
            var cO_ProsecutorAppealOrBreak = await _context.CO_ProsecutorAppealOrBreak.FindAsync(id);
            if (cO_ProsecutorAppealOrBreak != null)
            {
                _context.CO_ProsecutorAppealOrBreak.Remove(cO_ProsecutorAppealOrBreak);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_ProsecutorAppealOrBreakExists(Guid id)
        {
          return (_context.CO_ProsecutorAppealOrBreak?.Any(e => e.CO_ProsecutorAppealOrBreakId == id)).GetValueOrDefault();
        }
    }
}
