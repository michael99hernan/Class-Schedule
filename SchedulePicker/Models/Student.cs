using Microsoft.AspNetCore.Identity;
using SchedulePicker.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static SchedulePicker.Models.Enums.Enums;

namespace Schedule.Models
{
    [Table("Students")]
    public class Student: IdentityUser
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Year Year { get; set; }
        public int Credits { get; set; }
        public ICollection<StudentCourses> Courses { get; set; }

    }
}