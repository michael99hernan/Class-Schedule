using System.ComponentModel.DataAnnotations;

namespace SchedulePicker.Models.Enums
{
    public class Enums
    {
        public enum Year
        {
            Freshman,
            Sophmore,
            Junior,
            Senior
        }
        public enum CourseType
        {
            [Display(Name ="Core")]
            Core,
            [Display(Name = "Major")]
            Major,
            [Display(Name = "Major Elective")]
            MajorElective,
            [Display(Name = "Electives")]
            Elective
        }
    }
}
