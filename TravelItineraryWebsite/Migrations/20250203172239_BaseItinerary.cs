using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryWebsite.Migrations
{
    /// <inheritdoc />
    public partial class BaseItinerary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ItineraryDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "ItineraryDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "ItineraryDetail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ItineraryDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "ItineraryDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1a01f07-fd17-4663-ad31-6b835febc884", "AQAAAAIAAYagAAAAECBVcYJu2ijtp9WPDsq30Ay9cL0QhmyrpAHCJC96BdgAPFFDlTUDRQ//blD3zDU1OQ==", "2c680175-d784-481a-bdc1-203f8e8ec5d8" });

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryDetail_ItineraryId",
                table: "ItineraryDetail",
                column: "ItineraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItineraryDetail_Itinerary_ItineraryId",
                table: "ItineraryDetail",
                column: "ItineraryId",
                principalTable: "Itinerary",
                principalColumn: "ItineraryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItineraryDetail_Itinerary_ItineraryId",
                table: "ItineraryDetail");

            migrationBuilder.DropIndex(
                name: "IX_ItineraryDetail_ItineraryId",
                table: "ItineraryDetail");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ItineraryDetail");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "ItineraryDetail");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "ItineraryDetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ItineraryDetail");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ItineraryDetail");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e86b182-6d12-438a-b253-4615f6437c9c", "AQAAAAIAAYagAAAAEApTh55FhgDQOzUj83bnyEqMKkYBhnCSILGmFnwYRB7ev/dzU0w8DNgj3ujN9XY0Ng==", "ada897b8-4c0a-4ece-a54e-64cbcb3821d5" });
        }
    }
}
