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
    public class Student_TransferController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Student_TransferController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Student_Transfer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Student_Transfer.ToListAsync());
        }

        // GET: Student_Transfer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student_Transfer = await _context.Student_Transfer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student_Transfer == null)
            {
                return NotFound();
            }

            return View(student_Transfer);
        }

        // GET: Student_Transfer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student_Transfer/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,SchoolFrom,SchoolTo,Date,AdminPermition")] Student_Transfer student_Transfer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student_Transfer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student_Transfer);
        }

        // GET: Student_Transfer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student_Transfer = await _context.Student_Transfer.FindAsync(id);
            if (student_Transfer == null)
            {
                return NotFound();
            }
            return View(student_Transfer);
        }

        // POST: Student_Transfer/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,SchoolFrom,SchoolTo,Date,AdminPermition")] Student_Transfer student_Transfer)
        {
            if (id != student_Transfer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student_Transfer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Student_TransferExists(student_Transfer.Id))
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
            return View(student_Transfer);
        }

        // GET: Student_Transfer/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student_Transfer = await _context.Student_Transfer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student_Transfer == null)
            {
                return NotFound();
            }

            return View(student_Transfer);
        }

        // POST: Student_Transfer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student_Transfer = await _context.Student_Transfer.FindAsync(id);
            _context.Student_Transfer.Remove(student_Transfer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Student_TransferExists(int id)
        {
            return _context.Student_Transfer.Any(e => e.Id == id);
        }
    }
}
