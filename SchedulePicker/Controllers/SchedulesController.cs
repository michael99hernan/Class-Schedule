using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchedulePicker.Data;
using SchedulePicker.Models;

namespace SchedulePicker.Controllers
{
    public class SchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SchedulesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Schedules
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Schedule.Include(s => s.Student);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> AddtoSchedule(int scheduleId, int courseId)
        {
            var scheduleCourse = new ScheduleCourse()
            {
                Id = 0,
                ScheduleId = scheduleId,
                CourseId = courseId
            };
            if (ModelState.IsValid)
            {
                _context.Add(scheduleCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //TODO: Make this an alert
            return View("Not Found");
        }
        public async Task<IActionResult> GetStudentSchedule(int scheduleId)
        {
            var userId = User.Identity.GetUserId();
            var studentList = await _context.ScheduleCourses.Where(x => x.ScheduleId == scheduleId).Select(x => x.Course).ToListAsync();
            return Json(new { data = studentList });
        }
        public async Task<IActionResult> GetMajorCourses()
        {
            var userId = User.Identity.GetUserId();

            var c = await _context.Courses.Where(x => x.StudentId == userId).Select(x => x.Course).ToListAsync();
            var m = await _context.MajorCourses.Where(x => x.MajorId == 1).Select(x => x.Course).ToListAsync();
            var common = c.Intersect(m).ToList();
            m.RemoveAll(x => common.Contains(x));
            return Json(new { data = m });
        }
        public async Task<IActionResult> RemoveFromSchedule(int scheduleId, int courseId)
        {
            var scheduleCourse = _context.ScheduleCourses.Where(x => x.ScheduleId == scheduleId && x.CourseId == courseId);
            _context.ScheduleCourses.Remove(scheduleCourse.FirstOrDefault());
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // GET: Schedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // GET: Schedules/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email");
            return View();
        }

        // POST: Schedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,StudentId")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(schedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email", schedule.StudentId);
            return View(schedule);
        }

        // GET: Schedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule.FindAsync(id);
            if (schedule == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email", schedule.StudentId);
            return View(schedule);
        }

        // POST: Schedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StudentId")] Schedule schedule)
        {
            if (id != schedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(schedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScheduleExists(schedule.Id))
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
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Email", schedule.StudentId);
            return View(schedule);
        }

        // GET: Schedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var schedule = await _context.Schedule
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (schedule == null)
            {
                return NotFound();
            }

            return View(schedule);
        }

        // POST: Schedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schedule = await _context.Schedule.FindAsync(id);
            _context.Schedule.Remove(schedule);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScheduleExists(int id)
        {
            return _context.Schedule.Any(e => e.Id == id);
        }
    }
}
