using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoneyDoService.Migrations
{
    public partial class HoneyDoServiceModelsHoneyDoItemContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HoneyDoItems",
                columns: new[] { "Id", "AssignedTo", "Category", "Completed", "Description", "DueDate", "Priority", "Recurrence" },
                values: new object[] { 1, "Me", "Home indoors", false, "Clean litter box", new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Local), "High", "Monthly" });

            migrationBuilder.InsertData(
                table: "HoneyDoItems",
                columns: new[] { "Id", "AssignedTo", "Category", "Completed", "Description", "DueDate", "Priority", "Recurrence" },
                values: new object[] { 2, "Us", "Errand", false, "Grocery Shoop", new DateTime(2020, 3, 7, 0, 0, 0, 0, DateTimeKind.Local), "High", "Weekly" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HoneyDoItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HoneyDoItems",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
