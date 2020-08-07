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
            [Display(Name = "Major Preparatory Course")]
            MajorPrep,
            [Display(Name = "Major Core")]
            Major,
            [Display(Name = "Major Guided Elective")]
            MajorElective,
            [Display(Name = "Electives")]
            Elective
        }
    }
}
