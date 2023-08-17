using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABC_CompanyAPI.Migrations
{
    /// <inheritdoc />
    public partial class V5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentDuration",
                table: "CarBookings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RentDuration",
                table: "CarBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
