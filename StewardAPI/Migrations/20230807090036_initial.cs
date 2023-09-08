using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StewardAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "diagnosis",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    diagnosisname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diagnosis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fees = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenComplaintsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complaints = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenComplaintsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenDiagnosisList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenDiagnosisList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenMedicinesList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenMedicinesList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientAdvise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Advice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    Datetime = table.Column<DateTime>(type: "date", nullable: true, defaultValueSql: "(getdate())"),
                    Uhid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientAdvise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientComplaints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Uhid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientComplaints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Complaintname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Uhid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientInvestigation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvestigationName = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Uhid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientInvestigation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    when_take = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    frequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pid = table.Column<int>(type: "int", nullable: true),
                    Datetime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Uhid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uhid = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    Opdtype = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    Opdfess = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", null, "User", "USER" },
                    { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c5977a8-b26d-4af7-9e59-fd87bdd1cbd0", 0, "0d0e9588-8eba-4490-9b4a-95d34851d99a", "Vmalik@gmail.com", false, "Vikas", "Malik", false, null, "VMALIK@GMAIL.COM", "VMALIK@GMAIL.COM", "AQAAAAIAAYagAAAAEFPCRM1pKrzKTGifEPVzAQQViLQPZesYr+fofWBG8PWjQjkQo5sWencWaSmMKarnOg==", null, false, "fd069c52-b25d-4084-b0cd-116ad81136f6", false, "Vmalik@gmail.com" },
                    { "c458ec56-8cf5-4c3f-afc6-33c3a8157b4a", 0, "1fbcfc93-b30e-4746-b66c-01c16e76ab41", "vikasmalik8881@gmail.com", false, "Vikas", "Malik", false, null, "VIKASMALIK8881@GMAIL.COM", "VIKASMALIK8881@GMAIL.COM", "AQAAAAIAAYagAAAAELYzuPvGD1FvH2GO76x7up50KFQZtbwUtKDJ0vAu5omNgZKe/h43Rh8eNoE4vsalmQ==", null, false, "583dfb89-4898-4065-abe4-1af9f55c3399", false, "vikasmalik8881@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "GenDiagnosisList",
                columns: new[] { "Id", "Diagnosis" },
                values: new object[,]
                {
                    { 1, "ABD DISTENTION OCCASIONALLY" },
                    { 2, "ABDOMEN" },
                    { 3, "ABDOMINAL CRAMPS" },
                    { 4, "ACUTE RETENTION OF URINE TWICE" },
                    { 5, "ACUTE RESPIRATORY TRACT INFECTION" },
                    { 6, "ACUTE CHEST PAIN" },
                    { 7, "ACUTE RHINITIS" },
                    { 8, "ACUTE KIDNEY INJURY" },
                    { 9, "ACUTE GASTROENTERITIS" },
                    { 10, "ACUTE LOW BACK PAIN" },
                    { 11, "ACUTE RHINOSINUSITIS" },
                    { 12, "ACUTE BRONCHITIS" },
                    { 13, "ACUTE ABDOMINAL PAIN" },
                    { 14, "Acne" },
                    { 15, "ACID ERUCTATION ACID PEPTIC DISEASE ACIDITY" },
                    { 16, "ACANTHOSIS NIGRICANS" },
                    { 17, "ACHE ACHYMOSIS" },
                    { 18, "ACNE VULGARIS" },
                    { 19, "ACROMEGALY" },
                    { 20, "ACUTE BRONCHITIS" },
                    { 21, "ACUTE CHEST PAIN" },
                    { 23, "ACUTE DIARRHOEA" },
                    { 24, "ACUTE EXACERBATION" },
                    { 25, "ACUTE FEBRILE ILLNESS" },
                    { 26, "ACUTE GASTROENTERITIS" },
                    { 27, "ACUTE GASTRITIS" },
                    { 28, "ACUTE KIDNEY INJURY" },
                    { 29, "ACUTE LOW BACK PAIN" },
                    { 30, "ACUTE OTITIS EXTERNA" },
                    { 31, "ACUTE RETENTION OF URINE TWICE" },
                    { 32, "ACUTE RESPIRATORY TRACT INFECTION" },
                    { 33, "ACUTE RHINITIS" },
                    { 34, "ACUTE RHINOSINUSITIS" },
                    { 35, "ACUTE VERTIGO" },
                    { 36, "ADMIT" },
                    { 37, "AEROPHAGIA" },
                    { 38, "AFTER DEFECATION" },
                    { 39, "AFEBRILE" }
                });

            migrationBuilder.InsertData(
                table: "GenDiagnosisList",
                columns: new[] { "Id", "Diagnosis" },
                values: new object[,]
                {
                    { 40, "AGGRESSIVE" },
                    { 41, "AGITATED DEPRESSION" },
                    { 42, "AGGRESSION" },
                    { 43, "AGITATION" },
                    { 44, "AGORAPHOBIA" },
                    { 45, "AGGRESSION LESS" },
                    { 46, "AHO RTA" },
                    { 47, "AID TYPE 1" },
                    { 48, "AIR HUNGER" },
                    { 49, "AID TYPE 2" },
                    { 50, "ALBUMINURIA" },
                    { 51, "ALCHOL INTAKE DAILY" },
                    { 52, "ALCOHOLIC" },
                    { 53, "ALLERGY" },
                    { 54, "ALLERGIC WHOLE BODY RASHES" },
                    { 55, "ALLERGIC BRONCHITIS" },
                    { 56, "ALLERGIC CONJUNCTIVITIS" },
                    { 57, "ALLERGIC RHINITIS" },
                    { 58, "ALLERGIC RASHES" },
                    { 59, "ALLERGIC COUGH" },
                    { 60, "ALOPECIA" },
                    { 61, "ALTERNATING CONSTIPATENT" },
                    { 62, "ALTERED TASTE" },
                    { 63, "ALTERATION OF TASTE" },
                    { 64, "ALTERED BOWEL HABIT" },
                    { 65, "ALTERED SENSORIUM" },
                    { 66, "ALTERED VOICE" },
                    { 67, "ALTERED SLEEP" },
                    { 68, "AMPTATION BELOW KNEE" },
                    { 69, "AMOTIVATION" },
                    { 70, "AMENORRHEA" },
                    { 71, "AMNESIA" },
                    { 72, "ANAEMIA" },
                    { 73, "ANAL ITCHING" },
                    { 74, "ANAL BURNING" },
                    { 75, "ANASARCA" },
                    { 76, "ANAL FISSURE" },
                    { 77, "ANAL PAIN" },
                    { 78, "ANDROGENETIC ALOPECIA" },
                    { 79, "ANEMIA" },
                    { 80, "ANERGIA" },
                    { 81, "ANGER" }
                });

            migrationBuilder.InsertData(
                table: "GenDiagnosisList",
                columns: new[] { "Id", "Diagnosis" },
                values: new object[,]
                {
                    { 82, "ANGINA" },
                    { 83, "ANHEDONIA" },
                    { 84, "ANKLE SWELLING" },
                    { 85, "ANKLE JOINT PAIN" },
                    { 86, "ANKLE PAIN" },
                    { 87, "ANKLE INJURY" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba4026c4-1f90-478d-9b0f-dbee61cdb2cc", "2c5977a8-b26d-4af7-9e59-fd87bdd1cbd0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "de4ccc9c-2743-4c14-aa50-394d66c3b17b", "c458ec56-8cf5-4c3f-afc6-33c3a8157b4a" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_DoctorId",
                table: "Patient",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CityList");

            migrationBuilder.DropTable(
                name: "diagnosis");

            migrationBuilder.DropTable(
                name: "GenComplaintsList");

            migrationBuilder.DropTable(
                name: "GenDiagnosisList");

            migrationBuilder.DropTable(
                name: "GenMedicinesList");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "PatientAdvise");

            migrationBuilder.DropTable(
                name: "PatientComplaints");

            migrationBuilder.DropTable(
                name: "PatientDiagnosis");

            migrationBuilder.DropTable(
                name: "PatientInvestigation");

            migrationBuilder.DropTable(
                name: "PatientMedicine");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Doctor");
        }
    }
}
