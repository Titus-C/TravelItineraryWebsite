using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryWebsite.Migrations
{
    /// <inheritdoc />
    public partial class fixAccommTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "AccomodationId",
            //    table: "ItineraryDetail");
            migrationBuilder.RenameColumn(
            name: "AccomodationId",         // The *incorrectly* spelled column name in the *database*
            table: "ItineraryDetail",
            newName: "AccommodationId");    // The *correctly* spelled column name you want

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd0e63a5-25a8-4773-990d-a4211aaa53a6", "AQAAAAIAAYagAAAAEF5vU6HyHF+4YEfEHqNbZD6Ex9ptZO5OuhRb/Wjo/Chcc6MkhuGsIX4oIza9pOPoNw==", "4074742a-c561-4009-9ecf-852e9fbd3eff" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccomodationId",
                table: "ItineraryDetail",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcc461f6-3514-4ece-a2d5-48b96948c959", "AQAAAAIAAYagAAAAELqSBtKXraGyu+V+mlSTdpZ2PJVUeYJsho5TkR7TcvY5xwT1NXqP9lszwwTQwD0/5A==", "b5eb302b-799c-4fe8-b222-ed197c82fd12" });
        }
    }
}
