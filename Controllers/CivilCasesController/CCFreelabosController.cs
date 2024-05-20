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
using ExpertManagmentSystem.ViewModels.CivilCaseViewModels;

namespace ExpertManagmentSystem.Controllers.CivilCasesController
{
    public class CCFreelabosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CCFreelabosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CCFreelabos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CCFreelServices.Include(c => c.SectrorsDepartment).Where(c => c.CustomerCategory == CustomerCategory.ነፃ);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CCFreelabos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }

            var cCFreelServices = await _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CCFreelServicesId == id);
            if (cCFreelServices == null)
            {
                return NotFound();
            }

            return View(cCFreelServices);
        }

        public async Task<IActionResult> CCFreeLegalServiceFollowupr(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }

            var CcFreeServices = await _context.CCFreelServices.FindAsync(id);
            if (CcFreeServices == null)
            {
                return NotFound();
            }
            var model = new CCFreeLsfuViewModel
            {

                CCFreelServicesId = CcFreeServices.CCFreelServicesId
            };
            //return PartialView("_FreeCClsfollowupModalPartial", model);
            return View(model);
        }
        // POST: Post Free Legal Services Follow Up
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CCFreeLegalServiceFollowupr([Bind("FreeLegServiceFollowupId,Doc,Doa,AppointmentType,DoD,DecisionStatus,Decisionmadeby,CCFreelServicesId")] CCFreeLegServiceFollowup cCFreeLegServiceFollowup)
        {
            if (ModelState.IsValid)
            {
                cCFreeLegServiceFollowup.FreeLegServiceFollowupId = Guid.NewGuid();
                //cCFreeLegServiceFollowup.DecisionStatus = DecisionStatus.አሸናፊ;
                _context.Add(cCFreeLegServiceFollowup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CCFreeLegalServiceFollowuprIndex(Guid id)
        {
            var applicationDbContext = _context.CCFreeLegServiceFollowup.Include(c => c.CCFreelServices).Where(x => x.CCFreelServicesId == id);
            return View(await applicationDbContext.ToListAsync());
        }




        // GET: Get Free Legal Services Follow Up ID/5
        public async Task<IActionResult> CCFreeLegalServiceFollowup(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }

            var CcFreeServices = await _context.CCFreelServices.FindAsync(id);
            if (CcFreeServices == null)
            {
                return NotFound();
            }
            var model = new CCFreeLsfuViewModel
            {

                CCFreelServicesId = CcFreeServices.CCFreelServicesId
            };
            //return PartialView("_FreeCClsfollowupModalPartial", model);
            return View(model);
        }
        // POST: Post Free Legal Services Follow Up
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CCFreeLegalServiceFollowup([Bind("FreeLegServiceFollowupId,Doc,Doa,AppointmentType,DoD,DecisionStatus,Decisionmadeby,CCFreelServicesId")] CCFreeLegServiceFollowup cCFreeLegServiceFollowup)
        {
            if (ModelState.IsValid)
            {
                cCFreeLegServiceFollowup.FreeLegServiceFollowupId = Guid.NewGuid();
                //cCFreeLegServiceFollowup.DecisionStatus = DecisionStatus.አሸናፊ;
                _context.Add(cCFreeLegServiceFollowup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CCFreeLegalServiceFollowupIndex(Guid id)
        {
            var applicationDbContext = _context.CCFreeLegServiceFollowup.Include(c => c.CCFreelServices).Where(x => x.CCFreelServicesId == id);
            return View(await applicationDbContext.ToListAsync());
        }


        public IActionResult FreeLabrsCreate()
        {
            CCFreelServices Laaos = new();
            return PartialView("_FreeLabrsCreateModalPartial", Laaos);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FreeLabrsCreate(Guid SectrorsDepartmentId, CCFreelServices cCFreelServices)
        {


            if (ModelState.IsValid)
            {
                cCFreelServices.CCFreelServicesId = Guid.NewGuid();
                cCFreelServices.SectrorsDepartmentId = SectrorsDepartmentId;
                cCFreelServices.FreelCategory = FreelCategory.ሰበርተጠሪ;
                cCFreelServices.CustomerCategory = CustomerCategory.ነፃ;
                _context.Add(cCFreelServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            //return View(cCFreelServices);
            return RedirectToAction("Index", "CCFreelabos");
        }

        // GET: CCFreelabos/Create
        public IActionResult Create()
        {
            //ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId");
            //return View();
            CCFreelServices Laaos = new();
            return PartialView("_FreeLabosCreateModalPartial", Laaos);
        }

        // POST: CCFreelabos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Guid SectrorsDepartmentId, CCFreelServices cCFreelServices)
        {


            if (ModelState.IsValid)
            {
                cCFreelServices.CCFreelServicesId = Guid.NewGuid();
                cCFreelServices.SectrorsDepartmentId = SectrorsDepartmentId;
                cCFreelServices.FreelCategory = FreelCategory.ሰበርአመልካች;
                cCFreelServices.CustomerCategory = CustomerCategory.ነፃ;
                _context.Add(cCFreelServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            //return View(cCFreelServices);
            return RedirectToAction("Index", "CCFreelabos");
        }

        // GET: CCFreelabos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }

            var cCFreelServices = await _context.CCFreelServices.FindAsync(id);
            if (cCFreelServices == null)
            {
                return NotFound();
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            return View(cCFreelServices);
        }

        // POST: CCFreelabos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, CCFreelServices cCFreelServices)
        {
            if (id != cCFreelServices.CCFreelServicesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cCFreelServices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CCFreelServicesExists(cCFreelServices.CCFreelServicesId))
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
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            return View(cCFreelServices);
        }

        // GET: CCFreelabos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }

            var cCFreelServices = await _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CCFreelServicesId == id);
            if (cCFreelServices == null)
            {
                return NotFound();
            }

            return View(cCFreelServices);
        }


        // GET: CCFreeLaaos/Delete/5
        public async Task<IActionResult> Deleter(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }

            var cCFreelServices = await _context.CCFreelServices
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.CCFreelServicesId == id);
            if (cCFreelServices == null)
            {
                return NotFound();
            }

            return View(cCFreelServices);
        }

        // POST: CCFreelabos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.CCFreelServices == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CCFreelServices'  is null.");
            }
            var cCFreelServices = await _context.CCFreelServices.FindAsync(id);
            if (cCFreelServices != null)
            {
                _context.CCFreelServices.Remove(cCFreelServices);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CCFreelServicesExists(Guid id)
        {
          return (_context.CCFreelServices?.Any(e => e.CCFreelServicesId == id)).GetValueOrDefault();
        }
    }
}
