using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1279c557-f58b-450d-8532-d9471f1320fc"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("1539d778-d1a1-4848-bc76-75ec4175a718"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("7846fc85-347f-4c90-9107-90be08bd1c02"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("83adbdea-1fcd-4ae8-9a5a-bbe7fa9e0ba8"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("938c2da0-ae7f-43ee-9b4b-6e5e6fa91500"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("dcbaf073-3660-4031-a7c4-24697b183f3a"));

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: new Guid("e04d760e-b3ee-469b-b0ac-91b1595366b3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1e51f1e6-b682-4881-b02b-f8fccf706ffe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1ef012e0-c502-4e3e-bdfc-d92131289e3c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2d6b1e75-e41a-4702-a0d8-4443e2abdf88"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3140e784-e3a7-4f03-acae-ebb22803f6cc"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("380aa230-45a1-4435-ac5f-e8378e0f935a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3d0f68c1-3cda-4772-a9fa-39c758fc8905"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("459974e8-bc5d-4429-bbc6-58c7e3ec9934"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("48bd8ac4-3cf7-4a1a-b445-8cd6572ad90b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("55866a37-f707-4c9d-8a83-29c0fe06ce16"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6065292f-89be-4285-9c22-69370be9cbd0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("60b22b07-267c-44ba-86de-7c7ff88a2c58"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7865b992-2d87-41ea-9241-0ed5a3de51d7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7e7c5ca2-5bf5-49d1-ad8e-9cc754d1ef54"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("85e492c1-c047-4d5b-93e1-ef99080a9678"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("909abbec-1fe0-4cf3-ae94-a1c44b9753bd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9849e376-36ee-4b41-84c1-a5ed1d2efe84"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a510d03c-0795-436e-845c-edf77756ddfe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("af29b6d9-6a7d-4896-8082-eef07f299e9d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b197c712-a24f-4276-b1de-c26d44a7bc50"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b61a5c34-4266-41b7-a15b-46b38792d66b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cc8a7039-769c-4eff-a697-bd7a43f38104"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cdfad3fe-d2fe-4300-b332-468573df5459"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d66579a4-399e-41dd-9d9c-28c2422b7578"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dacc5574-24dd-41bf-8e70-d6830cd8c59b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("eb379f4b-8dee-4a19-843c-c51589bb5e40"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f07c7d60-d715-4cf9-9c24-778069d38320"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f2c0dea3-ee95-4d30-8f32-9f5c580d21fe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f5024a5e-e9cd-40a9-ac58-8b88ddba76f1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("fb5b6742-a0a2-4d75-855d-594589c2afdb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("fbb649c4-ffab-41f0-b9dd-8dd8b5d71573"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0028f547-7246-422b-a461-4e44e3020f17"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5ca86934-de29-42cc-a77f-f57636a6a968"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("731d1963-a780-4942-ac97-50dc5fd2a8d6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7f142e14-2fb1-4e88-bf7c-29c9d33faf60"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("87125863-fd72-4e2b-ab90-69f43e8e5928"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b6132b34-f470-49cf-92c4-463cbc3f54e0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("da1a37f1-8e7b-4864-b83c-0c1df42c4f80"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("db630dc7-9e11-44a4-9c7b-3be040c8dfe1"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "PerformanceRate", "Salary", "Specialization" },
                values: new object[,]
                {
                    { new Guid("0028f547-7246-422b-a461-4e44e3020f17"), "Judy", 19, 48498m, "Dermatology" },
                    { new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"), "Rafael", 97, 12266m, "Pediatrics" },
                    { new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Paula", 0, 19094m, "Urology" },
                    { new Guid("5ca86934-de29-42cc-a77f-f57636a6a968"), "Mable", 5, 33706m, "Infectious Disease" },
                    { new Guid("731d1963-a780-4942-ac97-50dc5fd2a8d6"), "Sara", 82, 45041m, "Pediatrics" },
                    { new Guid("7f142e14-2fb1-4e88-bf7c-29c9d33faf60"), "Judy", 32, 18711m, "Neurology" },
                    { new Guid("87125863-fd72-4e2b-ab90-69f43e8e5928"), "Jessie", 65, 27064m, "Hematology" },
                    { new Guid("b6132b34-f470-49cf-92c4-463cbc3f54e0"), "Naomi", 27, 32145m, "Pediatrics" },
                    { new Guid("da1a37f1-8e7b-4864-b83c-0c1df42c4f80"), "Alyssa", 79, 16586m, "Gastroenterology" },
                    { new Guid("db630dc7-9e11-44a4-9c7b-3be040c8dfe1"), "Joann", 72, 9232m, "Hematology" }
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1279c557-f58b-450d-8532-d9471f1320fc"), "Hypertension" },
                    { new Guid("1539d778-d1a1-4848-bc76-75ec4175a718"), "Allergy" },
                    { new Guid("7846fc85-347f-4c90-9107-90be08bd1c02"), "Diabetes" },
                    { new Guid("83adbdea-1fcd-4ae8-9a5a-bbe7fa9e0ba8"), "Depression" },
                    { new Guid("938c2da0-ae7f-43ee-9b4b-6e5e6fa91500"), "Arthritis" },
                    { new Guid("dcbaf073-3660-4031-a7c4-24697b183f3a"), "Asthma" },
                    { new Guid("e04d760e-b3ee-469b-b0ac-91b1595366b3"), "Flu" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "DoctorId", "Name" },
                values: new object[,]
                {
                    { new Guid("1e51f1e6-b682-4881-b02b-f8fccf706ffe"), new Guid("87125863-fd72-4e2b-ab90-69f43e8e5928"), "Krystal" },
                    { new Guid("1ef012e0-c502-4e3e-bdfc-d92131289e3c"), new Guid("7f142e14-2fb1-4e88-bf7c-29c9d33faf60"), "Max" },
                    { new Guid("2d6b1e75-e41a-4702-a0d8-4443e2abdf88"), new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"), "Miriam" },
                    { new Guid("3140e784-e3a7-4f03-acae-ebb22803f6cc"), new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Gretchen" },
                    { new Guid("380aa230-45a1-4435-ac5f-e8378e0f935a"), new Guid("b6132b34-f470-49cf-92c4-463cbc3f54e0"), "Lloyd" },
                    { new Guid("3d0f68c1-3cda-4772-a9fa-39c758fc8905"), new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Ervin" },
                    { new Guid("459974e8-bc5d-4429-bbc6-58c7e3ec9934"), new Guid("5ca86934-de29-42cc-a77f-f57636a6a968"), "Orlando" },
                    { new Guid("48bd8ac4-3cf7-4a1a-b445-8cd6572ad90b"), new Guid("5ca86934-de29-42cc-a77f-f57636a6a968"), "Stephanie" },
                    { new Guid("55866a37-f707-4c9d-8a83-29c0fe06ce16"), new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"), "Maggie" },
                    { new Guid("6065292f-89be-4285-9c22-69370be9cbd0"), new Guid("da1a37f1-8e7b-4864-b83c-0c1df42c4f80"), "Dana" },
                    { new Guid("60b22b07-267c-44ba-86de-7c7ff88a2c58"), new Guid("da1a37f1-8e7b-4864-b83c-0c1df42c4f80"), "Tasha" },
                    { new Guid("7865b992-2d87-41ea-9241-0ed5a3de51d7"), new Guid("87125863-fd72-4e2b-ab90-69f43e8e5928"), "Erma" },
                    { new Guid("7e7c5ca2-5bf5-49d1-ad8e-9cc754d1ef54"), new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Terence" },
                    { new Guid("85e492c1-c047-4d5b-93e1-ef99080a9678"), new Guid("da1a37f1-8e7b-4864-b83c-0c1df42c4f80"), "Marvin" },
                    { new Guid("909abbec-1fe0-4cf3-ae94-a1c44b9753bd"), new Guid("731d1963-a780-4942-ac97-50dc5fd2a8d6"), "Eduardo" },
                    { new Guid("9849e376-36ee-4b41-84c1-a5ed1d2efe84"), new Guid("731d1963-a780-4942-ac97-50dc5fd2a8d6"), "Damon" },
                    { new Guid("a510d03c-0795-436e-845c-edf77756ddfe"), new Guid("7f142e14-2fb1-4e88-bf7c-29c9d33faf60"), "Roosevelt" },
                    { new Guid("af29b6d9-6a7d-4896-8082-eef07f299e9d"), new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Isaac" },
                    { new Guid("b197c712-a24f-4276-b1de-c26d44a7bc50"), new Guid("0028f547-7246-422b-a461-4e44e3020f17"), "Sandra" },
                    { new Guid("b61a5c34-4266-41b7-a15b-46b38792d66b"), new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"), "Wilbert" },
                    { new Guid("cc8a7039-769c-4eff-a697-bd7a43f38104"), new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Jerry" },
                    { new Guid("cdfad3fe-d2fe-4300-b332-468573df5459"), new Guid("b6132b34-f470-49cf-92c4-463cbc3f54e0"), "Gwendolyn" },
                    { new Guid("d66579a4-399e-41dd-9d9c-28c2422b7578"), new Guid("0028f547-7246-422b-a461-4e44e3020f17"), "Beth" },
                    { new Guid("dacc5574-24dd-41bf-8e70-d6830cd8c59b"), new Guid("db630dc7-9e11-44a4-9c7b-3be040c8dfe1"), "Sandy" },
                    { new Guid("eb379f4b-8dee-4a19-843c-c51589bb5e40"), new Guid("0028f547-7246-422b-a461-4e44e3020f17"), "Lamar" },
                    { new Guid("f07c7d60-d715-4cf9-9c24-778069d38320"), new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"), "Wendell" },
                    { new Guid("f2c0dea3-ee95-4d30-8f32-9f5c580d21fe"), new Guid("15896574-6ca5-4ff6-8851-1bbb309a226f"), "Joe" },
                    { new Guid("f5024a5e-e9cd-40a9-ac58-8b88ddba76f1"), new Guid("b6132b34-f470-49cf-92c4-463cbc3f54e0"), "Bridget" },
                    { new Guid("fb5b6742-a0a2-4d75-855d-594589c2afdb"), new Guid("5ca86934-de29-42cc-a77f-f57636a6a968"), "Mitchell" },
                    { new Guid("fbb649c4-ffab-41f0-b9dd-8dd8b5d71573"), new Guid("0abcfd04-e9e8-47d0-a5ac-2e4ea829158a"), "Juan" }
                });
        }
    }
}
