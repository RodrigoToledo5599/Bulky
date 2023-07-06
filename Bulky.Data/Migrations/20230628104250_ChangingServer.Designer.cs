﻿// <auto-generated />
using BulkyBookWeb.Data;
using BulkyBookWeb.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BulkyBook.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230628104250_ChangingServer")]
    partial class ChangingServer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BulkyBook.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Kpop"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 8,
                            Name = "Serie"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 9,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 10,
                            Name = "Korean"
                        },
                        new
                        {
                            Id = 11,
                            DisplayOrder = 11,
                            Name = "Zombie Apocalipse"
                        },
                        new
                        {
                            Id = 12,
                            DisplayOrder = 12,
                            Name = "Horror"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
