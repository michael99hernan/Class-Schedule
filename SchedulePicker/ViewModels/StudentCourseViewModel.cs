

using Schedule.Models;
using SchedulePicker.Models;
using System.Collections.Generic;

namespace SchedulePicker.ViewModels
{
    public class StudentCourseViewModel
    {
        public StudentCourseViewModel(List<StudentCourse> courses, List<MajorCourse> majorCourses)
        {

        }

        public List<StudentCourse> Taken { get; set; }
        public List<StudentCourse> Needed { get; set; }
    }
}
