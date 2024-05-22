using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.DocumentModel;

namespace ExpertManagmentSystem.Controllers.DocumentController
{
    public class Doc_WarrantyDocumentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Doc_WarrantyDocumentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Doc_WarrantyDocument
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Doc_WarrantyDocument.Include(d => d.Doc_serviceType).Include(d => d.SectrorsDepartment);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> IndexService()
        {
            return _context.Doc_serviceType != null ?
                          View(await _context.Doc_serviceType .ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Doc_serviceType'  is null.");

            //var applicationDbContext = _context.Doc_serviceType.Include(d => d.Doc_serviceType).Include(d => d.SectrorsDepartment);
            //return View(await applicationDbContext.ToListAsync());
        }

        // GET: Doc_WarrantyDocument/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Doc_WarrantyDocument == null)
            {
                return NotFound();
            }

            var doc_WarrantyDocument = await _context.Doc_WarrantyDocument
                .Include(d => d.Doc_serviceType)
                .Include(d => d.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Doc_WarrantyDocumentId == id);
            if (doc_WarrantyDocument == null)
            {
                return NotFound();
            }

            return View(doc_WarrantyDocument);
        }


      
        // GET: Doc_WarrantyDocument/Create
        public IActionResult Create()
        {
            ViewData["Doc_serviceTypeId"] = new SelectList(_context.Set<Doc_serviceType>(), "Doc_serviceTypeId", "Doc_serviceTypeName");
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "DepartmentName");
            return View();
        }

        // POST: Doc_WarrantyDocument/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Doc_WarrantyDocumentId,Doc_serviceTypeId,ServerName,sex,serverAge,TemperFee,ServiceFee,Expert,workedDate,SectrorsDepartmentId")] Doc_WarrantyDocument doc_WarrantyDocument)
        {
            if (ModelState.IsValid)
            {
                doc_WarrantyDocument.Doc_WarrantyDocumentId = Guid.NewGuid();
                _context.Add(doc_WarrantyDocument);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Doc_serviceTypeId"] = new SelectList(_context.Set<Doc_serviceType>(), "Doc_serviceTypeId", "Doc_serviceTypeId", doc_WarrantyDocument.Doc_serviceTypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", doc_WarrantyDocument.SectrorsDepartmentId);
            return View(doc_WarrantyDocument);
        }

        // GET: Doc_WarrantyDocument/Create
        public IActionResult CreateService()
        {
            ViewData["Doc_serviceTypeId"] = new SelectList(_context.Set<Doc_serviceType>(), "Doc_serviceTypeId", "Doc_serviceTypeId");
           
            return View();
        }

        // POST: Doc_WarrantyDocument/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateService([Bind("Doc_serviceTypeId,Doc_serviceTypeName")] Doc_serviceType doc_ServiceType )
        {
            if (!ModelState.IsValid)
            {
                doc_ServiceType.Doc_serviceTypeId  = Guid.NewGuid();
                _context.Add(doc_ServiceType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexService));
            }
            //ViewData["Doc_serviceTypeId"] = new SelectList(_context.Set<Doc_serviceType>(), "Doc_serviceTypeId", "Doc_serviceTypeId");
            return View(doc_ServiceType);
        }


        // GET: Doc_WarrantyDocument/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Doc_WarrantyDocument == null)
            {
                return NotFound();
            }

            var doc_WarrantyDocument = await _context.Doc_WarrantyDocument.FindAsync(id);
            if (doc_WarrantyDocument == null)
            {
                return NotFound();
            }
            ViewData["Doc_serviceTypeId"] = new SelectList(_context.Set<Doc_serviceType>(), "Doc_serviceTypeId", "Doc_serviceTypeId", doc_WarrantyDocument.Doc_serviceTypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", doc_WarrantyDocument.SectrorsDepartmentId);
            return View(doc_WarrantyDocument);
        }

        // POST: Doc_WarrantyDocument/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Doc_WarrantyDocumentId,Doc_serviceTypeId,ServerName,sex,serverAge,TemperFee,ServiceFee,Expert,workedDate,TypeOfService,SectrorsDepartmentId")] Doc_WarrantyDocument doc_WarrantyDocument)
        {
            if (id != doc_WarrantyDocument.Doc_WarrantyDocumentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doc_WarrantyDocument);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doc_WarrantyDocumentExists(doc_WarrantyDocument.Doc_WarrantyDocumentId))
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
            ViewData["Doc_serviceTypeId"] = new SelectList(_context.Set<Doc_serviceType>(), "Doc_serviceTypeId", "Doc_serviceTypeId", doc_WarrantyDocument.Doc_serviceTypeId);
            ViewData["SectrorsDepartmentId"] = new SelectList(_context.SectrorsDepartment, "SectrorsDepartmentId", "SectrorsDepartmentId", doc_WarrantyDocument.SectrorsDepartmentId);
            return View(doc_WarrantyDocument);
        }


        public async Task<IActionResult> EditService(Guid? id)
        {
            if (id == null || _context.Doc_serviceType == null)
            {
                return NotFound();
            }

            var doc_serviceType = await _context.Doc_serviceType.FindAsync(id);
            if (doc_serviceType == null)
            {
                return NotFound();
            }
           
            return View(doc_serviceType);
        }

        // POST: Doc_WarrantyDocument/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditService(Guid id, [Bind("Doc_serviceTypeId,Doc_serviceTypeName")] Doc_serviceType doc_serviceType)
        {
            if (id != doc_serviceType.Doc_serviceTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doc_serviceType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doc_serviceTypeExists(doc_serviceType.Doc_serviceTypeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexService));
            }
           return View(doc_serviceType);
        }

        private bool Doc_serviceTypeExists(Guid doc_serviceTypeId)
        {
            throw new NotImplementedException();
        }

        // GET: Doc_WarrantyDocument/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Doc_WarrantyDocument == null)
            {
                return NotFound();
            }

            var doc_WarrantyDocument = await _context.Doc_WarrantyDocument
                .Include(d => d.Doc_serviceType)
                .Include(d => d.SectrorsDepartment)
                .FirstOrDefaultAsync(m => m.Doc_WarrantyDocumentId == id);
            if (doc_WarrantyDocument == null)
            {
                return NotFound();
            }

            return View(doc_WarrantyDocument);
        }

        // POST: Doc_WarrantyDocument/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Doc_WarrantyDocument == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Doc_WarrantyDocument'  is null.");
            }
            var doc_WarrantyDocument = await _context.Doc_WarrantyDocument.FindAsync(id);
            if (doc_WarrantyDocument != null)
            {
                _context.Doc_WarrantyDocument.Remove(doc_WarrantyDocument);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteService(Guid? id)
        {
            if (id == null || _context.Doc_serviceType == null)
            {
                return NotFound();
            }

            var doc_serviceType = await _context.Doc_serviceType.FindAsync(id);

            if (doc_serviceType == null)
            {
                return NotFound();
            }

            return View(doc_serviceType);
        }

        // POST: Doc_WarrantyDocument/Delete/5
        [HttpPost, ActionName("DeleteService")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteServiceConfirmed(Guid id)
        {
            if (_context.Doc_serviceType == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Doc_serviceType'  is null.");
            }
            var doc_serviceType = await _context.Doc_serviceType.FindAsync(id);
            if (doc_serviceType != null)
            {
                _context.Doc_serviceType.Remove(doc_serviceType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexService));
        }
        private bool Doc_WarrantyDocumentExists(Guid id)
        {
          return (_context.Doc_WarrantyDocument?.Any(e => e.Doc_WarrantyDocumentId == id)).GetValueOrDefault();
        }
    }
}
