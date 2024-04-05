using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProgettoScuola.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "registries",
                columns: new[] { "id", "address", "birth", "email", "gender", "name", "surname", "telephone" },
                values: new object[,]
                {
                    { new Guid("0e110c09-4108-476a-957e-dfe5571c758a"), "IndirizzoStudente8", new DateOnly(2007, 8, 8), "emailstudente8@example.com", "F", "NomeStudente8", "CognomeStudente8", "+39 123 456 7880" },
                    { new Guid("13749c04-480e-4334-ac4c-b4028e58c1db"), "IndirizzoStudente9", new DateOnly(2008, 9, 9), "emailstudente9@example.com", "M", "NomeStudente9", "CognomeStudente9", "+39 123 456 7890" },
                    { new Guid("1d128a01-414f-4811-b4e4-7d7d2df6f9e0"), "IndirizzoGenitore5", new DateOnly(1974, 5, 5), "emailgenitore5@example.com", "M", "NomeGenitore5", "CognomeGenitore5", "+39 123 456 7850" },
                    { new Guid("1e036c51-7070-4db8-90a5-0264503e364b"), "IndirizzoStudente6", new DateOnly(2005, 6, 6), "emailstudente6@example.com", "F", "NomeStudente6", "CognomeStudente6", "+39 123 456 7860" },
                    { new Guid("3d9caef5-6e98-4360-a815-e7dbcae6f8a5"), "IndirizzoGenitore3", new DateOnly(1972, 3, 3), "emailgenitore3@example.com", "M", "NomeGenitore3", "CognomeGenitore3", "+39 123 456 7830" },
                    { new Guid("5263ddc9-e212-41e9-857a-dd6cd8b00209"), "IndirizzoGenitore8", new DateOnly(1977, 8, 8), "emailgenitore8@example.com", "F", "NomeGenitore8", "CognomeGenitore8", "+39 123 456 7880" },
                    { new Guid("565de3bc-c9ef-447d-944d-0345974460fb"), "IndirizzoStudente10", new DateOnly(2009, 10, 10), "emailstudente10@example.com", "F", "NomeStudente10", "CognomeStudente10", "+39 123 456 78100" },
                    { new Guid("804ab104-65c2-4b52-9d81-fcb78d4dd6bf"), "IndirizzoStudente1", new DateOnly(2000, 1, 1), "emailstudente1@example.com", "M", "NomeStudente1", "CognomeStudente1", "+39 123 456 7810" },
                    { new Guid("8b17b443-2f58-4563-82b4-7f0d6df80d4a"), "IndirizzoStudente5", new DateOnly(2004, 5, 5), "emailstudente5@example.com", "M", "NomeStudente5", "CognomeStudente5", "+39 123 456 7850" },
                    { new Guid("8f868cc0-acf2-4318-966e-a50796f11c2d"), "IndirizzoGenitore4", new DateOnly(1973, 4, 4), "emailgenitore4@example.com", "F", "NomeGenitore4", "CognomeGenitore4", "+39 123 456 7840" },
                    { new Guid("a4c7a779-e1ce-46bd-b333-e897ea059412"), "IndirizzoGenitore6", new DateOnly(1975, 6, 6), "emailgenitore6@example.com", "F", "NomeGenitore6", "CognomeGenitore6", "+39 123 456 7860" },
                    { new Guid("a7cd10f7-d021-486d-a260-7dc06e10b698"), "IndirizzoStudente4", new DateOnly(2003, 4, 4), "emailstudente4@example.com", "F", "NomeStudente4", "CognomeStudente4", "+39 123 456 7840" },
                    { new Guid("aa7fcd00-e05b-421e-b1fb-1ddbbad2e2a4"), "IndirizzoGenitore9", new DateOnly(1978, 9, 9), "emailgenitore9@example.com", "M", "NomeGenitore9", "CognomeGenitore9", "+39 123 456 7890" },
                    { new Guid("ab3a5bb6-b0d5-42c1-945f-b4b798f7e460"), "IndirizzoStudente2", new DateOnly(2001, 2, 2), "emailstudente2@example.com", "F", "NomeStudente2", "CognomeStudente2", "+39 123 456 7820" },
                    { new Guid("b84dad7e-ddd7-4850-b658-d5e8331a69ab"), "IndirizzoGenitore7", new DateOnly(1976, 7, 7), "emailgenitore7@example.com", "M", "NomeGenitore7", "CognomeGenitore7", "+39 123 456 7870" },
                    { new Guid("c7869d7e-132a-4d63-abed-f1bfc6bcda17"), "IndirizzoGenitore10", new DateOnly(1979, 10, 10), "emailgenitore10@example.com", "F", "NomeGenitore10", "CognomeGenitore10", "+39 123 456 78100" },
                    { new Guid("d2281823-3312-4870-891d-c34bb697e6d9"), "IndirizzoGenitore1", new DateOnly(1970, 1, 1), "emailgenitore1@example.com", "M", "NomeGenitore1", "CognomeGenitore1", "+39 123 456 7810" },
                    { new Guid("e7c23394-fcfb-4403-aeef-8970adb62235"), "IndirizzoStudente3", new DateOnly(2002, 3, 3), "emailstudente3@example.com", "M", "NomeStudente3", "CognomeStudente3", "+39 123 456 7830" },
                    { new Guid("ef1069b8-63cc-4d38-ada3-14ada8f24f7d"), "IndirizzoStudente7", new DateOnly(2006, 7, 7), "emailstudente7@example.com", "M", "NomeStudente7", "CognomeStudente7", "+39 123 456 7870" },
                    { new Guid("f03bb687-b842-4c26-928d-cefdf5992d9c"), "IndirizzoGenitore2", new DateOnly(1971, 2, 2), "emailgenitore2@example.com", "F", "NomeGenitore2", "CognomeGenitore2", "+39 123 456 7820" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "password", "username" },
                values: new object[,]
                {
                    { new Guid("088364d2-ac4e-41ea-87c9-c223a9beb0c9"), "Password2", "StudentUser2" },
                    { new Guid("0c1d691a-08cb-42f4-b4ef-02a4fe40353b"), "Password9", "StudentUser9" },
                    { new Guid("166ef427-2cc3-424e-8fc4-fec8d18a5dcf"), "Password7", "StudentUser7" },
                    { new Guid("181c3b22-67d3-4f93-862f-5850137ff2c2"), "Password8", "StudentUser8" },
                    { new Guid("54d04938-587a-4615-a25d-2331e8733da0"), "Password5", "ParentUser5" },
                    { new Guid("5895d2d2-56af-4bb0-aa65-8255a4989a76"), "Password6", "ParentUser6" },
                    { new Guid("6c74a473-c6cd-4518-a922-df043a32ef9d"), "Password4", "StudentUser4" },
                    { new Guid("7531471f-5a47-4edc-adaf-ccd57e06a85f"), "Password10", "ParentUser10" },
                    { new Guid("835e7d5b-c1c5-4095-a730-be1e33ba6022"), "Password8", "ParentUser8" },
                    { new Guid("932eae4c-a940-4c16-a3fe-b2a4387525f8"), "Password6", "StudentUser6" },
                    { new Guid("971a7640-4942-4f3a-845a-8c8aa5953b35"), "Password7", "ParentUser7" },
                    { new Guid("ad027329-c7e4-4e21-b03c-583bfb3f4ca8"), "Password3", "StudentUser3" },
                    { new Guid("b6a7e520-235a-41b3-b13b-70dbd59e6440"), "Password1", "ParentUser1" },
                    { new Guid("b733e166-4d61-4686-b559-96232a6d9b87"), "Password2", "ParentUser2" },
                    { new Guid("cb101a90-09e8-4dbd-83a9-552910aa2e33"), "Password9", "ParentUser9" },
                    { new Guid("d7a64a17-d1ed-43ab-9179-9518f5f06f26"), "Password4", "ParentUser4" },
                    { new Guid("e250945b-a260-4840-9e3a-315d9da90dba"), "Password5", "StudentUser5" },
                    { new Guid("e8597a65-7367-41e6-a713-cd945fca4233"), "Password1", "StudentUser1" },
                    { new Guid("f6fac0e5-cec8-4427-8ea9-254049cfc2c4"), "Password3", "ParentUser3" },
                    { new Guid("fea415a9-c8c7-4a6c-a0e5-d63f1659057f"), "Password10", "StudentUser10" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "classe", "registry_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("4b0e6069-cb57-44ec-827e-a43c83a1445a"), "Classe6", new Guid("1e036c51-7070-4db8-90a5-0264503e364b"), new Guid("932eae4c-a940-4c16-a3fe-b2a4387525f8") },
                    { new Guid("5b887284-91c2-4411-a5fb-33284528e4cb"), "Classe2", new Guid("ab3a5bb6-b0d5-42c1-945f-b4b798f7e460"), new Guid("088364d2-ac4e-41ea-87c9-c223a9beb0c9") },
                    { new Guid("76f47fd6-7138-4184-9d79-6b4e74b91ad7"), "Classe7", new Guid("ef1069b8-63cc-4d38-ada3-14ada8f24f7d"), new Guid("166ef427-2cc3-424e-8fc4-fec8d18a5dcf") },
                    { new Guid("859515f8-2ec5-4dde-93f4-471faf579ed9"), "Classe4", new Guid("a7cd10f7-d021-486d-a260-7dc06e10b698"), new Guid("6c74a473-c6cd-4518-a922-df043a32ef9d") },
                    { new Guid("87cb155e-3b84-4cf8-bbe6-0e9d356558e9"), "Classe3", new Guid("e7c23394-fcfb-4403-aeef-8970adb62235"), new Guid("ad027329-c7e4-4e21-b03c-583bfb3f4ca8") },
                    { new Guid("a13e756c-1e61-416f-ba54-71c2d22b0d0f"), "Classe1", new Guid("804ab104-65c2-4b52-9d81-fcb78d4dd6bf"), new Guid("e8597a65-7367-41e6-a713-cd945fca4233") },
                    { new Guid("cabb9305-f83f-4ac7-bf6e-85c836409746"), "Classe10", new Guid("565de3bc-c9ef-447d-944d-0345974460fb"), new Guid("fea415a9-c8c7-4a6c-a0e5-d63f1659057f") },
                    { new Guid("d5d10f4d-31e2-47ee-ac40-67ca99162834"), "Classe8", new Guid("0e110c09-4108-476a-957e-dfe5571c758a"), new Guid("181c3b22-67d3-4f93-862f-5850137ff2c2") },
                    { new Guid("e9c49f04-ba48-4658-bfb4-453c439a0ae0"), "Classe9", new Guid("13749c04-480e-4334-ac4c-b4028e58c1db"), new Guid("0c1d691a-08cb-42f4-b4ef-02a4fe40353b") },
                    { new Guid("fccae2de-2533-4948-8460-fdc2d4197255"), "Classe5", new Guid("8b17b443-2f58-4563-82b4-7f0d6df80d4a"), new Guid("e250945b-a260-4840-9e3a-315d9da90dba") }
                });

            migrationBuilder.InsertData(
                table: "parents",
                columns: new[] { "id", "registry_id", "student_id", "user_id" },
                values: new object[,]
                {
                    { new Guid("08431d20-e217-4ab9-8b7f-7faeab08bdb8"), new Guid("b84dad7e-ddd7-4850-b658-d5e8331a69ab"), new Guid("76f47fd6-7138-4184-9d79-6b4e74b91ad7"), new Guid("971a7640-4942-4f3a-845a-8c8aa5953b35") },
                    { new Guid("15728b0c-cd21-4a66-875a-45a59a18f680"), new Guid("3d9caef5-6e98-4360-a815-e7dbcae6f8a5"), new Guid("87cb155e-3b84-4cf8-bbe6-0e9d356558e9"), new Guid("f6fac0e5-cec8-4427-8ea9-254049cfc2c4") },
                    { new Guid("3123746c-96e0-41eb-81db-3db1d7675e25"), new Guid("d2281823-3312-4870-891d-c34bb697e6d9"), new Guid("a13e756c-1e61-416f-ba54-71c2d22b0d0f"), new Guid("b6a7e520-235a-41b3-b13b-70dbd59e6440") },
                    { new Guid("5ffc1f91-360d-42af-bca5-8a3ea9ec1ccb"), new Guid("5263ddc9-e212-41e9-857a-dd6cd8b00209"), new Guid("d5d10f4d-31e2-47ee-ac40-67ca99162834"), new Guid("835e7d5b-c1c5-4095-a730-be1e33ba6022") },
                    { new Guid("6c3e54ef-b31a-4076-9c46-83a8e563b3ac"), new Guid("f03bb687-b842-4c26-928d-cefdf5992d9c"), new Guid("5b887284-91c2-4411-a5fb-33284528e4cb"), new Guid("b733e166-4d61-4686-b559-96232a6d9b87") },
                    { new Guid("976a3965-057f-48c5-8435-7e739cebce99"), new Guid("8f868cc0-acf2-4318-966e-a50796f11c2d"), new Guid("859515f8-2ec5-4dde-93f4-471faf579ed9"), new Guid("d7a64a17-d1ed-43ab-9179-9518f5f06f26") },
                    { new Guid("9888d83f-0228-411f-bf09-1962ccbee611"), new Guid("a4c7a779-e1ce-46bd-b333-e897ea059412"), new Guid("4b0e6069-cb57-44ec-827e-a43c83a1445a"), new Guid("5895d2d2-56af-4bb0-aa65-8255a4989a76") },
                    { new Guid("d5ff2647-372a-4e4d-ae4b-f7210c062d6a"), new Guid("aa7fcd00-e05b-421e-b1fb-1ddbbad2e2a4"), new Guid("e9c49f04-ba48-4658-bfb4-453c439a0ae0"), new Guid("cb101a90-09e8-4dbd-83a9-552910aa2e33") },
                    { new Guid("f0b1ccd1-7b1f-4d9f-955a-b013cdfb5843"), new Guid("c7869d7e-132a-4d63-abed-f1bfc6bcda17"), new Guid("cabb9305-f83f-4ac7-bf6e-85c836409746"), new Guid("7531471f-5a47-4edc-adaf-ccd57e06a85f") },
                    { new Guid("f18cbd8a-73c2-45d8-bece-d36d2a014f76"), new Guid("1d128a01-414f-4811-b4e4-7d7d2df6f9e0"), new Guid("fccae2de-2533-4948-8460-fdc2d4197255"), new Guid("54d04938-587a-4615-a25d-2331e8733da0") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("08431d20-e217-4ab9-8b7f-7faeab08bdb8"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("15728b0c-cd21-4a66-875a-45a59a18f680"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("3123746c-96e0-41eb-81db-3db1d7675e25"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("5ffc1f91-360d-42af-bca5-8a3ea9ec1ccb"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("6c3e54ef-b31a-4076-9c46-83a8e563b3ac"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("976a3965-057f-48c5-8435-7e739cebce99"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("9888d83f-0228-411f-bf09-1962ccbee611"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("d5ff2647-372a-4e4d-ae4b-f7210c062d6a"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("f0b1ccd1-7b1f-4d9f-955a-b013cdfb5843"));

            migrationBuilder.DeleteData(
                table: "parents",
                keyColumn: "id",
                keyValue: new Guid("f18cbd8a-73c2-45d8-bece-d36d2a014f76"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("1d128a01-414f-4811-b4e4-7d7d2df6f9e0"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("3d9caef5-6e98-4360-a815-e7dbcae6f8a5"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("5263ddc9-e212-41e9-857a-dd6cd8b00209"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("8f868cc0-acf2-4318-966e-a50796f11c2d"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("a4c7a779-e1ce-46bd-b333-e897ea059412"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("aa7fcd00-e05b-421e-b1fb-1ddbbad2e2a4"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("b84dad7e-ddd7-4850-b658-d5e8331a69ab"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("c7869d7e-132a-4d63-abed-f1bfc6bcda17"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("d2281823-3312-4870-891d-c34bb697e6d9"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("f03bb687-b842-4c26-928d-cefdf5992d9c"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("4b0e6069-cb57-44ec-827e-a43c83a1445a"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("5b887284-91c2-4411-a5fb-33284528e4cb"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("76f47fd6-7138-4184-9d79-6b4e74b91ad7"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("859515f8-2ec5-4dde-93f4-471faf579ed9"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("87cb155e-3b84-4cf8-bbe6-0e9d356558e9"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("a13e756c-1e61-416f-ba54-71c2d22b0d0f"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("cabb9305-f83f-4ac7-bf6e-85c836409746"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("d5d10f4d-31e2-47ee-ac40-67ca99162834"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("e9c49f04-ba48-4658-bfb4-453c439a0ae0"));

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "id",
                keyValue: new Guid("fccae2de-2533-4948-8460-fdc2d4197255"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("54d04938-587a-4615-a25d-2331e8733da0"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("5895d2d2-56af-4bb0-aa65-8255a4989a76"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("7531471f-5a47-4edc-adaf-ccd57e06a85f"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("835e7d5b-c1c5-4095-a730-be1e33ba6022"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("971a7640-4942-4f3a-845a-8c8aa5953b35"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b6a7e520-235a-41b3-b13b-70dbd59e6440"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("b733e166-4d61-4686-b559-96232a6d9b87"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("cb101a90-09e8-4dbd-83a9-552910aa2e33"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("d7a64a17-d1ed-43ab-9179-9518f5f06f26"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("f6fac0e5-cec8-4427-8ea9-254049cfc2c4"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("0e110c09-4108-476a-957e-dfe5571c758a"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("13749c04-480e-4334-ac4c-b4028e58c1db"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("1e036c51-7070-4db8-90a5-0264503e364b"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("565de3bc-c9ef-447d-944d-0345974460fb"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("804ab104-65c2-4b52-9d81-fcb78d4dd6bf"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("8b17b443-2f58-4563-82b4-7f0d6df80d4a"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("a7cd10f7-d021-486d-a260-7dc06e10b698"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("ab3a5bb6-b0d5-42c1-945f-b4b798f7e460"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("e7c23394-fcfb-4403-aeef-8970adb62235"));

            migrationBuilder.DeleteData(
                table: "registries",
                keyColumn: "id",
                keyValue: new Guid("ef1069b8-63cc-4d38-ada3-14ada8f24f7d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("088364d2-ac4e-41ea-87c9-c223a9beb0c9"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("0c1d691a-08cb-42f4-b4ef-02a4fe40353b"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("166ef427-2cc3-424e-8fc4-fec8d18a5dcf"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("181c3b22-67d3-4f93-862f-5850137ff2c2"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("6c74a473-c6cd-4518-a922-df043a32ef9d"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("932eae4c-a940-4c16-a3fe-b2a4387525f8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("ad027329-c7e4-4e21-b03c-583bfb3f4ca8"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e250945b-a260-4840-9e3a-315d9da90dba"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("e8597a65-7367-41e6-a713-cd945fca4233"));

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: new Guid("fea415a9-c8c7-4a6c-a0e5-d63f1659057f"));
        }
    }
}
