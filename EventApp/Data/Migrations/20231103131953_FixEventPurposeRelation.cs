using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventApp.Migrations
{
    /// <inheritdoc />
    public partial class FixEventPurposeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purpose_Event_EventId",
                table: "Purpose");

            migrationBuilder.DropIndex(
                name: "IX_Purpose_EventId",
                table: "Purpose");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Purpose");

            migrationBuilder.CreateTable(
                name: "EventPurpose",
                columns: table => new
                {
                    EventsId = table.Column<int>(type: "int", nullable: false),
                    PurposeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPurpose", x => new { x.EventsId, x.PurposeId });
                    table.ForeignKey(
                        name: "FK_EventPurpose_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventPurpose_Purpose_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "Purpose",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventPurpose_PurposeId",
                table: "EventPurpose",
                column: "PurposeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventPurpose");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Purpose",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 3,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 4,
                column: "EventId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 5,
                column: "EventId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Purpose_EventId",
                table: "Purpose",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purpose_Event_EventId",
                table: "Purpose",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id");
        }
    }
}
