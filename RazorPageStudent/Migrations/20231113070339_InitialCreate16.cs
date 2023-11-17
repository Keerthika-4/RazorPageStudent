using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageStudent.Migrations
{
    public partial class InitialCreate16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_StaffId",
                table: "Student",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Staff_StaffId",
                table: "Student",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Staff_StaffId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_StaffId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "Student");
        }
    }
}
