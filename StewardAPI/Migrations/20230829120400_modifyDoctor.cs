using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class modifyDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
