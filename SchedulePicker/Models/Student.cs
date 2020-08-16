using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static SchedulePicker.Models.Enums.Enums;

namespace SchedulePicker.Models
{
    [Table("Students")]
    public class Student: IdentityUser
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public Year Year { get; set; }
        public int MajorId { get; set; }
        public Major Major { get; set; }
        public int Credits { get; set; }
        public ICollection<StudentCourse> Courses { get; set; }
        public ICollection<Schedule> Schedules { get; set; }

    }
}