using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JJRentals.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "69eebdd3-8604-496f-a91b-7b52eead6024", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBqMZeAe9sdcXuOhTJLG3lrVsbJx7Zn1drWCJLXIBbh58UIxqCPze4isbIpAodhU4A==", null, false, "72d4eb82-feff-4fd5-9f48-5100269abeb3", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(6403), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(6428), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(6435), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(6436), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7219), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7221), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7225), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7226), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7651), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7652), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7658), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7661), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7662), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 11, 20, 12, 45, 33, 439, DateTimeKind.Local).AddTicks(7665), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
