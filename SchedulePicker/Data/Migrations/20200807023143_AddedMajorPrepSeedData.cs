using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class AddedMajorPrepSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CourseType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                columns: new[] { "CourseType", "Name" },
                values: new object[] { 1, "Physics Lab I" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CourseType",
                value: 1);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassLevel", "CourseType", "Credits", "Description", "Name", "Number", "Prefix" },
                values: new object[,]
                {
                    { 17, "UnderGraduate", 1, 1, "Introduction to engineering and computing careers; overview of Engineering and Computer Science (ECS) curricula, connections among ECS fields and to the sciences, and other fields; basic study, problem solving, and other skills needed to succeed as an ECS major.", "Introduction to Engineering and Computer Science", 1100, "ECS" },
                    { 18, "UnderGraduate", 1, 2, "Introduction to the computing professions; overview of Computer Science (CS) and Software Engineering (SE) curricula, connections with Computer Engineering, other Engineering and Computer Science fields, and Arts and Technology programs; problem solving and other skills needed to succeed as a CS or SE major. Introduction to quantitative methods; team projects designed to replicate decision processes and problem solving in real-world situations; additional preparatory topics for CS and SE majors.", "Introduction to Computer Science and Software Engineering", 1200, "CS" },
                    { 19, "UnderGraduate", 1, 3, "Review of control structures and data types with emphasis on structured data types. Applies the object-oriented programming paradigm, focusing on the definition and use of classes along with the fundamentals of object-oriented design. Includes basic analysis of algorithms, searching and sorting techniques, and an introduction to software engineering. Programming language of choice is C/C++. Students will also be registered for an exam section.", "Computer Science I", 1337, "CS" },
                    { 20, "UnderGraduate", 1, 3, "Principles of counting. Boolean operations. Logic and proof methods. Recurrence relations. Sets, relations, functions. Elementary graph theory. Elementary number theory. ", "Discrete Mathematics for Computing I", 2305, "CS" },
                    { 21, "UnderGraduate", 1, 3, "Further applications of programming techniques, introducing the fundamental concepts of data structures and algorithms. Topics include recursion, fundamental data structures (including stacks, queues, linked lists, hash tables, trees, and graphs), and algorithmic analysis. Includes comprehensive programming projects. Programming language of choice is Java. ", "Computer Science II", 2336, "CS" },
                    { 22, "UnderGraduate", 1, 4, "Introduces and provides models for application of the concepts of vector algebra. Topics include finite dimensional vector spaces and their geometric significance; representing and solving systems of linear equations using multiple methods, including Gaussian elimination and matrix inversion; matrices; determinants; linear transformations; quadratic forms; eigenvalues and eigenvectors; and applications in science and engineering. Three lecture hours and two discussion hours a week; ", "Linear Algebra", 2418, "MATH" },
                    { 23, "UnderGraduate", 1, 3, "A science elective", "Science Elective", 0, "" }
                });

            migrationBuilder.InsertData(
                table: "PreReqs",
                columns: new[] { "Id", "CourseId", "PrerequisiteId" },
                values: new object[] { 8, 21, 19 });

            migrationBuilder.InsertData(
                table: "PreReqs",
                columns: new[] { "Id", "CourseId", "PrerequisiteId" },
                values: new object[] { 9, 22, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PreReqs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PreReqs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CourseType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                columns: new[] { "CourseType", "Name" },
                values: new object[] { 0, "Physics Lab" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CourseType",
                value: 0);
        }
    }
}
