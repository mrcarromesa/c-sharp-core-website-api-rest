﻿// <auto-generated />
using ContosoCrafts.WebSite.database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContosoCrafts.WebSite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ContosoCrafts.WebSite.Models.People", b =>
                {
                    b.Property<int>("PeopleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnName("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("PeopleID");

                    b.ToTable("People");
                });
#pragma warning restore 612, 618
        }
    }
}