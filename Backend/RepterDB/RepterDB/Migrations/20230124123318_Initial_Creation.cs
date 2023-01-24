using Microsoft.EntityFrameworkCore.Migrations;

namespace RepterDB.Migrations
{
    public partial class Initial_Creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Varosok",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nepesseg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varosok", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Jatatok",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Legitarsasag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KiinduloVarosID = table.Column<int>(type: "int", nullable: false),
                    CelVarosID = table.Column<int>(type: "int", nullable: true),
                    KmDij = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jatatok", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Jatatok_Varosok_CelVarosID",
                        column: x => x.CelVarosID,
                        principalTable: "Varosok",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jatatok_Varosok_KiinduloVarosID",
                        column: x => x.KiinduloVarosID,
                        principalTable: "Varosok",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jatatok_CelVarosID",
                table: "Jatatok",
                column: "CelVarosID");

            migrationBuilder.CreateIndex(
                name: "IX_Jatatok_KiinduloVarosID",
                table: "Jatatok",
                column: "KiinduloVarosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jatatok");

            migrationBuilder.DropTable(
                name: "Varosok");
        }
    }
}
