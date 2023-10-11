using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Medicines",
                table: "GenMedicinesList",
                newName: "MedicinesName");

            migrationBuilder.RenameColumn(
                name: "Diagnosis",
                table: "GenDiagnosisList",
                newName: "DiagnosisName");

            migrationBuilder.RenameColumn(
                name: "Complaints",
                table: "GenComplaintsList",
                newName: "ComplaintsName");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "38b4ec32-da89-4657-b370-2efb1fbde11b", 0, "c10014de-0218-4bf4-b35c-18f0d12d0ef8", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEOM2p0EpjIrDe8r/nsL6JZ0/cn8vTow+Sr8PBxRvQhKy+C34FrndYXZRlkonDSmj4A==", null, false, "2e1db0a5-0266-420b-a49d-af697da40c9b", false, "Vmalik@gmail.com" },
                    { "f473f66f-fa1e-471b-895a-bd18a99638e1", 0, "246a5b39-673d-41df-8892-65fecaf344a1", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAECaS+whmLmGJgdZm2F3XyL9UE3ziGDJjK9nF9MMimmKaPC06C+9f0H4vN45MAV3ZYA==", null, false, "666f5f7f-617a-49fd-9824-879af8df2945", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "38b4ec32-da89-4657-b370-2efb1fbde11b" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f473f66f-fa1e-471b-895a-bd18a99638e1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "38b4ec32-da89-4657-b370-2efb1fbde11b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f473f66f-fa1e-471b-895a-bd18a99638e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38b4ec32-da89-4657-b370-2efb1fbde11b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f473f66f-fa1e-471b-895a-bd18a99638e1");

            migrationBuilder.RenameColumn(
                name: "MedicinesName",
                table: "GenMedicinesList",
                newName: "Medicines");

            migrationBuilder.RenameColumn(
                name: "DiagnosisName",
                table: "GenDiagnosisList",
                newName: "Diagnosis");

            migrationBuilder.RenameColumn(
                name: "ComplaintsName",
                table: "GenComplaintsList",
                newName: "Complaints");

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
        }
    }
}
