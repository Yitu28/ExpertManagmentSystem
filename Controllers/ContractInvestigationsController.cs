using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;

namespace ExpertManagmentSystem.Controllers
{
    public class ContractInvestigationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContractInvestigationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ContractInvestigations
        public async Task<IActionResult> Index()
        {
              return _context.ContractInvestigations != null ? 
                          View(await _context.ContractInvestigations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ContractInvestigations'  is null.");
        }

        // GET: ContractInvestigations/Details/5
        public async Task<IActionResult> Details(Guid? id)
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

        // GET: ContractInvestigations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ContractInvestigations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProsecutorIdentityNumber,Contractor,ContractReciepient,OpenningDate,TypeOfContract,AmountPerMoney,TheInstitutionRequestedForExamination,NameOfTheExpert,CompletionDate,TimeTakenToComplete,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] ContractInvestigation contractInvestigation)
        {
            if (ModelState.IsValid)
            {
                contractInvestigation.Id = Guid.NewGuid();
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
        public async Task<IActionResult> Edit(Guid id, [Bind("ProsecutorIdentityNumber,Contractor,ContractReciepient,OpenningDate,TypeOfContract,AmountPerMoney,TheInstitutionRequestedForExamination,NameOfTheExpert,CompletionDate,TimeTakenToComplete,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] ContractInvestigation contractInvestigation)
        {
            if (id != contractInvestigation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
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
