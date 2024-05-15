using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.OrganizationalStructures;
using ExpertManagmentSystem.ViewModels;
using ExpertManagmentSystem.ViewModels.CrimeViewModels;

namespace ExpertManagmentSystem.Controllers.CrimeControllers
{
    public class Cr_JudicalAppealOpeningController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Cr_JudicalAppealOpeningController(ApplicationDbContext context)
        {
            _context = context;
        }


        public JsonResult Departmentslists()
        {
            var regioneslist = _context.SectrorsDepartment.OrderBy(x => x.DepartmentName).ToList();
            return new JsonResult(regioneslist);
        }

        public JsonResult CrimeTypeList()
        {
            var CrimeTypeList = _context.Cr_Crime_Types.OrderBy(x => x.CrimeTypeName).ToList();
            return new JsonResult(CrimeTypeList);

        }
        // GET: Cr_Judical Appeal Opening Index List(የፍርደኛ ይግባኝ መክፈቻ)
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cr_JudicalAppealOpenings.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cr_Prosecuter Appeal Opening Index List(የዐ/ህግ ይግባኝ መክፈቻ)
        public async Task<IActionResult> ProsecuterIndex()
        {
            var applicationDbContext = _context.Cr_JudicalAppealOpenings.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cr_Prosecuter Brake Appeal Opening Index List(የዐ/ህግ ሰበር መክፈቻ)
        public async Task<IActionResult> ProsecuterBrakeIndex()
        {
            var applicationDbContext = _context.Cr_JudicalAppealOpenings.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cr_JudicialBrake Brake Opening Index List(የፍርደኛ ሰበር መክፈቻ)
        public async Task<IActionResult> JudicialBrakeIndex()
        {
            var applicationDbContext = _context.Cr_JudicalAppealOpenings.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Cr_JudicalAppealOpening/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Cr_JudicalAppealOpenings == null)
            {
                return NotFound();
            }

            var cr_JudicalAppealOpening = await _context.Cr_JudicalAppealOpenings
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Cr_JudicalAppealOpeningId == id);
            if (cr_JudicalAppealOpening == null)
            {
                return NotFound();
            }

            return View(cr_JudicalAppealOpening);
        }

        public async Task<IActionResult> CrFollowupCreate(Guid? id)
        {
            if (id == null || _context.Cr_JudicalAppealOpenings == null)
            {
                return NotFound();
            }

            var Crfollowup = await _context.Cr_JudicalAppealOpenings.FindAsync(id);
            if (Crfollowup == null)
            {
                return NotFound();
            }
            var Vm = new AllCrimeAppealOpninigAndFollowUpViewModel();
            var model = new AllCrimeAppealOpninigAndFollowUpViewModel
            {
                Cr_JudicalAppealOpeningId = Crfollowup.Cr_JudicalAppealOpeningId,            
                HighCourtDecission = Vm.HighCourtDecission,
                FileStatus = Vm.FileStatus,
                FileEndResult = Vm.FileEndResult,
                FederalBreakingRequest = Vm.FederalBreakingRequest,
                Cr_ProsecutorComment =Vm.Cr_ProsecutorComment,

            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrFollowupCreate([Bind("Cr_CrimeFollowUpModelId,Cr_ProsecutorComment,Other,WhoLawyeCommented,HighCourtDecission,OtherCourtDecition,WhoJudgeCommentedOnDecision,NumberOfFemaleAppellants,NumberOfMaleAppellants,FileStatus,FileEndResult,DateOfAppointment,FileIssuedDate,FileReturnedDate,FederalBreakingRequest,Cr_JudicalAppealOpeningId")] Cr_CrimeFollowUpModel cr_CrimeFollowUpModel)
        {
            if (ModelState.IsValid)
            {
                cr_CrimeFollowUpModel.Cr_CrimeFollowUpModelId = Guid.NewGuid();
                _context.Add(cr_CrimeFollowUpModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_JudicalAppealOpeningId"] = new SelectList(_context.Cr_JudicalAppealOpenings, "Cr_JudicalAppealOpeningId", "Cr_JudicalAppealOpeningId", cr_CrimeFollowUpModel.Cr_JudicalAppealOpeningId);
            return View(cr_CrimeFollowUpModel);
        }
        //Get Judical Appeal Opninig
        public IActionResult Create()
        {
            
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_allCrimeCreatePartial", Laaos);
        }

        //Post: Judical Appeal Using Partial
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AppealType,Cr_JudicalAppealOpeningId,OpeninigDate,ProcsecuterNo,CourtNo,Applicant,Respondant,Zone,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_JudicalAppealOpening cr_JudicalAppealOpening)
        {
            if (ModelState.IsValid)
            {
                cr_JudicalAppealOpening.Cr_JudicalAppealOpeningId = Guid.NewGuid();
                _context.Add(cr_JudicalAppealOpening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_JudicalAppealOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_JudicalAppealOpening.SectrorsDepartmentId);
            return View(cr_JudicalAppealOpening);
        }

        //To get Prosecuter Registration form using Partial 
        public IActionResult ProsecuterApealCreate()
        {

            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_ProsecuterApealCreatPartial", Laaos);
        }
        //Post: Prosecuter Registration form using Partial 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProsecuterApealCreate([Bind("AppealType,Cr_JudicalAppealOpeningId,OpeninigDate,ProcsecuterNo,CourtNo,Applicant,Respondant,Zone,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_JudicalAppealOpening cr_JudicalAppealOpening)
        {
            if (ModelState.IsValid)
            {
                cr_JudicalAppealOpening.Cr_JudicalAppealOpeningId = Guid.NewGuid();
                _context.Add(cr_JudicalAppealOpening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProsecuterIndex));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_JudicalAppealOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_JudicalAppealOpening.SectrorsDepartmentId);
            return View(cr_JudicalAppealOpening);
        }

        //To get Prosecuter Brake Registration form using Partial 
        public IActionResult ProsecuterBrakeCreate()
        {

            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_ProsecuterBrakeCreatPartial", Laaos);
        }

        //Post: Prosecuter Brake Registration form using Partial 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProsecuterBrakeCreate([Bind("AppealType,Cr_JudicalAppealOpeningId,OpeninigDate,ProcsecuterNo,CourtNo,Applicant,Respondant,Zone,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_JudicalAppealOpening cr_JudicalAppealOpening)
        {
            if (ModelState.IsValid)
            {
                cr_JudicalAppealOpening.Cr_JudicalAppealOpeningId = Guid.NewGuid();
                _context.Add(cr_JudicalAppealOpening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProsecuterBrakeIndex));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_JudicalAppealOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_JudicalAppealOpening.SectrorsDepartmentId);
            return View(cr_JudicalAppealOpening);
        }

        //To get Judicial Brake Registration form using Partial 
        public IActionResult JudicialBrakeCreate()
        {

            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_JudicialBrakeCreatPartial", Laaos);
        }

        //Post: Judicial Brake Registration form using Partial 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> JudicialBrakeCreate([Bind("AppealType,Cr_JudicalAppealOpeningId,OpeninigDate,ProcsecuterNo,CourtNo,Applicant,Respondant,Zone,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_JudicalAppealOpening cr_JudicalAppealOpening)
        {
            if (ModelState.IsValid)
            {
                cr_JudicalAppealOpening.Cr_JudicalAppealOpeningId = Guid.NewGuid();
                _context.Add(cr_JudicalAppealOpening);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(JudicialBrakeIndex));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_JudicalAppealOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_JudicalAppealOpening.SectrorsDepartmentId);
            return View(cr_JudicalAppealOpening);
        }


        // GET: Cr_JudicalAppealOpening/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Cr_JudicalAppealOpenings == null)
            {
                return NotFound();
            }

            var cr_JudicalAppealOpening = await _context.Cr_JudicalAppealOpenings.FindAsync(id);
            if (cr_JudicalAppealOpening == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_JudicalAppealOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_JudicalAppealOpening.SectrorsDepartmentId);
            return View(cr_JudicalAppealOpening);
        }

        // POST: Cr_JudicalAppealOpening/Edit/5     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("AppealType,Cr_JudicalAppealOpeningId,OpeninigDate,ProcsecuterNo,CourtNo,Applicant,Respondant,Zone,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_JudicalAppealOpening cr_JudicalAppealOpening)
        {
            if (id != cr_JudicalAppealOpening.Cr_JudicalAppealOpeningId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cr_JudicalAppealOpening);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cr_JudicalAppealOpeningExists(cr_JudicalAppealOpening.Cr_JudicalAppealOpeningId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_JudicalAppealOpening.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_JudicalAppealOpening.SectrorsDepartmentId);
            return View(cr_JudicalAppealOpening);
        }

        // GET: Cr_JudicalAppealOpening/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Cr_JudicalAppealOpenings == null)
            {
                return NotFound();
            }

            var cr_JudicalAppealOpening = await _context.Cr_JudicalAppealOpenings
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Cr_JudicalAppealOpeningId == id);
            if (cr_JudicalAppealOpening == null)
            {
                return NotFound();
            }

            return View(cr_JudicalAppealOpening);
        }

        // POST: Cr_JudicalAppealOpening/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Cr_JudicalAppealOpenings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cr_JudicalAppealOpenings'  is null.");
            }
            var cr_JudicalAppealOpening = await _context.Cr_JudicalAppealOpenings.FindAsync(id);
            if (cr_JudicalAppealOpening != null)
            {
                _context.Cr_JudicalAppealOpenings.Remove(cr_JudicalAppealOpening);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cr_JudicalAppealOpeningExists(Guid id)
        {
          return (_context.Cr_JudicalAppealOpenings?.Any(e => e.Cr_JudicalAppealOpeningId == id)).GetValueOrDefault();
        }
    }
}
