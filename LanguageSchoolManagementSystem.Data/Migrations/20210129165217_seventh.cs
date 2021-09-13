using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LanguageSchoolManagementSystem.Data.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "StudentOwnerID",
                table: "Attendances",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentOwnerID",
                table: "Attendances");

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
    }
}
