﻿// <auto-generated />
using System;
using HW15;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW15.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220720080252_ProjectId required Added")]
    partial class ProjectIdrequiredAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HW15.DbModels.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("ClientId");

                    b.ToTable("Client");

                    b.HasData(
                        new
                        {
                            ClientId = 1,
                            FirstName = "test1",
                            LastName = "test",
                            ProjectId = 1
                        },
                        new
                        {
                            ClientId = 2,
                            FirstName = "test2",
                            LastName = "test",
                            ProjectId = 2
                        },
                        new
                        {
                            ClientId = 3,
                            FirstName = "test3",
                            LastName = "test",
                            ProjectId = 3
                        },
                        new
                        {
                            ClientId = 4,
                            FirstName = "test4",
                            LastName = "test",
                            ProjectId = 4
                        },
                        new
                        {
                            ClientId = 5,
                            FirstName = "test5",
                            LastName = "test",
                            ProjectId = 5
                        });
                });

            modelBuilder.Entity("HW15.DbModels.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HiredDate")
                        .HasPrecision(7)
                        .HasColumnType("datetime2(7)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TitleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HW15.DbModels.EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeProjectId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartedDate")
                        .HasPrecision(7)
                        .HasColumnType("datetime2(7)");

                    b.HasKey("EmployeeProjectId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("HW15.DbModels.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfficeId"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("OfficeId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("HW15.DbModels.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartedDate")
                        .HasPrecision(7)
                        .HasColumnType("datetime2(7)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Budget = 100.0m,
                            ClientId = 1,
                            Name = "test1",
                            StartedDate = new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1859)
                        },
                        new
                        {
                            ProjectId = 2,
                            Budget = 100.0m,
                            ClientId = 2,
                            Name = "test2",
                            StartedDate = new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1869)
                        },
                        new
                        {
                            ProjectId = 3,
                            Budget = 100.0m,
                            ClientId = 3,
                            Name = "test3",
                            StartedDate = new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1870)
                        },
                        new
                        {
                            ProjectId = 4,
                            Budget = 100.0m,
                            ClientId = 4,
                            Name = "test4",
                            StartedDate = new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1871)
                        },
                        new
                        {
                            ProjectId = 5,
                            Budget = 100.0m,
                            ClientId = 5,
                            Name = "test5",
                            StartedDate = new DateTime(2022, 7, 20, 10, 2, 52, 38, DateTimeKind.Local).AddTicks(1872)
                        });
                });

            modelBuilder.Entity("HW15.DbModels.Title", b =>
                {
                    b.Property<int>("TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TitleId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TitleId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("HW15.DbModels.Employee", b =>
                {
                    b.HasOne("HW15.DbModels.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW15.DbModels.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("HW15.DbModels.EmployeeProject", b =>
                {
                    b.HasOne("HW15.DbModels.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HW15.DbModels.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}