using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fisio_api.Migrations
{
    /// <inheritdoc />
    public partial class AddGuardianContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GuardianName",
                table: "ContactInfos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "GuardianPhone",
                table: "ContactInfos",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuardianName",
                table: "ContactInfos");

            migrationBuilder.DropColumn(
                name: "GuardianPhone",
                table: "ContactInfos");
        }
    }
}
