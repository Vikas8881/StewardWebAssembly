using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class pMedicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PInvestigation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PDignosis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PAdvice",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "PatientMedicines",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    when_take = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    frequency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uhid = table.Column<int>(type: "int", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicines", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "72682698-c4de-45eb-87eb-07ddf82c12e9", 0, "d52caca1-3180-4aee-8397-84ae3c7b5c07", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEHe1ml7i7PldW+4EZgPS9prscxkNskfqILXkgvpAL9mRgBTsyM9yXO6Q8yfUR2nN3A==", null, false, "79d6d630-8f4f-4972-a764-6e619b8ac069", false, "vikasmalik8881@gmail.com" },
                    { "fdb63afc-5a39-475c-abe4-6ecd4d975ed4", 0, "69feae26-601e-43e6-ace2-7ac01ae657fa", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEBW9Kcj0kEwx5P5uLfucTyGUx1ywpYTnr1VXIno9rS/j4W7H7UNE0GpOc08nMwJSzA==", null, false, "c6343c56-90f9-4c26-825b-0a71a23baa78", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "72682698-c4de-45eb-87eb-07ddf82c12e9" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "fdb63afc-5a39-475c-abe4-6ecd4d975ed4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientMedicines");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "72682698-c4de-45eb-87eb-07ddf82c12e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "fdb63afc-5a39-475c-abe4-6ecd4d975ed4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72682698-c4de-45eb-87eb-07ddf82c12e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdb63afc-5a39-475c-abe4-6ecd4d975ed4");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PInvestigation");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PDignosis");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PAdvice");

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
    }
}
