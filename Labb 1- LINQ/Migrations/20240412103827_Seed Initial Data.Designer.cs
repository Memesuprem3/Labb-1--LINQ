﻿// <auto-generated />
using Labb_1__LINQ.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb_1__LINQ.Migrations
{
    [DbContext(typeof(EducationContext))]
    [Migration("20240412103827_Seed Initial Data")]
    partial class SeedInitialData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb_1__LINQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Code = "SUT23"
                        },
                        new
                        {
                            CourseId = 2,
                            Code = "SUT24"
                        },
                        new
                        {
                            CourseId = 3,
                            Code = "DAT23"
                        },
                        new
                        {
                            CourseId = 4,
                            Code = "DAT24"
                        });
                });

            modelBuilder.Entity("Labb_1__LINQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1,
                            Name = "Erik Karlsson",
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 4,
                            Name = "Sara Eriksson",
                            TeacherId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 3,
                            Name = "Wilma Sandström",
                            TeacherId = 2
                        },
                        new
                        {
                            StudentId = 4,
                            CourseId = 1,
                            Name = "Adrian Scholl",
                            TeacherId = 2
                        },
                        new
                        {
                            StudentId = 5,
                            CourseId = 1,
                            Name = "Åke Sjögren",
                            TeacherId = 4
                        },
                        new
                        {
                            StudentId = 6,
                            CourseId = 4,
                            Name = "Love Larsson",
                            TeacherId = 4
                        });
                });

            modelBuilder.Entity("Labb_1__LINQ.Models.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectID");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectID = 1,
                            Name = "Avancerad.net",
                            TeacherId = 1
                        },
                        new
                        {
                            SubjectID = 2,
                            Name = "Matematik",
                            TeacherId = 2
                        },
                        new
                        {
                            SubjectID = 3,
                            Name = "Programmering1",
                            TeacherId = 3
                        },
                        new
                        {
                            SubjectID = 4,
                            Name = "Programmering2",
                            TeacherId = 4
                        });
                });

            modelBuilder.Entity("Labb_1__LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            Name = "Anna Svensson"
                        },
                        new
                        {
                            TeacherID = 2,
                            Name = "Lars Larsson"
                        },
                        new
                        {
                            TeacherID = 3,
                            Name = "Jonas Qvist"
                        },
                        new
                        {
                            TeacherID = 4,
                            Name = "Tina Ahlström"
                        });
                });

            modelBuilder.Entity("Labb_1__LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb_1__LINQ.Models.Course", "Courrse")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb_1__LINQ.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courrse");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Labb_1__LINQ.Models.Subject", b =>
                {
                    b.HasOne("Labb_1__LINQ.Models.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Labb_1__LINQ.Models.Teacher", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
