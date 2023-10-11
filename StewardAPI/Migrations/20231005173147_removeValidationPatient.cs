using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeValidationPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "0592d445-9924-4645-9d58-5e2a25fcd46f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "4b0d7792-ede1-4344-b8b0-b2595c73660d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0592d445-9924-4645-9d58-5e2a25fcd46f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b0d7792-ede1-4344-b8b0-b2595c73660d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "40f47ede-9c76-40a6-b668-7cdfbb46dbe2", 0, "51660fd8-8935-4555-8441-48dd4344de9e", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEBeMnXzhQsMr/9pavYQ8s8NeP4sT9nK6VJDaEWKepj/PK2szC6WLdQS2p5Zaw5YwjQ==", null, false, "915c7054-1463-4d66-92a8-7bbc36365809", false, "Vmalik@gmail.com" },
                    { "eb74b7ba-0752-42cb-9255-f1f73cce277c", 0, "4bac8742-3fa2-49da-84d6-be635628fe80", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEDbFw58JCCKDul99DYjPw0SGq9zTQ19MLDc0V3SCcNlXeQIEqQpvv7wYZWuTnWdwvw==", null, false, "f44dafed-1de2-42be-99bb-dbe0af5aa624", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "40f47ede-9c76-40a6-b668-7cdfbb46dbe2" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "eb74b7ba-0752-42cb-9255-f1f73cce277c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "40f47ede-9c76-40a6-b668-7cdfbb46dbe2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "eb74b7ba-0752-42cb-9255-f1f73cce277c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40f47ede-9c76-40a6-b668-7cdfbb46dbe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb74b7ba-0752-42cb-9255-f1f73cce277c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0592d445-9924-4645-9d58-5e2a25fcd46f", 0, "c50db246-d971-4bc2-8045-2bdbe44dc5e9", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJnGmJsb6xGrGcASUaoKysgoEYo7dmQkXkcnYONA1kkusM2dR92SWUrAEBFJmSgK7w==", null, false, "c8ab4e06-ad06-4740-bd0f-423032f8ce8e", false, "Vmalik@gmail.com" },
                    { "4b0d7792-ede1-4344-b8b0-b2595c73660d", 0, "5214f5a6-f98f-45d6-9a58-c5f76550a57e", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEBExhuPuEPEO5oqhWW+2EvVhim4bapzyfT9+OhaRzfQFI6Fx/3auf0wHwVfzM124rQ==", null, false, "7db3f94f-29fe-4e54-ba1c-53172f8e77b7", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "0592d445-9924-4645-9d58-5e2a25fcd46f" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "4b0d7792-ede1-4344-b8b0-b2595c73660d" }
                });
        }
    }
}
