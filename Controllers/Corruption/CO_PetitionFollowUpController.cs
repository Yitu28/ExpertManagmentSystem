using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.Corruption;
using ExpertManagmentSystem.ViewModels.CorruptionViewModel;

namespace ExpertManagmentSystem.Controllers.Corruption
{
    public class CO_PetitionFollowUpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CO_PetitionFollowUpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CO_PetitionFollowUp
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CO_PetitionFollowUp.Include(c => c.CO_Petition).Include(c => c.CO_Petition.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CO_PetitionFollowUp/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CO_PetitionFollowUp == null)
            {
                return NotFound();
            }

            var cO_PetitionFollowUp = await _context.CO_PetitionFollowUp
                .Include(c => c.CO_Petition)
                //.Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_PetitionFollowUpId == id);
            if (cO_PetitionFollowUp == null)
            {
                return NotFound();
            }

            return View(cO_PetitionFollowUp);
        }

        // GET: CO_PetitionFollowUp/Create
        public IActionResult Create()
        {
            
            ViewData["CO_PetitionId"] = new SelectList(_context.CO_Petition, "CO_PetitionId", "CO_PetitionId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: CO_PetitionFollowUp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( CO_PetitionFollowUpViewModel cO_PetitionFollowUp, Guid id/*, CO_PetitionFollowUp cO_PetitionFollowUpVM*/)
        {
            if (!ModelState.IsValid)
            {
                cO_PetitionFollowUp.CO_PetitionId = id;
                cO_PetitionFollowUp.CO_PetitionFollowUpId = Guid.NewGuid();


                cO_PetitionFollowUp.SectrorsDepartmentId = _context.CO_Petition.First(i => i.CO_PetitionId == cO_PetitionFollowUp.CO_PetitionId).SectrorsDepartmentId;


                CO_PetitionFollowUp pfu = new CO_PetitionFollowUp();
                pfu.CO_PetitionFollowUpId = cO_PetitionFollowUp.CO_PetitionFollowUpId;
                pfu.CO_PetitionId = cO_PetitionFollowUp.CO_PetitionId;
                pfu.ExpertName = cO_PetitionFollowUp.ExpertName;
                pfu.SectrorsDepartmentId = cO_PetitionFollowUp.SectrorsDepartmentId;
                pfu.IssueDate = cO_PetitionFollowUp.IssueDate;
                pfu.ReturnDate = cO_PetitionFollowUp.ReturnDate;
                pfu.PetitionDecision = (Models.Corruption.PetitionDecision)cO_PetitionFollowUp.PetitionDecision;
                pfu.ComeanEnd = (Models.Corruption.ComeanEnd)cO_PetitionFollowUp.ComeanEnd;


                //cO_PetitionFollowUpVM.CO_PetitionFollowUpId = cO_PetitionFollowUp.CO_PetitionFollowUpId;
                //cO_PetitionFollowUpVM.CO_PetitionId = cO_PetitionFollowUp.CO_PetitionId;
                //cO_PetitionFollowUpVM.ExpertName = cO_PetitionFollowUp.ExpertName;
                //cO_PetitionFollowUpVM.SectrorsDepartmentId = cO_PetitionFollowUp.SectrorsDepartmentId;
                //cO_PetitionFollowUpVM.IssueDate = cO_PetitionFollowUp.IssueDate;
                //cO_PetitionFollowUpVM.ReturnDate = cO_PetitionFollowUp.ReturnDate;
                //cO_PetitionFollowUpVM.PetitionDecision = (Models.Corruption.PetitionDecision)cO_PetitionFollowUp.PetitionDecision;
                //cO_PetitionFollowUpVM.ComeanEnd = (Models.Corruption.ComeanEnd)cO_PetitionFollowUp.ComeanEnd;



                _context.Add(pfu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CO_PetitionId"] = new SelectList(_context.CO_Petition, "CO_PetitionId", "CO_PetitionId", cO_PetitionFollowUp.CO_PetitionId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName", cO_PetitionFollowUp.SectrorsDepartmentId);
            return RedirectToAction(nameof(Index));
            //return View(cO_PetitionFollowUp);
        }

        // GET: CO_PetitionFollowUp/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CO_PetitionFollowUp == null)
            {
                return NotFound();
            }

            var cO_PetitionFollowUp = await _context.CO_PetitionFollowUp.FindAsync(id);
            if (cO_PetitionFollowUp == null)
            {
                return NotFound();
            }
            ViewData["CO_PetitionId"] = new SelectList(_context.CO_Petition, "CO_PetitionId", "CO_PetitionId", cO_PetitionFollowUp.CO_PetitionId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_PetitionFollowUp.SectrorsDepartmentId);
            return View(cO_PetitionFollowUp);
        }

        // POST: CO_PetitionFollowUp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CO_PetitionFollowUpId,CO_PetitionId,ExpertName,IssueDate,ReturnDate,PetitionDecision,ComeanEnd,SectrorsDepartmentId")] CO_PetitionFollowUp cO_PetitionFollowUp)
        {
            if (id != cO_PetitionFollowUp.CO_PetitionFollowUpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cO_PetitionFollowUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CO_PetitionFollowUpExists(cO_PetitionFollowUp.CO_PetitionFollowUpId))
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
            ViewData["CO_PetitionId"] = new SelectList(_context.CO_Petition, "CO_PetitionId", "CO_PetitionId", cO_PetitionFollowUp.CO_PetitionId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cO_PetitionFollowUp.SectrorsDepartmentId);
            return View(cO_PetitionFollowUp);
        }

        // GET: CO_PetitionFollowUp/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CO_PetitionFollowUp == null)
            {
                return NotFound();
            }

            var cO_PetitionFollowUp = await _context.CO_PetitionFollowUp
                .Include(c => c.CO_Petition)
                //.Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CO_PetitionFollowUpId == id);
            if (cO_PetitionFollowUp == null)
            {
                return NotFound();
            }

            return View(cO_PetitionFollowUp);
        }

        // POST: CO_PetitionFollowUp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CO_PetitionFollowUp == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CO_PetitionFollowUp'  is null.");
            }
            var cO_PetitionFollowUp = await _context.CO_PetitionFollowUp.FindAsync(id);
            if (cO_PetitionFollowUp != null)
            {
                _context.CO_PetitionFollowUp.Remove(cO_PetitionFollowUp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CO_PetitionFollowUpExists(Guid id)
        {
          return (_context.CO_PetitionFollowUp?.Any(e => e.CO_PetitionFollowUpId == id)).GetValueOrDefault();
        }
    }
}
