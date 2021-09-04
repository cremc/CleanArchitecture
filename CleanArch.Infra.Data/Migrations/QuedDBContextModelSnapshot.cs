﻿// <auto-generated />
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArch.Infra.Data.Migrations
{
    [DbContext(typeof(QuedDBContext))]
    partial class QuedDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CleanArch.Domain.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttendanceTypeLookupID")
                        .HasColumnType("int");

                    b.Property<int>("CASL1SubinstitutionID")
                        .HasColumnType("int");

                    b.Property<int>("CASL2SubinstitutionID")
                        .HasColumnType("int");

                    b.Property<int>("CASL3SubinstitutionID")
                        .HasColumnType("int");

                    b.Property<int>("CASL4SubinstitutionID")
                        .HasColumnType("int");

                    b.Property<string>("CourseDescriptionForCareer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseDescriptionForRigour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseDurationAcademicSessions")
                        .HasColumnType("int");

                    b.Property<int>("CourseDurationDays")
                        .HasColumnType("int");

                    b.Property<int>("CourseDurationMonths")
                        .HasColumnType("int");

                    b.Property<int>("CourseDurationWeeks")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseStartSession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstitutionID")
                        .HasColumnType("int");

                    b.Property<int>("TargetStudentTypeLookupID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
