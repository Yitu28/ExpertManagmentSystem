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
    public class DirectChargeOpenningsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DirectChargeOpenningsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DirectChargeOpennings
        public async Task<IActionResult> Index()
        {
              return _context.DirectChargeOpennings != null ? 
                          View(await _context.DirectChargeOpennings.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }

        // GET: DirectChargeOpennings/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.DirectChargeOpennings == null)
            {
                return NotFound();
            }

            var directChargeOpenning = await _context.DirectChargeOpennings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directChargeOpenning == null)
            {
                return NotFound();
            }

            return View(directChargeOpenning);
        }

        // GET: DirectChargeOpennings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProsecutorsSRecordNumber,CourtRecordNumber,Plaintiff,Accused,OpenningDate,TypeOfIssue,TypeOfCustomer,AmountPerBirr,AmountPerSquerMetter,AddressZone,AddressWoreda,NameOfTheExpert,DateDirected,CompletionDate,TimeTakenToComplete,ProsecutorDecission,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] DirectChargeOpenning directChargeOpenning)
        {
            if (ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(directChargeOpenning);
        }

        // GET: DirectChargeOpennings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.DirectChargeOpennings == null)
            {
                return NotFound();
            }

            var directChargeOpenning = await _context.DirectChargeOpennings.FindAsync(id);
            if (directChargeOpenning == null)
            {
                return NotFound();
            }
            return View(directChargeOpenning);
        }

        // POST: DirectChargeOpennings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ProsecutorsSRecordNumber,CourtRecordNumber,Plaintiff,Accused,OpenningDate,TypeOfIssue,TypeOfCustomer,AmountPerBirr,AmountPerSquerMetter,AddressZone,AddressWoreda,NameOfTheExpert,DateDirected,CompletionDate,TimeTakenToComplete,ProsecutorDecission,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] DirectChargeOpenning directChargeOpenning)
        {
            if (id != directChargeOpenning.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(directChargeOpenning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DirectChargeOpenningExists(directChargeOpenning.Id))
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
            return View(directChargeOpenning);
        }

        // GET: DirectChargeOpennings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.DirectChargeOpennings == null)
            {
                return NotFound();
            }

            var directChargeOpenning = await _context.DirectChargeOpennings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directChargeOpenning == null)
            {
                return NotFound();
            }

            return View(directChargeOpenning);
        }

        // POST: DirectChargeOpennings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.DirectChargeOpennings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
            }
            var directChargeOpenning = await _context.DirectChargeOpennings.FindAsync(id);
            if (directChargeOpenning != null)
            {
                _context.DirectChargeOpennings.Remove(directChargeOpenning);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DirectChargeOpenningExists(Guid id)
        {
          return (_context.DirectChargeOpennings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
