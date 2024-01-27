using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class l : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Availability", "CarPlate", "CarRentPerDay", "CarRentPerHour", "Colour", "CreatedBy", "DateCreated", "DateUpdated", "ModelId", "OutletId", "UpdatedBy", "Year" },
                values: new object[,]
                {
                    { 1, true, "ABC123", 79.99m, 15.99m, "Blue", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, null, 2020 },
                    { 2, false, "XYZ789", 69.99m, 12.99m, "Red", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, null, 2019 },
                    { 3, true, "DEF456", 89.99m, 18.99m, "Green", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, null, 2021 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed7a87c-dc6d-464e-a95b-8ae80b828328", "AQAAAAIAAYagAAAAEPAVv3Yw7KtQfu3Sulqs/efTe2GFRNueaFfl/DyStFmSiA5jHfCvDJu6iRSMNESlaA==", "c9c6eb8d-73d8-4105-bad4-ca0f32327d43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f78735fc-6d1c-4269-ae56-0240f61447eb", "AQAAAAIAAYagAAAAENoLIWyer190OHo0/RyosAGXN4nnxfDnoI6/tR11LOkMIHofZJGs6NXYP9M2Msmdog==", "1e0fa7d6-5f70-4951-ae80-4746e1b6de13" });
        }
    }
}
