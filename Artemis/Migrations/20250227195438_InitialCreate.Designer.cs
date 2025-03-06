﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moon_Phase_App.Data;

#nullable disable

namespace Moon_Phase_App.Migrations
{
    [DbContext(typeof(MoonContext))]
    [Migration("20250227195438_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.2");

            modelBuilder.Entity("MoonData.Domain.Moon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .HasColumnType("TEXT");

                    b.Property<string>("Month")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phase")
                        .HasColumnType("TEXT");

                    b.Property<string>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Moon");
                });
#pragma warning restore 612, 618
        }
    }
}
