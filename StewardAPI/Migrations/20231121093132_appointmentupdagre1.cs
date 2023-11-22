using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class appointmentupdagre1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "hospitalID",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "confirmation",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Doctor",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a96ca1a-f4f8-4dcd-b9c5-dd6dec57e9a6", 0, "c81e668b-bc3b-429f-80c3-01059543f7c3", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEOytqgETpqQN0/gH428SCNcFDEX2gDL68a/GJ7mvoI1dRcb7JN6cgnmySg8hi80UPg==", null, false, "f7a1c64b-0cf7-4aa6-8d49-9e8d94ab6449", false, "vikasmalik8881@gmail.com" },
                    { "f7ad7046-43df-49d7-a9a5-af3f0662aeba", 0, "977afc96-9254-424c-8ceb-258610a50da1", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEMX3fklq0FNe4NaN6gmzzwb58NCCCQKAN2FQpTsl6LhIOEV+frvme8j6SmP5oRZxCA==", null, false, "62ac177b-ed89-4bc1-b560-d4cfb23e93cb", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "0a96ca1a-f4f8-4dcd-b9c5-dd6dec57e9a6" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "f7ad7046-43df-49d7-a9a5-af3f0662aeba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "0a96ca1a-f4f8-4dcd-b9c5-dd6dec57e9a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "f7ad7046-43df-49d7-a9a5-af3f0662aeba" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a96ca1a-f4f8-4dcd-b9c5-dd6dec57e9a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7ad7046-43df-49d7-a9a5-af3f0662aeba");

            migrationBuilder.AlterColumn<string>(
                name: "hospitalID",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "confirmation",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DoctorID",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Doctor",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
