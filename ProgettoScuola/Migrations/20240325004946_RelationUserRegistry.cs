using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgettoScuola.Migrations
{
    /// <inheritdoc />
    public partial class RelationUserRegistry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RegistryId",
                table: "users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_users_RegistryId",
                table: "users",
                column: "RegistryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_registries_RegistryId",
                table: "users",
                column: "RegistryId",
                principalTable: "registries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_registries_RegistryId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_RegistryId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "RegistryId",
                table: "users");
        }
    }
}
