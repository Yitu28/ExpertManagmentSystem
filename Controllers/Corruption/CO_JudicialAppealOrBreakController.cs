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
    public class CO_JudicialAppealOrBreakController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_JudicialAppealOrBreakController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_JudicialAppealOrBreak
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_JudicialAppealOrBreak.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment).Where(c => c.J_AppealOrBreak == J_AppealBreaking.ፍርደኛ_ይግባኝ);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_JudicialAppealOrBreak
        public async Task<IActionResult> BreakIndex()
        {
            var applicationDbContext = _context.CO_JudicialAppealOrBreak.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment).Where(c=>c.J_AppealOrBreak == J_AppealBreaking.ፍርደኛ_ሰበር);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_JudicialAppealOrBreak/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_JudicialAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_JudicialAppealOrBreak = await _context.CO_JudicialAppealOrBreak
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_JudicialAppealOrBreakId == id);
            if (cO_JudicialAppealOrBreak == null)
            {
                return NotFound();
            }

            return View(cO_JudicialAppealOrBreak);
        }

        // GET: CO_JudicialAppealOrBreak/Create
        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_JudicialAppealOrBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_JudicialAppealOrBreakId,ProsecutorNo,SupremCourtNo,Appellant,Answerer,OpeningDate,Cr_Crime_TypeId,LowerCourtDecision,ProsecutorComment,Various,ExpertOpinion,J_AppealOrBreak,SectrorsDepartmentId")] CO_JudicialAppealOrBreak cO_JudicialAppealOrBreak)
        {
            if (ModelState.IsValid)
            {
                cO_JudicialAppealOrBreak.CO_JudicialAppealOrBreakId = Guid.NewGuid();
                cO_JudicialAppealOrBreak.J_AppealOrBreak = J_AppealBreaking.ፍርደኛ_ይግባኝ;
                
                _context.Add(cO_JudicialAppealOrBreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_JudicialAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_JudicialAppealOrBreak.SectrorsDepartmentId);
            return View(cO_JudicialAppealOrBreak);
        }

        // GET: CO_JudicialAppealOrBreak/Create
        public IActionResult BreakCreate()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_JudicialAppealOrBreak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BreakCreate([Bind("CO_JudicialAppealOrBreakId,ProsecutorNo,SupremCourtNo,Appellant,Answerer,OpeningDate,Cr_Crime_TypeId,LowerCourtDecision,ProsecutorComment,Various,ExpertOpinion,J_AppealOrBreak,SectrorsDepartmentId")] CO_JudicialAppealOrBreak cO_JudicialAppealOrBreak)
        {
            if (ModelState.IsValid)
            {
                cO_JudicialAppealOrBreak.CO_JudicialAppealOrBreakId = Guid.NewGuid();
                cO_JudicialAppealOrBreak.J_AppealOrBreak = J_AppealBreaking.ፍርደኛ_ሰበር;
                _context.Add(cO_JudicialAppealOrBreak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_JudicialAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_JudicialAppealOrBreak.SectrorsDepartmentId);
            return View(cO_JudicialAppealOrBreak);
        }


        // GET: CO_JudicialAppealOrBreak/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_JudicialAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_JudicialAppealOrBreak = await _context.CO_JudicialAppealOrBreak.FindAsync(id);
            if (cO_JudicialAppealOrBreak == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_JudicialAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_JudicialAppealOrBreak.SectrorsDepartmentId);
            return View(cO_JudicialAppealOrBreak);
        }

        // POST: CO_JudicialAppealOrBreak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_JudicialAppealOrBreakId,ProsecutorNo,SupremCourtNo,Appellant,Answerer,OpeningDate,Cr_Crime_TypeId,LowerCourtDecision,ProsecutorComment,Various,ExpertOpinion,J_AppealOrBreak,SectrorsDepartmentId")] CO_JudicialAppealOrBreak cO_JudicialAppealOrBreak)
        {
            if (id != cO_JudicialAppealOrBreak.CO_JudicialAppealOrBreakId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_JudicialAppealOrBreak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_JudicialAppealOrBreakExists(cO_JudicialAppealOrBreak.CO_JudicialAppealOrBreakId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cO_JudicialAppealOrBreak.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_JudicialAppealOrBreak.SectrorsDepartmentId);
            return View(cO_JudicialAppealOrBreak);
        }

        // GET: CO_JudicialAppealOrBreak/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_JudicialAppealOrBreak == null)
            {
                return NotFound();
            }

            var cO_JudicialAppealOrBreak = await _context.CO_JudicialAppealOrBreak
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_JudicialAppealOrBreakId == id);
            if (cO_JudicialAppealOrBreak == null)
            {
                return NotFound();
            }

            return View(cO_JudicialAppealOrBreak);
        }

        // POST: CO_JudicialAppealOrBreak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_JudicialAppealOrBreak == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_JudicialAppealOrBreak'  is null.");
            }
            var cO_JudicialAppealOrBreak = await _context.CO_JudicialAppealOrBreak.FindAsync(id);
            if (cO_JudicialAppealOrBreak != null)
            {
                _context.CO_JudicialAppealOrBreak.Remove(cO_JudicialAppealOrBreak);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_JudicialAppealOrBreakExists(Guid id)
        {
          return (_context.CO_JudicialAppealOrBreak?.Any(e => e.CO_JudicialAppealOrBreakId == id)).GetValueOrDefault();
        }
    }
}
