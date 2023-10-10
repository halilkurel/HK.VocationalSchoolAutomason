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
    [Migration("20230924091912_LessonDayandTimeInformationTableCreate")]
    partial class LessonDayandTimeInformationTableCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Branch", b =>
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

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.ClassLessons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("LGMId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LGMId");

                    b.ToTable("ClassLessons");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.ClassRoom", b =>
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

                    b.ToTable("ClassRooms");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Days")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Days")
                        .IsUnique();

                    b.ToTable("Days");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Duty", b =>
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

                    b.ToTable("Duties");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeDuty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DutyId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DutyId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("EmployeeDuties");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeDutyBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeDutyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("EmployeeDutyId")
                        .IsUnique();

                    b.ToTable("EmployeeDutyBranches");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.LessonDayandTimeInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("WeekLessonHourId")
                        .HasColumnType("int");

                    b.Property<int>("WeeklyLessonHoursId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("WeeklyLessonHoursId");

                    b.ToTable("LessonDayandTimeInformation");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.LevelGruopMojor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GruopId")
                        .HasColumnType("int");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<int>("MajorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GruopId");

                    b.HasIndex("LevelId");

                    b.HasIndex("MajorId");

                    b.ToTable("LevelGruopMojors");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevelGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MajorLevelGroupId")
                        .HasColumnType("int");

                    b.Property<int>("SemesterId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MajorLevelGroupId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId", "MajorLevelGroupId", "SemesterId")
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.WeeklyLessonHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("WeeklyLessonHours");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.ClassLessons", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Course", "Course")
                        .WithMany("ClassLessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.LevelGruopMojor", "LevelGruopMojor")
                        .WithMany("ClassLessons")
                        .HasForeignKey("LGMId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("LevelGruopMojor");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeDuty", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Duty", "Duty")
                        .WithMany("EmployeeDuties")
                        .HasForeignKey("DutyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Employee", "Employee")
                        .WithMany("EmployeeDuties")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Duty");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeDutyBranch", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Branch", "Branch")
                        .WithMany("EmployeeDutyBranches")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeDuty", "EmployeeDuty")
                        .WithMany("EmployeeDutyBranches")
                        .HasForeignKey("EmployeeDutyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("EmployeeDuty");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.LessonDayandTimeInformation", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Day", "Days")
                        .WithMany("LessonDayandTimeInformations")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.WeeklyLessonHours", "WeeklyLessonHours")
                        .WithMany("LessonDayandTimeInformations")
                        .HasForeignKey("WeeklyLessonHoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Days");

                    b.Navigation("WeeklyLessonHours");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.LevelGruopMojor", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Groups", "Groups")
                        .WithMany("LevelGruopMojors")
                        .HasForeignKey("GruopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Level", "Level")
                        .WithMany("LevelGruopMojors")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Majors", "Majors")
                        .WithMany("LevelGruopMojors")
                        .HasForeignKey("MajorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Groups");

                    b.Navigation("Level");

                    b.Navigation("Majors");
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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.StudentMajorLevelGroup", b =>
                {
                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.LevelGruopMojor", "LevelGruopMojor")
                        .WithMany("StudentMajorLevelGroups")
                        .HasForeignKey("MajorLevelGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Semester", "Semester")
                        .WithMany("StudentMajorLevelGroups")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HK.VocationalSchoolAutomason.Entities.Domains.Students", "Students")
                        .WithMany("StudentMajorLevelGroups")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LevelGruopMojor");

                    b.Navigation("Semester");

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

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Branch", b =>
                {
                    b.Navigation("EmployeeDutyBranches");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Course", b =>
                {
                    b.Navigation("ClassLessons");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Day", b =>
                {
                    b.Navigation("LessonDayandTimeInformations");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Duty", b =>
                {
                    b.Navigation("EmployeeDuties");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Employee", b =>
                {
                    b.Navigation("EmployeeContact")
                        .IsRequired();

                    b.Navigation("EmployeeDuties");

                    b.Navigation("EmployeeInformation")
                        .IsRequired();
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.EmployeeDuty", b =>
                {
                    b.Navigation("EmployeeDutyBranches");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Groups", b =>
                {
                    b.Navigation("LevelGruopMojors");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Level", b =>
                {
                    b.Navigation("LevelGruopMojors");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.LevelGruopMojor", b =>
                {
                    b.Navigation("ClassLessons");

                    b.Navigation("StudentMajorLevelGroups");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Majors", b =>
                {
                    b.Navigation("LevelGruopMojors");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Parent_Information", b =>
                {
                    b.Navigation("Student_HasParentInformation");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Semester", b =>
                {
                    b.Navigation("StudentMajorLevelGroups");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.Students", b =>
                {
                    b.Navigation("StudentContact")
                        .IsRequired();

                    b.Navigation("StudentMajorLevelGroups");

                    b.Navigation("Student_HasParentInformation");
                });

            modelBuilder.Entity("HK.VocationalSchoolAutomason.Entities.Domains.WeeklyLessonHours", b =>
                {
                    b.Navigation("LessonDayandTimeInformations");
                });
#pragma warning restore 612, 618
        }
    }
}
