﻿// <auto-generated />
using System;
using ASP_Dot_Net_MVC_Aug_2021.Data.SqlRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_Dot_Net_MVC_Aug_2021.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210817142539_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ASP_Dot_Net_MVC_Aug_2021.Models.Product", b =>
                {
                    b.Property<string>("P_Code")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("P_Discount")
                        .HasColumnType("double");

                    b.Property<DateTime>("P_InDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("P_Min")
                        .HasColumnType("int");

                    b.Property<double>("P_Price")
                        .HasColumnType("double");

                    b.Property<int>("P_QOH")
                        .HasColumnType("int");

                    b.Property<string>("P_descript")
                        .HasColumnType("longtext");

                    b.Property<int?>("V_code")
                        .HasColumnType("int");

                    b.HasKey("P_Code");

                    b.HasIndex("V_code");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ASP_Dot_Net_MVC_Aug_2021.Models.Vendor", b =>
                {
                    b.Property<int>("V_code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("V_AreaCode")
                        .HasColumnType("int");

                    b.Property<string>("V_contact")
                        .HasColumnType("longtext");

                    b.Property<string>("V_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("V_order")
                        .HasColumnType("longtext");

                    b.Property<string>("V_phone")
                        .HasColumnType("longtext");

                    b.Property<string>("V_state")
                        .HasColumnType("longtext");

                    b.HasKey("V_code");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("ASP_Dot_Net_MVC_Aug_2021.Models.Product", b =>
                {
                    b.HasOne("ASP_Dot_Net_MVC_Aug_2021.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("V_code");

                    b.Navigation("Vendor");
                });
#pragma warning restore 612, 618
        }
    }
}
