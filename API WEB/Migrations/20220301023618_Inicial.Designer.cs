﻿// <auto-generated />
using System;
using API_WEB.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_WEB.Migrations
{
    [DbContext(typeof(NinjaContext))]
    [Migration("20220301023618_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API_WEB.Models.Cla", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long>("KekkeiGenkaiId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<long>("VillageId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("KekkeiGenkaiId");

                    b.HasIndex("VillageId");

                    b.ToTable("Cla");
                });

            modelBuilder.Entity("API_WEB.Models.KekkeiGenkai", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("level");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("KekkeiGenkai");
                });

            modelBuilder.Entity("API_WEB.Models.Ninja", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<long?>("ClaId")
                        .HasColumnType("bigint");

                    b.Property<int>("Graduation")
                        .HasColumnType("int")
                        .HasColumnName("order_graduation");

                    b.Property<bool>("IsRenegate")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_renegate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<long?>("VillageId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ClaId");

                    b.HasIndex("VillageId");

                    b.ToTable("Ninjas");
                });

            modelBuilder.Entity("API_WEB.Models.Village", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<int>("Country")
                        .HasColumnType("int")
                        .HasColumnName("order_country");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Village");
                });

            modelBuilder.Entity("API_WEB.Models.Cla", b =>
                {
                    b.HasOne("API_WEB.Models.KekkeiGenkai", "KekkeiGenkai")
                        .WithMany()
                        .HasForeignKey("KekkeiGenkaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_WEB.Models.Village", "Village")
                        .WithMany()
                        .HasForeignKey("VillageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KekkeiGenkai");

                    b.Navigation("Village");
                });

            modelBuilder.Entity("API_WEB.Models.Ninja", b =>
                {
                    b.HasOne("API_WEB.Models.Cla", "Cla")
                        .WithMany()
                        .HasForeignKey("ClaId");

                    b.HasOne("API_WEB.Models.Village", "Village")
                        .WithMany()
                        .HasForeignKey("VillageId");

                    b.Navigation("Cla");

                    b.Navigation("Village");
                });
#pragma warning restore 612, 618
        }
    }
}
