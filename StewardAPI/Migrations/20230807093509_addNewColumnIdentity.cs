using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class addNewColumnIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "2c5977a8-b26d-4af7-9e59-fd87bdd1cbd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c458ec56-8cf5-4c3f-afc6-33c3a8157b4a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5977a8-b26d-4af7-9e59-fd87bdd1cbd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c458ec56-8cf5-4c3f-afc6-33c3a8157b4a");

            migrationBuilder.AddColumn<string>(
                name: "HospitalID",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "HospitalID",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c5977a8-b26d-4af7-9e59-fd87bdd1cbd0", 0, "0d0e9588-8eba-4490-9b4a-95d34851d99a", "Vmalik@gmail.com", false, "Vikas", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEFPCRM1pKrzKTGifEPVzAQQViLQPZesYr+fofWBG8PWjQjkQo5sWencWaSmMKarnOg==", null, false, "fd069c52-b25d-4084-b0cd-116ad81136f6", false, "Vmalik@gmail.com" },
                    { "c458ec56-8cf5-4c3f-afc6-33c3a8157b4a", 0, "1fbcfc93-b30e-4746-b66c-01c16e76ab41", "vikasmalik8881@gmail.com", false, "Vikas", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAELYzuPvGD1FvH2GO76x7up50KFQZtbwUtKDJ0vAu5omNgZKe/h43Rh8eNoE4vsalmQ==", null, false, "583dfb89-4898-4065-abe4-1af9f55c3399", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "2c5977a8-b26d-4af7-9e59-fd87bdd1cbd0" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c458ec56-8cf5-4c3f-afc6-33c3a8157b4a" }
                });
        }
    }
}
