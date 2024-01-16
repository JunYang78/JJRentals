using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class vehicle_booking_null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e342f1df-a554-4385-b38d-d6f012d7034f", "AQAAAAIAAYagAAAAELIkq0CreNICyppXP0LmidT21Iqlril38JOoMWnZigrgSeXdB8bCXAmZKHz6w+4mnQ==", "7603ce43-f239-432b-b9d5-136cee45c832" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9215), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9219), new DateTime(2024, 1, 3, 12, 15, 58, 661, DateTimeKind.Local).AddTicks(9219) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 1, 3, 12, 3, 17, 102, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Makes",
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
    }
}
