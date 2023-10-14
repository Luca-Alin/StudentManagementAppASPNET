﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManagementApp.Data;

#nullable disable

namespace StudentManagementApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231014163911_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StudentManagementApp.Models.AddressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<short>("Number")
                        .HasColumnType("smallint");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("address");
                });

            modelBuilder.Entity("StudentManagementApp.Models.CourseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CourseHours")
                        .HasColumnType("int");

                    b.Property<int>("CourseType")
                        .HasColumnType("int");

                    b.Property<byte>("Credits")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("ExaminationType")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<byte>("LaboratoryHours")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("PracticeHours")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("ProjectHours")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<byte>("SeminarHours")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("course");
                });

            modelBuilder.Entity("StudentManagementApp.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("faculty");
                });

            modelBuilder.Entity("StudentManagementApp.Models.FacultyCoursesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Course1Id")
                        .HasColumnType("int");

                    b.Property<int>("Course2Id")
                        .HasColumnType("int");

                    b.Property<int>("Course3Id")
                        .HasColumnType("int");

                    b.Property<int>("Course4Id")
                        .HasColumnType("int");

                    b.Property<int>("Course5Id")
                        .HasColumnType("int");

                    b.Property<int>("Course6Id")
                        .HasColumnType("int");

                    b.Property<int>("Course7Id")
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<byte>("Semester")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("Year")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("Course1Id");

                    b.HasIndex("Course2Id");

                    b.HasIndex("Course3Id");

                    b.HasIndex("Course4Id");

                    b.HasIndex("Course5Id");

                    b.HasIndex("Course6Id");

                    b.HasIndex("Course7Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("facultyCourses");
                });

            modelBuilder.Entity("StudentManagementApp.Models.GradeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseModelId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<byte>("Value")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CourseModelId");

                    b.HasIndex("StudentId");

                    b.ToTable("grade");
                });

            modelBuilder.Entity("StudentManagementApp.Models.Student.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AddressModelId");

                    b.ToTable("student");
                });

            modelBuilder.Entity("StudentManagementApp.Models.TeacherModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressModelId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AddressModelId");

                    b.ToTable("teacher");
                });

            modelBuilder.Entity("StudentManagementApp.Models.WhatFacultyAStudentAttendsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("StudentId");

                    b.ToTable("whatFacultyAStudentAttends");
                });

            modelBuilder.Entity("StudentManagementApp.Models.CourseModel", b =>
                {
                    b.HasOne("StudentManagementApp.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("StudentManagementApp.Models.FacultyCoursesModel", b =>
                {
                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course1")
                        .WithMany()
                        .HasForeignKey("Course1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course2")
                        .WithMany()
                        .HasForeignKey("Course2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course3")
                        .WithMany()
                        .HasForeignKey("Course3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course4")
                        .WithMany()
                        .HasForeignKey("Course4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course5")
                        .WithMany()
                        .HasForeignKey("Course5Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course6")
                        .WithMany()
                        .HasForeignKey("Course6Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.CourseModel", "Course7")
                        .WithMany()
                        .HasForeignKey("Course7Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course1");

                    b.Navigation("Course2");

                    b.Navigation("Course3");

                    b.Navigation("Course4");

                    b.Navigation("Course5");

                    b.Navigation("Course6");

                    b.Navigation("Course7");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("StudentManagementApp.Models.GradeModel", b =>
                {
                    b.HasOne("StudentManagementApp.Models.CourseModel", "CourseModel")
                        .WithMany()
                        .HasForeignKey("CourseModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.Student.StudentModel", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseModel");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentManagementApp.Models.Student.StudentModel", b =>
                {
                    b.HasOne("StudentManagementApp.Models.AddressModel", "AddressModel")
                        .WithMany()
                        .HasForeignKey("AddressModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressModel");
                });

            modelBuilder.Entity("StudentManagementApp.Models.TeacherModel", b =>
                {
                    b.HasOne("StudentManagementApp.Models.AddressModel", "AddressModel")
                        .WithMany()
                        .HasForeignKey("AddressModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressModel");
                });

            modelBuilder.Entity("StudentManagementApp.Models.WhatFacultyAStudentAttendsModel", b =>
                {
                    b.HasOne("StudentManagementApp.Models.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentManagementApp.Models.Student.StudentModel", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
