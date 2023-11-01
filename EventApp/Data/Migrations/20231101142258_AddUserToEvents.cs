using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventApp.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Event",
                type: "nvarchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Event",
                type: "nvarchar(256)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Event");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Event",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)");
        }
    }
}
