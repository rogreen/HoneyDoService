using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoneyDoService.Migrations
{
    public partial class HoneyDoServiceModelsHoneyDoItemContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoneyDoItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    AssignedTo = table.Column<string>(nullable: true),
                    Priority = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    DueDate = table.Column<DateTime>(nullable: false),
                    Recurrence = table.Column<string>(nullable: true),
                    Completed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoneyDoItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoneyDoItems");
        }
    }
}
