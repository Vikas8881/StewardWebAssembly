using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAppointmentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "72682698-c4de-45eb-87eb-07ddf82c12e9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "fdb63afc-5a39-475c-abe4-6ecd4d975ed4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72682698-c4de-45eb-87eb-07ddf82c12e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdb63afc-5a39-475c-abe4-6ecd4d975ed4");

            migrationBuilder.AlterColumn<int>(
                name: "Uhid",
                table: "PatientMedicines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doctor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

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

            migrationBuilder.AlterColumn<int>(
                name: "Uhid",
                table: "PatientMedicines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "72682698-c4de-45eb-87eb-07ddf82c12e9", 0, "d52caca1-3180-4aee-8397-84ae3c7b5c07", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEHe1ml7i7PldW+4EZgPS9prscxkNskfqILXkgvpAL9mRgBTsyM9yXO6Q8yfUR2nN3A==", null, false, "79d6d630-8f4f-4972-a764-6e619b8ac069", false, "vikasmalik8881@gmail.com" },
                    { "fdb63afc-5a39-475c-abe4-6ecd4d975ed4", 0, "69feae26-601e-43e6-ace2-7ac01ae657fa", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEBW9Kcj0kEwx5P5uLfucTyGUx1ywpYTnr1VXIno9rS/j4W7H7UNE0GpOc08nMwJSzA==", null, false, "c6343c56-90f9-4c26-825b-0a71a23baa78", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "72682698-c4de-45eb-87eb-07ddf82c12e9" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "fdb63afc-5a39-475c-abe4-6ecd4d975ed4" }
                });
        }
    }
}
