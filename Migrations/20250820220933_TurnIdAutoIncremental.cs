using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fisio_api.Migrations
{
    /// <inheritdoc />
    public partial class TurnIdAutoIncremental : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Customers_Id",
                table: "Customers",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_Id",
                table: "Customers");
        }
    }
}
