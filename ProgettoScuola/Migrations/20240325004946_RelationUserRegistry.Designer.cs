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
    [Migration("20240325004946_RelationUserRegistry")]
    partial class RelationUserRegistry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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
                });

            modelBuilder.Entity("ProgettoScuola.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password")
                        .HasAnnotation("Relational:JsonPropertyName", "password");

                    b.Property<Guid>("RegistryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username")
                        .HasAnnotation("Relational:JsonPropertyName", "username");

                    b.HasKey("Id");

                    b.HasIndex("RegistryId")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("ProgettoScuola.Models.User", b =>
                {
                    b.HasOne("ProgettoScuola.Models.Registry", "Registry")
                        .WithOne("User")
                        .HasForeignKey("ProgettoScuola.Models.User", "RegistryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registry");
                });

            modelBuilder.Entity("ProgettoScuola.Models.Registry", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}