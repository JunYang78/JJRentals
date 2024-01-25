using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
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
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2b869731-b302-4b29-b83a-e0f6e169274c", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHkGtmAOgmQtrIIiVEwdHXOGkfjtE1vmByhQyh6m8WVYho22dNhXd6C1aRShwRJLnA==", null, false, "2443de54-7b81-4898-a473-a2123e2b97d9", false, "admin@localhost.com" },
                    { "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1", 0, "02b034d1-4431-44ed-b0cc-2d5a69aa58d8", "user@localhost.com", false, "User", "Default", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEMpT8OH+pcaiDZ7TLgPCCSJRWKCa8alwJ6rFegA9LE/xd6ZMHXDeuAY6UmtNPn7MEQ==", null, false, "e32b4715-d9ea-4648-a777-d3061d074623", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ContactNo", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "DriverLicenseNo", "Email", "LicenseExpDate", "LicenseIssueDate", "Name", "Password", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "81 Bedok Street 21", "98854760", "System", new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6212), new DateTime(2000, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6223), "S7654321Z", "john@gmail.com", new DateTime(2099, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Tan", "john123", "System" },
                    { 2, "203 Tampines Street 24", "96377946", "System", new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6228), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6228), "S1234567A", "mary@gmail.com", new DateTime(2099, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mary Lim", "mary123", "System" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "ContactNo", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "91234567", "System", new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6546), "BMW@gmail.com", "BMW", "System" },
                    { 2, "81234567", "System", new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6549), "Toyota@yahoo.com", "Toyota", "System" },
                    { 3, "87654321", "System", new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 1, 25, 16, 45, 13, 680, DateTimeKind.Local).AddTicks(6550), "Honda@yahoo.com", "Honda", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FuelType", "ManufacturerId", "Name", "SeatCapacity", "TransmissionType", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2018, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 1, "BMW X7", 5, "Automatic", null },
                    { 2, null, new DateTime(2006, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 1, "BMW X5", 5, "Automatic", null },
                    { 3, null, new DateTime(2002, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 1, "BMW Z4", 2, "Manual", null },
                    { 4, null, new DateTime(2013, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 3, "Honda Civic", 5, "Manual", null },
                    { 5, null, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hybrid", 3, "Honda Accord", 5, "Automatic", null },
                    { 6, null, new DateTime(2015, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diesel", 3, "Honda CR-V", 5, "Automatic", null },
                    { 7, null, new DateTime(2020, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2, "Toyota Corolla", 5, "Automatic", null },
                    { 8, null, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hybrid", 2, "Toyota Camry", 5, "Automatic", null },
                    { 9, null, new DateTime(2010, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petrol", 2, "Toyota RAV4", 5, "Manual", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1" });

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
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
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1");

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
