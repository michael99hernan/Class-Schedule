using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class SeedCoReq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoReqs",
                columns: new[] { "Id", "CorequisiteId", "CourseId" },
                values: new object[,]
                {
                    { 1, 15, 4 },
                    { 2, 14, 4 },
                    { 5, 4, 15 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassLevel", "CourseType", "Credits", "Description", "Name", "Number", "Prefix" },
                values: new object[] { 16, "UnderGraduate", 0, 1, "Laboratory course to accompany any Physics II or Electricity and Magnetism course. Experiments investigate electrostatics, electricity in simple circuits, RC circuits and magnetism. ", "Physics Lab II", 2126, "PHYS" });

            migrationBuilder.InsertData(
                table: "CoReqs",
                columns: new[] { "Id", "CorequisiteId", "CourseId" },
                values: new object[] { 3, 16, 5 });

            migrationBuilder.InsertData(
                table: "CoReqs",
                columns: new[] { "Id", "CorequisiteId", "CourseId" },
                values: new object[] { 4, 5, 16 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoReqs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoReqs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoReqs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoReqs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoReqs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16);
        }
    }
}
