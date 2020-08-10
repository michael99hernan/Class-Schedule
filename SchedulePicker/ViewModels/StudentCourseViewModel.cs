using SchedulePicker.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchedulePicker.ViewModels
{
    public class StudentCourseViewModel
    {
        public StudentCourseViewModel(List<StudentCourse> sc,List<Course> courses, List<Course> majorCourses)
        {
            StudentCourses = sc;
            Taken = courses;
            Needed = majorCourses;
            var common = Taken.Intersect(Needed).ToList();
            Needed.RemoveAll(x => common.Contains(x));
        }
        public List<StudentCourse> StudentCourses { get; set; }
        public List<Course> Taken { get; set; }
        public List<Course> Needed { get; set; }
    }
}
