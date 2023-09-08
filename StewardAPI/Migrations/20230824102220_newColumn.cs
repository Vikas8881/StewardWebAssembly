using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class newColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Doctor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "Doctor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0836e501-abca-4d95-96a1-904092c07578", 0, "9a0e7054-b7be-40e1-91d7-6ac2f323219f", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEFG0b0OOhCeMml3riZ4Y+M13LEht8oISY00d9lufNbJMrh7LcI9ZYU86qVHyhi8bzQ==", null, false, "cc1518c4-afeb-478a-bce2-c1f0b2031a1e", false, "vikasmalik8881@gmail.com" },
                    { "9396ee0e-a0c8-4a37-b18b-af85ff243844", 0, "889b493b-0043-4c35-9d28-e7b74278dfc2", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEBFZk1nOMPusc2MSdajlQjAdBxHHZw1wSub+wpFfcUmqSn/3vuv4+vC1ssZKBJZVvA==", null, false, "7aa30130-f7fb-4a69-b0df-3caa43becb92", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "0836e501-abca-4d95-96a1-904092c07578" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "9396ee0e-a0c8-4a37-b18b-af85ff243844" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "0836e501-abca-4d95-96a1-904092c07578" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "9396ee0e-a0c8-4a37-b18b-af85ff243844" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0836e501-abca-4d95-96a1-904092c07578");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9396ee0e-a0c8-4a37-b18b-af85ff243844");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "Doctor");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "Departments");

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
    }
}
