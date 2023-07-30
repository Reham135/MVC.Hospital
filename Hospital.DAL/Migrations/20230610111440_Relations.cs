using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0ceb4582-c5c4-473f-b532-ba3227c4e898"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0d7f9e4d-406f-4f31-9a23-cf43ecc55100"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2153cf83-7334-4117-8b54-67f565a59f3e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("27047528-db32-4434-8623-8a39ee529266"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("98cf3198-8d0a-4053-adb4-83fe225f8905"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cb2a9eba-3404-4fa5-bd58-3299e082cb90"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d121254e-9338-48f4-a8ce-600b5c0187b8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("dbc45914-fbbe-469e-b9bb-e8eaba9c8712"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e826721f-1642-44af-b18b-ef118d21b3af"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ec40c7f3-8034-479e-85fb-28580dbb2301"));

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("077796ff-8d5a-461b-8568-5e9d018e8df1"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("30c9bb11-64b1-4315-a544-f0cfe9702873"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("4021d23d-e321-49c2-ac8c-ec54dd3f0af9"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("7bfe8f4b-8a0a-4d94-871c-44c1d0b44fbc"), "Joann", 72, 9232m, "Hematology" },
                    { new Guid("7d9a040b-aec9-4745-ba75-f8858f5c1a94"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("7e49b00d-b525-4c7a-b8f9-523eaee2dad2"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("cf5e5851-1a86-4760-8afe-3e027401ef44"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("d2b4097e-6555-47cd-a4d1-ba1cb8ee5d56"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("ecc841cd-b038-4b6c-a362-68d4ad088879"), "Judy", 32, 18711m, "Neurology" },
                    { new Guid("f13d4a0e-9224-4d22-a343-711c2f96bb2a"), "Sara", 82, 45041m, "Pediatrics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("077796ff-8d5a-461b-8568-5e9d018e8df1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("30c9bb11-64b1-4315-a544-f0cfe9702873"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4021d23d-e321-49c2-ac8c-ec54dd3f0af9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7bfe8f4b-8a0a-4d94-871c-44c1d0b44fbc"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7d9a040b-aec9-4745-ba75-f8858f5c1a94"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7e49b00d-b525-4c7a-b8f9-523eaee2dad2"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cf5e5851-1a86-4760-8afe-3e027401ef44"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d2b4097e-6555-47cd-a4d1-ba1cb8ee5d56"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ecc841cd-b038-4b6c-a362-68d4ad088879"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f13d4a0e-9224-4d22-a343-711c2f96bb2a"));

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
    }
}
