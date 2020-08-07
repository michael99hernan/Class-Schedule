using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchedulePicker.Data;
using SchedulePicker.Models;

namespace SchedulePicker.Controllers
{
    public class CoReqsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoReqsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CoReqs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CoReqs.Include(c => c.Corequisite).Include(c => c.Course);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CoReqs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coReq = await _context.CoReqs
                .Include(c => c.Corequisite)
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coReq == null)
            {
                return NotFound();
            }

            return View(coReq);
        }

        // GET: CoReqs/Create
        public IActionResult Create()
        {
            ViewData["CorequisiteId"] = new SelectList(_context.Course, "CourseId", "Name");
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name");
            return View();
        }

        // POST: CoReqs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseId,CorequisiteId")] CoReq coReq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coReq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CorequisiteId"] = new SelectList(_context.Course, "CourseId", "Name", coReq.CorequisiteId);
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", coReq.CourseId);
            return View(coReq);
        }

        // GET: CoReqs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coReq = await _context.CoReqs.FindAsync(id);
            if (coReq == null)
            {
                return NotFound();
            }
            ViewData["CorequisiteId"] = new SelectList(_context.Course, "CourseId", "Name", coReq.CorequisiteId);
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", coReq.CourseId);
            return View(coReq);
        }

        // POST: CoReqs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseId,CorequisiteId")] CoReq coReq)
        {
            if (id != coReq.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coReq);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoReqExists(coReq.Id))
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
            ViewData["CorequisiteId"] = new SelectList(_context.Course, "CourseId", "Name", coReq.CorequisiteId);
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", coReq.CourseId);
            return View(coReq);
        }

        // GET: CoReqs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coReq = await _context.CoReqs
                .Include(c => c.Corequisite)
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coReq == null)
            {
                return NotFound();
            }

            return View(coReq);
        }

        // POST: CoReqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coReq = await _context.CoReqs.FindAsync(id);
            _context.CoReqs.Remove(coReq);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoReqExists(int id)
        {
            return _context.CoReqs.Any(e => e.Id == id);
        }
    }
}
