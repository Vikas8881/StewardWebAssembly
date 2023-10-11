using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class modifyPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "2a825352-6b98-4a80-8380-b3f15409e5eb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "f510f839-e9bb-49b0-8804-395c788ba1b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a825352-6b98-4a80-8380-b3f15409e5eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f510f839-e9bb-49b0-8804-395c788ba1b0");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Doctor_DoctorId",
                table: "Patient");

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
                    { "2a825352-6b98-4a80-8380-b3f15409e5eb", 0, "6a3bf936-de80-4a55-860c-9dffccfcf40f", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEPVBy8OHZKfexd9J7nkRDAjT+VwG3wpHBV6vR0hnVm+VnQAHoN9DTt43Ap56TkfAjg==", null, false, "fccdb8d3-5f2d-4bf2-8e19-a49d1f4d6802", false, "vikasmalik8881@gmail.com" },
                    { "f510f839-e9bb-49b0-8804-395c788ba1b0", 0, "d02b0e33-7801-4bd0-a27b-042a4881b4ed", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEH0FXs6Xti14jMabj3scSRpCeLm7VrboXASn4bQnLczx36jtNZlOLcba7qKYJlUW4Q==", null, false, "e7613c8c-b6f2-479a-8778-bf45adab0de9", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "2a825352-6b98-4a80-8380-b3f15409e5eb" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "f510f839-e9bb-49b0-8804-395c788ba1b0" }
                });
        }
    }
}
