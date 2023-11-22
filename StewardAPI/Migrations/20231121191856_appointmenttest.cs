using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class appointmenttest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "starDateTime",
                table: "Appointments",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "endDateTime",
                table: "Appointments",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "confirmation",
                table: "Appointments",
                newName: "RecurrenceRule");

            migrationBuilder.RenameColumn(
                name: "Doctor",
                table: "Appointments",
                newName: "RecurrenceException");

            migrationBuilder.AddColumn<string>(
                name: "Disease",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElementType",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAllDay",
                table: "Appointments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlock",
                table: "Appointments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecurrenceID",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Symptoms",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "029a2a1b-34b1-4b37-bc52-2acc5686c59d", 0, "449f93c2-d9de-4479-8b96-7a7758dc9e78", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEK9SxysWuxICIdOGbB1GTGEQLjIYZkROmV14dbEBdB5DdoththK7frqa2dwUSZ9idA==", null, false, "54ffe493-0294-4a57-839e-62144ef44d65", false, "vikasmalik8881@gmail.com" },
                    { "86020c2c-5a21-4851-a1aa-e69711d77fb1", 0, "15146e6a-da4f-4785-b0d4-02c297aaafa7", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJn4rHF4bLVeS8DLbdMdjpwJScRrg/eF4R5CzCQASEPF7fVMlv/iesLdiT+k4n4r3g==", null, false, "c72c3cbb-4695-4850-b4f5-77ccaa3f7755", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "029a2a1b-34b1-4b37-bc52-2acc5686c59d" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "86020c2c-5a21-4851-a1aa-e69711d77fb1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "029a2a1b-34b1-4b37-bc52-2acc5686c59d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "86020c2c-5a21-4851-a1aa-e69711d77fb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "029a2a1b-34b1-4b37-bc52-2acc5686c59d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86020c2c-5a21-4851-a1aa-e69711d77fb1");

            migrationBuilder.DropColumn(
                name: "Disease",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ElementType",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsAllDay",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsBlock",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "RecurrenceID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Symptoms",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Appointments",
                newName: "starDateTime");

            migrationBuilder.RenameColumn(
                name: "RecurrenceRule",
                table: "Appointments",
                newName: "confirmation");

            migrationBuilder.RenameColumn(
                name: "RecurrenceException",
                table: "Appointments",
                newName: "Doctor");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Appointments",
                newName: "endDateTime");

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
    }
}
