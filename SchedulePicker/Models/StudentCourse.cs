using Schedule.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePicker.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }
        [ForeignKey("StudentId")]
        public string StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("CourseId")]

        public int? CourseId { get; set; }
        public Course Course { get; set; }
    }
}
