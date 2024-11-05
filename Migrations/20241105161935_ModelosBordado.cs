using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioAVMR.Migrations
{
    /// <inheritdoc />
    public partial class ModelosBordado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bordados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdColores = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bordados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ColorHilos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Codigo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ColorHiloId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorHilos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorHilos_ColorHilos_ColorHiloId",
                        column: x => x.ColorHiloId,
                        principalTable: "ColorHilos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BordadoHilos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdBordado = table.Column<int>(type: "int", nullable: false),
                    IdHilo = table.Column<int>(type: "int", nullable: false),
                    BordadoId = table.Column<int>(type: "int", nullable: false),
                    ColorHiloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BordadoHilos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BordadoHilos_Bordados_BordadoId",
                        column: x => x.BordadoId,
                        principalTable: "Bordados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BordadoHilos_ColorHilos_ColorHiloId",
                        column: x => x.ColorHiloId,
                        principalTable: "ColorHilos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BordadoHilos_BordadoId",
                table: "BordadoHilos",
                column: "BordadoId");

            migrationBuilder.CreateIndex(
                name: "IX_BordadoHilos_ColorHiloId",
                table: "BordadoHilos",
                column: "ColorHiloId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorHilos_ColorHiloId",
                table: "ColorHilos",
                column: "ColorHiloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BordadoHilos");

            migrationBuilder.DropTable(
                name: "Bordados");

            migrationBuilder.DropTable(
                name: "ColorHilos");
        }
    }
}
