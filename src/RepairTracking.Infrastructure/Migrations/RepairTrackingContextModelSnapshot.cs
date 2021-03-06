﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepairTracking.Infrastructure.Data;

namespace RepairTracking.Infrastructure.Migrations
{
    [DbContext(typeof(RepairTrackingContext))]
    partial class RepairTrackingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Client", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressId");

                    b.Property<string>("Cellphone");

                    b.Property<string>("DocumentId");

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Lastname");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("DocumentId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Element", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Code");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Observations");

                    b.HasKey("Id");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Piece", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("ElementId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.ToTable("Pieces");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Repair", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<string>("ClientId");

                    b.Property<string>("Code");

                    b.Property<string>("ElementId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Observations");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ElementId");

                    b.ToTable("Repair");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Task", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("ElementId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.TaskCommon", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Observations");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("TaskGenerics");
                });

            modelBuilder.Entity("RepairTracking.Core.ValueObjects.Address", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Depto");

                    b.Property<int?>("Floor");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("Number");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("RepairTracking.Core.ValueObjects.Document", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<long>("Number");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("RepairTracking.Infrastructure.Security.RepairTrackingUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RepairTracking.Infrastructure.Security.RepairTrackingUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RepairTracking.Infrastructure.Security.RepairTrackingUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RepairTracking.Infrastructure.Security.RepairTrackingUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RepairTracking.Infrastructure.Security.RepairTrackingUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Client", b =>
                {
                    b.HasOne("RepairTracking.Core.ValueObjects.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("RepairTracking.Core.ValueObjects.Document", "Document")
                        .WithMany()
                        .HasForeignKey("DocumentId");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Piece", b =>
                {
                    b.HasOne("RepairTracking.Core.Entities.Element", "Element")
                        .WithMany("Pieces")
                        .HasForeignKey("ElementId");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Repair", b =>
                {
                    b.HasOne("RepairTracking.Core.Entities.Client")
                        .WithMany("Repairs")
                        .HasForeignKey("ClientId");

                    b.HasOne("RepairTracking.Core.Entities.Element", "Element")
                        .WithMany()
                        .HasForeignKey("ElementId");
                });

            modelBuilder.Entity("RepairTracking.Core.Entities.Task", b =>
                {
                    b.HasOne("RepairTracking.Core.Entities.Element", "Element")
                        .WithMany("Tasks")
                        .HasForeignKey("ElementId");
                });
#pragma warning restore 612, 618
        }
    }
}
