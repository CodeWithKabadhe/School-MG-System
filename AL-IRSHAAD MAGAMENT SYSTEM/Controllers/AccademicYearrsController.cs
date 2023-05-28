using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AL_IRSHAAD_MAGAMENT_SYSTEM.Data;
using AL_IRSHAD_SCHOOL_BOYSS.Models;

namespace AL_IRSHAAD_MAGAMENT_SYSTEM.Controllers
{
    public class AccademicYearrsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccademicYearrsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AccademicYearrs
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccademicYearr.ToListAsync());
        }
        public async Task<IActionResult> Report2(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate != null && EndDate != null)
            {
                return View(await _context.AccademicYearr.Where(e => e.Date < StartDate.Value && e.Date > EndDate.Value).ToListAsync());

            }

            return View(await _context.AccademicYearr.ToListAsync());

        }
        // GET: AccademicYearrs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accademicYearr = await _context.AccademicYearr
                .FirstOrDefaultAsync(m => m.ID == id);
            if (accademicYearr == null)
            {
                return NotFound();
            }

            return View(accademicYearr);
        }

        // GET: AccademicYearrs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccademicYearrs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,TOClass,ClassNow,Date,AdminPermition")] AccademicYearr accademicYearr)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accademicYearr);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accademicYearr);
        }

        // GET: AccademicYearrs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accademicYearr = await _context.AccademicYearr.FindAsync(id);
            if (accademicYearr == null)
            {
                return NotFound();
            }
            return View(accademicYearr);
        }

        // POST: AccademicYearrs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,TOClass,ClassNow,Date,AdminPermition")] AccademicYearr accademicYearr)
        {
            if (id != accademicYearr.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accademicYearr);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccademicYearrExists(accademicYearr.ID))
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
            return View(accademicYearr);
        }

        // GET: AccademicYearrs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accademicYearr = await _context.AccademicYearr
                .FirstOrDefaultAsync(m => m.ID == id);
            if (accademicYearr == null)
            {
                return NotFound();
            }

            return View(accademicYearr);
        }

        // POST: AccademicYearrs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accademicYearr = await _context.AccademicYearr.FindAsync(id);
            _context.AccademicYearr.Remove(accademicYearr);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccademicYearrExists(int id)
        {
            return _context.AccademicYearr.Any(e => e.ID == id);
        }
    }
}
