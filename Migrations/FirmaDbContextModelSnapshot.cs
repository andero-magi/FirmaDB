﻿// <auto-generated />
using System;
using FirmaDB_Migration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirmaDB_Migration.Migrations
{
    [DbContext(typeof(FirmaDbContext))]
    partial class FirmaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FirmaDB_Migration.Models.AccessPermission", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AccessLevels")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessPermissions");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Appeal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Appeals");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PersonalCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("PersonalCode")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("varchar(22)");

                    b.Property<int>("VacationDaysBalance")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.HealthCheck", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Results")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HealthChecks");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LiquidationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PurchasedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.ItemLoan", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.SickLeave", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SickLeaves");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Vacation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.AccessPermission", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithOne("AccessPermission")
                        .HasForeignKey("FirmaDB_Migration.Models.AccessPermission", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Child", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithMany("Children")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.HealthCheck", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithOne("HealthCheck")
                        .HasForeignKey("FirmaDB_Migration.Models.HealthCheck", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.ItemLoan", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithMany("Loans")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FirmaDB_Migration.Models.Item", "Item")
                        .WithMany("Loans")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.LeaveRequest", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Message", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Reciever")
                        .WithMany("Messages")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reciever");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.SickLeave", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithMany("SickLeaves")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Title", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithOne("Title")
                        .HasForeignKey("FirmaDB_Migration.Models.Title", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Vacation", b =>
                {
                    b.HasOne("FirmaDB_Migration.Models.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Employee", b =>
                {
                    b.Navigation("AccessPermission")
                        .IsRequired();

                    b.Navigation("Children");

                    b.Navigation("HealthCheck")
                        .IsRequired();

                    b.Navigation("LeaveRequests");

                    b.Navigation("Loans");

                    b.Navigation("Messages");

                    b.Navigation("SickLeaves");

                    b.Navigation("Title")
                        .IsRequired();

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("FirmaDB_Migration.Models.Item", b =>
                {
                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
