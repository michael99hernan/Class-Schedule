﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Schedule.Models;
using SchedulePicker.Data;
using SchedulePicker.Models;
using SchedulePicker.ViewModels;

namespace SchedulePicker.Controllers
{
    public class StudentCoursesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentCoursesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentCourses
        public IActionResult Index()
        {

            return View();
        }
        public async Task<IActionResult> GetStudentCourses()
        {
            var userId = User.Identity.GetUserId();
            var studentList = await _context.StudentCourses.Where(x => x.StudentId == userId).Select(x => new {x.Id, x.Course}).ToListAsync();
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

        // GET: StudentCourses/Create
        //public IActionResult Create()
        //{
        //    ViewData["CourseId"] = new SelectList(_context.Set<Course>(), "CourseId", "Name");
        //    ViewBag.SID = User.Identity.GetUserId();
        //    return View();
        //}

        // POST: StudentCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        public async Task<IActionResult> Create(int courseId)
        {
            var studentId = User.Identity.GetUserId();
            var myStudentCourses = await _context.StudentCourses.Where(x => x.StudentId == studentId).Select(x => x.Course).ToListAsync();
            var preReqs = await _context.PreReqs.Where(x => x.CourseId == courseId).Select(x => x.Prerequisite).ToListAsync();
            bool result = !preReqs.Except(myStudentCourses).Any();
            if(result)
            {
                var studentCourse = new StudentCourse()
                {
                    Id = 0,
                    StudentId = studentId,
                    CourseId = courseId
                };
                if (ModelState.IsValid)
                {
                    _context.Add(studentCourse);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            //TODO: Make this an alert
            return View("Not Found");
        }
        // GET: StudentCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentCourse = await _context.Courses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentCourse == null)
            {
                return NotFound();
            }

            return View(studentCourse);
        }

        // POST: StudentCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentCourse = await _context.StudentCourses.FindAsync(id);
            _context.Courses.Remove(studentCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentCourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}
