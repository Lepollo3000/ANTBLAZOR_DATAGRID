﻿// <auto-generated />
using System;
using ANTBLAZOR_DATAGRID.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PRUEBAMUDBLAZOR.Server.data.migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ANTBLAZOR_DATAGRID.Shared.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0102f709-1dd7-40de-af3d-23598c6bbd1f"),
                            ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Travel Mug",
                            Price = 11.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("ac7de2dc-049c-4328-ab06-6cde3ebe8aa7"),
                            ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
                            ManufactureDate = new DateTime(2016, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Classic Mug",
                            Price = 22.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("d26384cb-64b9-4aca-acb0-4ebb8fc53ba2"),
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Code Maze Logo T-Shirt",
                            Price = 20.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("b47d4c3c-3e29-49b9-b6be-28e5ee4625be"),
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
                            ManufactureDate = new DateTime(2015, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Pullover Hoodie",
                            Price = 30.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("54b2f952-b63e-4cad-8b38-c09955fe4c62"),
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fitted Scoop T-Shirt",
                            Price = 40.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("83e0aa87-158f-4e5f-a8f7-e5a98d13e3a5"),
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2013, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Zipped Hoodie",
                            Price = 55.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("488aaa0e-aa7e-4820-b4e9-5715f0e5186e"),
                            ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "iPhone Case & Cover",
                            Price = 25.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("4e693871-788d-4db4-89e5-dd7678db975e"),
                            ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
                            ManufactureDate = new DateTime(2019, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Case & Skin for Samsung Galaxy",
                            Price = 35.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("2d3c2abe-85ec-4d1e-9fef-9b4bfea5f459"),
                            ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2020, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "iPad Case & Skin",
                            Price = 45.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("d1f22836-6342-480a-be2f-035eeb010fd0"),
                            ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
                            ManufactureDate = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Wall Clock",
                            Price = 25.0,
                            Supplier = "Code Maze"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
