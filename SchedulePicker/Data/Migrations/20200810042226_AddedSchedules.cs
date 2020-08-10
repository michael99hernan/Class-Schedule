using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class AddedSchedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false),
                    StudentId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_AspNetUsers_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ScheduleId",
                table: "Courses",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StudentId1",
                table: "Schedules",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Schedules_ScheduleId",
                table: "Courses",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Schedules_ScheduleId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ScheduleId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "Courses");
        }
    }
}
