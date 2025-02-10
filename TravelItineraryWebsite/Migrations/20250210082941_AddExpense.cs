using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelItineraryWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddExpense : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4bafd1-822e-4a94-bbe6-9e736a13bd0f", "AQAAAAIAAYagAAAAEHDB5LLmiFW9Fe0hiTV7pBIa6Qk4vVp32sb4e0i+H/DppuUQXgom604EtwtQO2CX4w==", "2eb6db85-6bc8-4b0c-a1a7-32aa95d93b94" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb0dfe5b-45e5-4ad9-a51d-8dba545769cd", "AQAAAAIAAYagAAAAEKSAKc/j3+BFoOexgGP4+f0u1GOB4iAeyy7WHoU3tX5nCpGqzJZzxmEdTZPhJWnBPw==", "9d428b7f-cd18-4332-8082-efc851fc16a0" });
        }
    }
}
