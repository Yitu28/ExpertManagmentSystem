﻿// <auto-generated />
using System;
using ExpertManagmentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpertManagmentSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("ExpertUserMngt")
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExpertManagmentSystem.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentCategory")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Full_Name")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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

                    b.Property<Guid>("UserDepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("UserParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.Models.CrimeModels.Cr_Crime_Type", b =>
                {
                    b.Property<Guid>("Cr_Crime_TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CrimeTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cr_Crime_TypeId");

                    b.ToTable("Cr_Crime_Types", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.Models.CrimeModels.Cr_Decided_Judicial_and_Prosecuter", b =>
                {
                    b.Property<Guid>("Cr_Decided_Judicial_and_ProsecuterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Applicant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Court_No")
                        .HasColumnType("int");

                    b.Property<Guid>("Cr_Crime_TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CrimeType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FederalBreakingRequest")
                        .HasColumnType("int");

                    b.Property<int>("FileEndResult")
                        .HasColumnType("int");

                    b.Property<int>("FileStatus")
                        .HasColumnType("int");

                    b.Property<int>("HighCourtDecission")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfFemaleAppellants")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfMaleAppellants")
                        .HasColumnType("int");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherCourtDecition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProsecutorComment")
                        .HasColumnType("int");

                    b.Property<int>("ProsocuterNo")
                        .HasColumnType("int");

                    b.Property<string>("Respondant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SectrorsDepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WhoJudgeCommentedOnDecision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoLawyeCommented")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cr_Decided_Judicial_and_ProsecuterId");

                    b.HasIndex("Cr_Crime_TypeId");

                    b.HasIndex("SectrorsDepartmentId");

                    b.ToTable("Cr_Decided_Judicial_and_Prosecuters", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.Models.CrimeModels.Cr_JudicalAppealDirectCharege", b =>
                {
                    b.Property<Guid>("Cr_JudicalAppealDirectCharegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Applicant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Court_No")
                        .HasColumnType("int");

                    b.Property<Guid>("Cr_Crime_TypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CrimeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfAppointment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_of_Administration")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_of_Returen")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Openinig_data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prosocuter_Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prosocuters_No")
                        .HasColumnType("int");

                    b.Property<string>("Respondent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Returen")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SectrorsDepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Worked_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cr_JudicalAppealDirectCharegeId");

                    b.HasIndex("Cr_Crime_TypeId");

                    b.HasIndex("SectrorsDepartmentId");

                    b.ToTable("Cr_JudicalAppealDirectChareges", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.ReginalSector", b =>
                {
                    b.Property<Guid>("ReginalSectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReginalSectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReginalSectorId");

                    b.ToTable("ReginaslSector", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.SectrorsDepartment", b =>
                {
                    b.Property<Guid>("SectrorsDepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DepartmentCategory")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DepartmentParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SectrorsDepartmentId");

                    b.ToTable("SectrorsDepartment", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.WoredaSectors", b =>
                {
                    b.Property<Guid>("WoredaSectorsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WoredaSectorsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZonalSectorsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("WoredaSectorsId");

                    b.HasIndex("ZonalSectorsId");

                    b.ToTable("WoredaSectors", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.ZonalSectors", b =>
                {
                    b.Property<Guid>("ZonalSectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReginalSectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ZonalSectorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZonalSectorId");

                    b.HasIndex("ReginalSectorId");

                    b.ToTable("ZonalSectors", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.ViewModels.SectorDepartmentViewModels", b =>
                {
                    b.Property<int>("DepartmentCategory")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DepartmentParentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReginalSectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReginalSectorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SectrorsDepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WoredaSectorsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WoredaSectorsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZonalSectorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ZonalSectorName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("SectorDepartmentViewModels", "ExpertUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.ToTable("Roles", "ExpertUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "ExpertUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "ExpertUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "ExpertUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "ExpertUserMngt");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "ExpertUserMngt");
                });

            modelBuilder.Entity("ExpertManagmentSystem.Models.CrimeModels.Cr_Decided_Judicial_and_Prosecuter", b =>
                {
                    b.HasOne("ExpertManagmentSystem.Models.CrimeModels.Cr_Crime_Type", "Cr_Crime_Type")
                        .WithMany("Cr_Decided_Judicial_and_Prosecuters")
                        .HasForeignKey("Cr_Crime_TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpertManagmentSystem.OrganizationalStructures.SectrorsDepartment", "SectrorsDepartment")
                        .WithMany()
                        .HasForeignKey("SectrorsDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cr_Crime_Type");

                    b.Navigation("SectrorsDepartment");
                });

            modelBuilder.Entity("ExpertManagmentSystem.Models.CrimeModels.Cr_JudicalAppealDirectCharege", b =>
                {
                    b.HasOne("ExpertManagmentSystem.Models.CrimeModels.Cr_Crime_Type", "Cr_Crime_Type")
                        .WithMany("Cr_JudicalAppealDirectChareges")
                        .HasForeignKey("Cr_Crime_TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpertManagmentSystem.OrganizationalStructures.SectrorsDepartment", "SectrorsDepartment")
                        .WithMany()
                        .HasForeignKey("SectrorsDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cr_Crime_Type");

                    b.Navigation("SectrorsDepartment");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.WoredaSectors", b =>
                {
                    b.HasOne("ExpertManagmentSystem.OrganizationalStructures.ZonalSectors", "ZonalSectors")
                        .WithMany()
                        .HasForeignKey("ZonalSectorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZonalSectors");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.ZonalSectors", b =>
                {
                    b.HasOne("ExpertManagmentSystem.OrganizationalStructures.ReginalSector", "ReginalSector")
                        .WithMany("ZonalSectors")
                        .HasForeignKey("ReginalSectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReginalSector");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ExpertManagmentSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExpertManagmentSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpertManagmentSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExpertManagmentSystem.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExpertManagmentSystem.Models.CrimeModels.Cr_Crime_Type", b =>
                {
                    b.Navigation("Cr_Decided_Judicial_and_Prosecuters");

                    b.Navigation("Cr_JudicalAppealDirectChareges");
                });

            modelBuilder.Entity("ExpertManagmentSystem.OrganizationalStructures.ReginalSector", b =>
                {
                    b.Navigation("ZonalSectors");
                });
#pragma warning restore 612, 618
        }
    }
}
