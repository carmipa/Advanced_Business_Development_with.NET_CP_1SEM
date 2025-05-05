using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeCarrosAPI.Migrations
{
    /// <inheritdoc />
    public partial class AjusteTabelaCarros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros",
                table: "Carros");

            migrationBuilder.RenameTable(
                name: "Carros",
                newName: "Carros_CP2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros_CP2",
                table: "Carros_CP2",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carros_CP2",
                table: "Carros_CP2");

            migrationBuilder.RenameTable(
                name: "Carros_CP2",
                newName: "Carros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carros",
                table: "Carros",
                column: "Id");
        }
    }
}
