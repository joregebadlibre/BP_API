using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class MigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cliente_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEDULA = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Fecha_Registro = table.Column<DateTime>(nullable: false),
                    Fecha_Actualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cliente_ID);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    Cuenta_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente_ID = table.Column<long>(nullable: false),
                    TipoCuenta_ID = table.Column<long>(nullable: false),
                    Interes_ID = table.Column<long>(nullable: false),
                    Numero_Cuenta = table.Column<string>(nullable: true),
                    Monto_Apertura = table.Column<decimal>(nullable: false),
                    Fecha_Apertura = table.Column<DateTime>(nullable: false),
                    Fecha_Actualizacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.Cuenta_ID);
                });

            migrationBuilder.CreateTable(
                name: "Interes",
                columns: table => new
                {
                    Interes_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interes", x => x.Interes_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Interes");
        }
    }
}
