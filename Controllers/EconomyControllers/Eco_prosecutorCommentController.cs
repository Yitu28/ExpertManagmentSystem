using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpertManagmentSystem.Data;
using ExpertManagmentSystem.Models.EconomyModels;

namespace ExpertManagmentSystem.Controllers.EconomyControllers
{
    public class Eco_prosecutorCommentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Eco_prosecutorCommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Eco_prosecutorComment
        public async Task<IActionResult> Index()
        {
            
            return _context.Eco_prosecutorComment != null ?
                          View(await _context.Eco_prosecutorComment.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Eco_prosecutorComment'  is null.");
        }

        // GET: Eco_prosecutorComment/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.Eco_prosecutorComment == null)
            {
                return NotFound();
            }

            var eco_prosecutorComment = await _context.Eco_prosecutorComment
              
                .FirstOrDefaultAsync(m => m.Eco_prosecutorCommentId == id);
            if (eco_prosecutorComment == null)
            {
                return NotFound();
            }

            return View(eco_prosecutorComment);
        }

        // GET: Eco_prosecutorComment/Create
        public IActionResult Create()
        {
           
            return View();
        }

        // POST: Eco_prosecutorComment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eco_prosecutorCommentId,ProsecutorComment,Department")] Eco_prosecutorComment eco_prosecutorComment)
        {
            if (ModelState.IsValid)
            {
                eco_prosecutorComment.Eco_prosecutorCommentId = Guid.NewGuid();
                _context.Add(eco_prosecutorComment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
         
            return View(eco_prosecutorComment);
        }

        // GET: Eco_prosecutorComment/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.Eco_prosecutorComment == null)
            {
                return NotFound();
            }

            var eco_prosecutorComment = await _context.Eco_prosecutorComment.FindAsync(id);
            if (eco_prosecutorComment == null)
            {
                return NotFound();
            }
           
            return View(eco_prosecutorComment);
        }

        // POST: Eco_prosecutorComment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Eco_prosecutorCommentId,ProsecutorComment,Department")] Eco_prosecutorComment eco_prosecutorComment)
        {
            if (id != eco_prosecutorComment.Eco_prosecutorCommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eco_prosecutorComment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Eco_prosecutorCommentExists(eco_prosecutorComment.Eco_prosecutorCommentId))
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
           
            return View(eco_prosecutorComment);
        }

        // GET: Eco_prosecutorComment/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.Eco_prosecutorComment == null)
            {
                return NotFound();
            }

            var eco_prosecutorComment = await _context.Eco_prosecutorComment
                
                .FirstOrDefaultAsync(m => m.Eco_prosecutorCommentId == id);
            if (eco_prosecutorComment == null)
            {
                return NotFound();
            }

            return View(eco_prosecutorComment);
        }

        // POST: Eco_prosecutorComment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.Eco_prosecutorComment == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Eco_prosecutorComment'  is null.");
            }
            var eco_prosecutorComment = await _context.Eco_prosecutorComment.FindAsync(id);
            if (eco_prosecutorComment != null)
            {
                _context.Eco_prosecutorComment.Remove(eco_prosecutorComment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Eco_prosecutorCommentExists(Guid id)
        {
          return (_context.Eco_prosecutorComment?.Any(e => e.Eco_prosecutorCommentId == id)).GetValueOrDefault();
        }
    }
}
