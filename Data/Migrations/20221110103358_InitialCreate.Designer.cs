﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221110103358_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entities.Link", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("LongURl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = new Guid("51baed5b-7c28-4f1c-a698-f1f11f1cf768"),
                            Date = new DateTime(2022, 11, 10, 13, 33, 58, 568, DateTimeKind.Local).AddTicks(9261),
                            LongURl = "https://learn.javascript.ru/",
                            ShortURL = "learn.javascript.ru",
                            VisitsNumber = 0
                        },
                        new
                        {
                            Id = new Guid("d6a99653-0dc8-41c6-b492-076ec98ff360"),
                            Date = new DateTime(2022, 11, 10, 13, 33, 58, 568, DateTimeKind.Local).AddTicks(9271),
                            LongURl = "https://metanit.com/sharp/",
                            ShortURL = "metanit.com/sharp",
                            VisitsNumber = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
