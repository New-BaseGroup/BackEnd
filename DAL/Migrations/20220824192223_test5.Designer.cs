﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(BudgetContext))]
    [Migration("20220824192223_test5")]
    partial class test5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Models.Budget", b =>
                {
                    b.Property<int>("BudgetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BudgetID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BudgetID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("DAL.Models.BudgetCategory", b =>
                {
                    b.Property<int>("BudgetCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BudgetCategoryID"), 1L, 1);

                    b.Property<int?>("BudgetID")
                        .HasColumnType("int");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("CustomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxAmount")
                        .HasColumnType("int");

                    b.HasKey("BudgetCategoryID");

                    b.HasIndex("BudgetID");

                    b.HasIndex("CategoryID");

                    b.ToTable("BudgetCategories");
                });

            modelBuilder.Entity("DAL.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoryID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DAL.Models.Change", b =>
                {
                    b.Property<int>("ChangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChangeID"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("BudgetCategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChangeID");

                    b.HasIndex("BudgetCategoryID");

                    b.ToTable("Changes");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Models.Budget", b =>
                {
                    b.HasOne("DAL.Models.User", null)
                        .WithMany("Budgets")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("DAL.Models.BudgetCategory", b =>
                {
                    b.HasOne("DAL.Models.Budget", null)
                        .WithMany("BudgetCategories")
                        .HasForeignKey("BudgetID");

                    b.HasOne("DAL.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DAL.Models.Change", b =>
                {
                    b.HasOne("DAL.Models.BudgetCategory", null)
                        .WithMany("Changes")
                        .HasForeignKey("BudgetCategoryID");
                });

            modelBuilder.Entity("DAL.Models.Budget", b =>
                {
                    b.Navigation("BudgetCategories");
                });

            modelBuilder.Entity("DAL.Models.BudgetCategory", b =>
                {
                    b.Navigation("Changes");
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Navigation("Budgets");
                });
#pragma warning restore 612, 618
        }
    }
}