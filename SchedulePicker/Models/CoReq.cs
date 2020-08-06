using Schedule.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulePicker.Models
{
    public class CoReq
    {
        public int Id { get; set; }
        [ForeignKey("CourseId")]

        public int? CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("CorequisiteId")]

        public int? CorequisiteId { get; set; }
        public Course Corequisite { get; set; }
    }
}
