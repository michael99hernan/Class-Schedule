using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class AddSeedAllCSCoursesMajors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MajorCourses",
                columns: new[] { "Id", "CourseId", "MajorId" },
                values: new object[,]
                {
                    { 24, 24, 1 },
                    { 44, 44, 1 },
                    { 43, 43, 1 },
                    { 42, 42, 1 },
                    { 41, 41, 1 },
                    { 40, 40, 1 },
                    { 39, 39, 1 },
                    { 38, 38, 1 },
                    { 37, 37, 1 },
                    { 36, 36, 1 },
                    { 45, 45, 1 },
                    { 35, 35, 1 },
                    { 33, 33, 1 },
                    { 32, 32, 1 },
                    { 31, 31, 1 },
                    { 30, 30, 1 },
                    { 29, 29, 1 },
                    { 28, 28, 1 },
                    { 27, 27, 1 },
                    { 26, 26, 1 },
                    { 25, 25, 1 },
                    { 34, 34, 1 },
                    { 46, 46, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MajorCourses",
                keyColumn: "Id",
                keyValue: 46);
        }
    }
}
