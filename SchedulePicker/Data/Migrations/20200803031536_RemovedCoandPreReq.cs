using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class RemovedCoandPreReq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Courses_PreReqId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_PreReqId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PreReqId",
                table: "Courses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreReqId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PreReqId",
                table: "Courses",
                column: "PreReqId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Courses_PreReqId",
                table: "Courses",
                column: "PreReqId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
