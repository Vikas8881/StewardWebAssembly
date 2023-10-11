using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class genmedicine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "41ad0009-b7b9-4de3-ad01-078c380ce8f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41ad0009-b7b9-4de3-ad01-078c380ce8f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c");

            migrationBuilder.CreateTable(
                name: "GenMedicine",
                columns: table => new
                {
                    complainID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    valueID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenMedicine", x => x.complainID);
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenMedicine");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41ad0009-b7b9-4de3-ad01-078c380ce8f2", 0, "75ed3385-eeee-452a-bcbc-116b35888503", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEM0AxnhuX4S7jMxjh8GzJfFbQkRHaYeob3Uv4Y/sXNcgefa8K2dLEHYiZgqdIMNq2w==", null, false, "35b83dd8-1cae-4b5a-920e-09165a3ac8eb", false, "vikasmalik8881@gmail.com" },
                    { "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c", 0, "75cfdf67-1144-4137-b20e-c7981dfc7838", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJzdKJ7zWMskVrf2XrkehJ8ebrojktDm7FP0nOI6kbU5aJW5jDly9zgRvr3TOrYxhQ==", null, false, "f31142ff-8484-483f-af9f-3c9680b7b5eb", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "41ad0009-b7b9-4de3-ad01-078c380ce8f2" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c" }
                });
        }
    }
}
