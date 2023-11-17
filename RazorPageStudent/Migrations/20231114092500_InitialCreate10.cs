using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageStudent.Migrations
{
    public partial class InitialCreate10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffStudent",
                columns: table => new
                {
                    StaffsId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffStudent", x => new { x.StaffsId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_StaffStudent_Staff_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffStudent_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffStudent_StudentId",
                table: "StaffStudent",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffStudent");
        }
    }
}
