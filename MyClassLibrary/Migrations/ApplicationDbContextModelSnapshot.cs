﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyClassLibrary;

#nullable disable

namespace MyClassLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyClassLibrary.Models.CalculationResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Input1")
                        .HasColumnType("float");

                    b.Property<double>("Input2")
                        .HasColumnType("float");

                    b.Property<string>("Operator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Result")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CalculationResults");
                });

            modelBuilder.Entity("MyClassLibrary.Models.RockPaperScissorsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CurrentWinRatio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("WinOrLoss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RockPaperScissorsResults");
                });

            modelBuilder.Entity("MyClassLibrary.Models.ShapeResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Input1")
                        .HasColumnType("float");

                    b.Property<double>("Input2")
                        .HasColumnType("float");

                    b.Property<double>("Input3")
                        .HasColumnType("float");

                    b.Property<double>("Perimeter")
                        .HasColumnType("float");

                    b.Property<string>("Shape")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShapeType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ShapeResults");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Area = 2.0,
                            Date = new DateTime(2023, 1, 19, 22, 19, 24, 521, DateTimeKind.Local).AddTicks(9992),
                            Input1 = 1.0,
                            Input2 = 2.0,
                            Input3 = 0.0,
                            Perimeter = 6.0,
                            Shape = "Rektangel",
                            ShapeType = 0
                        },
                        new
                        {
                            Id = 2,
                            Area = 12.5,
                            Date = new DateTime(2023, 1, 19, 22, 19, 24, 522, DateTimeKind.Local).AddTicks(73),
                            Input1 = 5.0,
                            Input2 = 5.0,
                            Input3 = 7.0,
                            Perimeter = 17.0,
                            Shape = "Triangel",
                            ShapeType = 2
                        },
                        new
                        {
                            Id = 3,
                            Area = 120.0,
                            Date = new DateTime(2023, 1, 19, 22, 19, 24, 522, DateTimeKind.Local).AddTicks(79),
                            Input1 = 13.0,
                            Input2 = 24.0,
                            Input3 = 10.0,
                            Perimeter = 52.0,
                            Shape = "Romb",
                            ShapeType = 1
                        },
                        new
                        {
                            Id = 4,
                            Area = 72.0,
                            Date = new DateTime(2023, 1, 19, 22, 19, 24, 522, DateTimeKind.Local).AddTicks(84),
                            Input1 = 12.0,
                            Input2 = 8.0,
                            Input3 = 6.0,
                            Perimeter = 40.0,
                            Shape = "Parallelogram",
                            ShapeType = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
