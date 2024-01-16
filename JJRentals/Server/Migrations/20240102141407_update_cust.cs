using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class update_cust : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3454dfe-7e02-4036-b7d7-1fd81f2b8d4b", "AQAAAAIAAYagAAAAEFomFyGIpVgLV38BAFzYVGuuP1930SI+6nPuWi9o3p7Cjp0irWhjhrQLs482IbvcqQ==", "7c094190-4467-4080-9b37-cc43b23b50a6" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(5936), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6381), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6382) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6383), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6384), new DateTime(2024, 1, 2, 22, 14, 7, 798, DateTimeKind.Local).AddTicks(6385) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fa98f38-d46c-4141-ba9a-905ababc35c9", "AQAAAAIAAYagAAAAEJj/Um0Nnnk5aGG6nRxaOom7A15F1u4teTGDNgzaZFhVCesB6kQ+NKIBO9qRD7BphA==", "711acd60-8c45-4af4-890a-52fa5d010c11" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(7785), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8143), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8340), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 1, 2, 21, 53, 38, 613, DateTimeKind.Local).AddTicks(8342) });
        }
    }
}
