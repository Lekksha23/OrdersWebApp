﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrdersApp.Data;

#nullable disable

namespace OrdersApp.Data.Migrations
{
    [DbContext(typeof(OrdersAppContext))]
    partial class OrdersAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrdersApp.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressOfRecipient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOfSender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CargoWeight")
                        .HasColumnType("float");

                    b.Property<string>("CityOfRecipient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CityOfSender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressOfRecipient = "ул. Пушкина, д 7, кв 35",
                            AddressOfSender = "ул Ломоносова, д 39",
                            CargoWeight = 33.5,
                            CityOfRecipient = "Самара",
                            CityOfSender = "Санкт-Петербург",
                            DepartureDate = new DateTime(2022, 4, 23, 15, 30, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            AddressOfRecipient = "ул. Пушкина, д 2, кв 7",
                            AddressOfSender = "ул Ломоносова, д 39",
                            CargoWeight = 3.5,
                            CityOfRecipient = "Днепропетровск",
                            CityOfSender = "Санкт-Петербург",
                            DepartureDate = new DateTime(2022, 5, 2, 12, 15, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            AddressOfRecipient = "ул. Пушкина, д 23, кв 24",
                            AddressOfSender = "ул Ломоносова, д 39",
                            CargoWeight = 60.700000000000003,
                            CityOfRecipient = "Челябинск",
                            CityOfSender = "Санкт-Петербург",
                            DepartureDate = new DateTime(2022, 4, 25, 14, 50, 0, 0, DateTimeKind.Unspecified),
                            IsDeleted = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
