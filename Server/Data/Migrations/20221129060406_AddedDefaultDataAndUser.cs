using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 14, 4, 6, 223, DateTimeKind.Local).AddTicks(8323), new DateTime(2022, 11, 29, 14, 4, 6, 224, DateTimeKind.Local).AddTicks(6769), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 14, 4, 6, 224, DateTimeKind.Local).AddTicks(7435), new DateTime(2022, 11, 29, 14, 4, 6, 224, DateTimeKind.Local).AddTicks(7439), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 14, 4, 6, 225, DateTimeKind.Local).AddTicks(7628), new DateTime(2022, 11, 29, 14, 4, 6, 225, DateTimeKind.Local).AddTicks(7636), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 14, 4, 6, 225, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 11, 29, 14, 4, 6, 225, DateTimeKind.Local).AddTicks(7640), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(731), new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(737), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(739), new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(741), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(742), new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(744), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(745), new DateTime(2022, 11, 29, 14, 4, 6, 226, DateTimeKind.Local).AddTicks(746), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
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
