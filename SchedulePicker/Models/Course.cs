using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Schedule.Models
{
    [Table("Courses")]
    public class Course
    {
        [MaxLength(4), MinLength(2)]
        public string Prefix { get; set; }
        public int CourseId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public string ClassLevel { get; set; }

    }
}
