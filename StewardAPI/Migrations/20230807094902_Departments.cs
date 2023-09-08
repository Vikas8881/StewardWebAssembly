using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class Departments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "6dc88e5f-a2d0-4c04-a924-ef77c66e8586" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "de011084-6d9a-4ed0-8e0c-fd7f96fdc689" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dc88e5f-a2d0-4c04-a924-ef77c66e8586");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de011084-6d9a-4ed0-8e0c-fd7f96fdc689");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Visible = table.Column<bool>(type: "bit", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e47fd80f-ac46-43a3-9b0b-7072e1af3ea8", 0, "75d6bcdf-abc3-4b78-8027-a7d9164d70b5", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEMU3hOR6h/8kHLBi3OTdNuI4NwkSQR14+WvsF+wGh2bv/+KpDkos45YvI7CMFfVd1g==", null, false, "72b9f5bf-317a-4bab-b515-293ed8c42048", false, "vikasmalik8881@gmail.com" },
                    { "f5127a1c-3e04-4f0c-8880-8aa57a6bbf27", 0, "14bb5e01-2e1b-410c-89d3-44d343428f2c", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEILuoNeQkQyTePR3kIOqDO2JO+5soSEKKJsrGFvtdR7AQCQUrAvgJ/SAcLE/lTaEAw==", null, false, "161d0574-a937-4922-8c12-7263bb18b728", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "e47fd80f-ac46-43a3-9b0b-7072e1af3ea8" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "f5127a1c-3e04-4f0c-8880-8aa57a6bbf27" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "e47fd80f-ac46-43a3-9b0b-7072e1af3ea8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "f5127a1c-3e04-4f0c-8880-8aa57a6bbf27" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47fd80f-ac46-43a3-9b0b-7072e1af3ea8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5127a1c-3e04-4f0c-8880-8aa57a6bbf27");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6dc88e5f-a2d0-4c04-a924-ef77c66e8586", 0, "f7caeb4b-9243-446f-860e-963edb789213", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEOQKOReDobusUFiEJKtPAKfaD/Yg1B+XfgSjCwT7uUfzdTw058nEvg2QQgJNjc8Pnw==", null, false, "d1d9ef26-5e6b-435f-9b33-8ff74970a497", false, "Vmalik@gmail.com" },
                    { "de011084-6d9a-4ed0-8e0c-fd7f96fdc689", 0, "a28227d3-c3af-4268-a644-1c9545fb65d8", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEGTjrk2h/Z0go8eBgQ1dSjqhBMa1mATLTZZejk9UjLX5CWeraB4iu+epp+EgQKVr+w==", null, false, "05ae5191-2d7a-452a-95bc-c0ae4ec75cf0", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "6dc88e5f-a2d0-4c04-a924-ef77c66e8586" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "de011084-6d9a-4ed0-8e0c-fd7f96fdc689" }
                });
        }
    }
}
