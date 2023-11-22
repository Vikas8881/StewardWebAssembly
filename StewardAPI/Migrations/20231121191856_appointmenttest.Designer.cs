﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StewardAPI.Data;

#nullable disable

namespace StewardAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231121191856_appointmenttest")]
    partial class appointmenttest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "de4ccc9c-2743-4c14-aa50-394d66c3b17b",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "86020c2c-5a21-4851-a1aa-e69711d77fb1",
                            RoleId = "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc"
                        },
                        new
                        {
                            UserId = "029a2a1b-34b1-4b37-bc52-2acc5686c59d",
                            RoleId = "de4ccc9c-2743-4c14-aa50-394d66c3b17b"
                        });
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Model.AppointmentModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppointmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("ElementType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBlock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecurrenceException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecurrenceID")
                        .HasColumnType("int");

                    b.Property<string>("RecurrenceRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Symptoms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hospitalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Model.CityList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CityList", (string)null);
                });

            modelBuilder.Entity("Model.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.Property<string>("hospitalID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Model.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Fees")
                        .HasColumnType("int");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.Property<string>("hospitalID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctor", (string)null);
                });

            modelBuilder.Entity("Model.GenAdvice", b =>
                {
                    b.Property<int>("AdviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdviceID"));

                    b.Property<string>("AdviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("valueID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdviceID");

                    b.ToTable("GenAdvises");
                });

            modelBuilder.Entity("Model.GenComplaints", b =>
                {
                    b.Property<int>("complainID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("complainID"));

                    b.Property<string>("ComplaintsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("valueID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("complainID");

                    b.ToTable("GenComplaintsList", (string)null);
                });

            modelBuilder.Entity("Model.GenDignosis", b =>
                {
                    b.Property<int>("DignosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DignosisId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DignosisName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valueID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DignosisId");

                    b.ToTable("GenDiagnos");
                });

            modelBuilder.Entity("Model.GenLabInvestigation", b =>
                {
                    b.Property<int>("InvestigationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestigationID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvestigationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valueID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestigationID");

                    b.ToTable("GenlabInvestigation");
                });

            modelBuilder.Entity("Model.GenMedicine", b =>
                {
                    b.Property<int>("medicineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("medicineID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valueID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("medicineID");

                    b.ToTable("GenMedicine");
                });

            modelBuilder.Entity("Model.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<string>("City")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<int>("Opdfess")
                        .HasColumnType("int");

                    b.Property<string>("Opdtype")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValueSql("(N'')");

                    b.Property<int?>("Uhid")
                        .HasColumnType("int");

                    b.Property<string>("hospitalID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DoctorId" }, "IX_Patient_DoctorId");

                    b.ToTable("Patient", (string)null);
                });

            modelBuilder.Entity("Model.PatientMedicines", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Dose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicines")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pid")
                        .HasColumnType("int");

                    b.Property<int?>("Uhid")
                        .HasColumnType("int");

                    b.Property<string>("duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("frequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("when_take")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PatientMedicines");
                });

            modelBuilder.Entity("Model.pAdvice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("pID")
                        .HasColumnType("int");

                    b.Property<int>("uID")
                        .HasColumnType("int");

                    b.Property<string>("valueID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PAdvice");
                });

            modelBuilder.Entity("Model.pComplain", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("pID")
                        .HasColumnType("int");

                    b.Property<int>("uID")
                        .HasColumnType("int");

                    b.Property<string>("valueID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PComplains");
                });

            modelBuilder.Entity("Model.pDignosis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("pID")
                        .HasColumnType("int");

                    b.Property<int>("uID")
                        .HasColumnType("int");

                    b.Property<string>("valueID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PDignosis");
                });

            modelBuilder.Entity("Model.pInvestigation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("pID")
                        .HasColumnType("int");

                    b.Property<int>("uID")
                        .HasColumnType("int");

                    b.Property<string>("valueID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PInvestigation");
                });

            modelBuilder.Entity("StewardAPI.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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
                            Id = "029a2a1b-34b1-4b37-bc52-2acc5686c59d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "449f93c2-d9de-4479-8b96-7a7758dc9e78",
                            Email = "vikasmalik8881@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Vikas",
                            HospitalID = "Vikas0001",
                            LastName = "Malik",
                            LockoutEnabled = false,
                            NormalizedEmail = "VIKASMALIK8881@GMAIL.COM",
                            NormalizedUserName = "VIKASMALIK8881@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEK9SxysWuxICIdOGbB1GTGEQLjIYZkROmV14dbEBdB5DdoththK7frqa2dwUSZ9idA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "54ffe493-0294-4a57-839e-62144ef44d65",
                            TwoFactorEnabled = false,
                            UserName = "vikasmalik8881@gmail.com"
                        },
                        new
                        {
                            Id = "86020c2c-5a21-4851-a1aa-e69711d77fb1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "15146e6a-da4f-4785-b0d4-02c297aaafa7",
                            Email = "Vmalik@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Vikas",
                            HospitalID = "Vikas0002",
                            LastName = "Malik",
                            LockoutEnabled = false,
                            NormalizedEmail = "VMALIK@GMAIL.COM",
                            NormalizedUserName = "VMALIK@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEJn4rHF4bLVeS8DLbdMdjpwJScRrg/eF4R5CzCQASEPF7fVMlv/iesLdiT+k4n4r3g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c72c3cbb-4695-4850-b4f5-77ccaa3f7755",
                            TwoFactorEnabled = false,
                            UserName = "Vmalik@gmail.com"
                        });
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
                    b.HasOne("StewardAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StewardAPI.Models.ApplicationUser", null)
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

                    b.HasOne("StewardAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StewardAPI.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Patient", b =>
                {
                    b.HasOne("Model.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}
