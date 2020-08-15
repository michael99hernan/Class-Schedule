using Microsoft.EntityFrameworkCore.Migrations;

namespace SchedulePicker.Data.Migrations
{
    public partial class fixedscheduleFKEY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AspNetUsers_StudentId1",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_StudentId1",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Schedules");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "Schedules",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StudentId",
                table: "Schedules",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AspNetUsers_StudentId",
                table: "Schedules",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AspNetUsers_StudentId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_StudentId",
                table: "Schedules");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Schedules",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StudentId1",
                table: "Schedules",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StudentId1",
                table: "Schedules",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AspNetUsers_StudentId1",
                table: "Schedules",
                column: "StudentId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
