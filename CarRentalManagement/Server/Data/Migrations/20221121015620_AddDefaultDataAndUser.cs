using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "1b0c098c-ae28-4552-87ac-ce0fa81b28f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "984f78ed-80cb-46b2-a0ea-246748c84076");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d836c7d8-bada-40b3-8d67-091a8ffe5f86", "AQAAAAEAACcQAAAAEG3OWkLvk3ri8eInECplyod1RHz8PI5RSqbiJulnTz3VZpamRGcWKEeiaAmKsAzL0A==", "f4e91350-a951-4f74-8d01-aecb53e82981" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 148, DateTimeKind.Local).AddTicks(7599), new DateTime(2022, 11, 21, 9, 56, 20, 150, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 150, DateTimeKind.Local).AddTicks(5878), new DateTime(2022, 11, 21, 9, 56, 20, 150, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3545), new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3554), new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3557), new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 11, 21, 9, 56, 20, 152, DateTimeKind.Local).AddTicks(3561) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "b6ab2a59-2dba-4c62-b58b-a08b8a6eb0e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "996d9eb3-1439-4c1e-b470-1f0734ffffce");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dedb302e-4af3-4a25-8c62-7f910f8d63a9", "AQAAAAEAACcQAAAAEDxetuAfHGXgB1CsySJwcjQD4L6lokOv96ZEvaU4LjC6p89LLVSBeJs0oV8fJDcEsw==", "dd033d19-0214-41bf-a67e-e3b5477d14d6" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 359, DateTimeKind.Local).AddTicks(5728), new DateTime(2022, 11, 21, 9, 21, 20, 361, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 361, DateTimeKind.Local).AddTicks(5083), new DateTime(2022, 11, 21, 9, 21, 20, 361, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(1041), new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(1056), new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5813), new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5826), new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5834), new DateTime(2022, 11, 21, 9, 21, 20, 363, DateTimeKind.Local).AddTicks(5836) });
        }
    }
}
