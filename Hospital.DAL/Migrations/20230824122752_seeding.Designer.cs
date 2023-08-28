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
    [Migration("20230824122752_seeding")]
    partial class seeding
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
                            Id = new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"),
                            Name = "Jessie",
                            PerformanceRate = 65,
                            Salary = 27064m,
                            Specialization = "Hematology"
                        },
                        new
                        {
                            Id = new Guid("ec310247-7ada-4671-a338-676c98978811"),
                            Name = "Judy",
                            PerformanceRate = 32,
                            Salary = 18711m,
                            Specialization = "Neurology"
                        },
                        new
                        {
                            Id = new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"),
                            Name = "Naomi",
                            PerformanceRate = 27,
                            Salary = 32145m,
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = new Guid("cb92c8fc-ea27-48c8-a585-846989a023a1"),
                            Name = "Joann",
                            PerformanceRate = 72,
                            Salary = 9232m,
                            Specialization = "Hematology"
                        },
                        new
                        {
                            Id = new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"),
                            Name = "Judy",
                            PerformanceRate = 19,
                            Salary = 48498m,
                            Specialization = "Dermatology"
                        },
                        new
                        {
                            Id = new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"),
                            Name = "Alyssa",
                            PerformanceRate = 79,
                            Salary = 16586m,
                            Specialization = "Gastroenterology"
                        },
                        new
                        {
                            Id = new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"),
                            Name = "Mable",
                            PerformanceRate = 5,
                            Salary = 33706m,
                            Specialization = "Infectious Disease"
                        },
                        new
                        {
                            Id = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Paula",
                            PerformanceRate = 0,
                            Salary = 19094m,
                            Specialization = "Urology"
                        },
                        new
                        {
                            Id = new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"),
                            Name = "Rafael",
                            PerformanceRate = 97,
                            Salary = 12266m,
                            Specialization = "Pediatrics"
                        },
                        new
                        {
                            Id = new Guid("90f56224-e706-4972-912f-e2434dc075d1"),
                            Name = "Sara",
                            PerformanceRate = 82,
                            Salary = 45041m,
                            Specialization = "Pediatrics"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Issue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11cab47e-b789-4e23-b3c4-644d5905ee4f"),
                            Name = "Diabetes"
                        },
                        new
                        {
                            Id = new Guid("60cf6ca8-540c-463b-8d45-de51e117cda6"),
                            Name = "Hypertension"
                        },
                        new
                        {
                            Id = new Guid("0cd436c2-329a-4834-9702-f439efd70087"),
                            Name = "Asthma"
                        },
                        new
                        {
                            Id = new Guid("3c2700c0-596b-4bd9-8a31-5cf0b6fba2c4"),
                            Name = "Depression"
                        },
                        new
                        {
                            Id = new Guid("dbed6120-76f4-4db7-9872-ab2b701d081b"),
                            Name = "Arthritis"
                        },
                        new
                        {
                            Id = new Guid("df441c3d-6f7f-439f-abc1-6df992119686"),
                            Name = "Allergy"
                        },
                        new
                        {
                            Id = new Guid("cbc992f4-f99a-44b8-babf-7e9b8d7676ba"),
                            Name = "Flu"
                        });
                });

            modelBuilder.Entity("Hospital.DAL.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = new Guid("318d4dec-5469-4001-8ebb-6bb15f6badc2"),
                            DoctorId = new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"),
                            Name = "Dana"
                        },
                        new
                        {
                            Id = new Guid("a0674918-a95d-46a9-b3b0-1bf7ca5c249b"),
                            DoctorId = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Isaac"
                        },
                        new
                        {
                            Id = new Guid("b9758c54-bbd1-42a6-985b-1c64ed5c25f3"),
                            DoctorId = new Guid("90f56224-e706-4972-912f-e2434dc075d1"),
                            Name = "Damon"
                        },
                        new
                        {
                            Id = new Guid("9cbb9724-956f-4f5f-8890-56ea6cb0dc9e"),
                            DoctorId = new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"),
                            Name = "Miriam"
                        },
                        new
                        {
                            Id = new Guid("4f245803-da22-4f4c-a178-6e5f7ad62575"),
                            DoctorId = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Terence"
                        },
                        new
                        {
                            Id = new Guid("4ea3b834-f85f-4b10-a6d2-aafd48af6fc7"),
                            DoctorId = new Guid("ec310247-7ada-4671-a338-676c98978811"),
                            Name = "Roosevelt"
                        },
                        new
                        {
                            Id = new Guid("a4be96b9-4277-4fd7-8461-648ee2ae449c"),
                            DoctorId = new Guid("90f56224-e706-4972-912f-e2434dc075d1"),
                            Name = "Eduardo"
                        },
                        new
                        {
                            Id = new Guid("d603707b-e891-49ad-ac0e-ddfa9c2f8b7d"),
                            DoctorId = new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"),
                            Name = "Wilbert"
                        },
                        new
                        {
                            Id = new Guid("5f14cd6a-0679-47d2-9684-ee724a19bcca"),
                            DoctorId = new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"),
                            Name = "Tasha"
                        },
                        new
                        {
                            Id = new Guid("7cf3208e-0525-4e35-b36c-9730e7cf3923"),
                            DoctorId = new Guid("ec310247-7ada-4671-a338-676c98978811"),
                            Name = "Max"
                        },
                        new
                        {
                            Id = new Guid("6e249b3b-761e-4cb9-9eba-9e0229624fdf"),
                            DoctorId = new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"),
                            Name = "Bridget"
                        },
                        new
                        {
                            Id = new Guid("4b8908f1-824b-492c-b9c7-d809c56e454f"),
                            DoctorId = new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"),
                            Name = "Juan"
                        },
                        new
                        {
                            Id = new Guid("3488e89e-3e23-4ffc-b9a6-5b3a858e8f16"),
                            DoctorId = new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"),
                            Name = "Krystal"
                        },
                        new
                        {
                            Id = new Guid("544c741e-987d-42a0-90f7-f92f6be6296f"),
                            DoctorId = new Guid("ca56005c-0e2d-4e6a-92b6-51234965d07f"),
                            Name = "Erma"
                        },
                        new
                        {
                            Id = new Guid("692d1108-259e-47f4-a511-cb9f9925cc31"),
                            DoctorId = new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"),
                            Name = "Orlando"
                        },
                        new
                        {
                            Id = new Guid("1cdc8290-c05a-4b72-978c-1bec671c9d8b"),
                            DoctorId = new Guid("6be1da00-e8a0-4eab-bb40-5503f83f6e2d"),
                            Name = "Marvin"
                        },
                        new
                        {
                            Id = new Guid("cb9933df-c787-40f2-84cf-3837ad1c5eaf"),
                            DoctorId = new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"),
                            Name = "Lamar"
                        },
                        new
                        {
                            Id = new Guid("2b330fcb-4f80-4b71-a08c-54fa2564fc05"),
                            DoctorId = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Joe"
                        },
                        new
                        {
                            Id = new Guid("146b3f62-b89a-46ea-b8fe-f87e0250e01a"),
                            DoctorId = new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"),
                            Name = "Wendell"
                        },
                        new
                        {
                            Id = new Guid("d24ca736-b78d-4fd3-bbae-54fe079dde1d"),
                            DoctorId = new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"),
                            Name = "Sandra"
                        },
                        new
                        {
                            Id = new Guid("1d208e01-faab-4e5c-9fbb-05a3a801edd3"),
                            DoctorId = new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"),
                            Name = "Stephanie"
                        },
                        new
                        {
                            Id = new Guid("2e289506-1f8b-4653-97bf-55182305a9b9"),
                            DoctorId = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Ervin"
                        },
                        new
                        {
                            Id = new Guid("d1b8df29-7a36-468c-956b-d2a8cb882503"),
                            DoctorId = new Guid("ea94dc26-fafa-480e-ba29-476aa57a18ec"),
                            Name = "Beth"
                        },
                        new
                        {
                            Id = new Guid("6ac59b51-131e-4477-98e5-6de432586f7f"),
                            DoctorId = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Gretchen"
                        },
                        new
                        {
                            Id = new Guid("ae6db48e-7341-4884-81b6-e59289d0251b"),
                            DoctorId = new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"),
                            Name = "Gwendolyn"
                        },
                        new
                        {
                            Id = new Guid("7269ddda-48c7-4878-968b-3d75978d1810"),
                            DoctorId = new Guid("8fda37b5-2d3b-4bd3-bf4f-11763db38827"),
                            Name = "Jerry"
                        },
                        new
                        {
                            Id = new Guid("0b15c822-2b83-47cc-92a1-f2d93916c1da"),
                            DoctorId = new Guid("1d3979b0-f759-4dd1-98e4-62f162f88d3d"),
                            Name = "Mitchell"
                        },
                        new
                        {
                            Id = new Guid("7be56ccf-8912-4649-8c67-41968ae093e0"),
                            DoctorId = new Guid("4085ddb6-2025-46e7-a8b3-9ddfde960ff3"),
                            Name = "Maggie"
                        },
                        new
                        {
                            Id = new Guid("104a7a3c-678e-41c1-8eb4-37ce7ae4e81b"),
                            DoctorId = new Guid("cb92c8fc-ea27-48c8-a585-846989a023a1"),
                            Name = "Sandy"
                        },
                        new
                        {
                            Id = new Guid("8dc902ff-64cb-4353-a172-7498564cc6ae"),
                            DoctorId = new Guid("11d55d8a-1383-4a5b-aa2e-f89149beb703"),
                            Name = "Lloyd"
                        });
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.Property<Guid>("IssuesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IssuesId", "PatientsId");

                    b.HasIndex("PatientsId");

                    b.ToTable("IssuePatient");
                });

            modelBuilder.Entity("Hospital.DAL.Patient", b =>
                {
                    b.HasOne("Hospital.DAL.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("IssuePatient", b =>
                {
                    b.HasOne("Hospital.DAL.Issue", null)
                        .WithMany()
                        .HasForeignKey("IssuesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.DAL.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hospital.DAL.Doctor", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}