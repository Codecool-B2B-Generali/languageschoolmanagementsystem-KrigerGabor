using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageSchoolManagementSystem.Data.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Attendances_AttendanceId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AttendanceId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AttendanceId",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentOwnerUserID",
                table: "Attendances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentOwnerUserID",
                table: "Attendances",
                column: "StudentOwnerUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendances_Users_StudentOwnerUserID",
                table: "Attendances",
                column: "StudentOwnerUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendances_Users_StudentOwnerUserID",
                table: "Attendances");

            migrationBuilder.DropIndex(
                name: "IX_Attendances_StudentOwnerUserID",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "StudentOwnerUserID",
                table: "Attendances");

            migrationBuilder.AddColumn<Guid>(
                name: "AttendanceId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_AttendanceId",
                table: "Users",
                column: "AttendanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Attendances_AttendanceId",
                table: "Users",
                column: "AttendanceId",
                principalTable: "Attendances",
                principalColumn: "AttendanceId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
