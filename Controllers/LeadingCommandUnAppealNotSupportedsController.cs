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

namespace ExpertManagmentSystem.Controllers
{
    public class LeadingCommandUnAppealNotSupportedsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeadingCommandUnAppealNotSupportedsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LeadingCommandUnAppealNotSupporteds
        public async Task<IActionResult> Index()
        {
              return _context.LeadingCommandUnAppealNotSupporteds != null ? 
                          View(await _context.LeadingCommandUnAppealNotSupporteds.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.LeadingCommandUnAppealNotSupporteds'  is null.");
        }
        public async Task<IActionResult> LeadingCommands()
        {
            return _context.LeadingCommandUnAppealNotSupporteds != null ?
                        View(await _context.LeadingCommandUnAppealNotSupporteds.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.LeadingCommandUnAppealNotSupporteds'  is null.");
        }
        // GET: LeadingCommandUnAppealNotSupporteds/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.LeadingCommandUnAppealNotSupporteds == null)
            {
                return NotFound();
            }

            var leadingCommandUnAppealNotSupported = await _context.LeadingCommandUnAppealNotSupporteds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leadingCommandUnAppealNotSupported == null)
            {
                return NotFound();
            }

            return View(leadingCommandUnAppealNotSupported);
        }

        // GET: LeadingCommandUnAppealNotSupporteds/Create
        public IActionResult CreateLeadingCommand()
        {
            return View();
        }

        // POST: LeadingCommandUnAppealNotSupporteds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateLeadingCommand([Bind("ProsecutorRecordNumber,CourtRecordNumber,Plaintiff,Accused,OpenningDate,TypeOfIssue,LeadingCommandAndUnSupportAppeal,AmountPerBirr,AmountPerSquerMetter,ProsecutorSupportTo,AddressZone,AddressWoreda,NameOfTheExpert,CompletionDate,TimeTakenToComplete,ProsecutorDecission,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] LeadingCommandAndAppealNotSupported leadingCommandUnAppealNotSupported)
        {
            if (ModelState.IsValid)
            {
                leadingCommandUnAppealNotSupported.LeadingCommandAndUnSupportAppeal = 0;
                leadingCommandUnAppealNotSupported.Id = Guid.NewGuid();
                _context.Add(leadingCommandUnAppealNotSupported);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(LeadingCommands));
            }
            return View(leadingCommandUnAppealNotSupported);
        }

        public IActionResult CreateAppealNotSupported()
        {
            return View();
        }

        // POST: LeadingCommandUnAppealNotSupporteds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAppealNotSupported([Bind("ProsecutorRecordNumber,CourtRecordNumber,Plaintiff,Accused,OpenningDate,TypeOfIssue,LeadingCommandAndUnSupportAppeal,AmountPerBirr,AmountPerSquerMetter,ProsecutorSupportTo,AddressZone,AddressWoreda,NameOfTheExpert,CompletionDate,TimeTakenToComplete,ProsecutorDecission,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] LeadingCommandAndAppealNotSupported leadingCommandUnAppealNotSupported)
        {
            if (ModelState.IsValid)
            {
                leadingCommandUnAppealNotSupported.LeadingCommandAndUnSupportAppeal = (LeadingCommandAndUnSupportAppeal)1;
                leadingCommandUnAppealNotSupported.Id = Guid.NewGuid();
                _context.Add(leadingCommandUnAppealNotSupported);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leadingCommandUnAppealNotSupported);
        }

        // GET: LeadingCommandUnAppealNotSupporteds/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.LeadingCommandUnAppealNotSupporteds == null)
            {
                return NotFound();
            }

            var leadingCommandUnAppealNotSupported = await _context.LeadingCommandUnAppealNotSupporteds.FindAsync(id);
            if (leadingCommandUnAppealNotSupported == null)
            {
                return NotFound();
            }
            return View(leadingCommandUnAppealNotSupported);
        }

        // POST: LeadingCommandUnAppealNotSupporteds/Edit/5
        
        // GET: LeadingCommandUnAppealNotSupporteds/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.LeadingCommandUnAppealNotSupporteds == null)
            {
                return NotFound();
            }

            var leadingCommandUnAppealNotSupported = await _context.LeadingCommandUnAppealNotSupporteds
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leadingCommandUnAppealNotSupported == null)
            {
                return NotFound();
            }

            return View(leadingCommandUnAppealNotSupported);
        }

        // POST: LeadingCommandUnAppealNotSupporteds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.LeadingCommandUnAppealNotSupporteds == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeadingCommandUnAppealNotSupporteds'  is null.");
            }
            var leadingCommandUnAppealNotSupported = await _context.LeadingCommandUnAppealNotSupporteds.FindAsync(id);
            if (leadingCommandUnAppealNotSupported != null)
            {
                _context.LeadingCommandUnAppealNotSupporteds.Remove(leadingCommandUnAppealNotSupported);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeadingCommandUnAppealNotSupportedExists(Guid id)
        {
          return (_context.LeadingCommandUnAppealNotSupporteds?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
