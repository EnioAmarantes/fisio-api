using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fisio_api.Migrations
{
    /// <inheritdoc />
    public partial class AddCPF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactInfo_CPF",
                table: "Customers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactInfo_CPF",
                table: "Customers");
        }
    }
}
