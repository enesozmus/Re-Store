﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReStore.Infrastructure.Contexts;

#nullable disable

namespace ReStore.Infrastructure.Migrations
{
    [DbContext(typeof(ReStoreContext))]
    partial class ReStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 4,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 5,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 6,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 7,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 8,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 9,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 10,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ReStore.Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "18c9dad4-ba82-4d82-bdc3-e2dfcc078500",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "c2f7f56c-1b35-4c62-b5a3-7b9d9e408bd9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("ReStore.Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a0487000-ed21-4977-a106-1b1d330405df",
                            Email = "enes@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Enes",
                            LastName = "Ozmus",
                            LockoutEnabled = false,
                            NormalizedEmail = " ENES@SEEDDATA.COM",
                            NormalizedUserName = "ENESOZMUS",
                            PasswordHash = "AQAAAAEAACcQAAAAELkXU9LRxHIdRw99dte9JNwyCLxXCH3cp303UHrH8027BiKHlzVb3TaRIaV5hoxv0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b38d83ed-2e6b-4682-a175-ce54eef1df61",
                            TwoFactorEnabled = false,
                            UserName = "enesozmus"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb38bcb2-5730-4a33-a58a-8950a5e0bd14",
                            Email = "umay@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Umay",
                            LastName = "Zengin",
                            LockoutEnabled = false,
                            NormalizedEmail = "UMAY@SEEDDATA.COM",
                            NormalizedUserName = "UMAYZENGIN",
                            PasswordHash = "AQAAAAEAACcQAAAAECAKrJawpmqiz7HZFJ7a3/CWi95u4YXhDrCs1Nr+lIxWPmJJsauLwOM3oEwgSGj0gw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c41c01d-020c-4b48-8a5d-ef155607930c",
                            TwoFactorEnabled = false,
                            UserName = "umayzengin"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db99904a-53a2-40f4-aa0e-9b650a0add26",
                            Email = "selim@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Selim",
                            LastName = "Karaca",
                            LockoutEnabled = false,
                            NormalizedEmail = "SELIM@SEEDDATA.COM",
                            NormalizedUserName = "SELIMKARACA",
                            PasswordHash = "AQAAAAEAACcQAAAAEAVulKLitTcBpCipwqdkxYYHY6dMqOfWSWaiF6XMLpvFOQhmWP2Y1Lf1axglUrVCiA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aba74e05-26d4-447f-bffa-6a4bef505830",
                            TwoFactorEnabled = false,
                            UserName = "selimkaraca"
                        },
                        new
                        {
                            Id = 4,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3445f163-93ef-4318-a0ed-3a851f0fdc9e",
                            Email = "emine@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Emine",
                            LastName = "Yıldırım",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMINE@SEEDDATA.COM",
                            NormalizedUserName = "EMINEYILDIRIM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP35wDP/sGNFAxAuf1xvD3StK5CvVzaeG12QRpJut+MDWuJtHDQuxRr9ctIY7Gh2cg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e0b4dddc-d6dd-45b8-954b-1a20cbe7bbe9",
                            TwoFactorEnabled = false,
                            UserName = "emineyıldırım"
                        },
                        new
                        {
                            Id = 5,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ab02033a-af14-4370-b033-f717a6d70dcb",
                            Email = "ihsan@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "İhsan",
                            LastName = "Yenilmez",
                            LockoutEnabled = false,
                            NormalizedEmail = "IHSAN@SEEDDATA.COM",
                            NormalizedUserName = "IHSANYENILMEZ",
                            PasswordHash = "AQAAAAEAACcQAAAAEIussoruUXhsLfiBkiSGTDZnx+DWd1/RECk2ZkpO/4OLOgDbDKKselmsmCR2xieeMg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8fe9e7fa-b3c5-4408-a4a0-e941e9469524",
                            TwoFactorEnabled = false,
                            UserName = "ihsanyenilmez"
                        },
                        new
                        {
                            Id = 6,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bdc159b3-b1a1-4f1a-88a1-27837c9bd0f2",
                            Email = "berrin@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Berrin",
                            LastName = "Miral",
                            LockoutEnabled = false,
                            NormalizedEmail = "BERRIN@SEEDDATA.COM",
                            NormalizedUserName = "BERRINMIRAL",
                            PasswordHash = "AQAAAAEAACcQAAAAEAREYRvPL9aTY3vlVpP+XooipLkteK4p2islfdC9+lhReESGuHa4ezvKkdZUONSmuQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0cd502f7-0f5e-4efd-87ce-767e9667bca0",
                            TwoFactorEnabled = false,
                            UserName = "berrinmiral"
                        },
                        new
                        {
                            Id = 7,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c27d3b13-a67f-42c5-9825-1c088f1c8099",
                            Email = "salih@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Salih",
                            LastName = "Yurdakul",
                            LockoutEnabled = false,
                            NormalizedEmail = "SALIH@SEEDDATA.COM",
                            NormalizedUserName = "SALIHYURDAKUL",
                            PasswordHash = "AQAAAAEAACcQAAAAEIxw68VR/cfiHseCAmtnQuT+fSIylDago0K+lepTwtT0HUuamjt5Rz08AYn+bzQMXw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "07e0f1ea-2bac-4e8d-8036-2d3c3fd1f6eb",
                            TwoFactorEnabled = false,
                            UserName = "salihyurdakul"
                        },
                        new
                        {
                            Id = 8,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "232f24f9-c4ad-4700-8535-dff33ca2c260",
                            Email = "zafer@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Zafer",
                            LastName = "Kırat",
                            LockoutEnabled = false,
                            NormalizedEmail = "ZAFER@SEEDDATA.COM",
                            NormalizedUserName = "ZAFERKIRAT",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNrPqVZF5vxDCiXs97NdpUSUOuuF+P6ebBN5ad5ivt3Z3HRl+NWsvHeCaK5rHMvxQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4e718de4-e9eb-4fdf-8224-be08de359f4c",
                            TwoFactorEnabled = false,
                            UserName = "zaferkırat"
                        },
                        new
                        {
                            Id = 9,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "48329fe5-dc7c-40f4-9fd5-ce96874f4ddd",
                            Email = "emre@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Emre",
                            LastName = "Demir",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMRE@SEEDDATA.COM",
                            NormalizedUserName = "EMREDEMIR",
                            PasswordHash = "AQAAAAEAACcQAAAAEAKUlL3vI7kgKGKcapfBx9xz2DEt7MxfVaKKX8F9xWc+ws0u88LghCHibKxLQO5dsw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8d9f19da-1e2f-4171-b0d2-e6d6349d2703",
                            TwoFactorEnabled = false,
                            UserName = "emredemir"
                        },
                        new
                        {
                            Id = 10,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a20e84c-b1c3-4b39-95cd-c27ee8b57cfc",
                            Email = "hakan@seeddata.com",
                            EmailConfirmed = true,
                            FirstName = "Hakan",
                            LastName = "Filiz",
                            LockoutEnabled = false,
                            NormalizedEmail = "HAKAN@SEEDDATA.COM",
                            NormalizedUserName = "HAKANFILIZ",
                            PasswordHash = "AQAAAAEAACcQAAAAEKCewsOJJwMNoqtcqgZtIIJxAiUGRlca24/GiiSw+F9QPoT27DEPb5TaVPXbnVJfrw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "12192024-014d-4f61-8991-4f3a01b9a3ba",
                            TwoFactorEnabled = false,
                            UserName = "hakanfiliz"
                        });
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReStore.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReStore.Domain.Entities.BasketItem", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.Basket", "Basket")
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReStore.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Product", b =>
                {
                    b.HasOne("ReStore.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ReStore.Domain.Entities.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Category");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Basket", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ReStore.Domain.Entities.Color", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
