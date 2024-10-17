using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5848), "paul.taylor6@yahoo.com", "Paul", "Taylor" },
                    { 2, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5862), "peter.jones35@outlook.com", "Peter", "Jones" },
                    { 3, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5864), "david.jones72@gmail.com", "David", "Jones" },
                    { 4, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5866), "steven.brown12@outlook.com", "Steven", "Brown" },
                    { 5, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5873), "steven.miller95@outlook.com", "Steven", "Miller" },
                    { 6, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5876), "andrew.smith39@yahoo.com", "Andrew", "Smith" },
                    { 7, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5878), "steven.taylor86@outlook.com", "Steven", "Taylor" },
                    { 8, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5880), "paul.garcia84@gmail.com", "Paul", "Garcia" },
                    { 9, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5881), "paul.garcia2@yahoo.com", "Paul", "Garcia" },
                    { 10, new DateTime(2024, 3, 23, 14, 27, 54, 829, DateTimeKind.Local).AddTicks(5884), "andrew.jones53@gmail.com", "Andrew", "Jones" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
