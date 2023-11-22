using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class appointmentmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "28c22357-7f98-40f6-903e-bd03c2596c1f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "294c7fce-3836-42e2-8267-e192848801f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28c22357-7f98-40f6-903e-bd03c2596c1f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "294c7fce-3836-42e2-8267-e192848801f8");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Appointments",
                newName: "starDateTime");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Appointments",
                newName: "endDateTime");

            migrationBuilder.AddColumn<string>(
                name: "confirmation",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b7546b0e-12ee-425a-a209-7913ea9c5ceb", 0, "c6aa8f34-bdbe-47da-bb7f-b6c2640de308", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEOfYZn/899ew1dveCsxN6x9fkmsLQORFIKT1sNdu3JvcrDrcqRgLN6yi0YlWERY1dw==", null, false, "a94461f8-1fc0-441d-b17f-dd275220d00d", false, "Vmalik@gmail.com" },
                    { "f7308db1-dd64-4880-99d4-a266b8dc87ae", 0, "b4a65076-ad57-4c3b-b9ea-8b1c8cd49dbd", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEKsrktYgsNk7rn6w3tiRozygMLSpOw1PEC+0Daj209nqO5Fa+P7ZynOqNr1yT0xeyA==", null, false, "2965bc21-3efb-419b-b625-fb5c46b642c5", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "b7546b0e-12ee-425a-a209-7913ea9c5ceb" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f7308db1-dd64-4880-99d4-a266b8dc87ae" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "b7546b0e-12ee-425a-a209-7913ea9c5ceb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f7308db1-dd64-4880-99d4-a266b8dc87ae" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7546b0e-12ee-425a-a209-7913ea9c5ceb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7308db1-dd64-4880-99d4-a266b8dc87ae");

            migrationBuilder.DropColumn(
                name: "confirmation",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "starDateTime",
                table: "Appointments",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "endDateTime",
                table: "Appointments",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "28c22357-7f98-40f6-903e-bd03c2596c1f", 0, "787c1d5e-24d3-4c0c-8a16-6794ed7f5088", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAECD9Ss71L6/FOU6hitTpfSrY1tYVIJE0l+nUWKmhnA7s3hoFuuLZPqeq0/6hWg9ppQ==", null, false, "67e8117c-a779-455d-a8b8-ca30cd99967c", false, "Vmalik@gmail.com" },
                    { "294c7fce-3836-42e2-8267-e192848801f8", 0, "3002f82e-8f1e-4c8a-8af2-328ab2dd79c7", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAECuqVyvVbeFl6vMjxlaaEORyonwwU4Bk7rwzfbdOvuxmhXdOqD6wkR3jnWN+NAAI1Q==", null, false, "7127a094-f663-476a-a515-e20c1735c6f0", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "28c22357-7f98-40f6-903e-bd03c2596c1f" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "294c7fce-3836-42e2-8267-e192848801f8" }
                });
        }
    }
}
