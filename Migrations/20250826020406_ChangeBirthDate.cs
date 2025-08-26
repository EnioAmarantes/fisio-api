using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fisio_api.Migrations
{
    /// <inheritdoc />
    public partial class ChangeBirthDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Customers",
                newName: "BirthDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Customers",
                newName: "DateOfBirth");
        }
    }
}
