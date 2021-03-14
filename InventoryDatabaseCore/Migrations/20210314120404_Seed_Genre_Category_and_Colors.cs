using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InventoryDatabaseCore.Migrations
{
    public partial class Seed_Genre_Category_and_Colors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "IsActive", "IsDeleted", "LastModifiedDate", "LastModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 3, 14, 15, 4, 3, 800, DateTimeKind.Local).AddTicks(6983), true, false, null, null, "Fantasy" },
                    { 2, null, new DateTime(2021, 3, 14, 15, 4, 3, 803, DateTimeKind.Local).AddTicks(8533), true, false, null, null, "Sci/Fi" },
                    { 3, null, new DateTime(2021, 3, 14, 15, 4, 3, 803, DateTimeKind.Local).AddTicks(8628), true, false, null, null, "Horror" },
                    { 4, null, new DateTime(2021, 3, 14, 15, 4, 3, 803, DateTimeKind.Local).AddTicks(8635), true, false, null, null, "Comedy" },
                    { 5, null, new DateTime(2021, 3, 14, 15, 4, 3, 803, DateTimeKind.Local).AddTicks(8638), true, false, null, null, "Drama" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
