using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeCarrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class CorrigirTabelasDuplicadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros_CP2",
                table: "Carros_CP2");

            migrationBuilder.RenameTable(
                name: "Carros_CP2",
                newName: "CARROS_CP2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CARROS_CP2",
                table: "CARROS_CP2",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CARROS_CP2",
                table: "CARROS_CP2");

            migrationBuilder.RenameTable(
                name: "CARROS_CP2",
                newName: "Carros_CP2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros_CP2",
                table: "Carros_CP2",
                column: "Id");
        }
    }
}
