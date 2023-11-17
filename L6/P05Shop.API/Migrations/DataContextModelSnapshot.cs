﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05_3Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fuel = "Diesel",
                            Model = "Colorado"
                        },
                        new
                        {
                            Id = 2,
                            Fuel = "Electric",
                            Model = "Focus"
                        },
                        new
                        {
                            Id = 3,
                            Fuel = "Electric",
                            Model = "Spyder"
                        },
                        new
                        {
                            Id = 4,
                            Fuel = "Electric",
                            Model = "Malibu"
                        },
                        new
                        {
                            Id = 5,
                            Fuel = "Hybrid",
                            Model = "Roadster"
                        },
                        new
                        {
                            Id = 6,
                            Fuel = "Electric",
                            Model = "Expedition"
                        },
                        new
                        {
                            Id = 7,
                            Fuel = "Diesel",
                            Model = "Camry"
                        },
                        new
                        {
                            Id = 8,
                            Fuel = "Hybrid",
                            Model = "Altima"
                        },
                        new
                        {
                            Id = 9,
                            Fuel = "Gasoline",
                            Model = "Altima"
                        },
                        new
                        {
                            Id = 10,
                            Fuel = "Diesel",
                            Model = "Element"
                        },
                        new
                        {
                            Id = 11,
                            Fuel = "Diesel",
                            Model = "Durango"
                        },
                        new
                        {
                            Id = 12,
                            Fuel = "Hybrid",
                            Model = "Element"
                        },
                        new
                        {
                            Id = 13,
                            Fuel = "Electric",
                            Model = "Expedition"
                        },
                        new
                        {
                            Id = 14,
                            Fuel = "Diesel",
                            Model = "Explorer"
                        },
                        new
                        {
                            Id = 15,
                            Fuel = "Gasoline",
                            Model = "Sentra"
                        },
                        new
                        {
                            Id = 16,
                            Fuel = "Gasoline",
                            Model = "Alpine"
                        },
                        new
                        {
                            Id = 17,
                            Fuel = "Diesel",
                            Model = "1"
                        },
                        new
                        {
                            Id = 18,
                            Fuel = "Diesel",
                            Model = "Spyder"
                        },
                        new
                        {
                            Id = 19,
                            Fuel = "Electric",
                            Model = "Altima"
                        },
                        new
                        {
                            Id = 20,
                            Fuel = "Gasoline",
                            Model = "LeBaron"
                        },
                        new
                        {
                            Id = 21,
                            Fuel = "Gasoline",
                            Model = "Cruze"
                        },
                        new
                        {
                            Id = 22,
                            Fuel = "Diesel",
                            Model = "Mustang"
                        },
                        new
                        {
                            Id = 23,
                            Fuel = "Diesel",
                            Model = "ATS"
                        },
                        new
                        {
                            Id = 24,
                            Fuel = "Gasoline",
                            Model = "Sentra"
                        },
                        new
                        {
                            Id = 25,
                            Fuel = "Electric",
                            Model = "Focus"
                        },
                        new
                        {
                            Id = 26,
                            Fuel = "Electric",
                            Model = "Challenger"
                        },
                        new
                        {
                            Id = 27,
                            Fuel = "Hybrid",
                            Model = "Malibu"
                        },
                        new
                        {
                            Id = 28,
                            Fuel = "Diesel",
                            Model = "A4"
                        },
                        new
                        {
                            Id = 29,
                            Fuel = "Diesel",
                            Model = "PT Cruiser"
                        },
                        new
                        {
                            Id = 30,
                            Fuel = "Gasoline",
                            Model = "Colorado"
                        },
                        new
                        {
                            Id = 31,
                            Fuel = "Diesel",
                            Model = "Charger"
                        },
                        new
                        {
                            Id = 32,
                            Fuel = "Hybrid",
                            Model = "Sentra"
                        },
                        new
                        {
                            Id = 33,
                            Fuel = "Electric",
                            Model = "LeBaron"
                        },
                        new
                        {
                            Id = 34,
                            Fuel = "Electric",
                            Model = "PT Cruiser"
                        },
                        new
                        {
                            Id = 35,
                            Fuel = "Gasoline",
                            Model = "Colorado"
                        },
                        new
                        {
                            Id = 36,
                            Fuel = "Diesel",
                            Model = "Volt"
                        },
                        new
                        {
                            Id = 37,
                            Fuel = "Diesel",
                            Model = "Impala"
                        },
                        new
                        {
                            Id = 38,
                            Fuel = "Gasoline",
                            Model = "1"
                        },
                        new
                        {
                            Id = 39,
                            Fuel = "Gasoline",
                            Model = "Explorer"
                        },
                        new
                        {
                            Id = 40,
                            Fuel = "Diesel",
                            Model = "Grand Cherokee"
                        },
                        new
                        {
                            Id = 41,
                            Fuel = "Gasoline",
                            Model = "Land Cruiser"
                        },
                        new
                        {
                            Id = 42,
                            Fuel = "Electric",
                            Model = "CX-9"
                        },
                        new
                        {
                            Id = 43,
                            Fuel = "Diesel",
                            Model = "F-150"
                        },
                        new
                        {
                            Id = 44,
                            Fuel = "Diesel",
                            Model = "Charger"
                        },
                        new
                        {
                            Id = 45,
                            Fuel = "Gasoline",
                            Model = "ATS"
                        },
                        new
                        {
                            Id = 46,
                            Fuel = "Gasoline",
                            Model = "Civic"
                        },
                        new
                        {
                            Id = 47,
                            Fuel = "Hybrid",
                            Model = "Impala"
                        },
                        new
                        {
                            Id = 48,
                            Fuel = "Hybrid",
                            Model = "Corvette"
                        },
                        new
                        {
                            Id = 49,
                            Fuel = "Diesel",
                            Model = "Taurus"
                        },
                        new
                        {
                            Id = 50,
                            Fuel = "Hybrid",
                            Model = "Land Cruiser"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
