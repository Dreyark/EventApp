using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventApp.Migrations
{
    /// <inheritdoc />
    public partial class OnModelCreating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AdminStatus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Oczekujące" },
                    { 2, "Zaakceptowane" },
                    { 3, "Odrzucone" }
                });

            migrationBuilder.InsertData(
                table: "Purpose",
                columns: new[] { "Id", "EventId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Rozrywkowe" },
                    { 2, null, "Kulturalne" },
                    { 3, null, "Charytatywne" },
                    { 4, null, "Sportowe" },
                    { 5, null, "Biznesowe" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Oczekujące" },
                    { 2, "Zaakceptowane" },
                    { 3, "Wstrzymane" },
                    { 4, "Odrzucone" }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Koncert" },
                    { 2, "Festyn" },
                    { 3, "Wystawa" },
                    { 4, "Targi" },
                    { 5, "Zawody" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AdminStatus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AdminStatus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AdminStatus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Purpose",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
