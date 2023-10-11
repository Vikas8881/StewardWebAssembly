using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeMediDup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenMedicinesList");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "defed40f-ce7a-4d9d-99ea-eb72ca6ac25c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "e3de3fda-70e9-4a0a-99d2-920717647bff" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "defed40f-ce7a-4d9d-99ea-eb72ca6ac25c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3de3fda-70e9-4a0a-99d2-920717647bff");

            migrationBuilder.RenameColumn(
                name: "complainID",
                table: "GenMedicine",
                newName: "medicineID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "750d7cb0-46a2-44ab-98bd-a47feb53aecb", 0, "ae2fd07a-64d5-41ac-88ba-78aecc7d155a", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEHVZAffTvlnfNwrckbJlmIlRPfH4VVmPxG2JEfkXmijxGaBI0bkuTuwMU9KG2QMuSQ==", null, false, "fc81abfa-6cc2-4c90-afb9-759e7e98e71e", false, "vikasmalik8881@gmail.com" },
                    { "d6a55836-f8bd-4cd2-8fa9-4ef0ec17f12e", 0, "7f5e746a-ceb5-48f3-9a43-6a798c39a7d9", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEC3kwW8HBp4JKzU9IPBtrQBjuz5Ud9xay4AzPZN2Rrlv7ujJ2aT3yzuAcablwe6TFg==", null, false, "3d059c82-36b3-4125-a720-e49d03aee68d", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "750d7cb0-46a2-44ab-98bd-a47feb53aecb" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "d6a55836-f8bd-4cd2-8fa9-4ef0ec17f12e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "750d7cb0-46a2-44ab-98bd-a47feb53aecb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "d6a55836-f8bd-4cd2-8fa9-4ef0ec17f12e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "750d7cb0-46a2-44ab-98bd-a47feb53aecb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6a55836-f8bd-4cd2-8fa9-4ef0ec17f12e");

            migrationBuilder.RenameColumn(
                name: "medicineID",
                table: "GenMedicine",
                newName: "complainID");

            migrationBuilder.CreateTable(
                name: "GenMedicinesList",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicinesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valueID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenMedicinesList", x => x.MedicineId);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "defed40f-ce7a-4d9d-99ea-eb72ca6ac25c", 0, "cad10293-d5c7-486f-91cf-060f9eb94946", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEOebd0ehY5B86iYrG6mgkzDTNwebcu6a8M9uQpjfnVOLMdO5KqDuQOImZdLJk+9Aww==", null, false, "eb8f4b85-2603-4312-a27b-95c2b1474d1d", false, "Vmalik@gmail.com" },
                    { "e3de3fda-70e9-4a0a-99d2-920717647bff", 0, "d81c64bb-e789-4d3d-a660-8fde4ca064fe", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEEznGFocc7eyZLTWe1oYA/Xio56aXYjTEwqhZ845bmpqpt0kanLmd/rlyuWrcUVlzQ==", null, false, "052064dc-d9bd-449b-bc0e-86cd0c1c7f4f", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "defed40f-ce7a-4d9d-99ea-eb72ca6ac25c" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "e3de3fda-70e9-4a0a-99d2-920717647bff" }
                });
        }
    }
}
