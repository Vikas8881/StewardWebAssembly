using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class pAdvice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "331c4edd-b572-41a7-938d-05a2b89fc828" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "476cb2ec-30d5-4b5f-b924-89b003b9d47d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "331c4edd-b572-41a7-938d-05a2b89fc828");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "476cb2ec-30d5-4b5f-b924-89b003b9d47d");

            migrationBuilder.CreateTable(
                name: "PAdvice",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pID = table.Column<int>(type: "int", nullable: false),
                    uID = table.Column<int>(type: "int", nullable: false),
                    valueID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAdvice", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PDignosis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pID = table.Column<int>(type: "int", nullable: false),
                    uID = table.Column<int>(type: "int", nullable: false),
                    valueID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PDignosis", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PInvestigation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pID = table.Column<int>(type: "int", nullable: false),
                    uID = table.Column<int>(type: "int", nullable: false),
                    valueID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PInvestigation", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41ad0009-b7b9-4de3-ad01-078c380ce8f2", 0, "75ed3385-eeee-452a-bcbc-116b35888503", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEM0AxnhuX4S7jMxjh8GzJfFbQkRHaYeob3Uv4Y/sXNcgefa8K2dLEHYiZgqdIMNq2w==", null, false, "35b83dd8-1cae-4b5a-920e-09165a3ac8eb", false, "vikasmalik8881@gmail.com" },
                    { "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c", 0, "75cfdf67-1144-4137-b20e-c7981dfc7838", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEJzdKJ7zWMskVrf2XrkehJ8ebrojktDm7FP0nOI6kbU5aJW5jDly9zgRvr3TOrYxhQ==", null, false, "f31142ff-8484-483f-af9f-3c9680b7b5eb", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "41ad0009-b7b9-4de3-ad01-078c380ce8f2" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PAdvice");

            migrationBuilder.DropTable(
                name: "PDignosis");

            migrationBuilder.DropTable(
                name: "PInvestigation");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "41ad0009-b7b9-4de3-ad01-078c380ce8f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41ad0009-b7b9-4de3-ad01-078c380ce8f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67c8fdad-cd17-432e-9f2a-5ac51c00ce1c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "331c4edd-b572-41a7-938d-05a2b89fc828", 0, "1b5f48b5-71d7-4598-9bd5-bf562cf467fe", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEPJz2YLagy6wjGAxyaPywoaYooYHvoEndkpibXKXv1hGS9s7q4aWPhXGq1r+ingMvQ==", null, false, "8d7286f4-6c7d-46cc-ad38-616a45a8db2f", false, "vikasmalik8881@gmail.com" },
                    { "476cb2ec-30d5-4b5f-b924-89b003b9d47d", 0, "d00aa138-d823-40e6-b5e4-c16a2702584e", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAELpBOUmMlid378//MAcfhDCoA0TgQdsP7VZw1ru4zFGQ97aEA4Z6TOWaPmq87R36MA==", null, false, "7008cff8-e865-4dc4-bbf7-a4fe9d35f19b", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "331c4edd-b572-41a7-938d-05a2b89fc828" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "476cb2ec-30d5-4b5f-b924-89b003b9d47d" }
                });
        }
    }
}
