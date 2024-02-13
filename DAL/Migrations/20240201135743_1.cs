using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articolo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codice = table.Column<string>(type: "TEXT", nullable: false),
                    Descrizione = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articolo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataDocumento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RigaDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArticoloId = table.Column<int>(type: "INTEGER", nullable: true),
                    Quantita = table.Column<double>(type: "REAL", nullable: false),
                    TipoMovimento = table.Column<int>(type: "INTEGER", nullable: false),
                    Prezzo = table.Column<double>(type: "REAL", nullable: false),
                    EDocumentoId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RigaDocumento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RigaDocumento_Articolo_ArticoloId",
                        column: x => x.ArticoloId,
                        principalTable: "Articolo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RigaDocumento_Documento_EDocumentoId",
                        column: x => x.EDocumentoId,
                        principalTable: "Documento",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RigaDocumento_ArticoloId",
                table: "RigaDocumento",
                column: "ArticoloId");

            migrationBuilder.CreateIndex(
                name: "IX_RigaDocumento_EDocumentoId",
                table: "RigaDocumento",
                column: "EDocumentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RigaDocumento");

            migrationBuilder.DropTable(
                name: "Articolo");

            migrationBuilder.DropTable(
                name: "Documento");
        }
    }
}
