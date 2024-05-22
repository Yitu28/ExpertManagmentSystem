using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.DocumentModel;
using ExpertManagmentSystem.ViewModels.ViewDocument;

namespace ExpertManagmentSystem.Controllers.DocumentController
{
    public class ProsecutorLisencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProsecutorLisencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProsecutorLisences
        public async Task<IActionResult> Index()
        {
              return _context.ProsecutorLisence != null ? 
                          View(await _context.ProsecutorLisence.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.ProsecutorLisence'  is null.");
        }
        public async Task<IActionResult> IndexUpdate()
        {
            //return _context.ProsecutorLisenceUpdate != null ?
            //            View(await _context.ProsecutorLisenceUpdate.ToListAsync()) :
            //            Problem("Entity set 'ApplicationDbContext.ProsecutorLisenceUpdate'  is null.");
            var applicationDbContext = _context.ProsecutorLisenceUpdate.Include(c => c.ProsecutorLisence);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: ProsecutorLisences/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.ProsecutorLisence == null)
            {
                return NotFound();
            }

            var prosecutorLisence = await _context.ProsecutorLisence
                .FirstOrDefaultAsync(m => m.LisenceNo == id);
            if (prosecutorLisence == null)
            {
                return NotFound();
            }

            return View(prosecutorLisence);
        }


        public async Task<IActionResult> DetailsUpdate(Guid? id)
        {
            if (id == null || _context.ProsecutorLisenceUpdate == null)
            {
                return NotFound();
            }

            var prosecutorLisenceupdate = await _context.ProsecutorLisenceUpdate
                .FirstOrDefaultAsync(m => m.ProsecutorLisenceUpdateId == id);
            if (prosecutorLisenceupdate == null)
            {
                return NotFound();
            }

            return View(prosecutorLisenceupdate);
        }
        // GET: ProsecutorLisences/Create

        public async Task<IActionResult> UpdateLicence(string id)
        {
            if (id == null || _context.ProsecutorLisence == null)
            {
                return NotFound();
            }

            var prosecutorLisence = await _context.ProsecutorLisence.FindAsync(id);
            if (prosecutorLisence == null)
            {
                return NotFound();
            }
            var model = new ProsecutorLisenceUpdate
            {
                LisenceNo = prosecutorLisence.LisenceNo
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateLicence(ProsecutorLisenceUpdate prosecutorLisenceUpdate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prosecutorLisenceUpdate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexUpdate));
            }
            return View(prosecutorLisenceUpdate);
        }


        public IActionResult Create()
        {
            return View();
        }

        // POST: ProsecutorLisences/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LisenceNo,ProsecutorName,Gender,Age,Address,PhoneNo,EducationLevel,job,ProffissionalLevel,GivingDate")] ProsecutorLisence prosecutorLisence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prosecutorLisence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(prosecutorLisence);
        }

        // GET: ProsecutorLisences/Edit/5

        public async Task<IActionResult> EditUpdate(Guid?  id)
        {
            if (id == null || _context.ProsecutorLisenceUpdate  == null)
            {
                return NotFound();
            }

            var prosecutorLisenceUpdate = await _context.ProsecutorLisenceUpdate.FindAsync(id);
            if (prosecutorLisenceUpdate == null)
            {
                return NotFound();
            }
            return View(prosecutorLisenceUpdate);
        }

        // POST: ProsecutorLisences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUpdate(ProsecutorLisenceUpdate  prosecutorLisenceupdate, Guid id)
        {
            if (id != prosecutorLisenceupdate.ProsecutorLisenceUpdateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prosecutorLisenceupdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProsecutorLisenceExists(prosecutorLisenceupdate.ProsecutorLisenceUpdateId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexUpdate));
            }
            return View(prosecutorLisenceupdate);
        }

        private bool ProsecutorLisenceExists(Guid prosecutorLisenceUpdateId)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.ProsecutorLisence == null)
            {
                return NotFound();
            }

            var prosecutorLisence = await _context.ProsecutorLisence.FindAsync(id);
            if (prosecutorLisence == null)
            {
                return NotFound();
            }
            return View(prosecutorLisence);
        }

        // POST: ProsecutorLisences/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LisenceNo,ProsecutorName,Gender,Age,Address,PhoneNo,EducationLevel,job,ProffissionalLevel,GivingDate")] ProsecutorLisence prosecutorLisence)
        {
            if (id != prosecutorLisence.LisenceNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prosecutorLisence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProsecutorLisenceExists(prosecutorLisence.LisenceNo))
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
            return View(prosecutorLisence);
        }

        // GET: ProsecutorLisences/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.ProsecutorLisence == null)
            {
                return NotFound();
            }

            var prosecutorLisence = await _context.ProsecutorLisence
                .FirstOrDefaultAsync(m => m.LisenceNo == id);
            if (prosecutorLisence == null)
            {
                return NotFound();
            }

            return View(prosecutorLisence);
        }

        // POST: ProsecutorLisences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.ProsecutorLisence == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProsecutorLisence'  is null.");
            }
            var prosecutorLisence = await _context.ProsecutorLisence.FindAsync(id);
            if (prosecutorLisence != null)
            {
                _context.ProsecutorLisence.Remove(prosecutorLisence);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: ProsecutorLisences/Delete/5
        public async Task<IActionResult> DeleteUpdate(Guid? id)
        {
            if (id == null || _context.ProsecutorLisenceUpdate == null)
            {
                return NotFound();
            }

            var prosecutorLisence = await _context.ProsecutorLisenceUpdate
                .FirstOrDefaultAsync(m => m.ProsecutorLisenceUpdateId == id);
            if (prosecutorLisence == null)
            {
                return NotFound();
            }

            return View(prosecutorLisence);
        }

        // POST: ProsecutorLisences/Delete/5
        [HttpPost, ActionName("DeleteUpdate")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUpdateConfirmed(Guid id)
        {
            if (_context.ProsecutorLisenceUpdate == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ProsecutorLisenceUpdate'  is null.");
            }
            var prosecutorLisenceupdate = await _context.ProsecutorLisenceUpdate.FindAsync(id);
            if (prosecutorLisenceupdate != null)
            {
                _context.ProsecutorLisenceUpdate.Remove(prosecutorLisenceupdate);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexUpdate));
        }

        private bool ProsecutorLisenceExists(string id)
        {
          return (_context.ProsecutorLisence?.Any(e => e.LisenceNo == id)).GetValueOrDefault();
        }
    }
}
