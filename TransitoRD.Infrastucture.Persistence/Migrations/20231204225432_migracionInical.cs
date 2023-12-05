using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransitoRD.Infrastucture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class migracionInical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estatus = table.Column<bool>(type: "bit", nullable: false),
                    usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    multasId = table.Column<int>(type: "int", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificaionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificaio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<string>(name: "Fecha_Nacimiento", type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificaionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificaio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MultasTipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoMulta = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificaionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificaio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultasTipo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pasajeros = table.Column<int>(type: "int", nullable: false),
                    NombrePropietario = table.Column<string>(name: "Nombre_Propietario", type: "nvarchar(max)", nullable: false),
                    CedulaPropietario = table.Column<string>(name: "Cedula_Propietario", type: "nvarchar(max)", nullable: false),
                    DireccionPropietario = table.Column<string>(name: "Direccion_Propietario", type: "nvarchar(max)", nullable: false),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificaionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificaio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgenteId = table.Column<int>(type: "int", nullable: false),
                    CodigoMulta = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Audio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlacaVehiculo = table.Column<string>(name: "Placa_Vehiculo", type: "nvarchar(max)", nullable: false),
                    Cedulainfractor = table.Column<string>(name: "Cedula_infractor", type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vehiculosId = table.Column<int>(type: "int", nullable: true),
                    LicenciaId = table.Column<int>(type: "int", nullable: true),
                    CreadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UltimaModificaionPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimaModificaio = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Multas_Agentes_AgenteId",
                        column: x => x.AgenteId,
                        principalTable: "Agentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Multas_Licencia_LicenciaId",
                        column: x => x.LicenciaId,
                        principalTable: "Licencia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Multas_MultasTipo_CodigoMulta",
                        column: x => x.CodigoMulta,
                        principalTable: "MultasTipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Multas_Vehiculos_vehiculosId",
                        column: x => x.vehiculosId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Multas_AgenteId",
                table: "Multas",
                column: "AgenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Multas_CodigoMulta",
                table: "Multas",
                column: "CodigoMulta");

            migrationBuilder.CreateIndex(
                name: "IX_Multas_LicenciaId",
                table: "Multas",
                column: "LicenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Multas_vehiculosId",
                table: "Multas",
                column: "vehiculosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropTable(
                name: "Agentes");

            migrationBuilder.DropTable(
                name: "Licencia");

            migrationBuilder.DropTable(
                name: "MultasTipo");

            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
