﻿// <auto-generated />
using System;
using AccountingApp.DB.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AccountingApp.DB.Migrations
{
    [DbContext(typeof(AccountingContext))]
    partial class AccountingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AccountingApp.DB.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Balance")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Account", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 1500.50m,
                            Name = "Savings Account",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Balance = 250.00m,
                            Name = "Checking Account",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Balance = 5000.00m,
                            Name = "Investment Account",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Balance = 1000.00m,
                            Name = "Emergency Fund",
                            UserId = 3
                        },
                        new
                        {
                            Id = 5,
                            Balance = 300.00m,
                            Name = "Travel Fund",
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            Balance = 2000.00m,
                            Name = "Education Fund",
                            UserId = 4
                        },
                        new
                        {
                            Id = 7,
                            Balance = 400.00m,
                            Name = "Holiday Fund",
                            UserId = 5
                        },
                        new
                        {
                            Id = 8,
                            Balance = 10000.00m,
                            Name = "Retirement Fund",
                            UserId = 6
                        },
                        new
                        {
                            Id = 9,
                            Balance = 1200.00m,
                            Name = "Health Savings",
                            UserId = 7
                        });
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TransactionDetailId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Groceries",
                            TransactionDetailId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Utilities",
                            TransactionDetailId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Rent",
                            TransactionDetailId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Entertainment",
                            TransactionDetailId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Transportation",
                            TransactionDetailId = 5
                        },
                        new
                        {
                            Id = 6,
                            Name = "Healthcare",
                            TransactionDetailId = 6
                        },
                        new
                        {
                            Id = 7,
                            Name = "Education",
                            TransactionDetailId = 7
                        },
                        new
                        {
                            Id = 8,
                            Name = "Savings",
                            TransactionDetailId = 8
                        },
                        new
                        {
                            Id = 9,
                            Name = "Travel",
                            TransactionDetailId = 9
                        });
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp");

                    b.Property<int>("TransactionId")
                        .HasColumnType("integer");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TransactionId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Detail", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = -150.00m,
                            CategoryId = 1,
                            Note = "Grocery shopping",
                            TransactionDate = new DateTime(2024, 11, 10, 17, 27, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = -75.50m,
                            CategoryId = 2,
                            Note = "Electricity bill payment",
                            TransactionDate = new DateTime(2024, 2, 19, 8, 8, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 2000.00m,
                            CategoryId = 3,
                            Note = "January salary",
                            TransactionDate = new DateTime(2024, 3, 9, 0, 40, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 3,
                            TransactionTypeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Amount = -300.00m,
                            CategoryId = 4,
                            Note = "Car loan payment",
                            TransactionDate = new DateTime(2024, 7, 10, 14, 12, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 4,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Amount = -50.00m,
                            CategoryId = 5,
                            Note = "Internet subscription",
                            TransactionDate = new DateTime(2024, 7, 26, 12, 17, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 5,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Amount = -1200.00m,
                            CategoryId = 6,
                            Note = "Gym membership annual fee",
                            TransactionDate = new DateTime(2024, 1, 27, 18, 53, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 6,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            Id = 7,
                            Amount = -15.99m,
                            CategoryId = 7,
                            Note = "Netflix subscription fee",
                            TransactionDate = new DateTime(2024, 11, 9, 9, 22, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 7,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            Amount = -100.00m,
                            CategoryId = 8,
                            Note = "Charity donation",
                            TransactionDate = new DateTime(2024, 10, 22, 1, 46, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 8,
                            TransactionTypeId = 9
                        },
                        new
                        {
                            Id = 9,
                            Amount = -800.00m,
                            CategoryId = 9,
                            Note = "January house rent",
                            TransactionDate = new DateTime(2024, 10, 24, 16, 14, 0, 0, DateTimeKind.Unspecified),
                            TransactionId = 9,
                            TransactionTypeId = 2
                        });
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Repetition")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SetDate")
                        .HasColumnType("timestamp");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Transaction", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            Name = "Groceries",
                            Repetition = 0,
                            SetDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            EndDate = new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Electricity Bill",
                            Repetition = 3,
                            SetDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 3,
                            EndDate = new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Salary",
                            Repetition = 3,
                            SetDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            AccountId = 4,
                            EndDate = new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Car Loan",
                            Repetition = 2,
                            SetDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            AccountId = 5,
                            EndDate = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Internet Subscription",
                            Repetition = 3,
                            SetDate = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            AccountId = 6,
                            EndDate = new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gym Membership",
                            Repetition = 4,
                            SetDate = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            AccountId = 7,
                            EndDate = new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Netflix Subscription",
                            Repetition = 3,
                            SetDate = new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            AccountId = 8,
                            Name = "Donation",
                            Repetition = 0,
                            SetDate = new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            AccountId = 9,
                            EndDate = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "House Rent",
                            Repetition = 3,
                            SetDate = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TransactionType", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "One-Time Payment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Monthly Payment"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Savings for payment"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Travel"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Wedding"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Education"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Kids"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Gifts"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Entertainment"
                        });
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "user1@example.com",
                            IsActive = true,
                            Password = "password1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@example.com",
                            IsActive = true,
                            Password = "password2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "user3@example.com",
                            IsActive = false,
                            Password = "password3"
                        },
                        new
                        {
                            Id = 4,
                            Email = "user4@example.com",
                            IsActive = true,
                            Password = "password4"
                        },
                        new
                        {
                            Id = 5,
                            Email = "user5@example.com",
                            IsActive = false,
                            Password = "password5"
                        },
                        new
                        {
                            Id = 6,
                            Email = "user6@example.com",
                            IsActive = true,
                            Password = "password6"
                        },
                        new
                        {
                            Id = 7,
                            Email = "user7@example.com",
                            IsActive = true,
                            Password = "password7"
                        },
                        new
                        {
                            Id = 8,
                            Email = "user8@example.com",
                            IsActive = true,
                            Password = "password8"
                        },
                        new
                        {
                            Id = 9,
                            Email = "user9@example.com",
                            IsActive = false,
                            Password = "password9"
                        });
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Account", b =>
                {
                    b.HasOne("AccountingApp.DB.Entities.User", "User")
                        .WithMany("Accounts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Detail", b =>
                {
                    b.HasOne("AccountingApp.DB.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountingApp.DB.Entities.Transaction", "Transaction")
                        .WithMany("Details")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountingApp.DB.Entities.TransactionType", "TransactionType")
                        .WithMany("Details")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Transaction");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Transaction", b =>
                {
                    b.HasOne("AccountingApp.DB.Entities.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.Transaction", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.TransactionType", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("AccountingApp.DB.Entities.User", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
