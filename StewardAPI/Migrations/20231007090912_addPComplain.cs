using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class addPComplain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientComplaints");

            migrationBuilder.DropTable(
                name: "PatientDiagnosis");

            migrationBuilder.DropTable(
                name: "PatientInvestigation");

            migrationBuilder.DropTable(
                name: "PatientMedicine");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "2909406e-e558-40bc-9e5c-5064e5d4d3af" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f8d292b3-8f14-448b-934e-bcc8f2509c2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2909406e-e558-40bc-9e5c-5064e5d4d3af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8d292b3-8f14-448b-934e-bcc8f2509c2e");

            migrationBuilder.CreateTable(
                name: "PComplains",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    pID = table.Column<int>(type: "int", nullable: false),
                    GenComplaintsId = table.Column<int>(type: "int", nullable: false),
                    complainID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PComplains", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PComplains_GenComplaintsList_GenComplaintsId",
                        column: x => x.GenComplaintsId,
                        principalTable: "GenComplaintsList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PComplains_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c47d9453-1d5f-469c-9d98-e24ad1bb957f", 0, "b8a811e9-5546-4e3e-b0cb-39af47e43723", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJMADgmbOsqDsSdGdTX9RLH27T3Q021F2WFcturmV9ea2FysYGQpaAVOKPxKtGhKaQ==", null, false, "8b258d62-9e65-49db-81b6-886887794ce8", false, "Vmalik@gmail.com" },
                    { "d5258767-15d0-4628-b23c-6f2970ae63fc", 0, "777548ad-ce9b-4067-9e9b-f67c4f3f7a3c", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEC8P9wsL9qM19LMXFhyBBoC1dWwkx+sD/gEaoDkOEvqExB4+OSk/TWfNOlX4HXw/lQ==", null, false, "3c027f0a-1f53-4e19-9062-7db02577bd92", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "c47d9453-1d5f-469c-9d98-e24ad1bb957f" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "d5258767-15d0-4628-b23c-6f2970ae63fc" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PComplains_GenComplaintsId",
                table: "PComplains",
                column: "GenComplaintsId");

            migrationBuilder.CreateIndex(
                name: "IX_PComplains_PatientId",
                table: "PComplains",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PComplains");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "c47d9453-1d5f-469c-9d98-e24ad1bb957f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "d5258767-15d0-4628-b23c-6f2970ae63fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c47d9453-1d5f-469c-9d98-e24ad1bb957f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5258767-15d0-4628-b23c-6f2970ae63fc");

            migrationBuilder.CreateTable(
                name: "PatientComplaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientID = table.Column<int>(type: "int", nullable: false),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospitalID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientComplaints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientComplaints_Patient_patientID",
                        column: x => x.patientID,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complaintname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    hospitalID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientInvestigation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvestigationName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    hospitalID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInvestigation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    when_take = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hospitalID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicine", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2909406e-e558-40bc-9e5c-5064e5d4d3af", 0, "4fc1cfef-d3f8-45f1-bce8-c5e875a8a4c7", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEMbEFwgsLIpgyRTPGWuLYMYg30SJl5CfuRJDIBi5bo3qZ5cTsadWn6pP5sDNWMy80A==", null, false, "b096ff02-5c87-48f2-adc9-bd447dc9d941", false, "Vmalik@gmail.com" },
                    { "f8d292b3-8f14-448b-934e-bcc8f2509c2e", 0, "67062ff2-e208-4bfc-8405-fdea598fc027", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEK4noutV4W8uQFVF79Lt2YgL1ORSB1DBr4Y/CgvBebNh0UNmbrqe549K+M1slUd94Q==", null, false, "545bcce1-b9dd-4049-8284-b1dbc8423913", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "2909406e-e558-40bc-9e5c-5064e5d4d3af" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f8d292b3-8f14-448b-934e-bcc8f2509c2e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientComplaints_patientID",
                table: "PatientComplaints",
                column: "patientID");
        }
    }
}
