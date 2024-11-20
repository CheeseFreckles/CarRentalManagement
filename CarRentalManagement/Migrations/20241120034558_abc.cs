using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class abc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4201), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4216), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4219), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4439), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4440), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4441), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4442), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4540), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4542), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4542), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4543), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4544), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4545), new DateTime(2024, 11, 20, 11, 45, 57, 638, DateTimeKind.Local).AddTicks(4545), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
