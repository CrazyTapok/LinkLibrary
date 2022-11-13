﻿// <auto-generated />
using System;
using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Data.Entities.Link", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasMaxLength(20)
                        .HasColumnType("date");

                    b.Property<string>("LongURl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ShortURL")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VisitsNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            Id = new Guid("611380c0-85ef-4855-9d14-547c02370888"),
                            Date = new DateTime(2022, 11, 13, 17, 42, 0, 999, DateTimeKind.Local).AddTicks(4299),
                            LongURl = "https://learn.javascript.ru/",
                            ShortURL = "learn.javascript.ru",
                            VisitsNumber = 0
                        },
                        new
                        {
                            Id = new Guid("595110a0-c68d-4839-8829-5ed18a50ef8c"),
                            Date = new DateTime(2022, 11, 13, 17, 42, 0, 999, DateTimeKind.Local).AddTicks(4311),
                            LongURl = "https://metanit.com/sharp/",
                            ShortURL = "metanit.com/sharp",
                            VisitsNumber = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
