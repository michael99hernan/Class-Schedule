using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class ScheduleCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ScheduleCourses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(nullable: false),
                    CourseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleCourses_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MajorId",
                table: "AspNetUsers",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCourses_CourseId",
                table: "ScheduleCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCourses_ScheduleId",
                table: "ScheduleCourses",
                column: "ScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Majors_MajorId",
                table: "AspNetUsers",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Majors_MajorId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ScheduleCourses");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MajorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "AspNetUsers");
        }
    }
}
