using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apuesta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(nullable: false),
                    Cuota = table.Column<int>(nullable: false),
                    TipoApuesta = table.Column<string>(nullable: true),
                    Mercado_id = table.Column<int>(nullable: false),
                    DineroApostado = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuesta", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    CuentaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TarjetaCredito = table.Column<string>(nullable: true),
                    NombreBanco = table.Column<string>(nullable: true),
                    Saldo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.CuentaId);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EquipoLocal = table.Column<string>(nullable: true),
                    EquipoVisitante = table.Column<string>(nullable: true),
                    Fecha = table.Column<int>(nullable: false),
                    Goles = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mercado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UnderOver = table.Column<double>(nullable: false),
                    CuotaUnder = table.Column<double>(nullable: false),
                    CuotaOver = table.Column<double>(nullable: false),
                    DineroOver = table.Column<double>(nullable: false),
                    DineroUnder = table.Column<double>(nullable: false),
                    IdEvento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    CuentaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Usuario_Cuenta_CuentaId",
                        column: x => x.CuentaId,
                        principalTable: "Cuenta",
                        principalColumn: "CuentaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "CuentaId", "NombreBanco", "Saldo", "TarjetaCredito" },
                values: new object[] { 1, "Bankia", 25, "2354687" });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "CuentaId", "NombreBanco", "Saldo", "TarjetaCredito" },
                values: new object[] { 2, "Bankia", 24, "2352687" });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "CuentaId", "NombreBanco", "Saldo", "TarjetaCredito" },
                values: new object[] { 3, "Bankia", 22, "2354887" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Email", "Apellido", "CuentaId", "Edad", "Nombre" },
                values: new object[] { "manolito@gmail.com", "manolo", 1, 30, "ok" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Email", "Apellido", "CuentaId", "Edad", "Nombre" },
                values: new object[] { "Carlos@gmail.com", "Carlos", 2, 24, "vale" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Email", "Apellido", "CuentaId", "Edad", "Nombre" },
                values: new object[] { "pepe@gmail.com", "pepe", 3, 25, "si" });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CuentaId",
                table: "Usuario",
                column: "CuentaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apuesta");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Mercado");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cuenta");
        }
    }
}
