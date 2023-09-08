using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class addnewTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { "34785fd4-4ab3-4ecb-ae58-3d1ef3d26a95", 0, "f129f9cc-1e73-43c1-b0cb-33447855623b", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEODD1BdELeAIcs38GnrMw3jh5aV1HpTbe/wWDkISKdLQxHBWwr7FtE27D0uEewcnDQ==", null, false, "c89a16d3-1f1d-46d8-b64d-51bb529f720b", false, "Vmalik@gmail.com" },
                    { "b3042963-ddd1-4140-a66d-f700914d1855", 0, "1096d39a-eee1-4c36-8d1c-460415ec8c72", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEIQobHMRGmVI3PBhAdPa+EN4KEqzZXm1x5PZVItDOkm0dguaXJlTQJgeoUrVpktt5A==", null, false, "acf32a27-0555-4815-af03-e8c94e376037", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "34785fd4-4ab3-4ecb-ae58-3d1ef3d26a95" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "b3042963-ddd1-4140-a66d-f700914d1855" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "34785fd4-4ab3-4ecb-ae58-3d1ef3d26a95" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "b3042963-ddd1-4140-a66d-f700914d1855" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34785fd4-4ab3-4ecb-ae58-3d1ef3d26a95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3042963-ddd1-4140-a66d-f700914d1855");

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
    }
}
