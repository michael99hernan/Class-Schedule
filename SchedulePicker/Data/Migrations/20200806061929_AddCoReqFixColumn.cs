using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class AddCoReqFixColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoReqs_Courses_PrerequisiteId",
                table: "CoReqs");

            migrationBuilder.DropIndex(
                name: "IX_CoReqs_PrerequisiteId",
                table: "CoReqs");

            migrationBuilder.DropColumn(
                name: "PrerequisiteId",
                table: "CoReqs");

            migrationBuilder.AddColumn<int>(
                name: "CorequisiteId",
                table: "CoReqs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoReqs_CorequisiteId",
                table: "CoReqs",
                column: "CorequisiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoReqs_Courses_CorequisiteId",
                table: "CoReqs",
                column: "CorequisiteId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CoReqs_Courses_CorequisiteId",
                table: "CoReqs");

            migrationBuilder.DropIndex(
                name: "IX_CoReqs_CorequisiteId",
                table: "CoReqs");

            migrationBuilder.DropColumn(
                name: "CorequisiteId",
                table: "CoReqs");

            migrationBuilder.AddColumn<int>(
                name: "PrerequisiteId",
                table: "CoReqs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CoReqs_PrerequisiteId",
                table: "CoReqs",
                column: "PrerequisiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_CoReqs_Courses_PrerequisiteId",
                table: "CoReqs",
                column: "PrerequisiteId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
