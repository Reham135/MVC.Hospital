using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class relation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "IssuePatient",
                columns: table => new
                {
                    IssuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssuePatient", x => new { x.IssuesId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_IssuePatient_Issues_IssuesId",
                        column: x => x.IssuesId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IssuePatient_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("1aa498b6-196e-46b4-a93b-3277e89ccd9b"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("4118fba0-f71e-4fbb-b449-1f363c112188"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("4b3aa1a7-4c7d-4628-a0f4-7d347dd48e3e"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("6ad5b1c2-3b19-4e82-a8de-2f9afcec8aca"), "Joann", 72, 9232m, "Hematology" },
                    { new Guid("d51ef822-d0d9-4389-843a-981537c13fc3"), "Sara", 82, 45041m, "Pediatrics" },
                    { new Guid("dfb5e641-a056-4e56-a4b6-776b8311f631"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("e0263d1b-4d8d-421e-adce-3a40007961e8"), "Judy", 32, 18711m, "Neurology" },
                    { new Guid("e94a2e71-bf40-4314-94c7-848f477e0a4e"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("f052c4e5-585f-4556-9df1-ea11c18d6a32"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("fe955743-f4ed-4edd-9bc8-7c9d103816f0"), "Naomi", 27, 32145m, "Pediatrics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssuePatient_PatientsId",
                table: "IssuePatient",
                column: "PatientsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuePatient");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1aa498b6-196e-46b4-a93b-3277e89ccd9b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4118fba0-f71e-4fbb-b449-1f363c112188"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4b3aa1a7-4c7d-4628-a0f4-7d347dd48e3e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6ad5b1c2-3b19-4e82-a8de-2f9afcec8aca"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d51ef822-d0d9-4389-843a-981537c13fc3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("dfb5e641-a056-4e56-a4b6-776b8311f631"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e0263d1b-4d8d-421e-adce-3a40007961e8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e94a2e71-bf40-4314-94c7-848f477e0a4e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f052c4e5-585f-4556-9df1-ea11c18d6a32"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("fe955743-f4ed-4edd-9bc8-7c9d103816f0"));

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
        }
    }
}
