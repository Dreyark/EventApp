using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventApp.Migrations
{
    /// <inheritdoc />
    public partial class Changeacceptstatustoadminstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AdminStatus_AcceptStatusId",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "AcceptStatusId",
                table: "Event",
                newName: "AdminStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_AcceptStatusId",
                table: "Event",
                newName: "IX_Event_AdminStatusId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Event",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Event",
                type: "nvarchar(2000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AdminStatus_AdminStatusId",
                table: "Event",
                column: "AdminStatusId",
                principalTable: "AdminStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_AdminStatus_AdminStatusId",
                table: "Event");

            migrationBuilder.RenameColumn(
                name: "AdminStatusId",
                table: "Event",
                newName: "AcceptStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Event_AdminStatusId",
                table: "Event",
                newName: "IX_Event_AcceptStatusId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_AdminStatus_AcceptStatusId",
                table: "Event",
                column: "AcceptStatusId",
                principalTable: "AdminStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
