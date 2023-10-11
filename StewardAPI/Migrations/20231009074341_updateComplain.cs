using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateComplain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "52fce54e-6e74-4b3b-94e4-c9967ac30b86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9456d830-dc4f-4245-ba26-a19b23a6bfd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52fce54e-6e74-4b3b-94e4-c9967ac30b86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9456d830-dc4f-4245-ba26-a19b23a6bfd0");

            migrationBuilder.DropColumn(
                name: "complainID",
                table: "PComplains");

            migrationBuilder.AddColumn<string>(
                name: "valueID",
                table: "PComplains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "valueID",
                table: "GenComplaintsList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c4c741d-aa70-4886-9d5d-7c845a0da426", 0, "135ff9a4-a10a-45b5-971a-2c83c4fa9948", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJDXVDQTy68XbnyoUmNdoyRyUh0DKLZ2bf7HJ50wTafIxvFkn0c5JT72j4cFdiwRVA==", null, false, "54e9de30-62d6-4878-af80-662985e6bd09", false, "Vmalik@gmail.com" },
                    { "db7640a8-9568-41c2-8ef8-1c6667acb4e9", 0, "ec3dc6ee-faab-4ed7-bfaa-da74b179d56d", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEAPvLmhpw5k1oALo8EFYsB12VLums3X3sJAbO3qDHmHkLr+xf0LlG2D3y+NbYV6hkg==", null, false, "ed439dbe-d896-47f8-b246-b7867b9d6196", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "7c4c741d-aa70-4886-9d5d-7c845a0da426" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "db7640a8-9568-41c2-8ef8-1c6667acb4e9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "7c4c741d-aa70-4886-9d5d-7c845a0da426" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "db7640a8-9568-41c2-8ef8-1c6667acb4e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c4c741d-aa70-4886-9d5d-7c845a0da426");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db7640a8-9568-41c2-8ef8-1c6667acb4e9");

            migrationBuilder.DropColumn(
                name: "valueID",
                table: "PComplains");

            migrationBuilder.AddColumn<int>(
                name: "complainID",
                table: "PComplains",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "valueID",
                table: "GenComplaintsList",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52fce54e-6e74-4b3b-94e4-c9967ac30b86", 0, "096c6122-60e1-4c3f-8bcb-99e8d1aa4cec", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEEwhMl399tZQ5yUCVmRtOETutez4zqFszfg5Kcg6coGmv0bAUNIJuj2hk5HneqJyDg==", null, false, "9d2bcc7c-138c-4c36-9626-583aaafb111d", false, "Vmalik@gmail.com" },
                    { "9456d830-dc4f-4245-ba26-a19b23a6bfd0", 0, "30111c25-e683-4968-9461-7dde92bf5bb0", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAENVviDwsJVnbBN/b/e4Gnb+GAtf0R90FHXk0eIjHKvBRZjbHiyeCPvGtzI1xLYnKgw==", null, false, "740b69a4-92d4-4d2c-a6d7-38f71bbab49f", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "52fce54e-6e74-4b3b-94e4-c9967ac30b86" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9456d830-dc4f-4245-ba26-a19b23a6bfd0" }
                });
        }
    }
}
