﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationWorkersWeb.Data;

#nullable disable

namespace MigrationWorkersWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220522175948_AddEmbassyUserEmailToDatabase")]
    partial class AddEmbassyUserEmailToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MigrationWorkersWeb.Models.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("License_Exp_Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("License_No")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Reg_No")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Agency_Contact_No", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AgencyID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Contact_No")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AgencyID");

                    b.ToTable("Agency_Contact_Nos");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Agency_email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AgencyID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AgencyID");

                    b.ToTable("Agency_emails");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ambassador")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Embassies");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_Contact_No", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contact_No")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EmbassyID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmbassyID");

                    b.ToTable("Embassy_Contact_Nos");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EmbassyID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmbassyID");

                    b.ToTable("Embassy_Emails");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EmbassyID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("UserID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmbassyID");

                    b.HasIndex("UserID");

                    b.ToTable("Embassy_Users");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_User_Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("EmbassyUserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmbassyUserID");

                    b.ToTable("Embassy_User_Emails");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Agency_Contact_No", b =>
                {
                    b.HasOne("MigrationWorkersWeb.Models.Agency", "Agency")
                        .WithMany()
                        .HasForeignKey("AgencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Agency_email", b =>
                {
                    b.HasOne("MigrationWorkersWeb.Models.Agency", "Agency")
                        .WithMany()
                        .HasForeignKey("AgencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_Contact_No", b =>
                {
                    b.HasOne("MigrationWorkersWeb.Models.Embassy", "Embassy")
                        .WithMany()
                        .HasForeignKey("EmbassyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Embassy");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_Email", b =>
                {
                    b.HasOne("MigrationWorkersWeb.Models.Embassy", "Embassy")
                        .WithMany()
                        .HasForeignKey("EmbassyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Embassy");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_User", b =>
                {
                    b.HasOne("MigrationWorkersWeb.Models.Embassy", "Embassy")
                        .WithMany()
                        .HasForeignKey("EmbassyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MigrationWorkersWeb.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Embassy");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MigrationWorkersWeb.Models.Embassy_User_Email", b =>
                {
                    b.HasOne("MigrationWorkersWeb.Models.Embassy_User", "User")
                        .WithMany()
                        .HasForeignKey("EmbassyUserID");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
