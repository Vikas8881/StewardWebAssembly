using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialappointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9af480ed-c59d-442b-bfdc-fa262f56c04d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "c97b5925-a3bc-438b-b284-20aede92da48" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9af480ed-c59d-442b-bfdc-fa262f56c04d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c97b5925-a3bc-438b-b284-20aede92da48");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DoctorID",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "hospitalID",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DoctorID",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "hospitalID",
                table: "Appointments");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9af480ed-c59d-442b-bfdc-fa262f56c04d", 0, "b67dec94-7a41-4a54-99f6-71aa835f46cf", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEM7EnzorNQ31uUVocAynyl4NJmXdT/DIpADgDxuXPvYKCas4Ab12VDTyIzY+gDthzw==", null, false, "a1dc6112-d49c-41ff-83f1-d94a59ee9031", false, "vikasmalik8881@gmail.com" },
                    { "c97b5925-a3bc-438b-b284-20aede92da48", 0, "f53eea27-9889-45cb-985d-a60ea79bf064", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEMkamWkXIJnHKU61agfHaDlIlA9utsmOPdUEGGz/mZ6Z+9vsQhIzJ7lSpTxNrGYMVA==", null, false, "835e863f-b106-42d1-8f65-3015210a87c8", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9af480ed-c59d-442b-bfdc-fa262f56c04d" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "c97b5925-a3bc-438b-b284-20aede92da48" }
                });
        }
    }
}
