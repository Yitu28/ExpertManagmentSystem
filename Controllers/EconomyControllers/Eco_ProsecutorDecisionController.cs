using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.EconomyModels;

namespace ExpertManagmentSystem.Controllers.EconomyControllers
{
    public class Eco_ProsecutorDecisionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_ProsecutorDecisionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_ProsecutorDecision
        public async Task<IActionResult> Index()
        {
            return _context.Eco_ProsecutorDecision != null ?
                          View(await _context.Eco_ProsecutorDecision.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Eco_ProsecutorDecision'  is null.");
        }

        // GET: Eco_ProsecutorDecision/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_ProsecutorDecision == null)
            {
                return NotFound();
            }

            var eco_ProsecutorDecision = await _context.Eco_ProsecutorDecision
               
                .FirstOrDefaultAsync(m => m.Eco_ProsecutorDecisionId == id);
            if (eco_ProsecutorDecision == null)
            {
                return NotFound();
            }

            return View(eco_ProsecutorDecision);
        }

        // GET: Eco_ProsecutorDecision/Create
        public IActionResult Create()
        {
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            return View();
        }

        // POST: Eco_ProsecutorDecision/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_ProsecutorDecisionId,ProsecutorDecisionName,department")] Eco_ProsecutorDecision eco_ProsecutorDecision)
        {
            if (ModelState.IsValid)
            {
                eco_ProsecutorDecision.Eco_ProsecutorDecisionId = Guid.NewGuid();
                _context.Add(eco_ProsecutorDecision);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
          
            return View(eco_ProsecutorDecision);
        }

        // GET: Eco_ProsecutorDecision/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_ProsecutorDecision == null)
            {
                return NotFound();
            }

            var eco_ProsecutorDecision = await _context.Eco_ProsecutorDecision.FindAsync(id);
            if (eco_ProsecutorDecision == null)
            {
                return NotFound();
            }
            
            return View(eco_ProsecutorDecision);
        }

        // POST: Eco_ProsecutorDecision/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_ProsecutorDecisionId,ProsecutorDecisionName,SectrorsDepartmentId")] Eco_ProsecutorDecision eco_ProsecutorDecision)
        {
            if (id != eco_ProsecutorDecision.Eco_ProsecutorDecisionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_ProsecutorDecision);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_ProsecutorDecisionExists(eco_ProsecutorDecision.Eco_ProsecutorDecisionId))
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
          
            return View(eco_ProsecutorDecision);
        }

        // GET: Eco_ProsecutorDecision/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_ProsecutorDecision == null)
            {
                return NotFound();
            }

            var eco_ProsecutorDecision = await _context.Eco_ProsecutorDecision
                
                .FirstOrDefaultAsync(m => m.Eco_ProsecutorDecisionId == id);
            if (eco_ProsecutorDecision == null)
            {
                return NotFound();
            }

            return View(eco_ProsecutorDecision);
        }

        // POST: Eco_ProsecutorDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_ProsecutorDecision == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_ProsecutorDecision'  is null.");
            }
            var eco_ProsecutorDecision = await _context.Eco_ProsecutorDecision.FindAsync(id);
            if (eco_ProsecutorDecision != null)
            {
                _context.Eco_ProsecutorDecision.Remove(eco_ProsecutorDecision);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_ProsecutorDecisionExists(Guid id)
        {
          return (_context.Eco_ProsecutorDecision?.Any(e => e.Eco_ProsecutorDecisionId == id)).GetValueOrDefault();
        }
    }
}
