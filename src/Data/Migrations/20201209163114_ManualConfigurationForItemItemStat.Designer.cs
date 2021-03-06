﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pd2TradeApi.Server.Data;

namespace Pd2TradeApi.Server.Data.Migrations
{
    [DbContext(typeof(Pd2TradeApiDbContext))]
    [Migration("20201209163114_ManualConfigurationForItemItemStat")]
    partial class ManualConfigurationForItemItemStat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ItemStatRuneword", b =>
                {
                    b.Property<long>("ItemStatsId")
                        .HasColumnType("bigint");

                    b.Property<long>("RunewordsId")
                        .HasColumnType("bigint");

                    b.HasKey("ItemStatsId", "RunewordsId");

                    b.HasIndex("RunewordsId");

                    b.ToTable("ItemStatRuneword");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserToken");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.Item", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Category")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool?>("Corrupted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Defence")
                        .HasColumnType("int");

                    b.Property<int?>("DexterityRequirement")
                        .HasColumnType("int");

                    b.Property<int?>("Durability")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool?>("IsCurrency")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool?>("IsSearchable")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ItemLevel")
                        .HasColumnType("int");

                    b.Property<int?>("LevelRequirement")
                        .HasColumnType("int");

                    b.Property<int?>("MaxDamage")
                        .HasColumnType("int");

                    b.Property<int?>("MaxDurability")
                        .HasColumnType("int");

                    b.Property<int?>("MinDamage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("RuneRarity")
                        .HasColumnType("int");

                    b.Property<long?>("RunewordId")
                        .HasColumnType("bigint");

                    b.Property<int?>("StrengthRequirement")
                        .HasColumnType("int");

                    b.Property<string>("SubCategory")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("TotalSockets")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("RunewordId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemItemStat", b =>
                {
                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long>("ItemStatId")
                        .HasColumnType("bigint");

                    b.HasKey("ItemId", "ItemStatId");

                    b.HasIndex("ItemStatId");

                    b.ToTable("ItemItemStat");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemSocket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemSocket");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemStat", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<float?>("MaxValue")
                        .HasColumnType("float");

                    b.Property<float?>("MinValue")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Skill")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("ItemStat");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemStatTradeOffer", b =>
                {
                    b.Property<long>("TradeOfferId")
                        .HasColumnType("bigint");

                    b.Property<long>("ItemStatId")
                        .HasColumnType("bigint");

                    b.Property<float>("Value")
                        .HasColumnType("float");

                    b.HasKey("TradeOfferId", "ItemStatId");

                    b.HasIndex("ItemStatId");

                    b.ToTable("ItemStatTradeOffer");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.Runeword", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("SocketsNeeded")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Runeword");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.Season", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Number")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Season");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.TradeOffer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("AccountName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float?>("Cost")
                        .HasColumnType("float");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long?>("OfferedItemId")
                        .HasColumnType("bigint");

                    b.Property<long>("PosterId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<long?>("WantedItemId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OfferedItemId");

                    b.HasIndex("PosterId");

                    b.HasIndex("WantedItemId");

                    b.ToTable("TradeOffer");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AccountName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ItemStatRuneword", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.ItemStat", null)
                        .WithMany()
                        .HasForeignKey("ItemStatsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.Runeword", null)
                        .WithMany()
                        .HasForeignKey("RunewordsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pd2TradeApi.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.Item", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.Runeword", "Runeword")
                        .WithMany()
                        .HasForeignKey("RunewordId");

                    b.Navigation("Runeword");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemItemStat", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.Item", "Item")
                        .WithMany("ItemStats")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.ItemStat", "ItemStat")
                        .WithMany("Items")
                        .HasForeignKey("ItemStatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("ItemStat");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemSocket", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.Item", "Item")
                        .WithMany("Sockets")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemStatTradeOffer", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.ItemStat", "ItemStat")
                        .WithMany("TradeOffers")
                        .HasForeignKey("ItemStatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.TradeOffer", "TradeOffer")
                        .WithMany("ItemStats")
                        .HasForeignKey("TradeOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ItemStat");

                    b.Navigation("TradeOffer");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.TradeOffer", b =>
                {
                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.Item", "OfferedItem")
                        .WithMany()
                        .HasForeignKey("OfferedItemId");

                    b.HasOne("Pd2TradeApi.Server.Models.User", "Poster")
                        .WithMany("Offers")
                        .HasForeignKey("PosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pd2TradeApi.Server.Models.DatabaseModels.Item", "WantedItem")
                        .WithMany()
                        .HasForeignKey("WantedItemId");

                    b.Navigation("OfferedItem");

                    b.Navigation("Poster");

                    b.Navigation("WantedItem");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.Item", b =>
                {
                    b.Navigation("ItemStats");

                    b.Navigation("Sockets");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.ItemStat", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("TradeOffers");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.DatabaseModels.TradeOffer", b =>
                {
                    b.Navigation("ItemStats");
                });

            modelBuilder.Entity("Pd2TradeApi.Server.Models.User", b =>
                {
                    b.Navigation("Offers");
                });
#pragma warning restore 612, 618
        }
    }
}
