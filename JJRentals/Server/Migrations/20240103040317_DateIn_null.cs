using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class DateIn_null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96b012bb-218c-4c5b-a6eb-51994127a391", "AQAAAAIAAYagAAAAEEOOh4uyzrMH8vk41ygWXOqY5BJaRoekY/jP6pnF43m+MJRrheGXSuuCfLfn27VTlQ==", "1289d5a7-d4dd-4b32-bfdb-78512d67d667" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1277) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1280), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1281) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1998), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(2000), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(2002), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(2002) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DrivingLicense",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
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
    }
}
