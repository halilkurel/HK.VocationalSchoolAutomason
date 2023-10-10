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
    [Migration("20230918212312_BranchTableCreate")]
    partial class BranchTableCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Activities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActiviteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.ClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("ClassRoom");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BuildingName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Floor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Days", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Days");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentActivities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActiviteId")
                        .HasColumnType("int");

                    b.Property<string>("ParticipationResultsOrGains")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActiviteId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentActivities");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExcuseForAbsence")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentAttendances", (string)null);
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentHasClassRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClassRoomId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentHasClassRoom", (string)null);
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Branch", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Employee", "Employee")
                        .WithMany("Branches")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentActivities", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Activities", "Activities")
                        .WithMany("StudentActivities")
                        .HasForeignKey("ActiviteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Students")
                        .WithMany("StudentActivities")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activities");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentAttendance", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Students")
                        .WithMany("StudentAttendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentHasClassRoom", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.ClassRoom", "ClassRooms")
                        .WithMany("StudentHasClassRooms")
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Students")
                        .WithMany("StudentHasClassRooms")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassRooms");

                    b.Navigation("Students");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Activities", b =>
                {
                    b.Navigation("StudentActivities");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.ClassRoom", b =>
                {
                    b.Navigation("StudentHasClassRooms");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Employee", b =>
                {
                    b.Navigation("Branches");

                    b.Navigation("EmployeeContact")
                        .IsRequired();

                    b.Navigation("EmployeeInformation")
                        .IsRequired();
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Parent_Information", b =>
                {
                    b.Navigation("Student_HasParentInformation");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Students", b =>
                {
                    b.Navigation("StudentActivities");

                    b.Navigation("StudentAttendances");

                    b.Navigation("StudentContact")
                        .IsRequired();

                    b.Navigation("StudentHasClassRooms");

                    b.Navigation("Student_HasParentInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
