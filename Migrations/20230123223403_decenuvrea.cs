using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class decenuvrea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Biblioteci",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biblioteci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Editori",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Editura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varsta = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ziare",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Editura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Domeniu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ziare", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Varsta = table.Column<int>(type: "int", nullable: false),
                    Bani = table.Column<int>(type: "int", nullable: false),
                    BibliotecaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Biblioteci_BibliotecaId",
                        column: x => x.BibliotecaId,
                        principalTable: "Biblioteci",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Articole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZiarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articole_Ziare_ZiarId",
                        column: x => x.ZiarId,
                        principalTable: "Ziare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZiarBibliotecaRelations",
                columns: table => new
                {
                    ZiarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BibliotecaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZiarBibliotecaRelations", x => new { x.ZiarId, x.BibliotecaId });
                    table.ForeignKey(
                        name: "FK_ZiarBibliotecaRelations_Biblioteci_BibliotecaId",
                        column: x => x.BibliotecaId,
                        principalTable: "Biblioteci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZiarBibliotecaRelations_Ziare_ZiarId",
                        column: x => x.ZiarId,
                        principalTable: "Ziare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZiarEditorRelations",
                columns: table => new
                {
                    ZiarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EditorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZiarEditorRelations", x => new { x.ZiarId, x.EditorId });
                    table.ForeignKey(
                        name: "FK_ZiarEditorRelations_Editori_EditorId",
                        column: x => x.EditorId,
                        principalTable: "Editori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZiarEditorRelations_Ziare_ZiarId",
                        column: x => x.ZiarId,
                        principalTable: "Ziare",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articole_ZiarId",
                table: "Articole",
                column: "ZiarId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BibliotecaId",
                table: "Clients",
                column: "BibliotecaId",
                unique: true,
                filter: "[BibliotecaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ZiarBibliotecaRelations_BibliotecaId",
                table: "ZiarBibliotecaRelations",
                column: "BibliotecaId");

            migrationBuilder.CreateIndex(
                name: "IX_ZiarEditorRelations_EditorId",
                table: "ZiarEditorRelations",
                column: "EditorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articole");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ZiarBibliotecaRelations");

            migrationBuilder.DropTable(
                name: "ZiarEditorRelations");

            migrationBuilder.DropTable(
                name: "Biblioteci");

            migrationBuilder.DropTable(
                name: "Editori");

            migrationBuilder.DropTable(
                name: "Ziare");
        }
    }
}
