using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AL_IRSHAAD_MAGAMENT_SYSTEM.Data;
using AL_IRSHAAD_MAGAMENT_SYSTEM.Models;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Controllers
{
    public class FEEsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FEEsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FEEs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FEE.Include(f => f.Class);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> Report3(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate != null && EndDate != null)
            {
                return View(await _context.FEE.Where(e => e.Date < StartDate.Value && e.Date > EndDate.Value).ToListAsync());

            }

            return View(await _context.FEE.ToListAsync());

        }

        // GET: FEEs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fEE = await _context.FEE
                .Include(f => f.Class)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fEE == null)
            {
                return NotFound();
            }

            return View(fEE);
        }

        // GET: FEEs/Create
        public IActionResult Create()
        {
            ViewData["CLassid"] = new SelectList(_context.Class, "id", "id");
            return View();
        }

        // POST: FEEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Payer,Amount,CLassid,Date")] FEE fEE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fEE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CLassid"] = new SelectList(_context.Class, "id", "id", fEE.CLassid);
            return View(fEE);
        }

        // GET: FEEs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fEE = await _context.FEE.FindAsync(id);
            if (fEE == null)
            {
                return NotFound();
            }
            ViewData["CLassid"] = new SelectList(_context.Class, "id", "id", fEE.CLassid);
            return View(fEE);
        }

        // POST: FEEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Payer,Amount,CLassid,Date")] FEE fEE)
        {
            if (id != fEE.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fEE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FEEExists(fEE.ID))
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
            ViewData["CLassid"] = new SelectList(_context.Class, "id", "id", fEE.CLassid);
            return View(fEE);
        }

        // GET: FEEs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fEE = await _context.FEE
                .Include(f => f.Class)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fEE == null)
            {
                return NotFound();
            }

            return View(fEE);
        }

        // POST: FEEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fEE = await _context.FEE.FindAsync(id);
            _context.FEE.Remove(fEE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FEEExists(int id)
        {
            return _context.FEE.Any(e => e.ID == id);
        }
    }
}
