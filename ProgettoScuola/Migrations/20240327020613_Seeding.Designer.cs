﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ProgettoScuola.Models;

#nullable disable

namespace ProgettoScuola.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20240327020613_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ProgettoScuola.Models.Parent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("RegistryId")
                        .HasColumnType("uuid")
                        .HasColumnName("registry_id");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid")
                        .HasColumnName("student_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RegistryId")
                        .IsUnique();

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("parents");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3123746c-96e0-41eb-81db-3db1d7675e25"),
                            RegistryId = new Guid("d2281823-3312-4870-891d-c34bb697e6d9"),
                            StudentId = new Guid("a13e756c-1e61-416f-ba54-71c2d22b0d0f"),
                            UserId = new Guid("b6a7e520-235a-41b3-b13b-70dbd59e6440")
                        },
                        new
                        {
                            Id = new Guid("6c3e54ef-b31a-4076-9c46-83a8e563b3ac"),
                            RegistryId = new Guid("f03bb687-b842-4c26-928d-cefdf5992d9c"),
                            StudentId = new Guid("5b887284-91c2-4411-a5fb-33284528e4cb"),
                            UserId = new Guid("b733e166-4d61-4686-b559-96232a6d9b87")
                        },
                        new
                        {
                            Id = new Guid("15728b0c-cd21-4a66-875a-45a59a18f680"),
                            RegistryId = new Guid("3d9caef5-6e98-4360-a815-e7dbcae6f8a5"),
                            StudentId = new Guid("87cb155e-3b84-4cf8-bbe6-0e9d356558e9"),
                            UserId = new Guid("f6fac0e5-cec8-4427-8ea9-254049cfc2c4")
                        },
                        new
                        {
                            Id = new Guid("976a3965-057f-48c5-8435-7e739cebce99"),
                            RegistryId = new Guid("8f868cc0-acf2-4318-966e-a50796f11c2d"),
                            StudentId = new Guid("859515f8-2ec5-4dde-93f4-471faf579ed9"),
                            UserId = new Guid("d7a64a17-d1ed-43ab-9179-9518f5f06f26")
                        },
                        new
                        {
                            Id = new Guid("f18cbd8a-73c2-45d8-bece-d36d2a014f76"),
                            RegistryId = new Guid("1d128a01-414f-4811-b4e4-7d7d2df6f9e0"),
                            StudentId = new Guid("fccae2de-2533-4948-8460-fdc2d4197255"),
                            UserId = new Guid("54d04938-587a-4615-a25d-2331e8733da0")
                        },
                        new
                        {
                            Id = new Guid("9888d83f-0228-411f-bf09-1962ccbee611"),
                            RegistryId = new Guid("a4c7a779-e1ce-46bd-b333-e897ea059412"),
                            StudentId = new Guid("4b0e6069-cb57-44ec-827e-a43c83a1445a"),
                            UserId = new Guid("5895d2d2-56af-4bb0-aa65-8255a4989a76")
                        },
                        new
                        {
                            Id = new Guid("08431d20-e217-4ab9-8b7f-7faeab08bdb8"),
                            RegistryId = new Guid("b84dad7e-ddd7-4850-b658-d5e8331a69ab"),
                            StudentId = new Guid("76f47fd6-7138-4184-9d79-6b4e74b91ad7"),
                            UserId = new Guid("971a7640-4942-4f3a-845a-8c8aa5953b35")
                        },
                        new
                        {
                            Id = new Guid("5ffc1f91-360d-42af-bca5-8a3ea9ec1ccb"),
                            RegistryId = new Guid("5263ddc9-e212-41e9-857a-dd6cd8b00209"),
                            StudentId = new Guid("d5d10f4d-31e2-47ee-ac40-67ca99162834"),
                            UserId = new Guid("835e7d5b-c1c5-4095-a730-be1e33ba6022")
                        },
                        new
                        {
                            Id = new Guid("d5ff2647-372a-4e4d-ae4b-f7210c062d6a"),
                            RegistryId = new Guid("aa7fcd00-e05b-421e-b1fb-1ddbbad2e2a4"),
                            StudentId = new Guid("e9c49f04-ba48-4658-bfb4-453c439a0ae0"),
                            UserId = new Guid("cb101a90-09e8-4dbd-83a9-552910aa2e33")
                        },
                        new
                        {
                            Id = new Guid("f0b1ccd1-7b1f-4d9f-955a-b013cdfb5843"),
                            RegistryId = new Guid("c7869d7e-132a-4d63-abed-f1bfc6bcda17"),
                            StudentId = new Guid("cabb9305-f83f-4ac7-bf6e-85c836409746"),
                            UserId = new Guid("7531471f-5a47-4edc-adaf-ccd57e06a85f")
                        });
                });

            modelBuilder.Entity("ProgettoScuola.Models.Registry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateOnly?>("Birth")
                        .HasColumnType("date")
                        .HasColumnName("birth")
                        .HasAnnotation("Relational:JsonPropertyName", "birth");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email")
                        .HasAnnotation("Relational:JsonPropertyName", "email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender")
                        .HasAnnotation("Relational:JsonPropertyName", "gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname")
                        .HasAnnotation("Relational:JsonPropertyName", "surname");

                    b.Property<string>("Telephone")
                        .HasColumnType("text")
                        .HasColumnName("telephone")
                        .HasAnnotation("Relational:JsonPropertyName", "telephone");

                    b.HasKey("Id");

                    b.ToTable("registries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("804ab104-65c2-4b52-9d81-fcb78d4dd6bf"),
                            Address = "IndirizzoStudente1",
                            Birth = new DateOnly(2000, 1, 1),
                            Email = "emailstudente1@example.com",
                            Gender = "M",
                            Name = "NomeStudente1",
                            Surname = "CognomeStudente1",
                            Telephone = "+39 123 456 7810"
                        },
                        new
                        {
                            Id = new Guid("d2281823-3312-4870-891d-c34bb697e6d9"),
                            Address = "IndirizzoGenitore1",
                            Birth = new DateOnly(1970, 1, 1),
                            Email = "emailgenitore1@example.com",
                            Gender = "M",
                            Name = "NomeGenitore1",
                            Surname = "CognomeGenitore1",
                            Telephone = "+39 123 456 7810"
                        },
                        new
                        {
                            Id = new Guid("ab3a5bb6-b0d5-42c1-945f-b4b798f7e460"),
                            Address = "IndirizzoStudente2",
                            Birth = new DateOnly(2001, 2, 2),
                            Email = "emailstudente2@example.com",
                            Gender = "F",
                            Name = "NomeStudente2",
                            Surname = "CognomeStudente2",
                            Telephone = "+39 123 456 7820"
                        },
                        new
                        {
                            Id = new Guid("f03bb687-b842-4c26-928d-cefdf5992d9c"),
                            Address = "IndirizzoGenitore2",
                            Birth = new DateOnly(1971, 2, 2),
                            Email = "emailgenitore2@example.com",
                            Gender = "F",
                            Name = "NomeGenitore2",
                            Surname = "CognomeGenitore2",
                            Telephone = "+39 123 456 7820"
                        },
                        new
                        {
                            Id = new Guid("e7c23394-fcfb-4403-aeef-8970adb62235"),
                            Address = "IndirizzoStudente3",
                            Birth = new DateOnly(2002, 3, 3),
                            Email = "emailstudente3@example.com",
                            Gender = "M",
                            Name = "NomeStudente3",
                            Surname = "CognomeStudente3",
                            Telephone = "+39 123 456 7830"
                        },
                        new
                        {
                            Id = new Guid("3d9caef5-6e98-4360-a815-e7dbcae6f8a5"),
                            Address = "IndirizzoGenitore3",
                            Birth = new DateOnly(1972, 3, 3),
                            Email = "emailgenitore3@example.com",
                            Gender = "M",
                            Name = "NomeGenitore3",
                            Surname = "CognomeGenitore3",
                            Telephone = "+39 123 456 7830"
                        },
                        new
                        {
                            Id = new Guid("a7cd10f7-d021-486d-a260-7dc06e10b698"),
                            Address = "IndirizzoStudente4",
                            Birth = new DateOnly(2003, 4, 4),
                            Email = "emailstudente4@example.com",
                            Gender = "F",
                            Name = "NomeStudente4",
                            Surname = "CognomeStudente4",
                            Telephone = "+39 123 456 7840"
                        },
                        new
                        {
                            Id = new Guid("8f868cc0-acf2-4318-966e-a50796f11c2d"),
                            Address = "IndirizzoGenitore4",
                            Birth = new DateOnly(1973, 4, 4),
                            Email = "emailgenitore4@example.com",
                            Gender = "F",
                            Name = "NomeGenitore4",
                            Surname = "CognomeGenitore4",
                            Telephone = "+39 123 456 7840"
                        },
                        new
                        {
                            Id = new Guid("8b17b443-2f58-4563-82b4-7f0d6df80d4a"),
                            Address = "IndirizzoStudente5",
                            Birth = new DateOnly(2004, 5, 5),
                            Email = "emailstudente5@example.com",
                            Gender = "M",
                            Name = "NomeStudente5",
                            Surname = "CognomeStudente5",
                            Telephone = "+39 123 456 7850"
                        },
                        new
                        {
                            Id = new Guid("1d128a01-414f-4811-b4e4-7d7d2df6f9e0"),
                            Address = "IndirizzoGenitore5",
                            Birth = new DateOnly(1974, 5, 5),
                            Email = "emailgenitore5@example.com",
                            Gender = "M",
                            Name = "NomeGenitore5",
                            Surname = "CognomeGenitore5",
                            Telephone = "+39 123 456 7850"
                        },
                        new
                        {
                            Id = new Guid("1e036c51-7070-4db8-90a5-0264503e364b"),
                            Address = "IndirizzoStudente6",
                            Birth = new DateOnly(2005, 6, 6),
                            Email = "emailstudente6@example.com",
                            Gender = "F",
                            Name = "NomeStudente6",
                            Surname = "CognomeStudente6",
                            Telephone = "+39 123 456 7860"
                        },
                        new
                        {
                            Id = new Guid("a4c7a779-e1ce-46bd-b333-e897ea059412"),
                            Address = "IndirizzoGenitore6",
                            Birth = new DateOnly(1975, 6, 6),
                            Email = "emailgenitore6@example.com",
                            Gender = "F",
                            Name = "NomeGenitore6",
                            Surname = "CognomeGenitore6",
                            Telephone = "+39 123 456 7860"
                        },
                        new
                        {
                            Id = new Guid("ef1069b8-63cc-4d38-ada3-14ada8f24f7d"),
                            Address = "IndirizzoStudente7",
                            Birth = new DateOnly(2006, 7, 7),
                            Email = "emailstudente7@example.com",
                            Gender = "M",
                            Name = "NomeStudente7",
                            Surname = "CognomeStudente7",
                            Telephone = "+39 123 456 7870"
                        },
                        new
                        {
                            Id = new Guid("b84dad7e-ddd7-4850-b658-d5e8331a69ab"),
                            Address = "IndirizzoGenitore7",
                            Birth = new DateOnly(1976, 7, 7),
                            Email = "emailgenitore7@example.com",
                            Gender = "M",
                            Name = "NomeGenitore7",
                            Surname = "CognomeGenitore7",
                            Telephone = "+39 123 456 7870"
                        },
                        new
                        {
                            Id = new Guid("0e110c09-4108-476a-957e-dfe5571c758a"),
                            Address = "IndirizzoStudente8",
                            Birth = new DateOnly(2007, 8, 8),
                            Email = "emailstudente8@example.com",
                            Gender = "F",
                            Name = "NomeStudente8",
                            Surname = "CognomeStudente8",
                            Telephone = "+39 123 456 7880"
                        },
                        new
                        {
                            Id = new Guid("5263ddc9-e212-41e9-857a-dd6cd8b00209"),
                            Address = "IndirizzoGenitore8",
                            Birth = new DateOnly(1977, 8, 8),
                            Email = "emailgenitore8@example.com",
                            Gender = "F",
                            Name = "NomeGenitore8",
                            Surname = "CognomeGenitore8",
                            Telephone = "+39 123 456 7880"
                        },
                        new
                        {
                            Id = new Guid("13749c04-480e-4334-ac4c-b4028e58c1db"),
                            Address = "IndirizzoStudente9",
                            Birth = new DateOnly(2008, 9, 9),
                            Email = "emailstudente9@example.com",
                            Gender = "M",
                            Name = "NomeStudente9",
                            Surname = "CognomeStudente9",
                            Telephone = "+39 123 456 7890"
                        },
                        new
                        {
                            Id = new Guid("aa7fcd00-e05b-421e-b1fb-1ddbbad2e2a4"),
                            Address = "IndirizzoGenitore9",
                            Birth = new DateOnly(1978, 9, 9),
                            Email = "emailgenitore9@example.com",
                            Gender = "M",
                            Name = "NomeGenitore9",
                            Surname = "CognomeGenitore9",
                            Telephone = "+39 123 456 7890"
                        },
                        new
                        {
                            Id = new Guid("565de3bc-c9ef-447d-944d-0345974460fb"),
                            Address = "IndirizzoStudente10",
                            Birth = new DateOnly(2009, 10, 10),
                            Email = "emailstudente10@example.com",
                            Gender = "F",
                            Name = "NomeStudente10",
                            Surname = "CognomeStudente10",
                            Telephone = "+39 123 456 78100"
                        },
                        new
                        {
                            Id = new Guid("c7869d7e-132a-4d63-abed-f1bfc6bcda17"),
                            Address = "IndirizzoGenitore10",
                            Birth = new DateOnly(1979, 10, 10),
                            Email = "emailgenitore10@example.com",
                            Gender = "F",
                            Name = "NomeGenitore10",
                            Surname = "CognomeGenitore10",
                            Telephone = "+39 123 456 78100"
                        });
                });

            modelBuilder.Entity("ProgettoScuola.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Classe")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("classe");

                    b.Property<Guid>("RegistryId")
                        .HasColumnType("uuid")
                        .HasColumnName("registry_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("RegistryId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a13e756c-1e61-416f-ba54-71c2d22b0d0f"),
                            Classe = "Classe1",
                            RegistryId = new Guid("804ab104-65c2-4b52-9d81-fcb78d4dd6bf"),
                            UserId = new Guid("e8597a65-7367-41e6-a713-cd945fca4233")
                        },
                        new
                        {
                            Id = new Guid("5b887284-91c2-4411-a5fb-33284528e4cb"),
                            Classe = "Classe2",
                            RegistryId = new Guid("ab3a5bb6-b0d5-42c1-945f-b4b798f7e460"),
                            UserId = new Guid("088364d2-ac4e-41ea-87c9-c223a9beb0c9")
                        },
                        new
                        {
                            Id = new Guid("87cb155e-3b84-4cf8-bbe6-0e9d356558e9"),
                            Classe = "Classe3",
                            RegistryId = new Guid("e7c23394-fcfb-4403-aeef-8970adb62235"),
                            UserId = new Guid("ad027329-c7e4-4e21-b03c-583bfb3f4ca8")
                        },
                        new
                        {
                            Id = new Guid("859515f8-2ec5-4dde-93f4-471faf579ed9"),
                            Classe = "Classe4",
                            RegistryId = new Guid("a7cd10f7-d021-486d-a260-7dc06e10b698"),
                            UserId = new Guid("6c74a473-c6cd-4518-a922-df043a32ef9d")
                        },
                        new
                        {
                            Id = new Guid("fccae2de-2533-4948-8460-fdc2d4197255"),
                            Classe = "Classe5",
                            RegistryId = new Guid("8b17b443-2f58-4563-82b4-7f0d6df80d4a"),
                            UserId = new Guid("e250945b-a260-4840-9e3a-315d9da90dba")
                        },
                        new
                        {
                            Id = new Guid("4b0e6069-cb57-44ec-827e-a43c83a1445a"),
                            Classe = "Classe6",
                            RegistryId = new Guid("1e036c51-7070-4db8-90a5-0264503e364b"),
                            UserId = new Guid("932eae4c-a940-4c16-a3fe-b2a4387525f8")
                        },
                        new
                        {
                            Id = new Guid("76f47fd6-7138-4184-9d79-6b4e74b91ad7"),
                            Classe = "Classe7",
                            RegistryId = new Guid("ef1069b8-63cc-4d38-ada3-14ada8f24f7d"),
                            UserId = new Guid("166ef427-2cc3-424e-8fc4-fec8d18a5dcf")
                        },
                        new
                        {
                            Id = new Guid("d5d10f4d-31e2-47ee-ac40-67ca99162834"),
                            Classe = "Classe8",
                            RegistryId = new Guid("0e110c09-4108-476a-957e-dfe5571c758a"),
                            UserId = new Guid("181c3b22-67d3-4f93-862f-5850137ff2c2")
                        },
                        new
                        {
                            Id = new Guid("e9c49f04-ba48-4658-bfb4-453c439a0ae0"),
                            Classe = "Classe9",
                            RegistryId = new Guid("13749c04-480e-4334-ac4c-b4028e58c1db"),
                            UserId = new Guid("0c1d691a-08cb-42f4-b4ef-02a4fe40353b")
                        },
                        new
                        {
                            Id = new Guid("cabb9305-f83f-4ac7-bf6e-85c836409746"),
                            Classe = "Classe10",
                            RegistryId = new Guid("565de3bc-c9ef-447d-944d-0345974460fb"),
                            UserId = new Guid("fea415a9-c8c7-4a6c-a0e5-d63f1659057f")
                        });
                });

            modelBuilder.Entity("ProgettoScuola.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e8597a65-7367-41e6-a713-cd945fca4233"),
                            Password = "Password1",
                            Username = "StudentUser1"
                        },
                        new
                        {
                            Id = new Guid("b6a7e520-235a-41b3-b13b-70dbd59e6440"),
                            Password = "Password1",
                            Username = "ParentUser1"
                        },
                        new
                        {
                            Id = new Guid("088364d2-ac4e-41ea-87c9-c223a9beb0c9"),
                            Password = "Password2",
                            Username = "StudentUser2"
                        },
                        new
                        {
                            Id = new Guid("b733e166-4d61-4686-b559-96232a6d9b87"),
                            Password = "Password2",
                            Username = "ParentUser2"
                        },
                        new
                        {
                            Id = new Guid("ad027329-c7e4-4e21-b03c-583bfb3f4ca8"),
                            Password = "Password3",
                            Username = "StudentUser3"
                        },
                        new
                        {
                            Id = new Guid("f6fac0e5-cec8-4427-8ea9-254049cfc2c4"),
                            Password = "Password3",
                            Username = "ParentUser3"
                        },
                        new
                        {
                            Id = new Guid("6c74a473-c6cd-4518-a922-df043a32ef9d"),
                            Password = "Password4",
                            Username = "StudentUser4"
                        },
                        new
                        {
                            Id = new Guid("d7a64a17-d1ed-43ab-9179-9518f5f06f26"),
                            Password = "Password4",
                            Username = "ParentUser4"
                        },
                        new
                        {
                            Id = new Guid("e250945b-a260-4840-9e3a-315d9da90dba"),
                            Password = "Password5",
                            Username = "StudentUser5"
                        },
                        new
                        {
                            Id = new Guid("54d04938-587a-4615-a25d-2331e8733da0"),
                            Password = "Password5",
                            Username = "ParentUser5"
                        },
                        new
                        {
                            Id = new Guid("932eae4c-a940-4c16-a3fe-b2a4387525f8"),
                            Password = "Password6",
                            Username = "StudentUser6"
                        },
                        new
                        {
                            Id = new Guid("5895d2d2-56af-4bb0-aa65-8255a4989a76"),
                            Password = "Password6",
                            Username = "ParentUser6"
                        },
                        new
                        {
                            Id = new Guid("166ef427-2cc3-424e-8fc4-fec8d18a5dcf"),
                            Password = "Password7",
                            Username = "StudentUser7"
                        },
                        new
                        {
                            Id = new Guid("971a7640-4942-4f3a-845a-8c8aa5953b35"),
                            Password = "Password7",
                            Username = "ParentUser7"
                        },
                        new
                        {
                            Id = new Guid("181c3b22-67d3-4f93-862f-5850137ff2c2"),
                            Password = "Password8",
                            Username = "StudentUser8"
                        },
                        new
                        {
                            Id = new Guid("835e7d5b-c1c5-4095-a730-be1e33ba6022"),
                            Password = "Password8",
                            Username = "ParentUser8"
                        },
                        new
                        {
                            Id = new Guid("0c1d691a-08cb-42f4-b4ef-02a4fe40353b"),
                            Password = "Password9",
                            Username = "StudentUser9"
                        },
                        new
                        {
                            Id = new Guid("cb101a90-09e8-4dbd-83a9-552910aa2e33"),
                            Password = "Password9",
                            Username = "ParentUser9"
                        },
                        new
                        {
                            Id = new Guid("fea415a9-c8c7-4a6c-a0e5-d63f1659057f"),
                            Password = "Password10",
                            Username = "StudentUser10"
                        },
                        new
                        {
                            Id = new Guid("7531471f-5a47-4edc-adaf-ccd57e06a85f"),
                            Password = "Password10",
                            Username = "ParentUser10"
                        });
                });

            modelBuilder.Entity("ProgettoScuola.Models.Parent", b =>
                {
                    b.HasOne("ProgettoScuola.Models.Registry", "Registry")
                        .WithOne("Parent")
                        .HasForeignKey("ProgettoScuola.Models.Parent", "RegistryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgettoScuola.Models.Student", "Student")
                        .WithOne("Parent")
                        .HasForeignKey("ProgettoScuola.Models.Parent", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgettoScuola.Models.User", "User")
                        .WithOne("Parent")
                        .HasForeignKey("ProgettoScuola.Models.Parent", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registry");

                    b.Navigation("Student");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProgettoScuola.Models.Student", b =>
                {
                    b.HasOne("ProgettoScuola.Models.Registry", "Registry")
                        .WithOne("Student")
                        .HasForeignKey("ProgettoScuola.Models.Student", "RegistryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgettoScuola.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("ProgettoScuola.Models.Student", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProgettoScuola.Models.Registry", b =>
                {
                    b.Navigation("Parent");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ProgettoScuola.Models.Student", b =>
                {
                    b.Navigation("Parent");
                });

            modelBuilder.Entity("ProgettoScuola.Models.User", b =>
                {
                    b.Navigation("Parent");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
