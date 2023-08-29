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
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { new Guid("0e3fc154-d0af-4719-9ee8-a7d12563cced"), "Joann", 72, 9232m, "Hematology" },
                    { new Guid("19d22233-9758-4e00-8ccd-92311e2ba8d6"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("33c644e0-7553-43db-991d-c450fd64adf8"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("61a671d3-dfd6-40f0-aabb-929160a6e240"), "Judy", 32, 18711m, "Neurology" },
                    { new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("76a11fcf-dd4d-4d0e-8404-fbf2c5ec8389"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("c2c263ee-e86b-45f6-9410-c6d50285120c"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("c9395ccb-e7aa-4add-9d5d-de61a0edd297"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("cdeb4840-da71-4c67-94e7-d124fa562d68"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("e73fc86f-0724-4a0c-a8fe-52fd7238932d"), "Sara", 82, 45041m, "Pediatrics" }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c7679e6-3214-425d-8e7f-53abe192a6cc"), "Arthritis" },
                    { new Guid("22512b93-8b8b-4139-8c25-75a0aadd9bea"), "Asthma" },
                    { new Guid("27dcfe13-9a6a-4b3a-b5c2-b8391d70690b"), "Allergy" },
                    { new Guid("3dd5245c-939d-4054-9fa1-0deeaeda24d6"), "Diabetes" },
                    { new Guid("9320a6e7-0b49-48fe-b141-1fa0c9e6a4f8"), "Depression" },
                    { new Guid("d40dda5c-e113-4d1d-9387-2b91c47517cc"), "Hypertension" },
                    { new Guid("de566c34-94a0-4756-b546-4e50a1f3dd71"), "Flu" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DoctorId", "Name" },
                values: new object[,]
                {
                    { new Guid("1307e1b3-262f-4f34-8e6c-84712c0a4a96"), new Guid("c9395ccb-e7aa-4add-9d5d-de61a0edd297"), "Sandra" },
                    { new Guid("16bceabe-d0cb-4089-a7f4-84db80e6c404"), new Guid("c2c263ee-e86b-45f6-9410-c6d50285120c"), "Lloyd" },
                    { new Guid("1bdf9193-a144-4b2c-82db-536e1daeda7e"), new Guid("61a671d3-dfd6-40f0-aabb-929160a6e240"), "Roosevelt" },
                    { new Guid("2389f8e0-92da-4ce3-ad5f-1299054c7425"), new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Isaac" },
                    { new Guid("310f2472-3b29-4114-9bb9-32a4de1a2744"), new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Terence" },
                    { new Guid("3441d6d0-72f4-45df-864b-5274933a735c"), new Guid("cdeb4840-da71-4c67-94e7-d124fa562d68"), "Marvin" },
                    { new Guid("3712eb13-7afc-4a52-b7a4-3f67d280d241"), new Guid("0e3fc154-d0af-4719-9ee8-a7d12563cced"), "Sandy" },
                    { new Guid("4126b03d-84b2-4fbe-bf5d-28dfeb1e3d00"), new Guid("33c644e0-7553-43db-991d-c450fd64adf8"), "Stephanie" },
                    { new Guid("41f3e020-8f6a-4272-ad3c-21facf5910db"), new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Ervin" },
                    { new Guid("44bee883-c171-4dfa-9293-587db3cbf2c5"), new Guid("cdeb4840-da71-4c67-94e7-d124fa562d68"), "Dana" },
                    { new Guid("4d8f41f5-d279-4b93-a3fb-e5e0f882bf92"), new Guid("cdeb4840-da71-4c67-94e7-d124fa562d68"), "Tasha" },
                    { new Guid("53843957-3860-40ca-b990-07cd9f163aa2"), new Guid("33c644e0-7553-43db-991d-c450fd64adf8"), "Mitchell" },
                    { new Guid("66e4a6ea-4872-4228-86ce-93d4371bf882"), new Guid("c2c263ee-e86b-45f6-9410-c6d50285120c"), "Bridget" },
                    { new Guid("6bc1cbb3-0ef1-4af0-b8c1-6e4c47329c6d"), new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Joe" },
                    { new Guid("6cd1da93-9730-4bf9-af3d-ae702cfdbc29"), new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Gretchen" },
                    { new Guid("6d3697d8-a2be-4d9c-856e-a4db7db592b5"), new Guid("e73fc86f-0724-4a0c-a8fe-52fd7238932d"), "Eduardo" },
                    { new Guid("76d12572-28b0-4e6b-a820-76d561cb6348"), new Guid("c9395ccb-e7aa-4add-9d5d-de61a0edd297"), "Lamar" },
                    { new Guid("7d0c01f6-372f-41ff-96ed-d51bcd9572b5"), new Guid("76a11fcf-dd4d-4d0e-8404-fbf2c5ec8389"), "Erma" },
                    { new Guid("7eaf1561-34ba-4137-a69e-7fd42388bafe"), new Guid("c2c263ee-e86b-45f6-9410-c6d50285120c"), "Gwendolyn" },
                    { new Guid("82f856c8-69f7-4c53-838c-d1972992f383"), new Guid("19d22233-9758-4e00-8ccd-92311e2ba8d6"), "Juan" },
                    { new Guid("868998f3-c15b-4399-ab42-9c4adc7ef1cd"), new Guid("19d22233-9758-4e00-8ccd-92311e2ba8d6"), "Maggie" },
                    { new Guid("8790fb17-2d32-4a8b-b2f5-8c46d5cfd29b"), new Guid("19d22233-9758-4e00-8ccd-92311e2ba8d6"), "Wendell" },
                    { new Guid("a9a74c48-3996-4d14-b2a5-e3e210817dea"), new Guid("76a11fcf-dd4d-4d0e-8404-fbf2c5ec8389"), "Krystal" },
                    { new Guid("b5ba4cac-3caf-4b07-82e6-25d314edf40d"), new Guid("e73fc86f-0724-4a0c-a8fe-52fd7238932d"), "Damon" },
                    { new Guid("b6c39554-980a-424f-a2db-859e15604ea8"), new Guid("61a671d3-dfd6-40f0-aabb-929160a6e240"), "Max" },
                    { new Guid("b6c8e7c9-4e7c-44ff-aead-9b2d8fdc9e4c"), new Guid("c9395ccb-e7aa-4add-9d5d-de61a0edd297"), "Beth" },
                    { new Guid("c54fd8d1-9557-45af-97dc-4d466103c63c"), new Guid("6f09a669-9484-451c-a3ba-4bbafce5a028"), "Jerry" },
                    { new Guid("d1bc83c4-91c7-4de3-9431-af5ff1b77bfa"), new Guid("33c644e0-7553-43db-991d-c450fd64adf8"), "Orlando" },
                    { new Guid("d75187c2-d690-4e59-960c-916d02be795c"), new Guid("19d22233-9758-4e00-8ccd-92311e2ba8d6"), "Miriam" },
                    { new Guid("fe1d49ec-11c6-498f-9b5d-db1f58273e54"), new Guid("19d22233-9758-4e00-8ccd-92311e2ba8d6"), "Wilbert" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_IssuePatient_PatientsId",
                table: "IssuePatient",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IssuePatient");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
