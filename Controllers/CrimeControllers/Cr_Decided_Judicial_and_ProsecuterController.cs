﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.CrimeModels;

namespace ExpertManagmentSystem.Controllers
{
    public class Cr_Decided_Judicial_and_ProsecuterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Cr_Decided_Judicial_and_ProsecuterController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cr_Decided_Judicial_and_Prosecuter
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Cr_Decided_Judicial_and_Prosecuters.Include(c => c.Cr_Crime_Type).Include(c => c.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
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
        // GET: Cr_Decided_Judicial_and_Prosecuter/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Cr_Decided_Judicial_and_Prosecuters == null)
            {
                return NotFound();
            }

            var cr_Decided_Judicial_and_Prosecuter = await _context.Cr_Decided_Judicial_and_Prosecuters
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Cr_Decided_Judicial_and_ProsecuterId == id);
            if (cr_Decided_Judicial_and_Prosecuter == null)
            {
                return NotFound();
            }

            return View(cr_Decided_Judicial_and_Prosecuter);
        }

        // GET: Cr_Decided_Judicial_and_Prosecuter/Create

        public IActionResult Create()
        {
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");

            //var examList = courses.Select(c => new ExamViewModel
            //{
            //    ExamId = c.ExamId,
            //    CourseName = c.CourseName
            //}).ToList();
            //return View();
            Cr_Decided_Judicial_and_Prosecuter Laaos = new();
            return PartialView("_Cr_Decided_Judicial_and_Prosecuterpartial", Laaos);
        }
        public IActionResult Cr_DecideJudiciryandProsecuterCreate()
        {
            Cr_Decided_Judicial_and_Prosecuter x = new Cr_Decided_Judicial_and_Prosecuter();
            return PartialView("_Cr_Decided_Judicial_and_Prosecuterpartial",x);
        
        }

            //public IActionResult Create()
            //{
            //    ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "CrimeTypeName");
            //    ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            //    return View();
            //}

            // POST: Cr_Decided_Judicial_and_Prosecuter/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cr_Decided_Judicial_and_ProsecuterId,OpeningDate,ProsocuterNo,Court_No,Applicant,Respondant,CrimeType,ProsecutorComment,Other,WhoLawyeCommented,HighCourtDecission,OtherCourtDecition,WhoJudgeCommentedOnDecision,NumberOfFemaleAppellants,NumberOfMaleAppellants,FileStatus,FileEndResult,FederalBreakingRequest,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_Decided_Judicial_and_Prosecuter cr_Decided_Judicial_and_Prosecuter)
        {
            if (ModelState.IsValid)
            {
                cr_Decided_Judicial_and_Prosecuter.Cr_Decided_Judicial_and_ProsecuterId = Guid.NewGuid();
                _context.Add(cr_Decided_Judicial_and_Prosecuter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_Decided_Judicial_and_Prosecuter.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_Decided_Judicial_and_Prosecuter.SectrorsDepartmentId);
            return View(cr_Decided_Judicial_and_Prosecuter);
        }

        // GET: Cr_Decided_Judicial_and_Prosecuter/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Cr_Decided_Judicial_and_Prosecuters == null)
            {
                return NotFound();
            }

            var cr_Decided_Judicial_and_Prosecuter = await _context.Cr_Decided_Judicial_and_Prosecuters.FindAsync(id);
            if (cr_Decided_Judicial_and_Prosecuter == null)
            {
                return NotFound();
            }
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_Decided_Judicial_and_Prosecuter.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_Decided_Judicial_and_Prosecuter.SectrorsDepartmentId);
            return View(cr_Decided_Judicial_and_Prosecuter);
        }

        // POST: Cr_Decided_Judicial_and_Prosecuter/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Cr_Decided_Judicial_and_ProsecuterId,OpeningDate,ProsocuterNo,Court_No,Applicant,Respondant,CrimeType,ProsecutorComment,Other,WhoLawyeCommented,HighCourtDecission,OtherCourtDecition,WhoJudgeCommentedOnDecision,NumberOfFemaleAppellants,NumberOfMaleAppellants,FileStatus,FileEndResult,FederalBreakingRequest,Cr_Crime_TypeId,SectrorsDepartmentId")] Cr_Decided_Judicial_and_Prosecuter cr_Decided_Judicial_and_Prosecuter)
        {
            if (id != cr_Decided_Judicial_and_Prosecuter.Cr_Decided_Judicial_and_ProsecuterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cr_Decided_Judicial_and_Prosecuter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cr_Decided_Judicial_and_ProsecuterExists(cr_Decided_Judicial_and_Prosecuter.Cr_Decided_Judicial_and_ProsecuterId))
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
            ViewData["Cr_Crime_TypeId"] = new SelectList(_context.Cr_Crime_Types, "Cr_Crime_TypeId", "Cr_Crime_TypeId", cr_Decided_Judicial_and_Prosecuter.Cr_Crime_TypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", cr_Decided_Judicial_and_Prosecuter.SectrorsDepartmentId);
            return View(cr_Decided_Judicial_and_Prosecuter);
        }

        // GET: Cr_Decided_Judicial_and_Prosecuter/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Cr_Decided_Judicial_and_Prosecuters == null)
            {
                return NotFound();
            }

            var cr_Decided_Judicial_and_Prosecuter = await _context.Cr_Decided_Judicial_and_Prosecuters
                .Include(c => c.Cr_Crime_Type)
                .Include(c => c.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Cr_Decided_Judicial_and_ProsecuterId == id);
            if (cr_Decided_Judicial_and_Prosecuter == null)
            {
                return NotFound();
            }

            return View(cr_Decided_Judicial_and_Prosecuter);
        }

        // POST: Cr_Decided_Judicial_and_Prosecuter/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Cr_Decided_Judicial_and_Prosecuters == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cr_Decided_Judicial_and_Prosecuters'  is null.");
            }
            var cr_Decided_Judicial_and_Prosecuter = await _context.Cr_Decided_Judicial_and_Prosecuters.FindAsync(id);
            if (cr_Decided_Judicial_and_Prosecuter != null)
            {
                _context.Cr_Decided_Judicial_and_Prosecuters.Remove(cr_Decided_Judicial_and_Prosecuter);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cr_Decided_Judicial_and_ProsecuterExists(Guid id)
        {
          return (_context.Cr_Decided_Judicial_and_Prosecuters?.Any(e => e.Cr_Decided_Judicial_and_ProsecuterId == id)).GetValueOrDefault();
        }
    }
}
