using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.API.Migrations
{
    /// <inheritdoc />
    public partial class initialidentity : Migration
    {
        /// <inheritdoc />
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

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8264), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8262), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8271), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8260), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8257), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8275), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8282), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8277), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8278) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8284), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8273), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(7860), new DateTime(2023, 12, 24, 15, 44, 32, 496, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7316), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7277), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7282), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7285), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7318), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7296), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7322), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7289), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 495, DateTimeKind.Local).AddTicks(5771), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7299), new DateTime(2023, 12, 24, 18, 44, 32, 496, DateTimeKind.Local).AddTicks(7299) });

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
        }

        /// <inheritdoc />
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3158), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3152), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3162), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3147), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3165), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3172), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3167), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3170), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3174), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3163), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(2748), new DateTime(2023, 12, 20, 11, 18, 57, 601, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2113), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2156), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 600, DateTimeKind.Local).AddTicks(134), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 12, 20, 14, 18, 57, 601, DateTimeKind.Local).AddTicks(2172) });
        }
    }
}
