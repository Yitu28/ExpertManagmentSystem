using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace ExpertManagmentSystem.Controllers
{
    public class ContractInvestigationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContractInvestigationsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: ContractInvestigations
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return _context.ContractInvestigations != null ? 
                          View(await _context.ContractInvestigations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ContractInvestigations'  is null.");
        }
        public async Task<IActionResult> ReportIndex()
        {
            //var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return _context.ContractInvestigations != null ?
                          View(await _context.ContractInvestigations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ContractInvestigations'  is null.");
        }


        // GET: ContractInvestigations/Create
        public IActionResult ContractDocumentPreparationCreate()
        {
            return View();
        }

        // POST: ContractInvestigations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContractDocumentPreparationCreate(ContractInvestigation contractInvestigation)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (!ModelState.IsValid)
            {
                contractInvestigation.Id = Guid.NewGuid();
                contractInvestigation.ContractInvestigationDocumentType = ContractInvestigationDocumentType.የውል_ሰነድ_ዝግጅት;
                contractInvestigation.OpenningDate = DateTime.Now;
                contractInvestigation.CreatedAt = DateTime.Now;
                contractInvestigation.ApplicationUserId = currentUser.Id;
                contractInvestigation.ContractInvestigationDocumentStatus = 0;
                _context.Add(contractInvestigation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contractInvestigation);
        }
        // GET: ContractInvestigations/Create
        public IActionResult ContractDocumentInvestigationCreate()
        {
            return View();
        }

        // POST: ContractInvestigations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ContractDocumentInvestigationCreate(ContractInvestigation contractInvestigation)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                contractInvestigation.Id = Guid.NewGuid();
                contractInvestigation.ContractInvestigationDocumentType = ContractInvestigationDocumentType.ረቂቅ_ውል_ምርመራ;
                contractInvestigation.EdittedAt = DateAndTime.Now;
                contractInvestigation.EditedBy = currentUser.Id;
                contractInvestigation.ApplicationUserId = currentUser.Id;
                _context.Add(contractInvestigation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contractInvestigation);
        }
        
        // GET: ContractInvestigations/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ContractInvestigations == null)
            {
                return NotFound();
            }

            var contractInvestigation = await _context.ContractInvestigations.FindAsync(id);
            if (contractInvestigation == null)
            {
                return NotFound();
            }
            return View(contractInvestigation);
        }

        // POST: ContractInvestigations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, ContractInvestigation contractInvestigation)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            if (id != contractInvestigation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    contractInvestigation.EdittedAt = DateTime.UtcNow;
                    contractInvestigation.EditedBy = currentUser.Id;
                    contractInvestigation.ApplicationUserId = currentUser.Id;
                    _context.Update(contractInvestigation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContractInvestigationExists(contractInvestigation.Id))
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
            return View(contractInvestigation);
        }

        // GET: ContractInvestigations/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ContractInvestigations == null)
            {
                return NotFound();
            }

            var contractInvestigation = await _context.ContractInvestigations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contractInvestigation == null)
            {
                return NotFound();
            }

            return View(contractInvestigation);
        }

        // POST: ContractInvestigations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ContractInvestigations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ContractInvestigations'  is null.");
            }
            var contractInvestigation = await _context.ContractInvestigations.FindAsync(id);
            if (contractInvestigation != null)
            {
                _context.ContractInvestigations.Remove(contractInvestigation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContractInvestigationExists(Guid id)
        {
          return (_context.ContractInvestigations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
