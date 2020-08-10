using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class AddSeedAllCSCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CourseType",
                value: 2);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassLevel", "CourseType", "Credits", "Description", "Name", "Number", "Prefix" },
                values: new object[,]
                {
                    { 45, "UnderGraduate", 4, 3, "Both lower- and upper-division courses may count as free electives", "Free Elective III", 0, "" },
                    { 44, "UnderGraduate", 4, 3, "Both lower- and upper-division courses may count as free electives", "Free Elective II", 0, "" },
                    { 43, "UnderGraduate", 4, 3, "Both lower- and upper-division courses may count as free electives", "Free Elective I", 0, "" },
                    { 42, "UnderGraduate", 3, 3, "CS guided electives are 4000 level CS courses approved by the student's CS advisor. The following courses may be used as guided electives without the explicit approval of an advisor:", "Major Guided Elective III", 0, "CS" },
                    { 41, "UnderGraduate", 3, 3, "CS guided electives are 4000 level CS courses approved by the student's CS advisor. The following courses may be used as guided electives without the explicit approval of an advisor:", "Major Guided Elective II", 0, "CS" },
                    { 40, "UnderGraduate", 3, 3, "CS guided electives are 4000 level CS courses approved by the student's CS advisor. The following courses may be used as guided electives without the explicit approval of an advisor:", "Major Guided Elective I", 0, "CS" },
                    { 39, "UnderGraduate", 2, 3, "This course is intended to complement theory and to provide an in-depth, hands-on experience in all aspects of a software development project. Students will work in teams on projects of interest to industry and will be involved in specifying the problem and its solution, designing and analyzing the solution, developing the software architecture, along with implementation and testing plans. The deliverables will include reports that document these steps as well as a final project report, including the challenges they faced, and a user manual of the developed system. Students will explore security issues of their project and its potential impact on society. Teams will also make presentations as well as demonstrate their software. Additionally, this course will cover topics related to computer science profession including ethics and professional responsibility, entrepreneurship, leadership, and project management.", "Computer Science Project", 4485, "CS" },
                    { 38, "UnderGraduate", 2, 3, " A review of the abstract notions encountered in machine computation. Topics include finite automata, regular expressions, PDAs, and context-free languages.", "Automata Theory", 4384, "CS" },
                    { 37, "UnderGraduate", 2, 3, "Asymptomatic analysis, recurrences, and graph algorithms. Algorithm design techniques such as greedy method, dynamic programming, and divide-and-conquer. Issues from computational complexity. Course emphasizes a theoretical approach. ", "Advanced Algorithm Design and Analysis", 4349, "CS" },
                    { 36, "UnderGraduate", 2, 3, "An introduction to fundamental concepts in operating systems: their design, implementation, and usage. Topics include process management, main memory management, virtual memory, I/O and device drivers, file systems, secondary storage management, and an introduction to critical sections and deadlocks.", "Operating Systems Concepts", 4348, "CS" },
                    { 35, "UnderGraduate", 2, 3, "This course emphasizes the concepts and structures necessary for the design and implementation of database management systems. Topics include data models, data normalization, data description languages, query facilities, file organization, index organization, file security, data integrity, and reliability.", "Database Systems", 4347, "CS" },
                    { 34, "UnderGraduate", 2, 3, "Boolean algebra and logic circuits; synchronous sequential circuits; gate level design of ALSU, registers, and memory unit; register transfer operations; design of data path and control unit for a small computer; Input-Output interface.", " Digital Logic and Computer Design", 4341, "CS" },
                    { 33, "UnderGraduate", 2, 3, "Principles of design and implementation of contemporary programming languages. Formal description including specification of syntax and semantics of programming languages. Language definition structures including binding, scoping, data types, control structures, parameter passing, abstraction mechanism, and run-time considerations. Design issues of imperative languages, object-oriented languages, functional languages and logic languages. Design, implement, and debug programs in various programming language paradigms.", "Organization of Programming Languages", 4337, "CS" },
                    { 32, "UnderGraduate", 2, 1, "The purpose of this laboratory is to give students an intuitive understanding of digital circuits and systems. Laboratory exercises include construction of simple digital logic circuits using prototyping kits and board-level assembly of a personal computer.", "Digital Systems Laboratory", 4141, "CS" },
                    { 31, "UnderGraduate", 2, 3, "This course exposes students to major theoretical approaches and professional codes of ethics and how they may be applied to explore a range of important social issues in the information age. Issues of professional ethics, computer crime and privacy, intellectual property, the balance between the acceptability of risk and constraints such as cost, scheduling, safety and quality, the role of globalization and various important constitutional issues are explored by drawing upon case studies.", "Social Issues and Ethics in Science and Technology", 2361, "ECS" },
                    { 30, "UnderGraduate", 2, 3, "", "C/C++ Programming in a UNIX Environment", 3377, "CS" },
                    { 29, "UnderGraduate", 2, 3, "Introduction to software life cycle models. Software requirements engineering, formal specification and validation. Techniques for software design and testing. Cost estimation models. Issues in software quality assurance and software maintenance.", "Software Engineering", 3354, "CS" },
                    { 28, "UnderGraduate", 2, 3, "Analysis of algorithms including time complexity and Big-O notation. Analysis of stacks, queues, and trees, including B-trees. Heaps, hashing, and advanced sorting techniques. Disjoint sets and graphs. Course emphasizes design and implementation.", "Data Structures and Introduction to Algorithmic Analysis", 3345, "CS" },
                    { 27, "UnderGraduate", 2, 3, "Axiomatic probability theory, independence, conditional probability. Discrete and continuous random variables, special distributions of importance to CS/SE, and expectation. Simulation of random variables and Monte Carlo methods. Central limit theorem. Basic statistical inference, parameter estimation, hypothesis testing, and linear regression. Introduction to stochastic processes. Illustrative examples and simulation exercises from queuing, reliability, and other CS/SE applications.", "Probability and Statistics in Computer Science and Software Engineering", 3341, "CS" },
                    { 26, "UnderGraduate", 2, 3, "This course introduces the concepts of computer architecture by going through multiple levels of abstraction, and the numbering systems and their basic computations. It focuses on the instruction-set architecture of the MIPS machine, including MIPS assembly programming, translation between MIPS and C, and between MIPS and machine code. General topics include performance calculation, processor datapath, pipelining, and memory hierarchy.", "Computer Architecture", 3340, "CS" },
                    { 25, "UnderGraduate", 2, 3, "Advanced counting methods; recurrence relations, divide and conquer algorithms, principle of inclusion and exclusion. Partial orders and lattices, Algorithmic complexity. Graph theory. Strings and languages. Number theory. Elements of modern algebra.", "Discrete Mathematics for Computing II", 3305, "CS" },
                    { 46, "UnderGraduate", 4, 2, "Both lower- and upper-division courses may count as free electives", "Free Elective I", 0, "" },
                    { 24, "UnderGraduate", 2, 1, "Professional and ethical responsibilities of computer scientists and software engineers as influenced by growth in computer use and networks. Costs and benefits of computer technology. Risks and liabilities of safety-critical systems. Social implications of the Internet. Interaction between human values and technical decisions involving computing.", "Professional Responsibility in Computer Science and Software Engineering", 3162, "CS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 46);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CourseType",
                value: 0);
        }
    }
}
