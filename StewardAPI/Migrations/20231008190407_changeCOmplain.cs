using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class changeCOmplain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PComplains_GenComplaintsList_GenComplaintsId",
                table: "PComplains");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "38b4ec32-da89-4657-b370-2efb1fbde11b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f473f66f-fa1e-471b-895a-bd18a99638e1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38b4ec32-da89-4657-b370-2efb1fbde11b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f473f66f-fa1e-471b-895a-bd18a99638e1");

            migrationBuilder.RenameColumn(
                name: "GenComplaintsId",
                table: "PComplains",
                newName: "GenComplaintscomplainID");

            migrationBuilder.RenameIndex(
                name: "IX_PComplains_GenComplaintsId",
                table: "PComplains",
                newName: "IX_PComplains_GenComplaintscomplainID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GenComplaintsList",
                newName: "complainID");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "64f2e05f-88c9-461f-b1c6-6c13922b043b", 0, "a3fb6408-3b69-45dc-ac03-e13f70f7b2ca", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAEN4TJPhnjNITUFc3Rii5UJsGYbc+8F5g7LREVszVd6UDsHDW+PzScPwstD1RU3iUTA==", null, false, "8427967a-51ed-49e0-8d26-bbc8e85137c4", false, "vikasmalik8881@gmail.com" },
                    { "6bf6bfe8-cad7-45d8-8e59-22c2a1f50102", 0, "888e9fa9-421d-4f94-a8a0-0e688a4b2abe", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEGvzvu1u0U+0ZFGx/5zFFVhBuUOIV9KpC4l7SIiZQn2bjbw/RyRrNIxfyVtf0whfuA==", null, false, "db515230-0550-4d7c-af3c-4344efc3cd4b", false, "Vmalik@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "64f2e05f-88c9-461f-b1c6-6c13922b043b" },
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "6bf6bfe8-cad7-45d8-8e59-22c2a1f50102" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PComplains_GenComplaintsList_GenComplaintscomplainID",
                table: "PComplains",
                column: "GenComplaintscomplainID",
                principalTable: "GenComplaintsList",
                principalColumn: "complainID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PComplains_GenComplaintsList_GenComplaintscomplainID",
                table: "PComplains");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "64f2e05f-88c9-461f-b1c6-6c13922b043b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "6bf6bfe8-cad7-45d8-8e59-22c2a1f50102" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64f2e05f-88c9-461f-b1c6-6c13922b043b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bf6bfe8-cad7-45d8-8e59-22c2a1f50102");

            migrationBuilder.RenameColumn(
                name: "GenComplaintscomplainID",
                table: "PComplains",
                newName: "GenComplaintsId");

            migrationBuilder.RenameIndex(
                name: "IX_PComplains_GenComplaintscomplainID",
                table: "PComplains",
                newName: "IX_PComplains_GenComplaintsId");

            migrationBuilder.RenameColumn(
                name: "complainID",
                table: "GenComplaintsList",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "HospitalID", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "38b4ec32-da89-4657-b370-2efb1fbde11b", 0, "c10014de-0218-4bf4-b35c-18f0d12d0ef8", "Vmalik@gmail.com", false, "Vikas", "Vikas0002", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEOM2p0EpjIrDe8r/nsL6JZ0/cn8vTow+Sr8PBxRvQhKy+C34FrndYXZRlkonDSmj4A==", null, false, "2e1db0a5-0266-420b-a49d-af697da40c9b", false, "Vmalik@gmail.com" },
                    { "f473f66f-fa1e-471b-895a-bd18a99638e1", 0, "246a5b39-673d-41df-8892-65fecaf344a1", "vikasmalik8881@gmail.com", false, "Vikas", "Vikas0001", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAECaS+whmLmGJgdZm2F3XyL9UE3ziGDJjK9nF9MMimmKaPC06C+9f0H4vN45MAV3ZYA==", null, false, "666f5f7f-617a-49fd-9824-879af8df2945", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "38b4ec32-da89-4657-b370-2efb1fbde11b" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "f473f66f-fa1e-471b-895a-bd18a99638e1" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PComplains_GenComplaintsList_GenComplaintsId",
                table: "PComplains",
                column: "GenComplaintsId",
                principalTable: "GenComplaintsList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
