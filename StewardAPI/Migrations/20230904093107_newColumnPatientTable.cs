using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class newColumnPatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "b0bcd70a-1bec-48c3-bb08-3283d58c622e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c213cb5c-b602-4b9a-96b7-688766247401" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0bcd70a-1bec-48c3-bb08-3283d58c622e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c213cb5c-b602-4b9a-96b7-688766247401");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Patient",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9e2518ef-ff45-4216-a6fe-13d0a066d609", 0, "74f30f36-cedc-4da3-a70a-7b7336457847", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEF+J8t5tQ3ZdPUTNkUkpJFyXB5FSxnaNPjIUt3jR4FQ69gI4GGjA0ODYru0cYKnVZw==", null, false, "cd075390-65cf-40b5-9663-c512824007d2", false, "vikasmalik8881@gmail.com" },
                    { "a0a72932-12f1-4827-9e9e-377850e4ade8", 0, "79e08e3c-920b-490b-a879-a564309871e7", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEM6qzrpPevNEvZKNopkNQtMAnyWzQpeBXwY1U7O+B4B5U2bSHyVcFlH+pkGT9lC4ig==", null, false, "fac149b8-315e-435c-ba23-30ef7011e0e1", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9e2518ef-ff45-4216-a6fe-13d0a066d609" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "a0a72932-12f1-4827-9e9e-377850e4ade8" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9e2518ef-ff45-4216-a6fe-13d0a066d609" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "a0a72932-12f1-4827-9e9e-377850e4ade8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e2518ef-ff45-4216-a6fe-13d0a066d609");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0a72932-12f1-4827-9e9e-377850e4ade8");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Patient");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Departments");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b0bcd70a-1bec-48c3-bb08-3283d58c622e", 0, "b11377f8-17c2-49b8-b0b1-e501d2569d31", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJbBgQzxTFwxOqe+FSlK4LqPf+ldFINPuKi/AqG8Hmrm2xWx+9wbBI05IpRGsHLwcQ==", null, false, "dc651161-b799-4001-9d0c-c899ac11aad1", false, "Vmalik@gmail.com" },
                    { "c213cb5c-b602-4b9a-96b7-688766247401", 0, "83963697-351c-4826-b1ec-8dedcefddc3b", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEJzIDTMwkdHrrMNSFSBPybHhwEyBjRCaQhUTW1ernjIS0tPh3Xiqb0jerv/PzLdrTQ==", null, false, "fb31db9b-c57a-421d-bf6e-85cd36e8fb45", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "b0bcd70a-1bec-48c3-bb08-3283d58c622e" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c213cb5c-b602-4b9a-96b7-688766247401" }
                });
        }
    }
}
