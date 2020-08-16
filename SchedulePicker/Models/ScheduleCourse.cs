using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePicker.Models
{
    public class ScheduleCourse
    {
        public int Id { get; set; }
        [ForeignKey("ScheduleId")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        [ForeignKey("CourseId")]

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
