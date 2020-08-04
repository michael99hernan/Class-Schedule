using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassLevel", "Credits", "Description", "Name", "Number", "Prefix" },
                values: new object[,]
                {
                    { 1, "UnderGraduate", 3, "This course presents an integrated approach to writing, reading, and critical thinking by developing the grammatical, logical, and rhetorical skills necessary for university writing.", "Rhetoric", 1302, "RHET" },
                    { 2, "UnderGraduate", 3, "Expands students' professional and team communication skills and strategies in technical contexts. Integrates writing, speaking and group communication by developing and presenting technical information to different audiences. Written assignments focus on creating professional technical documents, such as proposals, memos, abstracts, reports and letters. Presentation assignments emphasize planning, preparing and delivering dynamic, informative and persuasive presentations. Attendance at first class mandatory.", "Professional and Technical Communication", 3390, "ECS" },
                    { 3, "UnderGraduate", 4, "Functions, limits, continuity, differentiation; integration of function of one variable; logarithmic, exponential, and inverse trigonometric functions; techniques of integration, and applications. Three lecture hours and two discussion hours a week; problem section required with MATH 2417, and will also be registered for exam section. Not all MATH/STAT courses may be counted toward various degree plans. Please consult your degree plan to determine the appropriate MATH/STAT course requirements. ", "Calculus I", 3417, "MATH" },
                    { 4, "UnderGraduate", 3, "Calculus based. Basic physics including a study of space and time, kinematics, forces, energy and momentum, conservation laws, rotational motion, torques, and harmonic oscillation. Two lectures per week. Students will also be registered for an exam section.", "Mechanics", 2325, "PHYS" },
                    { 5, "UnderGraduate", 3, "Topics include electrostatics and electromagnetics, electric field and potential, electric currents, magnetic fields, laws of Coulomb, Ampere, and Faraday, Maxwell's theory of wave propagation. Two lectures per week. Students will also be registered for an exam section.", "Electromagnetism and Waves", 2326, "PHYS" },
                    { 6, "UnderGraduate", 3, "", "Language, Philosphy and Culture", 0, "" },
                    { 7, "UnderGraduate", 3, "", "Creative Arts I", 0, "" },
                    { 8, "UnderGraduate", 3, "", "Creative Arts II", 0, "" },
                    { 9, "UnderGraduate", 3, "", "American History I", 0, "" },
                    { 10, "UnderGraduate", 3, "", "American History II", 0, "" },
                    { 11, "UnderGraduate", 3, "Survey of American national government, politics, and constitutional development. ", "American National Government", 2305, "GOVT" },
                    { 12, "UnderGraduate", 3, "Survey of state and local government and politics with special reference to the constitution and politics of Texas.", "State and Local Government", 2306, "GOVT" },
                    { 13, "UnderGraduate", 3, "This course exposes students to major theoretical approaches and professional codes of ethics and how they may be applied to explore a range of important social issues in the information age. Issues of professional ethics, computer crime and privacy, intellectual property, the balance between the acceptability of risk and constraints such as cost, scheduling, safety and quality, the role of globalization and various important constitutional issues are explored by drawing upon case studies. Prerequisite: Completion of an 030 core course.", "Social Issues and Ethics in Science and Technology", 2361, "ECS" },
                    { 14, "UnderGraduate", 4, "Improper integrals, sequences, infinite series, power series, parametric equations and polar coordinates, vectors, vector valued functions, functions of several variables, partial derivatives and applications, and multiple integration. Three lecture hours and two discussion hours a week; problem section required with MATH 2419, and will also be registered for exam section. ", "Calculus II", 2419, "MATH" },
                    { 15, "UnderGraduate", 1, "Laboratory course to accompany any Physics I or Mechanics course. Experiments investigate basic measurements and statistics including error, mean, standard deviation and error propagation; one dimensional and two dimensional motion; Newton's laws; conservation laws of energy and momentum; rotational motion; and oscillations.", "Physics Lab", 2125, "PHYS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);
        }
    }
}
