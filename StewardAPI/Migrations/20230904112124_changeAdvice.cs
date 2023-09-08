using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class changeAdvice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "1a7460b4-16cc-4372-a5be-c2ce2628a211" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a7460b4-16cc-4372-a5be-c2ce2628a211");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45");

            migrationBuilder.DropColumn(
                name: "Uhid",
                table: "PatientAdvise");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "PatientAdvise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DoctorName",
                table: "PatientAdvise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PatientAdvise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "PatientAdvise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "PatientAdvise",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Department",
                table: "PatientAdvise");

            migrationBuilder.DropColumn(
                name: "DoctorName",
                table: "PatientAdvise");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PatientAdvise");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "PatientAdvise");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "PatientAdvise");

            migrationBuilder.AddColumn<int>(
                name: "Uhid",
                table: "PatientAdvise",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a7460b4-16cc-4372-a5be-c2ce2628a211", 0, "50697063-b8b5-41cd-926d-98bd40f575d3", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAENTHDswOcfpYVqMEfjNXayuQ8h6WTXadFI/oxV+fI/os4+R82MA0IyRk1Rm3hZbsFQ==", null, false, "045308ec-d4aa-4834-b83a-7ab5906dfc7a", false, "Vmalik@gmail.com" },
                    { "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45", 0, "9bbb66a6-2865-412e-b882-4f01c6318d7a", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEAH54Frw2CZoINVxiOgMQw/gHzKDxlXt4aqHiCqRshMALLBPOGJILQwg+4nKJdytWA==", null, false, "01a67ff9-181e-426b-a833-ea2ef27df472", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "1a7460b4-16cc-4372-a5be-c2ce2628a211" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "ce19b000-e3b0-407f-b83a-0c2bb0c4fc45" }
                });
        }
    }
}
