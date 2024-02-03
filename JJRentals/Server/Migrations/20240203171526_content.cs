using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JJRentals.Server.Migrations
{
    /// <inheritdoc />
    public partial class content : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Staff",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Staff",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Staff",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Staff",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Staff",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Outlets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Outlets",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Outlets",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceProvider",
                table: "Maintenance",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PartsAffected",
                table: "Maintenance",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CarPlate",
                table: "Cars",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d433aee3-5cc8-4e06-9471-fcb33ef03b36", "AQAAAAIAAYagAAAAEIUX59P9AKE1w15Pz5LvpnkZl2H1U+cK60X6Q97tlWXF0D3hriwRIpG/dwNT/owzKg==", "6713068f-9ae4-4243-a8d8-74c0abebe9ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5bf368d-7d24-4858-b325-526b288c8f1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7efec0a2-4e06-4f95-bbee-3eed9ef03c5a", "AQAAAAIAAYagAAAAEM1fREMk08GEb2xSlDQLknU/7Gu5gQTfz//LnyVSoggHSY00/gdG1mo+cGUzEIQJNg==", "05b91938-d4df-44df-b6cf-061cf9291292" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b853f17-b8a0-4e03-b7c2-5ad1ded8b2fb", "AQAAAAIAAYagAAAAECCbd6gpZWaK/5UeAYKS1jpvVh573vJdNpRoTHZ7yxgY6LkU9MEemyTmO91wPNP4/g==", "5eee1174-79a5-4715-92be-1782f0ab3424" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb50467-a003-40aa-9ead-c34777f6f63e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85ce7a71-f013-4f38-84b6-c1a2df0c8340", "AQAAAAIAAYagAAAAEGnb/KTYXR8rIKjsQPn4WdjUU8bJ/AZpL8vHDaP8UwmwiQrhbQePsnQOqK8DF3JtXQ==", "a0e5c3af-28d6-4288-abcd-6fb753058dc1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Outlets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Outlets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNo",
                table: "Outlets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "ServiceProvider",
                table: "Maintenance",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PartsAffected",
                table: "Maintenance",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "CarPlate",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc04ffd7-b30a-45c5-904c-425aed591761", "AQAAAAIAAYagAAAAEJUHDcKP9YKkIrVMPRGTZvSwhMTHoeUv8a3EvvSMabt0gLLDjH309PPblUt9L/TQ7g==", "d6ff08c3-7084-4c9a-b27c-ad58eecbd2ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5bf368d-7d24-4858-b325-526b288c8f1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95bcd394-b4ce-48f0-b40a-305cc4ecbc41", "AQAAAAIAAYagAAAAELE50z2JILOqdGCSk6gwmJHwPW0CZHhFO0FTDfK+ct/z7nSiPGEesrNik6pHtKWyxA==", "388ac10d-16d4-42a8-bbbd-d456ddcf6012" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e64d016-d1a6-455a-baa2-622e29148a44", "AQAAAAIAAYagAAAAEOqPlAZQz5/OW9un9JQxuXv7CKkiRcF0YmMnY8HfOr7b4T14JeyvmG3Z879IrYhR3Q==", "fd77d945-e5a2-42d3-8aab-d8cebfcc0fb5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edb50467-a003-40aa-9ead-c34777f6f63e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10d1fa92-8381-4496-bf42-b73c0914c1fd", "AQAAAAIAAYagAAAAEG97ZwQ+s97STiLJcvDna+B0jSWeaLoCg7xmtO35lIQwCOek+hpJeP5gorzteI2big==", "fbd62791-24cd-4c3d-8e3d-f73193c3f3f5" });
        }
    }
}
