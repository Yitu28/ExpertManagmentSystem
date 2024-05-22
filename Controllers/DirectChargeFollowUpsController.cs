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
    public class DirectChargeFollowUpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DirectChargeFollowUpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DirectChargeFollowUps
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.DirectChargeFollowUps.Include(d => d.DirectChargeOpenning);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DirectChargeFollowUps/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.DirectChargeFollowUps == null)
            {
                return NotFound();
            }

            var directChargeFollowUp = await _context.DirectChargeFollowUps
                .Include(d => d.DirectChargeOpenning)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directChargeFollowUp == null)
            {
                return NotFound();
            }

            return View(directChargeFollowUp);
        }

        // GET: DirectChargeFollowUps/Create
        public IActionResult Create()
        {
            ViewData["DirectChargeOppeningId"] = new SelectList(_context.DirectChargeOpennings, "Id", "Id");
            return View();
        }

        // POST: DirectChargeFollowUps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DirectChargeFollowUp directChargeFollowUp)
        {
            if (ModelState.IsValid)
            {
                directChargeFollowUp.Id = Guid.NewGuid();
                _context.Add(directChargeFollowUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DirectChargeOppeningId"] = new SelectList(_context.DirectChargeOpennings, "Id", "Id", directChargeFollowUp.DirectChargeOppeningId);
            return View(directChargeFollowUp);
        }

        //// GET: DirectChargeFollowUps/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null || _context.DirectChargeFollowUps == null)
        //    {
        //        return NotFound();
        //    }

        //    var directChargeFollowUp = await _context.DirectChargeFollowUps.FindAsync(id);
        //    if (directChargeFollowUp == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["DirectChargeOppeningId"] = new SelectList(_context.DirectChargeOpennings, "Id", "Id", directChargeFollowUp.DirectChargeOppeningId);
        //    return View(directChargeFollowUp);
        //}

        //// POST: DirectChargeFollowUps/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("IssuedCourtWrittenForOrganization,DateSubmittedToCourt,DateApointmented,DecissionDate,CivilCaseCategory,DirectChargeOppeningId,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] DirectChargeFollowUp directChargeFollowUp)
        //{
        //    if (id != directChargeFollowUp.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(directChargeFollowUp);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!DirectChargeFollowUpExists(directChargeFollowUp.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["DirectChargeOppeningId"] = new SelectList(_context.DirectChargeOpennings, "Id", "Id", directChargeFollowUp.DirectChargeOppeningId);
        //    return View(directChargeFollowUp);
        //}

        // GET: DirectChargeFollowUps/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.DirectChargeFollowUps == null)
            {
                return NotFound();
            }

            var directChargeFollowUp = await _context.DirectChargeFollowUps
                .Include(d => d.DirectChargeOpenning)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (directChargeFollowUp == null)
            {
                return NotFound();
            }

            return View(directChargeFollowUp);
        }

        // POST: DirectChargeFollowUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.DirectChargeFollowUps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DirectChargeFollowUps'  is null.");
            }
            var directChargeFollowUp = await _context.DirectChargeFollowUps.FindAsync(id);
            if (directChargeFollowUp != null)
            {
                _context.DirectChargeFollowUps.Remove(directChargeFollowUp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DirectChargeFollowUpExists(Guid id)
        {
          return (_context.DirectChargeFollowUps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
