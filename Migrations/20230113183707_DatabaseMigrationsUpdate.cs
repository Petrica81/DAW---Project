using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ziare.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseMigrationsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumarZiare",
                table: "Biblioteci");

            migrationBuilder.RenameColumn(
                name: "Balance",
                table: "Clients",
                newName: "Bani");

            migrationBuilder.AddColumn<Guid>(
                name: "BibliotecaId",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Denumire",
                table: "Biblioteci",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ZiarId",
                table: "Articole",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ZiarBibliotecaRelation",
                columns: table => new
                {
                    ZiarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BibliotecaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZiarBibliotecaRelation", x => new { x.ZiarId, x.BibliotecaId });
                    table.ForeignKey(
                        name: "FK_ZiarBibliotecaRelation_Biblioteci_BibliotecaId",
                        column: x => x.BibliotecaId,
                        principalTable: "Biblioteci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZiarBibliotecaRelation_Ziare_ZiarId",
                        column: x => x.ZiarId,
                        principalTable: "Ziare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZiarEditorRelation",
                columns: table => new
                {
                    ZiarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZiarEditorRelation", x => new { x.ZiarId, x.EditorId });
                    table.ForeignKey(
                        name: "FK_ZiarEditorRelation_Editori_EditorId",
                        column: x => x.EditorId,
                        principalTable: "Editori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZiarEditorRelation_Ziare_ZiarId",
                        column: x => x.ZiarId,
                        principalTable: "Ziare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BibliotecaId",
                table: "Clients",
                column: "BibliotecaId",
                unique: true,
                filter: "[BibliotecaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Articole_ZiarId",
                table: "Articole",
                column: "ZiarId");

            migrationBuilder.CreateIndex(
                name: "IX_ZiarBibliotecaRelation_BibliotecaId",
                table: "ZiarBibliotecaRelation",
                column: "BibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_ZiarEditorRelation_EditorId",
                table: "ZiarEditorRelation",
                column: "EditorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articole_Ziare_ZiarId",
                table: "Articole",
                column: "ZiarId",
                principalTable: "Ziare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Biblioteci_BibliotecaId",
                table: "Clients",
                column: "BibliotecaId",
                principalTable: "Biblioteci",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articole_Ziare_ZiarId",
                table: "Articole");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Biblioteci_BibliotecaId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "ZiarBibliotecaRelation");

            migrationBuilder.DropTable(
                name: "ZiarEditorRelation");

            migrationBuilder.DropIndex(
                name: "IX_Clients_BibliotecaId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Articole_ZiarId",
                table: "Articole");

            migrationBuilder.DropColumn(
                name: "BibliotecaId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Denumire",
                table: "Biblioteci");

            migrationBuilder.DropColumn(
                name: "ZiarId",
                table: "Articole");

            migrationBuilder.RenameColumn(
                name: "Bani",
                table: "Clients",
                newName: "Balance");

            migrationBuilder.AddColumn<int>(
                name: "NumarZiare",
                table: "Biblioteci",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
