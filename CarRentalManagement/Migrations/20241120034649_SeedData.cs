using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5029), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5299), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5301), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5303), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5304), new DateTime(2024, 11, 20, 11, 46, 48, 636, DateTimeKind.Local).AddTicks(5305) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4201), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4439), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4441), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4543), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4545), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4545) });
        }
    }
}
