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
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        public async Task<IActionResult> DirectChargeResponseOpenningIndex()
        {
            return _context.DirectChargeOpennings != null ?
                        View(await _context.DirectChargeOpennings.Where(dc => dc.CivilCaseCategory == 0).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }
        public async Task<IActionResult> DirectChargeOpenningIndex()
        {
            return _context.DirectChargeOpennings != null ?
                        View(await _context.DirectChargeOpennings.Where(dc => dc.CivilCaseCategory == CivilCaseCategory.DirectChargeResponseOpenning ).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }
        public async Task<IActionResult> GeneralAppealOpenningIndex()
        {
            return _context.DirectChargeOpennings != null ?
                        View(await _context.DirectChargeOpennings.Where(dc => dc.CivilCaseCategory == CivilCaseCategory.GeneralAppealOpenning).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }
        public async Task<IActionResult> GeneralAppealResponseOpenningIndex()
        {
            return _context.DirectChargeOpennings != null ?
                        View(await _context.DirectChargeOpennings.Where(dc => dc.CivilCaseCategory == CivilCaseCategory.GeneralAppealResponseOpenning).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }
        public async Task<IActionResult> BreakingApplicantOpenningIndex()
        {
            return _context.DirectChargeOpennings != null ?
                        View(await _context.DirectChargeOpennings.Where(dc => dc.CivilCaseCategory == CivilCaseCategory.BreakingApplicantOpenning).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }
        public async Task<IActionResult> BreakingRespondentOpenningIndex()
        {
            return _context.DirectChargeOpennings != null ?
                        View(await _context.DirectChargeOpennings.Where(dc => dc.CivilCaseCategory == CivilCaseCategory.BreakingApplicantOpenning).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.DirectChargeOpennings'  is null.");
        }
        // GET: DirectChargeOpennings/Create
        public IActionResult DirectChargeOpenning()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DirectChargeOpenning(DirectChargeOpenning directChargeOpenning)
        {
            if (!ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                directChargeOpenning.CivilCaseCategory = 0;
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DirectChargeOpenningIndex));
            }
            return View(directChargeOpenning);
        }


        // GET: DirectChargeOpennings/Create
        public IActionResult DirectChargeResponseOpenning()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DirectChargeResponseOpenning(DirectChargeOpenning directChargeOpenning)
        {
            if (!ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                directChargeOpenning.CivilCaseCategory = (CivilCaseCategory)1;
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DirectChargeResponseOpenning));
            }
            return View(directChargeOpenning);
        }// GET: DirectChargeOpennings/Create
        public IActionResult GeneralAppealOpenning()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GeneralAppealOpenning(DirectChargeOpenning directChargeOpenning)
        {
            if (!ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                directChargeOpenning.CivilCaseCategory = (CivilCaseCategory)2;
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GeneralAppealOpenningIndex));
            }
            return View(directChargeOpenning);
        }
        // GET: DirectChargeOpennings/Create
        public IActionResult GeneralAppealResponseOpenning()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GeneralAppealResponseOpenning(DirectChargeOpenning directChargeOpenning)
        {
            if (!ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                directChargeOpenning.CivilCaseCategory = (CivilCaseCategory)3;
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(GeneralAppealResponseOpenningIndex));
            }
            return View(directChargeOpenning);
        }   
        // GET: DirectChargeOpennings/Create
        public IActionResult BreakingApplicantOpenning()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BreakingApplicantOpenning(DirectChargeOpenning directChargeOpenning)
        {
            if (!ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                directChargeOpenning.CivilCaseCategory = (CivilCaseCategory)4;
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BreakingApplicantOpenningIndex));
            }
            return View(directChargeOpenning);
        }
        // GET: DirectChargeOpennings/Create
        public IActionResult BreakingRespondentOpenning()
        {
            return View();
        }

        // POST: DirectChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BreakingRespondentOpenning(DirectChargeOpenning directChargeOpenning)
        {
            if (!ModelState.IsValid)
            {
                directChargeOpenning.Id = Guid.NewGuid();
                directChargeOpenning.CivilCaseCategory = (CivilCaseCategory)5;
                _context.Add(directChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(BreakingRespondentOpenningIndex));
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
