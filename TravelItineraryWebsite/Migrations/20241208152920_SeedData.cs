using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryWebsite.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c604540b-8283-4f0c-bd42-f673dedefd6b", "AQAAAAIAAYagAAAAEMu4SqRbnvo/yfHCHbaRr36ARk+2dulKmDD9YJLGJoC6t4wOQTf+/fKaX2E8Pu4/dw==", "7c82f3df-e586-4ef8-9aae-1cdb3e35b4e6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e86b182-6d12-438a-b253-4615f6437c9c", "AQAAAAIAAYagAAAAEApTh55FhgDQOzUj83bnyEqMKkYBhnCSILGmFnwYRB7ev/dzU0w8DNgj3ujN9XY0Ng==", "ada897b8-4c0a-4ece-a54e-64cbcb3821d5" });
        }
    }
}
