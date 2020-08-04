
using Microsoft.AspNetCore.Mvc.Rendering;
using Schedule.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchedulePicker.ViewModels
{
    public class AddCourseViewModel
    {
        public AddCourseViewModel(Student student, List<Course> courses)
        {
            Courses = courses.Select(x => new SelectListItem { Text = x.Name, Value = x.CourseId.ToString() }).ToList();
            Student = student;
            StudentId = Student.StudentId;
        }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public string CourseNumber { get; set; }
        public string CoursePrefix { get; set; }
        public List<SelectListItem> Courses { get; set; }
        public Student Student { get; set; }
    }
}
