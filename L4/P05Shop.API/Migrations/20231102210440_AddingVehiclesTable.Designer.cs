﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231102210440_AddingVehiclesTable")]
    partial class AddingVehiclesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.VehicleDealership.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fuel = "Hybrid",
                            Model = "A8"
                        },
                        new
                        {
                            Id = 2,
                            Fuel = "Gasoline",
                            Model = "Beetle"
                        },
                        new
                        {
                            Id = 3,
                            Fuel = "Gasoline",
                            Model = "Malibu"
                        },
                        new
                        {
                            Id = 4,
                            Fuel = "Electric",
                            Model = "1"
                        },
                        new
                        {
                            Id = 5,
                            Fuel = "Electric",
                            Model = "XC90"
                        },
                        new
                        {
                            Id = 6,
                            Fuel = "Electric",
                            Model = "Silverado"
                        },
                        new
                        {
                            Id = 7,
                            Fuel = "Electric",
                            Model = "Land Cruiser"
                        },
                        new
                        {
                            Id = 8,
                            Fuel = "Diesel",
                            Model = "XC90"
                        },
                        new
                        {
                            Id = 9,
                            Fuel = "Hybrid",
                            Model = "Mercielago"
                        },
                        new
                        {
                            Id = 10,
                            Fuel = "Electric",
                            Model = "Element"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
