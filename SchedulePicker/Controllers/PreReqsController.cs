
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchedulePicker.Data;
using SchedulePicker.Models;

namespace SchedulePicker.Controllers
{
    [Authorize(Roles ="Moderator")]
    public class PreReqsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PreReqsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PreReqs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PreReqs.Include(p => p.Course).Include(p => p.Prerequisite);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PreReqs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preReq = await _context.PreReqs
                .Include(p => p.Course)
                .Include(p => p.Prerequisite)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preReq == null)
            {
                return NotFound();
            }

            return View(preReq);
        }

        // GET: PreReqs/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name");
            ViewData["PrerequisiteId"] = new SelectList(_context.Course, "CourseId", "Name");
            return View();
        }

        // POST: PreReqs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CourseId,PrerequisiteId")] PreReq preReq)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preReq);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", preReq.CourseId);
            ViewData["PrerequisiteId"] = new SelectList(_context.Course, "CourseId", "Name", preReq.PrerequisiteId);
            return View(preReq);
        }

        // GET: PreReqs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preReq = await _context.PreReqs.FindAsync(id);
            if (preReq == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", preReq.CourseId);
            ViewData["PrerequisiteId"] = new SelectList(_context.Course, "CourseId", "Name", preReq.PrerequisiteId);
            return View(preReq);
        }

        // POST: PreReqs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CourseId,PrerequisiteId")] PreReq preReq)
        {
            if (id != preReq.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preReq);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PreReqExists(preReq.Id))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "CourseId", "Name", preReq.CourseId);
            ViewData["PrerequisiteId"] = new SelectList(_context.Course, "CourseId", "Name", preReq.PrerequisiteId);
            return View(preReq);
        }

        // GET: PreReqs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preReq = await _context.PreReqs
                .Include(p => p.Course)
                .Include(p => p.Prerequisite)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (preReq == null)
            {
                return NotFound();
            }

            return View(preReq);
        }

        // POST: PreReqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var preReq = await _context.PreReqs.FindAsync(id);
            _context.PreReqs.Remove(preReq);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PreReqExists(int id)
        {
            return _context.PreReqs.Any(e => e.Id == id);
        }
    }
}
