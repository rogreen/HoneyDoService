﻿// <auto-generated />
using System;
using HoneyDoService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HoneyDoService.Migrations
{
    [DbContext(typeof(HoneyDoItemContext))]
    [Migration("20200305182528_HoneyDoService.Models.HoneyDoItemContextSeed")]
    partial class HoneyDoServiceModelsHoneyDoItemContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HoneyDoService.Models.HoneyDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recurrence")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HoneyDoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignedTo = "Me",
                            Category = "Home indoors",
                            Completed = false,
                            Description = "Clean litter box",
                            DueDate = new DateTime(2020, 3, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Priority = "High",
                            Recurrence = "Monthly"
                        },
                        new
                        {
                            Id = 2,
                            AssignedTo = "Us",
                            Category = "Errand",
                            Completed = false,
                            Description = "Grocery Shoop",
                            DueDate = new DateTime(2020, 3, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Priority = "High",
                            Recurrence = "Weekly"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
