﻿// <auto-generated />
using System;
using Hospital.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.DAL.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20230609120250_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerformanceRate")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ceb4582-c5c4-473f-b532-ba3227c4e898"),
                            Name = "Jessie",
                            PerformanceRate = 65,
                            Salary = 27064m,
                            Specialization = "Hematology"
                        },
                        new
                        {
                            Id = new Guid("ec40c7f3-8034-479e-85fb-28580dbb2301"),
                            Name = "Judy",
                            PerformanceRate = 32,
                            Salary = 18711m,
                            Specialization = "Neurology"
                        },
                        new
                        {
                            Id = new Guid("d121254e-9338-48f4-a8ce-600b5c0187b8"),
                            Name = "Naomi",
                            PerformanceRate = 27,
                            Salary = 32145m,
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = new Guid("cb2a9eba-3404-4fa5-bd58-3299e082cb90"),
                            Name = "Joann",
                            PerformanceRate = 72,
                            Salary = 9232m,
                            Specialization = "Hematology"
                        },
                        new
                        {
                            Id = new Guid("e826721f-1642-44af-b18b-ef118d21b3af"),
                            Name = "Judy",
                            PerformanceRate = 19,
                            Salary = 48498m,
                            Specialization = "Dermatology"
                        },
                        new
                        {
                            Id = new Guid("dbc45914-fbbe-469e-b9bb-e8eaba9c8712"),
                            Name = "Alyssa",
                            PerformanceRate = 79,
                            Salary = 16586m,
                            Specialization = "Gastroenterology"
                        },
                        new
                        {
                            Id = new Guid("2153cf83-7334-4117-8b54-67f565a59f3e"),
                            Name = "Mable",
                            PerformanceRate = 5,
                            Salary = 33706m,
                            Specialization = "Infectious Disease"
                        },
                        new
                        {
                            Id = new Guid("27047528-db32-4434-8623-8a39ee529266"),
                            Name = "Paula",
                            PerformanceRate = 0,
                            Salary = 19094m,
                            Specialization = "Urology"
                        },
                        new
                        {
                            Id = new Guid("98cf3198-8d0a-4053-adb4-83fe225f8905"),
                            Name = "Rafael",
                            PerformanceRate = 97,
                            Salary = 12266m,
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = new Guid("0d7f9e4d-406f-4f31-9a23-cf43ecc55100"),
                            Name = "Sara",
                            PerformanceRate = 82,
                            Salary = 45041m,
                            Specialization = "Pediatrics"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
