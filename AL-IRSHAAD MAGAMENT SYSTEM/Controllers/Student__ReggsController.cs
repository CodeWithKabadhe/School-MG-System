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
    public class Student__ReggsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Student__ReggsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Student__Reggs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student__Reggs.ToListAsync());
        }
        public async Task<IActionResult> Report2(DateTime? StartDate, DateTime? EndDate)
        {
            if (StartDate != null && EndDate != null)
            {
                return View(await _context.Student__Reggs.Where(e => e.CreatedDate < StartDate.Value && e.CreatedDate > EndDate.Value).ToListAsync());

            }

            return View(await _context.Student__Reggs.ToListAsync());

        }
        // GET: Student__Reggs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student__Reggs = await _context.Student__Reggs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (student__Reggs == null)
            {
                return NotFound();
            }

            return View(student__Reggs);
        }

        // GET: Student__Reggs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student__Reggs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ROll_ID,FullName,MotherName,Phone,Address,CreatedDate,AdminPermition,DateOfBirth,Class")] Student__Reggs student__Reggs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student__Reggs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student__Reggs);
        }

        // GET: Student__Reggs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student__Reggs = await _context.Student__Reggs.FindAsync(id);
            if (student__Reggs == null)
            {
                return NotFound();
            }
            return View(student__Reggs);
        }

        // POST: Student__Reggs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ROll_ID,FullName,MotherName,Phone,Address,CreatedDate,AdminPermition,DateOfBirth,Class")] Student__Reggs student__Reggs)
        {
            if (id != student__Reggs.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student__Reggs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Student__ReggsExists(student__Reggs.ID))
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
            return View(student__Reggs);
        }

        // GET: Student__Reggs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student__Reggs = await _context.Student__Reggs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (student__Reggs == null)
            {
                return NotFound();
            }

            return View(student__Reggs);
        }

        // POST: Student__Reggs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student__Reggs = await _context.Student__Reggs.FindAsync(id);
            _context.Student__Reggs.Remove(student__Reggs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Student__ReggsExists(int id)
        {
            return _context.Student__Reggs.Any(e => e.ID == id);
        }
    }
}
