using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarifaAPI.Migrations
{
    /// <inheritdoc />
    public partial class TablaTarifas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tarifas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesdeFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HastaFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DesdeTrabajadores = table.Column<int>(type: "int", nullable: false),
                    HastaTrabajadores = table.Column<int>(type: "int", nullable: false),
                    ImporteTrabajador = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarifas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tarifas");
        }
    }
}
