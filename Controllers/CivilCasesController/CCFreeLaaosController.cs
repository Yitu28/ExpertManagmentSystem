using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.OrganizationalStructures;
using ExpertManagmentSystem.ViewModels;
using ExpertManagmentSystem.ViewModels.CivilCaseViewModels;
using ExpertManagmentSystem.Enums;

namespace ExpertManagmentSystem.Controllers.CivilCasesController
{
    public class CCFreeLaaosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CCFreeLaaosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CCFreeLaaos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CCFreelServices.Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CCFreeLaaos/Details/5
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
        public JsonResult Departmentslists()
        {
            var regioneslist = _context.SectrorsDepartment.OrderBy(x => x.DepartmentName).ToList();
            return new JsonResult(regioneslist);
        }

        public IActionResult FreeLaarsCreate()
        {
            CCFreelServices Laaos = new();
            return PartialView("_FreeLaarsCreateModalPartial", Laaos);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> FreeLaarsCreate(Guid SectrorsDepartmentId, CCFreelServices cCFreelServices)
        {


            if (ModelState.IsValid)
            {
                cCFreelServices.CCFreelServicesId = Guid.NewGuid();
                cCFreelServices.SectrorsDepartmentId = SectrorsDepartmentId;
                cCFreelServices.FreelCategory = FreelCategory.ይግባኝመልስ;
                _context.Add(cCFreelServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            //return View(cCFreelServices);
            return RedirectToAction("Index", "CCFreeLaaos");
        }

        // GET: CCFreeLaaros/Create
        public IActionResult Create()
        {
            //ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            //return View();
            CCFreelServices Laaos = new();
            return PartialView("_FreeLaaosCreateModalPartial", Laaos);
        }



        // POST: CCFreeLaaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Guid SectrorsDepartmentId, CCFreelServices cCFreelServices)
        {
            

            if (ModelState.IsValid)
            {
                cCFreelServices.CCFreelServicesId = Guid.NewGuid();
                cCFreelServices.SectrorsDepartmentId = SectrorsDepartmentId;
                cCFreelServices.FreelCategory = FreelCategory.ይግባኝአመልካች;
                _context.Add(cCFreelServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            //return View(cCFreelServices);
            return RedirectToAction("Index", "CCFreeLaaos");
        }

        // GET: CCFreeLaaos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.CCFreelServices == null)
            {
                return NotFound();
            }
            var Laaos = await _context.CCFreelServices.FindAsync(id);
            if (Laaos == null)
            {
                return NotFound();
            }
            //ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cCFreelServices.SectrorsDepartmentId);
            // CCFreelServices Laaos = new();
            return PartialView("_FreeLaaosEditModalPartial", Laaos); 
            //return View(cCFreelServices);
        }

        // POST: CCFreeLaaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CCFreelServicesId,FileNo,RecorNo,Applicant,Responder,Gender,Age,SupportType,Doo,typesofIssue,apsm,AddressZone,AddressWoreda,ExpertName,DoAss,DoRet,LOS,PDecission,SectrorsDepartmentId,FreelCategory")] CCFreelServices cCFreelServices)
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

        // GET: CCFreeLaaos/Delete/5
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

        // POST: CCFreeLaaos/Delete/5
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
