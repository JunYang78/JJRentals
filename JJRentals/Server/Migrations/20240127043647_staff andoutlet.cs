using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class staffandoutlet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Outlets",
                columns: new[] { "Id", "ContactNo", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Location", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "63234590", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JJRentalHorizon@gmail.com", "SengKang", "JJRentalHorizon", null },
                    { 2, "67885643", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JJRentalMirage@yahoo.com", "BoonLay", "JJRentalMirage", null },
                    { 3, "64523474", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JJRentalDestiny@yahoo.com", "Tampinies", "JJRentalDestiny", null }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Address", "ContactNo", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "HireDate", "Name", "OutletId", "Password", "Position", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "42 Punggol Street 62", "92554760", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jackson@gmail.com", new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jackson Lee", 1, "jacky123", "Fleet Manager", null },
                    { 2, "82 Tampinies Street 23", "96374434", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jave@gmail.com", new DateTime(2008, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jave Lau", 2, "jave123", "Reservation Agent", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Outlets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3326590-7e06-4505-99e0-19befb047b8d", "AQAAAAIAAYagAAAAEHGmAdxgbNDw4JSb5LHpBY+cLmqZ2OcKGjATaY9LU22IRQAIvLPxnMvRSYqXDjX2QA==", "0a69aa91-92d1-45d1-90a7-dcb30682ae07" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "816f63e6-d9f1-4eea-a09f-6ced18b13788", "AQAAAAIAAYagAAAAEG17tIbvQrWfF6Dczq6hmPsVh94xOuzsNS46Ux6YwJHqk7EGfaBPCb2XFSYYVzAFdw==", "bad2ca46-4a09-4f7d-8488-c5a7372249f9" });
        }
    }
}
