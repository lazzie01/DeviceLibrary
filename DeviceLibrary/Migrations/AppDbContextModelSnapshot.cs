﻿// <auto-generated />
using System;
using DeviceLibrary.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeviceLibrary.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeviceLibrary.DataAccessLayer.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CameraId")
                        .HasColumnType("int");

                    b.Property<int?>("LaptopId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CameraId");

                    b.HasIndex("LaptopId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("DeviceLibrary.DataAccessLayer.Models.Camera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cameras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            DeviceType = 1,
                            Model = "CX101",
                            Name = "Canon"
                        },
                        new
                        {
                            Id = 2,
                            Available = true,
                            DeviceType = 1,
                            Model = "PH001",
                            Name = "Philips"
                        },
                        new
                        {
                            Id = 3,
                            Available = true,
                            DeviceType = 1,
                            Model = "SO09",
                            Name = "Sony"
                        });
                });

            modelBuilder.Entity("DeviceLibrary.DataAccessLayer.Models.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("DeviceType")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laptops");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Available = true,
                            DeviceType = 0,
                            Model = "H01",
                            Name = "HP"
                        },
                        new
                        {
                            Id = 2,
                            Available = true,
                            DeviceType = 0,
                            Model = "D123",
                            Name = "DELL"
                        },
                        new
                        {
                            Id = 3,
                            Available = true,
                            DeviceType = 0,
                            Model = "S001",
                            Name = "Samsung"
                        });
                });

            modelBuilder.Entity("DeviceLibrary.DataAccessLayer.Models.Booking", b =>
                {
                    b.HasOne("DeviceLibrary.DataAccessLayer.Models.Camera", "Camera")
                        .WithMany()
                        .HasForeignKey("CameraId");

                    b.HasOne("DeviceLibrary.DataAccessLayer.Models.Laptop", "Laptop")
                        .WithMany()
                        .HasForeignKey("LaptopId");

                    b.Navigation("Camera");

                    b.Navigation("Laptop");
                });
#pragma warning restore 612, 618
        }
    }
}
