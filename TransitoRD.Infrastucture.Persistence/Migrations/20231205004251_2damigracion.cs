using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransitoRD.Infrastucture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _2damigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoMulta",
                table: "MultasTipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodigoMulta",
                table: "MultasTipo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
