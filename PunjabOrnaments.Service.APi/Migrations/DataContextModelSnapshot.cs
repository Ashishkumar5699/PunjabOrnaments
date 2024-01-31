﻿// <auto-generated />
using System;
using PunjabOrnaments.Service.APi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PunjabOrnaments.Service.APi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PunjabOrnaments.Service.APi.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PunjabOrnaments.Service.APi.Entities.Contacts.ContactDetails", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("ContactAddress1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactAddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLandMark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPrifix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.HasKey("ContactId");

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("PunjabOrnaments.Service.APi.Entities.Purchase.PurchaseRequest", b =>
                {
                    b.Property<int>("PurchaseRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseRequestId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GrossWeight")
                        .HasColumnType("float");

                    b.Property<int?>("IsApproved")
                        .HasColumnType("int");

                    b.Property<string>("ItemType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Labour")
                        .HasColumnType("float");

                    b.Property<double>("LessWeight")
                        .HasColumnType("float");

                    b.Property<string>("ManufactureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufactureName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NetWeight")
                        .HasColumnType("float");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<double>("Wastage")
                        .HasColumnType("float");

                    b.HasKey("PurchaseRequestId");

                    b.ToTable("PurchaseRequests");
                });

            modelBuilder.Entity("PunjabOrnaments.Service.APi.Entities.Stock.Gold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carrot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GrossWeight")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LessWeight")
                        .HasColumnType("float");

                    b.Property<double>("NetWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("GoldStock");
                });
#pragma warning restore 612, 618
        }
    }
}
