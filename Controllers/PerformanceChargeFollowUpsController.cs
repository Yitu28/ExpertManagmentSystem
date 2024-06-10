using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.ViewModels.CivilCaseViewModels;
using Microsoft.AspNetCore.Identity;
using ExpertManagmentSystem.Enums;

namespace ExpertManagmentSystem.Controllers
{
    public class PerformanceChargeFollowUpsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PerformanceChargeFollowUpsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: PerformanceChargeFollowUps
        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            var applicationDbContext = _context.PerformanceChargeFollowUps.Include(p => p.PerformanceChargeOpenning);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> ReportIndex()
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            var applicationDbContext = _context.PerformanceChargeFollowUps.Include(p => p.PerformanceChargeOpenning);
            return View(await applicationDbContext.ToListAsync());
        }



        // GET: PerformanceChargeFollowUps/Create
        public IActionResult Create()
        {
            ViewData["PerformanceChargeOpenningId"] = new SelectList(_context.PerformanceChargeOpennings, "Id", "Id");
            return View();
        }

        // POST: PerformanceChargeFollowUps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PerformanceChargeViewModel viewModel, Guid id /*PerformanceChargeOpenning performanceChargeOpenning*/)
        {
            //var performanceChargeOpenningToBeUpdated = await _context.PerformanceChargeOpennings.FindAsync(id);
            //performanceChargeOpenning.Id = id;
            //performanceChargeOpenning.ProsecutorsSRecordNumber = performanceChargeOpenningToBeUpdated.ProsecutorsSRecordNumber;
            //performanceChargeOpenning.CourtRecordNumber = performanceChargeOpenningToBeUpdated.CourtRecordNumber;
            //performanceChargeOpenning.Accused = performanceChargeOpenningToBeUpdated.Accused;
            //performanceChargeOpenning.Plaintiff = performanceChargeOpenningToBeUpdated.Plaintiff;
            //performanceChargeOpenning.AddressWoreda = performanceChargeOpenningToBeUpdated.AddressWoreda;
            //performanceChargeOpenning.AddressZone = performanceChargeOpenningToBeUpdated.AddressZone;
            //performanceChargeOpenning.AmountPerSquerMetter = performanceChargeOpenningToBeUpdated.AmountPerSquerMetter;
            //performanceChargeOpenning.AmountInBirr = performanceChargeOpenningToBeUpdated.AmountInBirr;
            //performanceChargeOpenning.NameOfCourtCasePresented = performanceChargeOpenningToBeUpdated.NameOfCourtCasePresented;
            //performanceChargeOpenning.CustomerType = performanceChargeOpenningToBeUpdated.CustomerType;
            //performanceChargeOpenning.HasBeenAppointed = performanceChargeOpenningToBeUpdated.HasBeenAppointed;
            //performanceChargeOpenning.EdittedAt = performanceChargeOpenningToBeUpdated.OpenningDate;
            //performanceChargeOpenning.OpenningDate = DateTime.Now;
            //performanceChargeOpenning.NameOfTheExpert = performanceChargeOpenningToBeUpdated.NameOfTheExpert;
            //performanceChargeOpenning.TypeOfPerformanceCharge = performanceChargeOpenningToBeUpdated.TypeOfPerformanceCharge;
            //_context.Attach(performanceChargeOpenning);
            //await _context.SaveChangesAsync();
            var peformanceChargeOpenning = _context.PerformanceChargeOpennings.First(p => p.Id == id);
            peformanceChargeOpenning.PerformanceChargeStatus = PerformanceChargeStatus.Apointed;
            _context.Entry(peformanceChargeOpenning).State = EntityState.Modified;

            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (!ModelState.IsValid)
            {
                viewModel.PerformanceChargeOpenningId = id;
                viewModel.Id = Guid.NewGuid();
                 
                PerformanceChargeFollowUp pcf = new PerformanceChargeFollowUp();
                pcf.PerformanceChargeOpenningId = viewModel.PerformanceChargeOpenningId;
                pcf.Id = viewModel.Id;
                pcf.ApointmentType = viewModel.ApointmentType;
                pcf.ApointmentDate = viewModel.ApointmentDate;
                pcf.HasDecissionMade = viewModel.HasDecissionMade;
                pcf.TypeOfDecission = viewModel.TypeOfDecission;
                pcf.DecidedBy = viewModel.DecidedBy;
                pcf.MoneyGained = viewModel.MoneyGained;
                pcf.ProperyClosed = viewModel.ProperyClosed;
                pcf.DiffrenetReasons = viewModel.DiffrenetReasons;
                pcf.HasBeenAppointed = false;
                pcf.SectorDepartmentId = currentUser.UserDepartmentId;
                pcf.CreatedBy = currentUser.Id;
                pcf.CreatedAt = DateTime.Now    ;
                _context.Add(pcf);
                await _context.SaveChangesAsync();           
                return RedirectToAction(nameof(Index));
            }
            ViewData["PerformanceChargeOpenningId"] = new SelectList(_context.PerformanceChargeOpennings, "Id", "Id", viewModel.PerformanceChargeOpenningId);
            return RedirectToAction(nameof(Index));
            
        }
        // GET: PerformanceChargeFollowUps/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.PerformanceChargeFollowUps == null)
            {
                return NotFound();
            }

            var performanceChargeFollowUp = await _context.PerformanceChargeFollowUps.FindAsync(id);
            if (performanceChargeFollowUp == null)
            {
                return NotFound();
            }
            ViewData["PerformanceChargeOpenningId"] = new SelectList(_context.PerformanceChargeOpennings, "Id", "Id", performanceChargeFollowUp.PerformanceChargeOpenningId);
            return View(performanceChargeFollowUp);
        }

        // POST: PerformanceChargeFollowUps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("NameOfTheExpert,NameOfCourtCasePresented,ApointmentType,ApointmentDate,HasDecissionMade,TypeOfDecission,DecidedBy,MoneyGained,ProperyClosed,DiffrenetReasons,PerformanceChargeOpenningId,Id,CreatedAt,EdittedAt,DeletedAt,ApplicationUserUser")] PerformanceChargeFollowUp performanceChargeFollowUp)
        {
            var currentUser = await _userManager.GetUserAsync(HttpContext.User);

            if (id != performanceChargeFollowUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    performanceChargeFollowUp.EditedBy = currentUser.Id;
                    performanceChargeFollowUp.EdittedAt = DateTime.Now;
                    _context.Update(performanceChargeFollowUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerformanceChargeFollowUpExists(performanceChargeFollowUp.Id))
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
            ViewData["PerformanceChargeOpenningId"] = new SelectList(_context.PerformanceChargeOpennings, "Id", "Id", performanceChargeFollowUp.PerformanceChargeOpenningId);
            return View(performanceChargeFollowUp);
        }

        // GET: PerformanceChargeFollowUps/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.PerformanceChargeFollowUps == null)
            {
                return NotFound();
            }

            var performanceChargeFollowUp = await _context.PerformanceChargeFollowUps
                .Include(p => p.PerformanceChargeOpenning)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performanceChargeFollowUp == null)
            {
                return NotFound();
            }

            return View(performanceChargeFollowUp);
        }

        // POST: PerformanceChargeFollowUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.PerformanceChargeFollowUps == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PerformanceChargeFollowUps'  is null.");
            }
            var performanceChargeFollowUp = await _context.PerformanceChargeFollowUps.FindAsync(id);
            if (performanceChargeFollowUp != null)
            {
                _context.PerformanceChargeFollowUps.Remove(performanceChargeFollowUp);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformanceChargeFollowUpExists(Guid id)
        {
          return (_context.PerformanceChargeFollowUps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}