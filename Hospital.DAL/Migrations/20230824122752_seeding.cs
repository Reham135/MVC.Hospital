using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("90f56224-e706-4972-912f-e2434dc075d1"), "Sara", 82, 45041m, "Pediatrics" },
                    { new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("cb92c8fc-ea27-48c8-a585-846989a023a1"), "Joann", 72, 9232m, "Hematology" },
                    { new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("ec310247-7ada-4671-a338-676c98978811"), "Judy", 32, 18711m, "Neurology" }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0cd436c2-329a-4834-9702-f439efd70087"), "Asthma" },
                    { new Guid("11cab47e-b789-4e23-b3c4-644d5905ee4f"), "Diabetes" },
                    { new Guid("3c2700c0-596b-4bd9-8a31-5cf0b6fba2c4"), "Depression" },
                    { new Guid("60cf6ca8-540c-463b-8d45-de51e117cda6"), "Hypertension" },
                    { new Guid("cbc992f4-f99a-44b8-babf-7e9b8d7676ba"), "Flu" },
                    { new Guid("dbed6120-76f4-4db7-9872-ab2b701d081b"), "Arthritis" },
                    { new Guid("df441c3d-6f7f-439f-abc1-6df992119686"), "Allergy" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DoctorId", "Name" },
                values: new object[,]
                {
                    { new Guid("0b15c822-2b83-47cc-92a1-f2d93916c1da"), new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"), "Mitchell" },
                    { new Guid("104a7a3c-678e-41c1-8eb4-37ce7ae4e81b"), new Guid("cb92c8fc-ea27-48c8-a585-846989a023a1"), "Sandy" },
                    { new Guid("146b3f62-b89a-46ea-b8fe-f87e0250e01a"), new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"), "Wendell" },
                    { new Guid("1cdc8290-c05a-4b72-978c-1bec671c9d8b"), new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"), "Marvin" },
                    { new Guid("1d208e01-faab-4e5c-9fbb-05a3a801edd3"), new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"), "Stephanie" },
                    { new Guid("2b330fcb-4f80-4b71-a08c-54fa2564fc05"), new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Joe" },
                    { new Guid("2e289506-1f8b-4653-97bf-55182305a9b9"), new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Ervin" },
                    { new Guid("318d4dec-5469-4001-8ebb-6bb15f6badc2"), new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"), "Dana" },
                    { new Guid("3488e89e-3e23-4ffc-b9a6-5b3a858e8f16"), new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"), "Krystal" },
                    { new Guid("4b8908f1-824b-492c-b9c7-d809c56e454f"), new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"), "Juan" },
                    { new Guid("4ea3b834-f85f-4b10-a6d2-aafd48af6fc7"), new Guid("ec310247-7ada-4671-a338-676c98978811"), "Roosevelt" },
                    { new Guid("4f245803-da22-4f4c-a178-6e5f7ad62575"), new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Terence" },
                    { new Guid("544c741e-987d-42a0-90f7-f92f6be6296f"), new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"), "Erma" },
                    { new Guid("5f14cd6a-0679-47d2-9684-ee724a19bcca"), new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"), "Tasha" },
                    { new Guid("692d1108-259e-47f4-a511-cb9f9925cc31"), new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"), "Orlando" },
                    { new Guid("6ac59b51-131e-4477-98e5-6de432586f7f"), new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Gretchen" },
                    { new Guid("6e249b3b-761e-4cb9-9eba-9e0229624fdf"), new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"), "Bridget" },
                    { new Guid("7269ddda-48c7-4878-968b-3d75978d1810"), new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Jerry" },
                    { new Guid("7be56ccf-8912-4649-8c67-41968ae093e0"), new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"), "Maggie" },
                    { new Guid("7cf3208e-0525-4e35-b36c-9730e7cf3923"), new Guid("ec310247-7ada-4671-a338-676c98978811"), "Max" },
                    { new Guid("8dc902ff-64cb-4353-a172-7498564cc6ae"), new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"), "Lloyd" },
                    { new Guid("9cbb9724-956f-4f5f-8890-56ea6cb0dc9e"), new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"), "Miriam" },
                    { new Guid("a0674918-a95d-46a9-b3b0-1bf7ca5c249b"), new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"), "Isaac" },
                    { new Guid("a4be96b9-4277-4fd7-8461-648ee2ae449c"), new Guid("90f56224-e706-4972-912f-e2434dc075d1"), "Eduardo" },
                    { new Guid("ae6db48e-7341-4884-81b6-e59289d0251b"), new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"), "Gwendolyn" },
                    { new Guid("b9758c54-bbd1-42a6-985b-1c64ed5c25f3"), new Guid("90f56224-e706-4972-912f-e2434dc075d1"), "Damon" },
                    { new Guid("cb9933df-c787-40f2-84cf-3837ad1c5eaf"), new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"), "Lamar" },
                    { new Guid("d1b8df29-7a36-468c-956b-d2a8cb882503"), new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"), "Beth" },
                    { new Guid("d24ca736-b78d-4fd3-bbae-54fe079dde1d"), new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"), "Sandra" },
                    { new Guid("d603707b-e891-49ad-ac0e-ddfa9c2f8b7d"), new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"), "Wilbert" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("0cd436c2-329a-4834-9702-f439efd70087"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("11cab47e-b789-4e23-b3c4-644d5905ee4f"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("3c2700c0-596b-4bd9-8a31-5cf0b6fba2c4"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("60cf6ca8-540c-463b-8d45-de51e117cda6"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("cbc992f4-f99a-44b8-babf-7e9b8d7676ba"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("dbed6120-76f4-4db7-9872-ab2b701d081b"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("df441c3d-6f7f-439f-abc1-6df992119686"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("0b15c822-2b83-47cc-92a1-f2d93916c1da"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("104a7a3c-678e-41c1-8eb4-37ce7ae4e81b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("146b3f62-b89a-46ea-b8fe-f87e0250e01a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1cdc8290-c05a-4b72-978c-1bec671c9d8b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1d208e01-faab-4e5c-9fbb-05a3a801edd3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2b330fcb-4f80-4b71-a08c-54fa2564fc05"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2e289506-1f8b-4653-97bf-55182305a9b9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("318d4dec-5469-4001-8ebb-6bb15f6badc2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3488e89e-3e23-4ffc-b9a6-5b3a858e8f16"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4b8908f1-824b-492c-b9c7-d809c56e454f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4ea3b834-f85f-4b10-a6d2-aafd48af6fc7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4f245803-da22-4f4c-a178-6e5f7ad62575"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("544c741e-987d-42a0-90f7-f92f6be6296f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5f14cd6a-0679-47d2-9684-ee724a19bcca"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("692d1108-259e-47f4-a511-cb9f9925cc31"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6ac59b51-131e-4477-98e5-6de432586f7f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6e249b3b-761e-4cb9-9eba-9e0229624fdf"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7269ddda-48c7-4878-968b-3d75978d1810"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7be56ccf-8912-4649-8c67-41968ae093e0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7cf3208e-0525-4e35-b36c-9730e7cf3923"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8dc902ff-64cb-4353-a172-7498564cc6ae"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9cbb9724-956f-4f5f-8890-56ea6cb0dc9e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a0674918-a95d-46a9-b3b0-1bf7ca5c249b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a4be96b9-4277-4fd7-8461-648ee2ae449c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ae6db48e-7341-4884-81b6-e59289d0251b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b9758c54-bbd1-42a6-985b-1c64ed5c25f3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cb9933df-c787-40f2-84cf-3837ad1c5eaf"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d1b8df29-7a36-468c-956b-d2a8cb882503"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d24ca736-b78d-4fd3-bbae-54fe079dde1d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d603707b-e891-49ad-ac0e-ddfa9c2f8b7d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("90f56224-e706-4972-912f-e2434dc075d1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cb92c8fc-ea27-48c8-a585-846989a023a1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ec310247-7ada-4671-a338-676c98978811"));
        }
    }
}
