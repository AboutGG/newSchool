using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgettoScuola.Migrations
{
    /// <inheritdoc />
    public partial class RelationStudentRegistry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_registries_registry_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_registry_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "registry_id",
                table: "users");

            migrationBuilder.AddColumn<Guid>(
                name: "registry_id",
                table: "students",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_students_registry_id",
                table: "students",
                column: "registry_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_students_registries_registry_id",
                table: "students",
                column: "registry_id",
                principalTable: "registries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_registries_registry_id",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_registry_id",
                table: "students");

            migrationBuilder.DropColumn(
                name: "registry_id",
                table: "students");

            migrationBuilder.AddColumn<Guid>(
                name: "registry_id",
                table: "users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_users_registry_id",
                table: "users",
                column: "registry_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_registries_registry_id",
                table: "users",
                column: "registry_id",
                principalTable: "registries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
