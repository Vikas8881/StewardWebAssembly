using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class valueIDcomplain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "a2686e3e-1bb3-442e-927b-61bd556a1f3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c2ae5fc3-356c-4dc6-a10e-3d95d4f5c932" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2686e3e-1bb3-442e-927b-61bd556a1f3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2ae5fc3-356c-4dc6-a10e-3d95d4f5c932");

            migrationBuilder.AddColumn<int>(
                name: "valueID",
                table: "GenComplaintsList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "52fce54e-6e74-4b3b-94e4-c9967ac30b86", 0, "096c6122-60e1-4c3f-8bcb-99e8d1aa4cec", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEEwhMl399tZQ5yUCVmRtOETutez4zqFszfg5Kcg6coGmv0bAUNIJuj2hk5HneqJyDg==", null, false, "9d2bcc7c-138c-4c36-9626-583aaafb111d", false, "Vmalik@gmail.com" },
                    { "9456d830-dc4f-4245-ba26-a19b23a6bfd0", 0, "30111c25-e683-4968-9461-7dde92bf5bb0", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAENVviDwsJVnbBN/b/e4Gnb+GAtf0R90FHXk0eIjHKvBRZjbHiyeCPvGtzI1xLYnKgw==", null, false, "740b69a4-92d4-4d2c-a6d7-38f71bbab49f", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "52fce54e-6e74-4b3b-94e4-c9967ac30b86" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9456d830-dc4f-4245-ba26-a19b23a6bfd0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "52fce54e-6e74-4b3b-94e4-c9967ac30b86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "9456d830-dc4f-4245-ba26-a19b23a6bfd0" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52fce54e-6e74-4b3b-94e4-c9967ac30b86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9456d830-dc4f-4245-ba26-a19b23a6bfd0");

            migrationBuilder.DropColumn(
                name: "valueID",
                table: "GenComplaintsList");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a2686e3e-1bb3-442e-927b-61bd556a1f3b", 0, "5f6c08d0-4cdc-4c95-9eae-11468e52aa99", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEBSLnyJ1QUsaYk+BPK2kv+fINqDuJLPQebjr36h0+wDhhzuEpKf6OgVOI3AXyaygrw==", null, false, "4e20f2a8-28cb-4995-a65c-f4797ed8e11f", false, "Vmalik@gmail.com" },
                    { "c2ae5fc3-356c-4dc6-a10e-3d95d4f5c932", 0, "f10b8de2-c76a-4f34-acad-5ad32d4c8730", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEDgmJsHOEBnsr9rGOZfjQ8cGVsGAaXUM7A6CdC4KNj9PzbmiemXN2QXGKLkUYCBbLw==", null, false, "ff41e2b5-1882-444b-8f96-9ea88c5eecdc", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "a2686e3e-1bb3-442e-927b-61bd556a1f3b" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c2ae5fc3-356c-4dc6-a10e-3d95d4f5c932" }
                });
        }
    }
}
