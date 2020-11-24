﻿// <auto-generated />
using System;
using ForceT.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ForceT.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191223200440_iden")]
    partial class iden
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ForceT.Server.Data.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("ForceT.Server.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ForceT.Server.Data.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Adresse", b =>
                {
                    b.Property<int>("AdresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Agenceid")
                        .HasColumnType("int");

                    b.Property<int>("Codepostale")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Societé")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresseId");

                    b.ToTable("Adresse");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Agence", b =>
                {
                    b.Property<int>("AgenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libellé")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AgenceId");

                    b.ToTable("Agence");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adressenlevement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adresslivraison")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Sondage", b =>
                {
                    b.Property<int>("SondageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Libellé")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Obligatoire")
                        .HasColumnType("bit");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Statut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SondageId");

                    b.ToTable("Sondage");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Tournee", b =>
                {
                    b.Property<int>("TourneeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Agenceid")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_tournee")
                        .HasColumnType("datetime2");

                    b.Property<string>("Libellé")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LivreurId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehiculeId")
                        .HasColumnType("int");

                    b.HasKey("TourneeId");

                    b.ToTable("Tournee");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Vehicule", b =>
                {
                    b.Property<int>("VehiculeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Matriculation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Poid")
                        .HasColumnType("int");

                    b.HasKey("VehiculeId");

                    b.ToTable("Vehicule");
                });

            modelBuilder.Entity("ForceT.Shared.Models.Zone", b =>
                {
                    b.Property<int>("zoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("codepostal")
                        .HasColumnType("int");

                    b.Property<string>("ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("zoneId");

                    b.ToTable("Zone");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "6ecb5ea3-bc2c-4104-9039-e6cdfa90cb8b",
                            ConcurrencyStamp = "5ca21059-f849-4b21-8520-441a7690117f",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "3f69bebd-4203-4b0f-962f-1eccdc163074",
                            ConcurrencyStamp = "d17b65a8-a19a-4d0c-b498-ed0debc76802",
                            Name = "VehiculeCreat",
                            NormalizedName = "VehiculeCreat"
                        },
                        new
                        {
                            Id = "5a21b337-54df-44af-b76d-36a89a0b1203",
                            ConcurrencyStamp = "19f3e9a3-0936-4518-b907-0e2180def9db",
                            Name = "VehiculeRead",
                            NormalizedName = "VehiculeRead"
                        },
                        new
                        {
                            Id = "a8614a1f-55cf-4b2d-9d74-6da7af8e988a",
                            ConcurrencyStamp = "6369c1a5-fc8f-4228-b816-9c2eba451574",
                            Name = "VehiculeUpdt",
                            NormalizedName = "VehiculeUpdt"
                        },
                        new
                        {
                            Id = "d171c020-2e65-43c8-9bd2-351c90c9f906",
                            ConcurrencyStamp = "716eea5e-b985-4be8-a5fd-329c07eb8ef0",
                            Name = "VehiculeDlet",
                            NormalizedName = "VehiculeDlet"
                        },
                        new
                        {
                            Id = "3c03b439-7316-48e7-8865-3f261c075a72",
                            ConcurrencyStamp = "3f16b1de-5b05-4d50-9661-d8e64fa3689a",
                            Name = "SondageCreat",
                            NormalizedName = "SondageCreat"
                        },
                        new
                        {
                            Id = "3e757a24-33f0-4754-9cbe-e78e3923ccf0",
                            ConcurrencyStamp = "e057e051-7e9c-46e5-bbb3-5e7f40764410",
                            Name = "SondageRead",
                            NormalizedName = "SondageRead"
                        },
                        new
                        {
                            Id = "3c29eb8a-5fec-463a-8f71-5f7a753afec1",
                            ConcurrencyStamp = "a57d7bab-c026-4f7b-a1ce-abde18d0b283",
                            Name = "SondageUpdt",
                            NormalizedName = "SondageUpdt"
                        },
                        new
                        {
                            Id = "11b03500-7f50-4e9c-b489-7b7475f8df62",
                            ConcurrencyStamp = "7f568a63-aba6-4079-9205-885bc98449a6",
                            Name = "SondageDlet",
                            NormalizedName = "SondageDlet"
                        },
                        new
                        {
                            Id = "ea0caa4b-3b40-46ac-9ff9-eb81b5e4d455",
                            ConcurrencyStamp = "aac302ab-e5d4-480c-8e73-9ee2e39f2fc7",
                            Name = "ZoneCreat",
                            NormalizedName = "ZoneCreat"
                        },
                        new
                        {
                            Id = "0387338c-c618-49bd-ac3f-552b70fd0790",
                            ConcurrencyStamp = "53fdb4d1-841b-4474-a3d9-dd015cd4331f",
                            Name = "ZoneRead",
                            NormalizedName = "ZoneRead"
                        },
                        new
                        {
                            Id = "0539982b-449a-42a5-ba85-340b1a46dca4",
                            ConcurrencyStamp = "58d10ec1-ae04-4887-b674-b72d06485079",
                            Name = "ZoneUpdt",
                            NormalizedName = "ZoneUpdt"
                        },
                        new
                        {
                            Id = "2a88db49-2931-41f3-b03b-8124420de987",
                            ConcurrencyStamp = "ac5ff6ff-48ca-4694-bf46-cbf596a078cb",
                            Name = "ZoneDlet",
                            NormalizedName = "ZoneDlet"
                        },
                        new
                        {
                            Id = "d42ad489-13cc-44a5-ad14-2ea980f26e52",
                            ConcurrencyStamp = "54d86890-79e2-4ab9-bda3-6a4a2e67ac5d",
                            Name = "AgenceCreat",
                            NormalizedName = "AgenceCreat"
                        },
                        new
                        {
                            Id = "7e52f5ce-056e-4963-bbea-9e85abfdf140",
                            ConcurrencyStamp = "c5466864-77d4-4f62-bcbd-672e9db6b021",
                            Name = "AgenceRead",
                            NormalizedName = "AgenceRead"
                        },
                        new
                        {
                            Id = "3c299db1-2c54-4a6d-a5b8-968f7ea1b017",
                            ConcurrencyStamp = "3c21cc10-1f80-48ae-aa00-45bb2a5463bd",
                            Name = "AgenceUpdt",
                            NormalizedName = "AgenceUpdt"
                        },
                        new
                        {
                            Id = "35cd68f3-7fbe-43e6-9681-4f356e9a5f45",
                            ConcurrencyStamp = "0e539161-c3dd-4473-951d-5e778274f392",
                            Name = "AgenceDlet",
                            NormalizedName = "AgenceDlet"
                        },
                        new
                        {
                            Id = "605db567-0072-4fae-b32e-37192aa57dbf",
                            ConcurrencyStamp = "54fd8058-9129-405e-a9cb-e7f97162aead",
                            Name = "AdresseCreat",
                            NormalizedName = "AdresseCreat"
                        },
                        new
                        {
                            Id = "6b301ee8-22d8-4890-a2d0-00fe41a882df",
                            ConcurrencyStamp = "25176a29-748e-45aa-807e-ab9bb1def50b",
                            Name = "AdresseRead",
                            NormalizedName = "AdresseRead"
                        },
                        new
                        {
                            Id = "a80aabae-8bc0-47f4-b06b-f092bb439071",
                            ConcurrencyStamp = "a4360e7a-a578-4af7-a305-df20726eef14",
                            Name = "AdresseUpdt",
                            NormalizedName = "AdresseUpdt"
                        },
                        new
                        {
                            Id = "67384571-5cb6-46bc-87a0-6e38b9379893",
                            ConcurrencyStamp = "21bcd5e9-02d0-4136-ad33-773dd71b130e",
                            Name = "AdresseDlet",
                            NormalizedName = "AdresseDlet"
                        },
                        new
                        {
                            Id = "5a242a31-76c8-4ed4-91b3-55f9fc4a3800",
                            ConcurrencyStamp = "86efcd0d-7d41-4a88-8c5d-30ead472dee5",
                            Name = "CourseCreat",
                            NormalizedName = "CourseCreat"
                        },
                        new
                        {
                            Id = "ed636012-715c-4cfa-8f8e-39aa66c41628",
                            ConcurrencyStamp = "df4057fe-a956-4019-8199-b3cbf31c0e14",
                            Name = "CourseRead",
                            NormalizedName = "CourseRead"
                        },
                        new
                        {
                            Id = "b3cb1cd9-4e07-4031-8d6d-99871ed3fcdd",
                            ConcurrencyStamp = "1784cdca-8288-45df-9942-c27b60487b5e",
                            Name = "CourseUpdt",
                            NormalizedName = "CourseUpdt"
                        },
                        new
                        {
                            Id = "4708784e-83e1-4436-9657-c54bd82456f7",
                            ConcurrencyStamp = "418c1a02-ad97-4d73-9720-edeaf11928e9",
                            Name = "CourseDlet",
                            NormalizedName = "CourseDlet"
                        },
                        new
                        {
                            Id = "b36590f6-15de-424c-90bb-445843f461aa",
                            ConcurrencyStamp = "6d82d3bb-fd3e-4b0e-b2f8-53cf5207706b",
                            Name = "TourneeCreat",
                            NormalizedName = "TourneeCreat"
                        },
                        new
                        {
                            Id = "0ad4642f-b9cb-4984-8711-ccd12eae39ea",
                            ConcurrencyStamp = "3c26426b-2d0d-4580-9a64-d2a47d199926",
                            Name = "TourneeRead",
                            NormalizedName = "TourneeRead"
                        },
                        new
                        {
                            Id = "ef014bd2-48d9-4d1c-b979-5408c7b1f1b9",
                            ConcurrencyStamp = "2d7092e7-0a52-4f2f-93fa-fb17e2785048",
                            Name = "TourneeUpdt",
                            NormalizedName = "TourneeUpdt"
                        },
                        new
                        {
                            Id = "ac5d9389-c11b-46c9-b6c4-ec278128fb8c",
                            ConcurrencyStamp = "bbb16680-ac5a-4d86-bd5b-1cd80af6e4fe",
                            Name = "TourneeDlet",
                            NormalizedName = "TourneeDlet"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");

                    b.HasData(
                        new
                        {
                            Id = "43592427-a291-46be-8cf9-a89314b496dc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cd4ca31c-cb33-4125-a9d4-4264a6605768",
                            Email = "admin@forcetracking.com",
                            EmailConfirmed = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@FORCETRACKING.COM",
                            NormalizedUserName = "ADMINISTRATEUR",
                            PasswordHash = "AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==",
                            PhoneNumber = "",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL",
                            TwoFactorEnabled = false,
                            UserName = "administrateur"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ForceT.Server.Data.ApplicationUserRole", b =>
                {
                    b.HasOne("ForceT.Server.Data.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForceT.Server.Data.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("ForceT.Server.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ForceT.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ForceT.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ForceT.Server.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
