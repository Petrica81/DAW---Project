using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ziare.Migrations
{
    /// <inheritdoc />
    public partial class TEstamupdatametc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZiarBibliotecaRelation_Biblioteci_BibliotecaId",
                table: "ZiarBibliotecaRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ZiarBibliotecaRelation_Ziare_ZiarId",
                table: "ZiarBibliotecaRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ZiarEditorRelation_Editori_EditorId",
                table: "ZiarEditorRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_ZiarEditorRelation_Ziare_ZiarId",
                table: "ZiarEditorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZiarEditorRelation",
                table: "ZiarEditorRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZiarBibliotecaRelation",
                table: "ZiarBibliotecaRelation");

            migrationBuilder.RenameTable(
                name: "ZiarEditorRelation",
                newName: "ZiarEditorRelations");

            migrationBuilder.RenameTable(
                name: "ZiarBibliotecaRelation",
                newName: "ZiarBibliotecaRelations");

            migrationBuilder.RenameIndex(
                name: "IX_ZiarEditorRelation_EditorId",
                table: "ZiarEditorRelations",
                newName: "IX_ZiarEditorRelations_EditorId");

            migrationBuilder.RenameIndex(
                name: "IX_ZiarBibliotecaRelation_BibliotecaId",
                table: "ZiarBibliotecaRelations",
                newName: "IX_ZiarBibliotecaRelations_BibliotecaId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Ziare",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Editori",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Editori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Editori",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Biblioteci",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Articole",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZiarEditorRelations",
                table: "ZiarEditorRelations",
                columns: new[] { "ZiarId", "EditorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZiarBibliotecaRelations",
                table: "ZiarBibliotecaRelations",
                columns: new[] { "ZiarId", "BibliotecaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarBibliotecaRelations_Biblioteci_BibliotecaId",
                table: "ZiarBibliotecaRelations",
                column: "BibliotecaId",
                principalTable: "Biblioteci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarBibliotecaRelations_Ziare_ZiarId",
                table: "ZiarBibliotecaRelations",
                column: "ZiarId",
                principalTable: "Ziare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarEditorRelations_Editori_EditorId",
                table: "ZiarEditorRelations",
                column: "EditorId",
                principalTable: "Editori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarEditorRelations_Ziare_ZiarId",
                table: "ZiarEditorRelations",
                column: "ZiarId",
                principalTable: "Ziare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZiarBibliotecaRelations_Biblioteci_BibliotecaId",
                table: "ZiarBibliotecaRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_ZiarBibliotecaRelations_Ziare_ZiarId",
                table: "ZiarBibliotecaRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_ZiarEditorRelations_Editori_EditorId",
                table: "ZiarEditorRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_ZiarEditorRelations_Ziare_ZiarId",
                table: "ZiarEditorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZiarEditorRelations",
                table: "ZiarEditorRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZiarBibliotecaRelations",
                table: "ZiarBibliotecaRelations");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Editori");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Editori");

            migrationBuilder.RenameTable(
                name: "ZiarEditorRelations",
                newName: "ZiarEditorRelation");

            migrationBuilder.RenameTable(
                name: "ZiarBibliotecaRelations",
                newName: "ZiarBibliotecaRelation");

            migrationBuilder.RenameIndex(
                name: "IX_ZiarEditorRelations_EditorId",
                table: "ZiarEditorRelation",
                newName: "IX_ZiarEditorRelation_EditorId");

            migrationBuilder.RenameIndex(
                name: "IX_ZiarBibliotecaRelations_BibliotecaId",
                table: "ZiarBibliotecaRelation",
                newName: "IX_ZiarBibliotecaRelation_BibliotecaId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Ziare",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Editori",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Biblioteci",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Articole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZiarEditorRelation",
                table: "ZiarEditorRelation",
                columns: new[] { "ZiarId", "EditorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZiarBibliotecaRelation",
                table: "ZiarBibliotecaRelation",
                columns: new[] { "ZiarId", "BibliotecaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarBibliotecaRelation_Biblioteci_BibliotecaId",
                table: "ZiarBibliotecaRelation",
                column: "BibliotecaId",
                principalTable: "Biblioteci",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarBibliotecaRelation_Ziare_ZiarId",
                table: "ZiarBibliotecaRelation",
                column: "ZiarId",
                principalTable: "Ziare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarEditorRelation_Editori_EditorId",
                table: "ZiarEditorRelation",
                column: "EditorId",
                principalTable: "Editori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZiarEditorRelation_Ziare_ZiarId",
                table: "ZiarEditorRelation",
                column: "ZiarId",
                principalTable: "Ziare",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
