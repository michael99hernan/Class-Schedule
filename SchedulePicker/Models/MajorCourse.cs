using Schedule.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePicker.Models
{
    public class MajorCourse
    {
        public int Id { get; set; }
        [ForeignKey("CourseId")]

        public int CourseId { get; set; }
        public Course Course { get; set; }
        [ForeignKey("MajorId")]

        public int MajorId { get; set; }
        public Major Major { get; set; }
    }
}
