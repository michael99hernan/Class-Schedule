using Schedule.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulePicker.Models
{
    public class PreReq
    {
        [ForeignKey("CourseId")]

        public int? CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("PrerequisiteId")]

        public int? PrerequisiteId { get; set; }
        public Course Prerequisite { get; set; }
    }
}
