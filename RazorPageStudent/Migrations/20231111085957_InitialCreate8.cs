﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageStudent.Migrations
{
    public partial class InitialCreate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_StudentId",
                table: "Course",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Student_StudentId",
                table: "Course",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Student_StudentId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_StudentId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Course");
        }
    }
}
