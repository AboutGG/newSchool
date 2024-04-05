using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProgettoScuola.Migrations
{
    /// <inheritdoc />
    public partial class AddedParent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    registry_id = table.Column<Guid>(type: "uuid", nullable: false),
                    student_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.id);
                    table.ForeignKey(
                        name: "FK_parents_registries_registry_id",
                        column: x => x.registry_id,
                        principalTable: "registries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_parents_students_student_id",
                        column: x => x.student_id,
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_parents_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_parents_registry_id",
                table: "parents",
                column: "registry_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parents_student_id",
                table: "parents",
                column: "student_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_parents_user_id",
                table: "parents",
                column: "user_id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "parents");
        }
    }
}
