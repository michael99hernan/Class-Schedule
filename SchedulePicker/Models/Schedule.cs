using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePicker.Models
{
    [Table("Schedules")]
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
