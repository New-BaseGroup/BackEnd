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
    [Migration("20221003120845_firstMig")]
    partial class firstMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BudgetID");

                    b.HasIndex("UserID");

                    b.ToTable("Budgets");

                    b.HasData(
                        new
                        {
                            BudgetID = 1,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4199),
                            Name = "budgetNr1",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4166),
                            TotalAmount = 40000m,
                            UserID = 1
                        },
                        new
                        {
                            BudgetID = 2,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4206),
                            Name = "budgetNr2",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4205),
                            TotalAmount = 20000m,
                            UserID = 1
                        },
                        new
                        {
                            BudgetID = 3,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4209),
                            Name = "budgetNr1",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4208),
                            TotalAmount = 10000m,
                            UserID = 2
                        },
                        new
                        {
                            BudgetID = 4,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4212),
                            Name = "budgetNr2",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4211),
                            TotalAmount = 10000m,
                            UserID = 2
                        },
                        new
                        {
                            BudgetID = 5,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4215),
                            Name = "budgetNr1",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4214),
                            TotalAmount = 10000m,
                            UserID = 3
                        },
                        new
                        {
                            BudgetID = 6,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4218),
                            Name = "budgetNr2",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4217),
                            TotalAmount = 10000m,
                            UserID = 3
                        },
                        new
                        {
                            BudgetID = 7,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4221),
                            Name = "budgetNr1",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4219),
                            TotalAmount = 10000m,
                            UserID = 4
                        },
                        new
                        {
                            BudgetID = 8,
                            EndDate = new DateTime(2022, 10, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4223),
                            Name = "budgetNr2",
                            StartDate = new DateTime(2022, 9, 23, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4222),
                            TotalAmount = 10000m,
                            UserID = 4
                        });
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

                    b.HasData(
                        new
                        {
                            BudgetCategoryID = 1,
                            BudgetID = 1,
                            CategoryID = 1,
                            CustomName = "BudgetCategory1",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 2,
                            BudgetID = 1,
                            CategoryID = 2,
                            CustomName = "BudgetCategory2",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 3,
                            BudgetID = 1,
                            CategoryID = 3,
                            CustomName = "BudgetCategory3",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 4,
                            BudgetID = 1,
                            CategoryID = 4,
                            CustomName = "BudgetCategory4",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 5,
                            BudgetID = 2,
                            CategoryID = 5,
                            CustomName = "BudgetCategory5",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 6,
                            BudgetID = 2,
                            CategoryID = 1,
                            CustomName = "BudgetCategory6",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 7,
                            BudgetID = 3,
                            CategoryID = 2,
                            CustomName = "BudgetCategory7",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 8,
                            BudgetID = 4,
                            CategoryID = 3,
                            CustomName = "BudgetCategory8",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 9,
                            BudgetID = 5,
                            CategoryID = 4,
                            CustomName = "BudgetCategory9",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 10,
                            BudgetID = 6,
                            CategoryID = 5,
                            CustomName = "BudgetCategory10",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 11,
                            BudgetID = 7,
                            CategoryID = 6,
                            CustomName = "BudgetCategory11",
                            MaxAmount = 10000
                        },
                        new
                        {
                            BudgetCategoryID = 12,
                            BudgetID = 8,
                            CategoryID = 6,
                            CustomName = "BudgetCategory12",
                            MaxAmount = 10000
                        });
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

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Food"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Fuel"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Clothes"
                        },
                        new
                        {
                            CategoryID = 4,
                            Name = "Furniture"
                        },
                        new
                        {
                            CategoryID = 5,
                            Name = "House"
                        },
                        new
                        {
                            CategoryID = 6,
                            Name = "NotHouse"
                        });
                });

            modelBuilder.Entity("DAL.Models.Change", b =>
                {
                    b.Property<int>("ChangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChangeID"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

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

                    b.HasData(
                        new
                        {
                            ChangeID = 1,
                            Amount = 11000,
                            BudgetCategoryID = 1,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4266),
                            Description = "test Description 1",
                            Title = "income test test1"
                        },
                        new
                        {
                            ChangeID = 2,
                            Amount = -2000,
                            BudgetCategoryID = 1,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4268),
                            Description = "test Description 1",
                            Title = "income test test2"
                        },
                        new
                        {
                            ChangeID = 3,
                            Amount = 30000,
                            BudgetCategoryID = 2,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4270),
                            Description = "test Description 1",
                            Title = "income test test3"
                        },
                        new
                        {
                            ChangeID = 4,
                            Amount = -1000,
                            BudgetCategoryID = 2,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4272),
                            Description = "test Description 1",
                            Title = "income test test4"
                        },
                        new
                        {
                            ChangeID = 5,
                            Amount = -2000,
                            BudgetCategoryID = 3,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4273),
                            Description = "test Description 1",
                            Title = "income test test5"
                        },
                        new
                        {
                            ChangeID = 6,
                            Amount = -3000,
                            BudgetCategoryID = 4,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4274),
                            Description = "test Description 1",
                            Title = "income test test6"
                        },
                        new
                        {
                            ChangeID = 7,
                            Amount = -3000,
                            BudgetCategoryID = 5,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4276),
                            Description = "test Description 1",
                            Title = "income test test7"
                        },
                        new
                        {
                            ChangeID = 8,
                            Amount = -3000,
                            BudgetCategoryID = 6,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4277),
                            Description = "test Description 1",
                            Title = "income test test8"
                        },
                        new
                        {
                            ChangeID = 9,
                            Amount = -3000,
                            BudgetCategoryID = 7,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4278),
                            Description = "test Description 1",
                            Title = "income test test9"
                        },
                        new
                        {
                            ChangeID = 10,
                            Amount = -3000,
                            BudgetCategoryID = 8,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4280),
                            Description = "test Description 1",
                            Title = "income test test10"
                        },
                        new
                        {
                            ChangeID = 11,
                            Amount = -3000,
                            BudgetCategoryID = 3,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4281),
                            Description = "test Description 1",
                            Title = "income test test11"
                        },
                        new
                        {
                            ChangeID = 12,
                            Amount = -3000,
                            BudgetCategoryID = 3,
                            Date = new DateTime(2022, 10, 3, 14, 8, 44, 894, DateTimeKind.Local).AddTicks(4282),
                            Description = "test Description 1",
                            Title = "income test test12"
                        });
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
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

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

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "Adam@gmail.com",
                            Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==",
                            Username = "Adam"
                        },
                        new
                        {
                            UserID = 2,
                            Email = "Kim@gmail.com",
                            Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==",
                            Username = "Kim"
                        },
                        new
                        {
                            UserID = 3,
                            Email = "Omar@gmail.com",
                            Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==",
                            Username = "Omar"
                        },
                        new
                        {
                            UserID = 4,
                            Email = "Ahmad@gmail.com",
                            Password = "0XepCVJtI65/eqjMxKR9s/4l0ENjank3fVdkrXghTC0=@TPS8UlUWVKfcpQuE1jXDOg==",
                            Username = "Ahmad"
                        });
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