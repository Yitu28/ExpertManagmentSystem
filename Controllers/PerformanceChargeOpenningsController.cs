using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;
using Microsoft.AspNetCore.Identity;
using ExpertManagmentSystem.Enums;

namespace ExpertManagmentSystem.Controllers
{
    public class PerformanceChargeOpenningsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PerformanceChargeOpenningsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: PerformanceChargeOpennings
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);
            return _context.PerformanceChargeOpennings != null ? 
                          View(await _context.PerformanceChargeOpennings.Where(pco => pco.PerformanceChargeStatus == PerformanceChargeStatus.Pending).ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PerformanceChargeOpennings'  is null.");
        }

        
        // GET: PerformanceChargeOpennings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerformanceChargeOpennings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PerformanceChargeOpenning performanceChargeOpenning)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (!ModelState.IsValid)
            {
                performanceChargeOpenning.Id = Guid.NewGuid();
                performanceChargeOpenning.PerformanceChargeStatus = 0;
                //performanceChargeOpenning.ApplicationUserId = currentUser.Id;
                //performanceChargeOpenning.CreatedBy = currentUser.Id;
                performanceChargeOpenning.CreatedAt = DateTime.Now;
                performanceChargeOpenning.OpenningDate = DateTime.Now;
                _context.Add(performanceChargeOpenning);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //return RedirectToAction(nameof(Index));

            return View(performanceChargeOpenning);
        }
        // GET: PerformanceChargeOpennings/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.PerformanceChargeOpennings == null)
            {
                return NotFound();
            }

            var performanceChargeOpenning = await _context.PerformanceChargeOpennings.FindAsync(id);
            if (performanceChargeOpenning == null)
            {
                return NotFound();
            }
            return View(performanceChargeOpenning);
        }

        // POST: PerformanceChargeOpennings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, PerformanceChargeOpenning performanceChargeOpenning)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (id != performanceChargeOpenning.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var performanceChargeOpenningEntity = new PerformanceChargeOpenning()
                    {
                        //var performanceChargeOpenningToBeUpdated = await _context.PerformanceChargeOpennings.FindAsync(id);
                        Id = id,
                        ProsecutorsSRecordNumber = performanceChargeOpenning.ProsecutorsSRecordNumber,
                        CourtRecordNumber = performanceChargeOpenning.CourtRecordNumber,
                        Accused = performanceChargeOpenning.Accused,
                        Plaintiff = performanceChargeOpenning.Plaintiff,
                        AddressWoreda = performanceChargeOpenning.AddressWoreda,
                        AddressZone = performanceChargeOpenning.AddressZone,
                        AmountPerSquerMetter = performanceChargeOpenning.AmountPerSquerMetter,
                        AmountInBirr = performanceChargeOpenning.AmountInBirr,
                        NameOfCourtCasePresented = performanceChargeOpenning.NameOfCourtCasePresented,
                        CustomerType = performanceChargeOpenning.CustomerType,
                        EdittedAt = performanceChargeOpenning.OpenningDate,
                        OpenningDate = DateTime.Now,
                        NameOfTheExpert = performanceChargeOpenning.NameOfTheExpert,
                        TypeOfPerformanceCharge = performanceChargeOpenning.TypeOfPerformanceCharge
                        
                    //_context.Attach(performanceChargeOpenning);
                    //await _context.SaveChangesAsync();
                };
                    performanceChargeOpenning.EdittedAt = DateTime.Now;
                    performanceChargeOpenning.EditedBy = currentUser.Id;
                _context.PerformanceChargeOpennings.Attach(performanceChargeOpenningEntity);
                _context.Entry(performanceChargeOpenningEntity).Property(x => x.Id).IsModified = true;
                _context.Entry(performanceChargeOpenningEntity).Property(x => x.ProsecutorsSRecordNumber).IsModified = true;
                _context.Entry(performanceChargeOpenningEntity).Property(x => x.CourtRecordNumber).IsModified = true;
                _context.SaveChanges();
            }

                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformanceChargeOpenningExists(performanceChargeOpenning.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }                
            return View(performanceChargeOpenning);

        }

        // GET: PerformanceChargeOpennings/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.PerformanceChargeOpennings == null)
            {
                return NotFound();
            }

            var performanceChargeOpenning = await _context.PerformanceChargeOpennings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performanceChargeOpenning == null)
            {
                return NotFound();
            }

            return View(performanceChargeOpenning);
        }

        // POST: PerformanceChargeOpennings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.PerformanceChargeOpennings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PerformanceChargeOpennings'  is null.");
            }
            var performanceChargeOpenning = await _context.PerformanceChargeOpennings.FindAsync(id);
            if (performanceChargeOpenning != null)
            {
                _context.PerformanceChargeOpennings.Remove(performanceChargeOpenning);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformanceChargeOpenningExists(Guid id)
        {
          return (_context.PerformanceChargeOpennings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
