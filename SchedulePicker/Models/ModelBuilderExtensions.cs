using Microsoft.EntityFrameworkCore;
using Schedule.Models;


namespace SchedulePicker.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MajorCourse>().HasData(
                new MajorCourse
                {
                    Id = 1,
                    CourseId = 1,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 2,
                    CourseId = 2,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 3,
                    CourseId = 3,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 4,
                    CourseId = 4,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 5,
                    CourseId = 5,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 6,
                    CourseId = 6,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 7,
                    CourseId = 7,
                    MajorId = 1,
                },
                new MajorCourse
                {
                    Id = 9,
                    CourseId = 9,
                    MajorId = 1,
               
                },
                new MajorCourse
                {
                    Id = 10,
                    CourseId = 10,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 11,
                    CourseId = 11,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 12,
                    CourseId = 12,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 13,
                    CourseId = 13,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 14,
                    CourseId = 14,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 15,
                    CourseId = 15,
                    MajorId = 1,

                }

                );
            modelBuilder.Entity<Major>().HasData(
                new Major
                {
                    Id = 1,
                    Name = "Computer Science",
                    School = "Erik School of Engineering"
                }
                );

            modelBuilder.Entity<PreReq>().HasData(
              new PreReq  {
                  Id = 1,
                  CourseId = 2,
                  PrerequisiteId = 1,
              },
              new PreReq
              {
                  Id = 2,
                  CourseId = 14,
                  PrerequisiteId = 3,
              },
              new PreReq
              {
                  Id = 3,
                  CourseId = 5,
                  PrerequisiteId = 4,
              },
              new PreReq
              {
                  Id = 4,
                  CourseId = 12,
                  PrerequisiteId = 11,
              },
              new PreReq
              {
                  Id = 5,
                  CourseId = 10,
                  PrerequisiteId = 9,
              },
              new PreReq
              {
                  Id = 6,
                  CourseId = 4,
                  PrerequisiteId = 3,
              },
              new PreReq
              {
                  Id = 7,
                  CourseId = 5,
                  PrerequisiteId = 14,
              });
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    Prefix = "RHET",
                    Number =  1302,
                    Name = "Rhetoric",
                    Description = "This course presents an integrated approach to writing, reading, and critical thinking by developing the grammatical, logical, and rhetorical skills necessary for university writing.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 2,
                    Prefix = "ECS",
                    Number =  3390,
                    Name = "Professional and Technical Communication",
                    Description = "Expands students' professional and team communication skills and strategies in technical contexts. Integrates writing, speaking and group communication by developing and presenting technical information to different audiences. Written assignments focus on creating professional technical documents, such as proposals, memos, abstracts, reports and letters. Presentation assignments emphasize planning, preparing and delivering dynamic, informative and persuasive presentations. Attendance at first class mandatory.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 3,
                    Prefix = "MATH",
                    Number =  3417,
                    Name = "Calculus I",
                    Description = "Functions, limits, continuity, differentiation; integration of function of one variable; logarithmic, exponential, and inverse trigonometric functions; techniques of integration, and applications. Three lecture hours and two discussion hours a week; problem section required with MATH 2417, and will also be registered for exam section. Not all MATH/STAT courses may be counted toward various degree plans. Please consult your degree plan to determine the appropriate MATH/STAT course requirements. ",
                    Credits = 4,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 4,
                    Prefix = "PHYS",
                    Number = 2325,
                    Name = "Mechanics",
                    Description = "Calculus based. Basic physics including a study of space and time, kinematics, forces, energy and momentum, conservation laws, rotational motion, torques, and harmonic oscillation. Two lectures per week. Students will also be registered for an exam section.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 5,
                    Prefix = "PHYS",
                    Number =  2326,
                    Name = "Electromagnetism and Waves",
                    Description = "Topics include electrostatics and electromagnetics, electric field and potential, electric currents, magnetic fields, laws of Coulomb, Ampere, and Faraday, Maxwell's theory of wave propagation. Two lectures per week. Students will also be registered for an exam section.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 6,
                    Prefix = "",
                    Number = 0,
                    Name = "Language, Philosphy and Culture",
                    Description = "",
                    Credits =  3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 7,
                    Prefix = "",
                    Number =  0,
                    Name = "Creative Arts I",
                    Description = "",
                    Credits =  3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 8,
                    Prefix = "",
                    Number =  0,
                    Name = "Creative Arts II",
                    Description = "",
                    Credits =  3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 9,
                    Prefix = "",
                    Number =  0,
                    Name = "American History I",
                    Description = "",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 10,
                    Prefix = "",
                    Number =  0,
                    Name = "American History II",
                    Description = "",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 11,
                    Prefix = "GOVT",
                    Number =  2305,
                    Name = "American National Government",
                    Description = "Survey of American national government, politics, and constitutional development. ",
                    Credits =  3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 12,
                    Prefix = "GOVT",
                    Number =  2306,
                    Name = "State and Local Government",
                    Description = "Survey of state and local government and politics with special reference to the constitution and politics of Texas.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 13,
                    Prefix = "ECS",
                    Number =  2361,
                    Name = "Social Issues and Ethics in Science and Technology",
                    Description = "This course exposes students to major theoretical approaches and professional codes of ethics and how they may be applied to explore a range of important social issues in the information age. Issues of professional ethics, computer crime and privacy, intellectual property, the balance between the acceptability of risk and constraints such as cost, scheduling, safety and quality, the role of globalization and various important constitutional issues are explored by drawing upon case studies. Prerequisite: Completion of an 030 core course.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 14,
                    Prefix = "MATH",
                    Number =  2419,
                    Name = "Calculus II",
                    Description = "Improper integrals, sequences, infinite series, power series, parametric equations and polar coordinates, vectors, vector valued functions, functions of several variables, partial derivatives and applications, and multiple integration. Three lecture hours and two discussion hours a week; problem section required with MATH 2419, and will also be registered for exam section. ",
                    Credits = 4,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                },
                new Course
                {
                    CourseId = 15,
                    Prefix = "PHYS",
                    Number =  2125,
                    Name = "Physics Lab",
                    Description = "Laboratory course to accompany any Physics I or Mechanics course. Experiments investigate basic measurements and statistics including error, mean, standard deviation and error propagation; one dimensional and two dimensional motion; Newton's laws; conservation laws of energy and momentum; rotational motion; and oscillations.",
                    Credits = 1,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)0
                });
        }
    }
}
