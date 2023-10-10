﻿// <auto-generated />
using System;
using HK.VocationalSchoolAutomason.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HK.VocationalSchoolAutomason.DataAccess.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20230921074148_SemesterTableCreate")]
    partial class SemesterTableCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Capacity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Capacities");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirthDay")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime");

                    b.Property<string>("Duty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("IdentificationNumber")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeContact", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("PhoneNumber2")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeContacts");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeInformation", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("GraduatedSchool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graduation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GraduationYear")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeId");

                    b.ToTable("EmployeeInformations");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Groups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Majors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("MajorName")
                        .IsUnique();

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Parent_Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Proximity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("IdentificationNumber")
                        .IsUnique();

                    b.ToTable("Parent_Informations");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Semester", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Semesters");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentContact", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("PhoneNumber2")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.HasKey("StudentId");

                    b.ToTable("StudentContacts");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("MajorId");

                    b.HasIndex("StudentId", "MajorId", "LevelId")
                        .IsUnique();

                    b.ToTable("StudentMajorLevels");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevelGroups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("StudentMajorLevelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentMajorLevelId");

                    b.HasIndex("GroupId", "StudentMajorLevelId")
                        .IsUnique();

                    b.ToTable("StudentMajorLevelGroups");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Student_has_ParentInformation", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("ParentInformationId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "ParentInformationId");

                    b.HasIndex("ParentInformationId");

                    b.ToTable("Student_HasParentInformation");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfBirthDay")
                        .HasColumnType("Date");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("RegistrationYear")
                        .HasColumnType("date");

                    b.Property<string>("RepeatingAGrade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("IdentificationNumber")
                        .IsUnique();

                    b.HasIndex("Number")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeContact", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Employee", "Employee")
                        .WithOne("EmployeeContact")
                        .HasForeignKey("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeContact", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeInformation", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Employee", "Employee")
                        .WithOne("EmployeeInformation")
                        .HasForeignKey("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeInformation", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentContact", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Students")
                        .WithOne("StudentContact")
                        .HasForeignKey("HK.VocationalSchoolAutomason.Entities.Domains.StudentContact", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevel", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Level", "Level")
                        .WithMany("StudentMajorLevels")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Majors", "Major")
                        .WithMany("StudentMajorLevels")
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Student")
                        .WithMany("StudentMajorLevels")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("Major");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevelGroups", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Groups", "Group")
                        .WithMany("StudentMajorLevelGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevel", "StudentMajorLevel")
                        .WithMany("StudentMajorLevelGroups")
                        .HasForeignKey("StudentMajorLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("StudentMajorLevel");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Student_has_ParentInformation", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Parent_Information", "Parent_Information")
                        .WithMany("Student_HasParentInformation")
                        .HasForeignKey("ParentInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Students")
                        .WithMany("Student_HasParentInformation")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Parent_Information");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Employee", b =>
                {
                    b.Navigation("EmployeeContact")
                        .IsRequired();

                    b.Navigation("EmployeeInformation")
                        .IsRequired();
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Groups", b =>
                {
                    b.Navigation("StudentMajorLevelGroups");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Level", b =>
                {
                    b.Navigation("StudentMajorLevels");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Majors", b =>
                {
                    b.Navigation("StudentMajorLevels");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Parent_Information", b =>
                {
                    b.Navigation("Student_HasParentInformation");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevel", b =>
                {
                    b.Navigation("StudentMajorLevelGroups");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Students", b =>
                {
                    b.Navigation("StudentContact")
                        .IsRequired();

                    b.Navigation("StudentMajorLevels");

                    b.Navigation("Student_HasParentInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
