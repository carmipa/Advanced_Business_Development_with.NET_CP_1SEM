using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeCarrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjustesFinais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorDiaria",
                table: "Carros_CP2",
                type: "NUMBER(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "BINARY_DOUBLE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "ValorDiaria",
                table: "Carros_CP2",
                type: "BINARY_DOUBLE",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "NUMBER(10,2)");
        }
    }
}
