using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StewardAPI.Migrations
{
    /// <inheritdoc />
    public partial class pcomplain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PComplains_GenComplaintsList_GenComplaintscomplainID",
                table: "PComplains");

            migrationBuilder.DropForeignKey(
                name: "FK_PComplains_Patient_PatientId",
                table: "PComplains");

            migrationBuilder.DropIndex(
                name: "IX_PComplains_GenComplaintscomplainID",
                table: "PComplains");

            migrationBuilder.DropIndex(
                name: "IX_PComplains_PatientId",
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

            migrationBuilder.DropColumn(
                name: "GenComplaintscomplainID",
                table: "PComplains");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "PComplains",
                newName: "uID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "uID",
                table: "PComplains",
                newName: "PatientId");

            migrationBuilder.AddColumn<int>(
                name: "GenComplaintscomplainID",
                table: "PComplains",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_PComplains_GenComplaintscomplainID",
                table: "PComplains",
                column: "GenComplaintscomplainID");

            migrationBuilder.CreateIndex(
                name: "IX_PComplains_PatientId",
                table: "PComplains",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PComplains_GenComplaintsList_GenComplaintscomplainID",
                table: "PComplains",
                column: "GenComplaintscomplainID",
                principalTable: "GenComplaintsList",
                principalColumn: "complainID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PComplains_Patient_PatientId",
                table: "PComplains",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
