using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_EF_06_Migrazioni.Migrations
{
    /// <inheritdoc />
    public partial class colonna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autore",
                table: "Proiezioni",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autore",
                table: "Proiezioni");
        }
    }
}
