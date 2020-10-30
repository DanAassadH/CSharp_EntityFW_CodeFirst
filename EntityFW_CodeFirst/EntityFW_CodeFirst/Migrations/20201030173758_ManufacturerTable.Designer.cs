﻿// <auto-generated />
using EntityFW_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFW_CodeFirst.Migrations
{
    [DbContext(typeof(DealershipContext))]
    [Migration("20201030173758_ManufacturerTable")]
    partial class ManufacturerTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EntityFW_CodeFirst.Models.Manufacturer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.HasKey("ID");

                    b.ToTable("manufacturer");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            Name = "Ford"
                        },
                        new
                        {
                            ID = -2,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            ID = -3,
                            Name = "Dodge"
                        });
                });

            modelBuilder.Entity("EntityFW_CodeFirst.Models.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Colour")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int>("ManufacturerID")
                        .HasColumnType("int(10)");

                    b.Property<string>("Model")
                        .HasColumnType("varchar(30)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_general_ci");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int(10)");

                    b.HasKey("ID");

                    b.HasIndex("ManufacturerID")
                        .HasName("FK_Vehicle_Manufacturer");

                    b.ToTable("vehicle");
                });

            modelBuilder.Entity("EntityFW_CodeFirst.Models.Vehicle", b =>
                {
                    b.HasOne("EntityFW_CodeFirst.Models.Manufacturer", "Manufacturer")
                        .WithMany("Vehicles")
                        .HasForeignKey("ManufacturerID")
                        .HasConstraintName("FK_Vehicle_Manufacturer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
