using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class changesinPatientHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9e2518ef-ff45-4216-a6fe-13d0a066d609" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "a0a72932-12f1-4827-9e9e-377850e4ade8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e2518ef-ff45-4216-a6fe-13d0a066d609");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0a72932-12f1-4827-9e9e-377850e4ade8");

            migrationBuilder.DropColumn(
                name: "Uhid",
                table: "PatientMedicine");

            migrationBuilder.DropColumn(
                name: "Uhid",
                table: "PatientInvestigation");

            migrationBuilder.DropColumn(
                name: "Uhid",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "Uhid",
                table: "PatientComplaints");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "PatientMedicine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "PatientMedicine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PatientMedicine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PatientMedicine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "PatientMedicine",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "PatientInvestigation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "PatientInvestigation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PatientInvestigation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PatientInvestigation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "PatientInvestigation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "PatientDiagnosis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "PatientDiagnosis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PatientDiagnosis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PatientDiagnosis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "PatientDiagnosis",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "PatientComplaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "PatientComplaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PatientComplaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PatientComplaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "PatientComplaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "GenMedicinesList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "GenDiagnosisList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "GenComplaintsList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a7460b4-16cc-4372-a5be-c2ce2628a211", 0, "50697063-b8b5-41cd-926d-98bd40f575d3", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAENTHDswOcfpYVqMEfjNXayuQ8h6WTXadFI/oxV+fI/os4+R82MA0IyRk1Rm3hZbsFQ==", null, false, "045308ec-d4aa-4834-b83a-7ab5906dfc7a", false, "Vmalik@gmail.com" },
                    { "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45", 0, "9bbb66a6-2865-412e-b882-4f01c6318d7a", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEAH54Frw2CZoINVxiOgMQw/gHzKDxlXt4aqHiCqRshMALLBPOGJILQwg+4nKJdytWA==", null, false, "01a67ff9-181e-426b-a833-ea2ef27df472", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 26,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 27,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 28,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 29,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 30,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 31,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 32,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 33,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 34,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 35,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 36,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 37,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 38,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 39,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 40,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 41,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 42,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 43,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 44,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 45,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 46,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 47,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 48,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 49,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 50,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 51,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 52,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 53,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 54,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 55,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 56,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 57,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 58,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 59,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 60,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 61,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 62,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 63,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 64,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 65,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 66,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 67,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 68,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 69,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 70,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 71,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 72,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 73,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 74,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 75,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 76,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 77,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 78,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 79,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 80,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 81,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 82,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 83,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 84,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 85,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 86,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "GenDiagnosisList",
                keyColumn: "Id",
                keyValue: 87,
                column: "Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "1a7460b4-16cc-4372-a5be-c2ce2628a211" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "1a7460b4-16cc-4372-a5be-c2ce2628a211" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a7460b4-16cc-4372-a5be-c2ce2628a211");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "PatientMedicine");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "PatientMedicine");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PatientMedicine");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PatientMedicine");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "PatientMedicine");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "PatientInvestigation");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "PatientInvestigation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PatientInvestigation");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PatientInvestigation");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "PatientInvestigation");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "PatientDiagnosis");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "PatientComplaints");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "PatientComplaints");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PatientComplaints");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PatientComplaints");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "PatientComplaints");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "GenMedicinesList");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "GenDiagnosisList");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "GenComplaintsList");

            migrationBuilder.AddColumn<int>(
                name: "Uhid",
                table: "PatientMedicine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Uhid",
                table: "PatientInvestigation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Uhid",
                table: "PatientDiagnosis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Uhid",
                table: "PatientComplaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e2518ef-ff45-4216-a6fe-13d0a066d609", 0, "74f30f36-cedc-4da3-a70a-7b7336457847", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEF+J8t5tQ3ZdPUTNkUkpJFyXB5FSxnaNPjIUt3jR4FQ69gI4GGjA0ODYru0cYKnVZw==", null, false, "cd075390-65cf-40b5-9663-c512824007d2", false, "vikasmalik8881@gmail.com" },
                    { "a0a72932-12f1-4827-9e9e-377850e4ade8", 0, "79e08e3c-920b-490b-a879-a564309871e7", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEM6qzrpPevNEvZKNopkNQtMAnyWzQpeBXwY1U7O+B4B5U2bSHyVcFlH+pkGT9lC4ig==", null, false, "fac149b8-315e-435c-ba23-30ef7011e0e1", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9e2518ef-ff45-4216-a6fe-13d0a066d609" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "a0a72932-12f1-4827-9e9e-377850e4ade8" }
                });
        }
    }
}
