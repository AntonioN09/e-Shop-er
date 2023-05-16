using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EShop.Data;
using EShop.Models;

namespace EShop.Controllers
{
    public class AcquisitionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AcquisitionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Acquisitions
        public async Task<IActionResult> Index()
        {
              return _context.Acquisitions != null ? 
                          View(await _context.Acquisitions.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Acquisitions'  is null.");
        }

        // GET: Acquisitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Acquisitions == null)
            {
                return NotFound();
            }

            var acquisition = await _context.Acquisitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acquisition == null)
            {
                return NotFound();
            }

            return View(acquisition);
        }

        // GET: Acquisitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Acquisitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatedDate")] Acquisition acquisition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(acquisition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(acquisition);
        }

        // GET: Acquisitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Acquisitions == null)
            {
                return NotFound();
            }

            var acquisition = await _context.Acquisitions.FindAsync(id);
            if (acquisition == null)
            {
                return NotFound();
            }
            return View(acquisition);
        }

        // POST: Acquisitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreatedDate")] Acquisition acquisition)
        {
            if (id != acquisition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(acquisition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AcquisitionExists(acquisition.Id))
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
            return View(acquisition);
        }

        // GET: Acquisitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Acquisitions == null)
            {
                return NotFound();
            }

            var acquisition = await _context.Acquisitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (acquisition == null)
            {
                return NotFound();
            }

            return View(acquisition);
        }

        // POST: Acquisitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Acquisitions == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Acquisitions'  is null.");
            }
            var acquisition = await _context.Acquisitions.FindAsync(id);
            if (acquisition != null)
            {
                _context.Acquisitions.Remove(acquisition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AcquisitionExists(int id)
        {
          return (_context.Acquisitions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
