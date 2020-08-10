using Microsoft.EntityFrameworkCore;

namespace SchedulePicker.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region MajorCourse
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

                },
                new MajorCourse
                {
                    Id = 16,
                    CourseId = 16,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 17,
                    CourseId = 17,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 18,
                    CourseId = 18,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 19,
                    CourseId = 19,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 20,
                    CourseId = 20,
                    MajorId = 1,


                },
                new MajorCourse
                {
                    Id = 21,
                    CourseId = 21,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 22,
                    CourseId = 22,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 23,
                    CourseId = 23,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 24,
                    CourseId = 24,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 25,
                    CourseId = 25,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 26,
                    CourseId = 26,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 27,
                    CourseId = 27,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 28,
                    CourseId = 28,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 29,
                    CourseId = 29,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 30,
                    CourseId = 30,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 31,
                    CourseId = 31,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 32,
                    CourseId = 32,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 33,
                    CourseId = 33,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 34,
                    CourseId = 34,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 35,
                    CourseId = 35,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 36,
                    CourseId = 36,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 37,
                    CourseId = 37,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 38,
                    CourseId = 38,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 39,
                    CourseId = 39,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 40,
                    CourseId = 40,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 41,
                    CourseId = 41,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 42,
                    CourseId = 42,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 43,
                    CourseId = 43,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 44,
                    CourseId = 44,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 45,
                    CourseId = 45,
                    MajorId = 1,

                },
                new MajorCourse
                {
                    Id = 46,
                    CourseId = 46,
                    MajorId = 1,

                }

                );
            #endregion
            #region Major
            modelBuilder.Entity<Major>().HasData(
                new Major
                {
                    Id = 1,
                    Name = "Computer Science",
                    School = "Erik School of Engineering"
                }
                );
            #endregion
            #region CoReq
            modelBuilder.Entity<CoReq>().HasData(
                new CoReq
                {
                    Id = 1,
                    CourseId = 4,
                    CorequisiteId = 15,
                },
                new CoReq
                {
                    Id = 2,
                    CourseId = 4,
                    CorequisiteId = 14,
                },
                new CoReq
                {
                    Id = 3,
                    CourseId = 5,
                    CorequisiteId = 16,
                },
                new CoReq
                {
                    Id = 4,
                    CourseId = 16,
                    CorequisiteId = 5,
                },
                new CoReq
                {
                    Id = 5,
                    CourseId = 15,
                    CorequisiteId = 4,
                }

                );
            #endregion
            #region PreReq
            modelBuilder.Entity<PreReq>().HasData(
              new PreReq
              {
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
              },
              new PreReq
              {
                  Id = 8,
                  CourseId = 21,
                  PrerequisiteId = 19,
              },
              new PreReq
              {
                  Id = 9,
                  CourseId = 22,
                  PrerequisiteId = 3,
              }
              );
            #endregion
            #region Courses
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
                    CourseType = (Enums.Enums.CourseType)2
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
                    CourseType = (Enums.Enums.CourseType)1
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
                    CourseType = (Enums.Enums.CourseType)1
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
                    CourseType = (Enums.Enums.CourseType)1
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
                    Name = "Physics Lab I",
                    Description = "Laboratory course to accompany any Physics I or Mechanics course. Experiments investigate basic measurements and statistics including error, mean, standard deviation and error propagation; one dimensional and two dimensional motion; Newton's laws; conservation laws of energy and momentum; rotational motion; and oscillations.",
                    Credits = 1,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 16,
                    Prefix = "PHYS",
                    Number = 2126,
                    Name = "Physics Lab II",
                    Description = "Laboratory course to accompany any Physics II or Electricity and Magnetism course. Experiments investigate electrostatics, electricity in simple circuits, RC circuits and magnetism. ",
                    Credits = 1,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 17,
                    Prefix = "ECS",
                    Number = 1100,
                    Name = "Introduction to Engineering and Computer Science",
                    Description = "Introduction to engineering and computing careers; overview of Engineering and Computer Science (ECS) curricula, connections among ECS fields and to the sciences, and other fields; basic study, problem solving, and other skills needed to succeed as an ECS major.",
                    Credits = 1,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 18,
                    Prefix = "CS",
                    Number = 1200,
                    Name = "Introduction to Computer Science and Software Engineering",
                    Description = "Introduction to the computing professions; overview of Computer Science (CS) and Software Engineering (SE) curricula, connections with Computer Engineering, other Engineering and Computer Science fields, and Arts and Technology programs; problem solving and other skills needed to succeed as a CS or SE major. Introduction to quantitative methods; team projects designed to replicate decision processes and problem solving in real-world situations; additional preparatory topics for CS and SE majors.",
                    Credits = 2,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 19,
                    Prefix = "CS",
                    Number = 1337,
                    Name = "Computer Science I",
                    Description = "Review of control structures and data types with emphasis on structured data types. Applies the object-oriented programming paradigm, focusing on the definition and use of classes along with the fundamentals of object-oriented design. Includes basic analysis of algorithms, searching and sorting techniques, and an introduction to software engineering. Programming language of choice is C/C++. Students will also be registered for an exam section.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 20,
                    Prefix = "CS",
                    Number = 2305,
                    Name = "Discrete Mathematics for Computing I",
                    Description = "Principles of counting. Boolean operations. Logic and proof methods. Recurrence relations. Sets, relations, functions. Elementary graph theory. Elementary number theory. ",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 21,
                    Prefix = "CS",
                    Number = 2336,
                    Name = "Computer Science II",
                    Description = "Further applications of programming techniques, introducing the fundamental concepts of data structures and algorithms. Topics include recursion, fundamental data structures (including stacks, queues, linked lists, hash tables, trees, and graphs), and algorithmic analysis. Includes comprehensive programming projects. Programming language of choice is Java. ",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 22,
                    Prefix = "MATH",
                    Number = 2418,
                    Name = "Linear Algebra",
                    Description = "Introduces and provides models for application of the concepts of vector algebra. Topics include finite dimensional vector spaces and their geometric significance; representing and solving systems of linear equations using multiple methods, including Gaussian elimination and matrix inversion; matrices; determinants; linear transformations; quadratic forms; eigenvalues and eigenvectors; and applications in science and engineering. Three lecture hours and two discussion hours a week; ",
                    Credits = 4,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 23,
                    Prefix = "",
                    Number = 0,
                    Name = "Science Elective",
                    Description = "A science elective",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)1
                },
                new Course
                {
                    CourseId = 24,
                    Prefix = "CS",
                    Number = 3162,
                    Name = "Professional Responsibility in Computer Science and Software Engineering",
                    Description = "Professional and ethical responsibilities of computer scientists and software engineers as influenced by growth in computer use and networks. Costs and benefits of computer technology. Risks and liabilities of safety-critical systems. Social implications of the Internet. Interaction between human values and technical decisions involving computing.",
                    Credits = 1,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 25,
                    Prefix = "CS",
                    Number = 3305,
                    Name = "Discrete Mathematics for Computing II",
                    Description = "Advanced counting methods; recurrence relations, divide and conquer algorithms, principle of inclusion and exclusion. Partial orders and lattices, Algorithmic complexity. Graph theory. Strings and languages. Number theory. Elements of modern algebra.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 26,
                    Prefix = "CS",
                    Number = 3340,
                    Name = "Computer Architecture",
                    Description = "This course introduces the concepts of computer architecture by going through multiple levels of abstraction, and the numbering systems and their basic computations. It focuses on the instruction-set architecture of the MIPS machine, including MIPS assembly programming, translation between MIPS and C, and between MIPS and machine code. General topics include performance calculation, processor datapath, pipelining, and memory hierarchy.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 27,
                    Prefix = "CS",
                    Number = 3341,
                    Name = "Probability and Statistics in Computer Science and Software Engineering",
                    Description = "Axiomatic probability theory, independence, conditional probability. Discrete and continuous random variables, special distributions of importance to CS/SE, and expectation. Simulation of random variables and Monte Carlo methods. Central limit theorem. Basic statistical inference, parameter estimation, hypothesis testing, and linear regression. Introduction to stochastic processes. Illustrative examples and simulation exercises from queuing, reliability, and other CS/SE applications.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 28,
                    Prefix = "CS",
                    Number = 3345,
                    Name = "Data Structures and Introduction to Algorithmic Analysis",
                    Description = "Analysis of algorithms including time complexity and Big-O notation. Analysis of stacks, queues, and trees, including B-trees. Heaps, hashing, and advanced sorting techniques. Disjoint sets and graphs. Course emphasizes design and implementation.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 29,
                    Prefix = "CS",
                    Number = 3354,
                    Name = "Software Engineering",
                    Description = "Introduction to software life cycle models. Software requirements engineering, formal specification and validation. Techniques for software design and testing. Cost estimation models. Issues in software quality assurance and software maintenance.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 30,
                    Prefix = "CS",
                    Number = 3377,
                    Name = "C/C++ Programming in a UNIX Environment",
                    Description = "",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 31,
                    Prefix = "ECS",
                    Number = 2361,
                    Name = "Social Issues and Ethics in Science and Technology",
                    Description = "This course exposes students to major theoretical approaches and professional codes of ethics and how they may be applied to explore a range of important social issues in the information age. Issues of professional ethics, computer crime and privacy, intellectual property, the balance between the acceptability of risk and constraints such as cost, scheduling, safety and quality, the role of globalization and various important constitutional issues are explored by drawing upon case studies.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 32,
                    Prefix = "CS",
                    Number = 4141,
                    Name = "Digital Systems Laboratory",
                    Description = "The purpose of this laboratory is to give students an intuitive understanding of digital circuits and systems. Laboratory exercises include construction of simple digital logic circuits using prototyping kits and board-level assembly of a personal computer.",
                    Credits = 1,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 33,
                    Prefix = "CS",
                    Number = 4337,
                    Name = "Organization of Programming Languages",
                    Description = "Principles of design and implementation of contemporary programming languages. Formal description including specification of syntax and semantics of programming languages. Language definition structures including binding, scoping, data types, control structures, parameter passing, abstraction mechanism, and run-time considerations. Design issues of imperative languages, object-oriented languages, functional languages and logic languages. Design, implement, and debug programs in various programming language paradigms.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 34,
                    Prefix = "CS",
                    Number = 4341,
                    Name = " Digital Logic and Computer Design",
                    Description = "Boolean algebra and logic circuits; synchronous sequential circuits; gate level design of ALSU, registers, and memory unit; register transfer operations; design of data path and control unit for a small computer; Input-Output interface.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 35,
                    Prefix = "CS",
                    Number = 4347,
                    Name = "Database Systems",
                    Description = "This course emphasizes the concepts and structures necessary for the design and implementation of database management systems. Topics include data models, data normalization, data description languages, query facilities, file organization, index organization, file security, data integrity, and reliability.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 36,
                    Prefix = "CS",
                    Number = 4348,
                    Name = "Operating Systems Concepts",
                    Description = "An introduction to fundamental concepts in operating systems: their design, implementation, and usage. Topics include process management, main memory management, virtual memory, I/O and device drivers, file systems, secondary storage management, and an introduction to critical sections and deadlocks.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 37,
                    Prefix = "CS",
                    Number = 4349,
                    Name = "Advanced Algorithm Design and Analysis",
                    Description = "Asymptomatic analysis, recurrences, and graph algorithms. Algorithm design techniques such as greedy method, dynamic programming, and divide-and-conquer. Issues from computational complexity. Course emphasizes a theoretical approach. ",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 38,
                    Prefix = "CS",
                    Number = 4384,
                    Name = "Automata Theory",
                    Description = " A review of the abstract notions encountered in machine computation. Topics include finite automata, regular expressions, PDAs, and context-free languages.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 39,
                    Prefix = "CS",
                    Number = 4485,
                    Name = "Computer Science Project",
                    Description = "This course is intended to complement theory and to provide an in-depth, hands-on experience in all aspects of a software development project. Students will work in teams on projects of interest to industry and will be involved in specifying the problem and its solution, designing and analyzing the solution, developing the software architecture, along with implementation and testing plans. The deliverables will include reports that document these steps as well as a final project report, including the challenges they faced, and a user manual of the developed system. Students will explore security issues of their project and its potential impact on society. Teams will also make presentations as well as demonstrate their software. Additionally, this course will cover topics related to computer science profession including ethics and professional responsibility, entrepreneurship, leadership, and project management.",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)2
                },
                new Course
                {
                    CourseId = 40,
                    Prefix = "CS",
                    Number = 0,
                    Name = "Major Guided Elective I",
                    Description = "CS guided electives are 4000 level CS courses approved by the student's CS advisor. The following courses may be used as guided electives without the explicit approval of an advisor:",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)3
                },
                new Course
                {
                    CourseId = 41,
                    Prefix = "CS",
                    Number = 0,
                    Name = "Major Guided Elective II",
                    Description = "CS guided electives are 4000 level CS courses approved by the student's CS advisor. The following courses may be used as guided electives without the explicit approval of an advisor:",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)3
                },
                new Course
                {
                    CourseId = 42,
                    Prefix = "CS",
                    Number = 0,
                    Name = "Major Guided Elective III",
                    Description = "CS guided electives are 4000 level CS courses approved by the student's CS advisor. The following courses may be used as guided electives without the explicit approval of an advisor:",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)3
                },
                new Course
                {
                    CourseId = 43,
                    Prefix = "",
                    Number = 0,
                    Name = "Free Elective I",
                    Description = "Both lower- and upper-division courses may count as free electives",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)4
                },
                new Course
                {
                    CourseId = 44,
                    Prefix = "",
                    Number = 0,
                    Name = "Free Elective II",
                    Description = "Both lower- and upper-division courses may count as free electives",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)4
                },
                new Course
                {
                    CourseId = 45,
                    Prefix = "",
                    Number = 0,
                    Name = "Free Elective III",
                    Description = "Both lower- and upper-division courses may count as free electives",
                    Credits = 3,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)4
                },
                new Course
                {
                    CourseId = 46,
                    Prefix = "",
                    Number = 0,
                    Name = "Free Elective I",
                    Description = "Both lower- and upper-division courses may count as free electives",
                    Credits = 2,
                    ClassLevel = "UnderGraduate",
                    CourseType = (Enums.Enums.CourseType)4
                }



                );
            #endregion
        }
    }
}
