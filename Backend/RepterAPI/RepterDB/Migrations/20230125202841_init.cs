using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepterAPI.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Legitarsasag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legitarsasag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varosok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nepesseg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varosok", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jaratok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegitarsasagId = table.Column<int>(type: "int", nullable: true),
                    KiinduloVarosId = table.Column<int>(type: "int", nullable: true),
                    CelVarosId = table.Column<int>(type: "int", nullable: true),
                    RepulesiIdo = table.Column<int>(type: "int", nullable: false),
                    Indulas = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KmDij = table.Column<double>(type: "float", nullable: false),
                    Atszallas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jaratok", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jaratok_Legitarsasag_LegitarsasagId",
                        column: x => x.LegitarsasagId,
                        principalTable: "Legitarsasag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jaratok_Varosok_CelVarosId",
                        column: x => x.CelVarosId,
                        principalTable: "Varosok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jaratok_Varosok_KiinduloVarosId",
                        column: x => x.KiinduloVarosId,
                        principalTable: "Varosok",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jaratok_CelVarosId",
                table: "Jaratok",
                column: "CelVarosId");

            migrationBuilder.CreateIndex(
                name: "IX_Jaratok_KiinduloVarosId",
                table: "Jaratok",
                column: "KiinduloVarosId");

            migrationBuilder.CreateIndex(
                name: "IX_Jaratok_LegitarsasagId",
                table: "Jaratok",
                column: "LegitarsasagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jaratok");

            migrationBuilder.DropTable(
                name: "Legitarsasag");

            migrationBuilder.DropTable(
                name: "Varosok");
        }
    }
}
