﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatePass.DataAcess;

#nullable disable

namespace PlatePass.DataAcess.Migrations
{
    [DbContext(typeof(PlatePassContext))]
    [Migration("20231109155635_mig_1_db_created")]
    partial class mig_1_db_created
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlatePass.Entities.Plate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PlateText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Plate");
                });

            modelBuilder.Entity("PlatePass.Entities.PlateDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsSafePlate")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PassDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlateId");

                    b.ToTable("PlateUserDetail");
                });

            modelBuilder.Entity("PlatePass.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PlatePass.Entities.Plate", b =>
                {
                    b.HasOne("PlatePass.Entities.User", "User")
                        .WithMany("Plates")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlatePass.Entities.PlateDetails", b =>
                {
                    b.HasOne("PlatePass.Entities.Plate", "Plate")
                        .WithMany("PlateDetails")
                        .HasForeignKey("PlateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plate");
                });

            modelBuilder.Entity("PlatePass.Entities.Plate", b =>
                {
                    b.Navigation("PlateDetails");
                });

            modelBuilder.Entity("PlatePass.Entities.User", b =>
                {
                    b.Navigation("Plates");
                });
#pragma warning restore 612, 618
        }
    }
}
