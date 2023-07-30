using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PerformanceRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("0ceb4582-c5c4-473f-b532-ba3227c4e898"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("0d7f9e4d-406f-4f31-9a23-cf43ecc55100"), "Sara", 82, 45041m, "Pediatrics" },
                    { new Guid("2153cf83-7334-4117-8b54-67f565a59f3e"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("27047528-db32-4434-8623-8a39ee529266"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("98cf3198-8d0a-4053-adb4-83fe225f8905"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("cb2a9eba-3404-4fa5-bd58-3299e082cb90"), "Joann", 72, 9232m, "Hematology" },
                    { new Guid("d121254e-9338-48f4-a8ce-600b5c0187b8"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("dbc45914-fbbe-469e-b9bb-e8eaba9c8712"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("e826721f-1642-44af-b18b-ef118d21b3af"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("ec40c7f3-8034-479e-85fb-28580dbb2301"), "Judy", 32, 18711m, "Neurology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
