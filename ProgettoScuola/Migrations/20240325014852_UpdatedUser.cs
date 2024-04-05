using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgettoScuola.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_registries_RegistryId",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "RegistryId",
                table: "users",
                newName: "registry_id");

            migrationBuilder.RenameIndex(
                name: "IX_users_RegistryId",
                table: "users",
                newName: "IX_users_registry_id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_registries_registry_id",
                table: "users",
                column: "registry_id",
                principalTable: "registries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_registries_registry_id",
                table: "users");

            migrationBuilder.RenameColumn(
                name: "registry_id",
                table: "users",
                newName: "RegistryId");

            migrationBuilder.RenameIndex(
                name: "IX_users_registry_id",
                table: "users",
                newName: "IX_users_RegistryId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_registries_RegistryId",
                table: "users",
                column: "RegistryId",
                principalTable: "registries",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
