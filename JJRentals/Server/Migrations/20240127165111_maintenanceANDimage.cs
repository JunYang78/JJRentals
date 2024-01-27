using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class maintenanceANDimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Maintenance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0695421f-f7e3-4225-876a-9c7f81dc6c5c", "AQAAAAIAAYagAAAAEG4JRq7a+nwcTvUnxh3u8d6rL/tK4MOhDXTEQl0AFn3HU2weTp6wjy9GqMrBf0FNdw==", "7897194e-b2f0-4d27-b96d-9cdd6e2495fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1059e727-cc7e-465e-a299-2356fa9246b0", "AQAAAAIAAYagAAAAEBT+PT67zotf/Zl2v+W34l7BpJvHIfnIL7VFDD0x+s3HWxPQvboXL6QnAGBFhaxLmQ==", "ce4e42ee-7456-45f0-bb5a-3cfd7bb2ed33" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CarId", "CreatedBy", "DateCreated", "DateUpdated", "ImgFileURL", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/images/car1.jpg", null },
                    { 2, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://example.com/images/car2.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Maintenance",
                columns: new[] { "Id", "CarId", "Cost", "CreatedBy", "DateCreated", "DateUpdated", "PartsAffected", "ReturnDate", "SentDate", "ServiceProvider", "StaffId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 200.00m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brakes, Oil filter", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best Maintenance Co", 1, null },
                    { 2, 2, 150.00m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air filter, Headlights", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quick Fix Mechanics", 2, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Maintenance",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Maintenance",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Maintenance",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e428f758-2f40-4ca4-8d1c-a071b3a0c0d4", "AQAAAAIAAYagAAAAEOgrTkMBr25d5XG7ER/3kzk1D6gBxxs2vxGQzxkp3O0HaJfaWmghOTmJfNKUG6iWJg==", "e38d5523-40a9-432d-a93b-d355f4afb01a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13619883-14bb-42c4-bd4c-e45004383763", "AQAAAAIAAYagAAAAEDQbkNk4/AkBoS9qMZ7Z6YBg+VeYzHo+UwEqiy2yEi3AxP1T8NRhomEisfdslx1SBw==", "a83d4b50-9ad3-44d5-b4e7-0e1a555368ca" });
        }
    }
}
