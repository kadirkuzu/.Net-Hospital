using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.API.Migrations
{
    /// <inheritdoc />
    public partial class workscheduledoctor2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkSchedules_Doctors_DoctorId",
                table: "WorkSchedules");

            migrationBuilder.DropIndex(
                name: "IX_WorkSchedules_DoctorId",
                table: "WorkSchedules");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "WorkSchedules");

            migrationBuilder.CreateTable(
                name: "DoctorWorkSchedule",
                columns: table => new
                {
                    DoctorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkSchedulesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorWorkSchedule", x => new { x.DoctorsId, x.WorkSchedulesId });
                    table.ForeignKey(
                        name: "FK_DoctorWorkSchedule_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorWorkSchedule_WorkSchedules_WorkSchedulesId",
                        column: x => x.WorkSchedulesId,
                        principalTable: "WorkSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8921), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8918), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8924), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8916), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8914), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8931), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8938), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8933), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8936), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8929), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8529), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(8529) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7969), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7953), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7978), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7963), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7958), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 703, DateTimeKind.Local).AddTicks(5267), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7966), new DateTime(2023, 12, 31, 19, 23, 22, 704, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(738), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(9896), new DateTime(2023, 12, 31, 16, 23, 22, 704, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("38160085-0064-4bd8-ac0f-f537e994c321"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(667), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(658), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(751), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(737), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(749), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(735), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(744), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("94126296-7f82-47aa-bb30-9acd9f034764"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(741), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(748), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(669), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(665), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(746), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(733), new DateTime(2023, 12, 31, 16, 23, 22, 705, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorWorkSchedule_WorkSchedulesId",
                table: "DoctorWorkSchedule",
                column: "WorkSchedulesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorWorkSchedule");

            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "WorkSchedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3842), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3839), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3848), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3837), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3834), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3856), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3858), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3861), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3864), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3854), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3450), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2853), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2857), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2882), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2867), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2861), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 503, DateTimeKind.Local).AddTicks(9650), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2870), new DateTime(2023, 12, 31, 19, 22, 14, 505, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4842), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4331), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("38160085-0064-4bd8-ac0f-f537e994c321"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4803), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4796), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4854), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4841), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4852), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4839), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4848), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("94126296-7f82-47aa-bb30-9acd9f034764"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4845), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4851), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4834), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4802), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4850), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"),
                columns: new[] { "CreatedDate", "DoctorId", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4837), null, new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4837) });

            migrationBuilder.CreateIndex(
                name: "IX_WorkSchedules_DoctorId",
                table: "WorkSchedules",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkSchedules_Doctors_DoctorId",
                table: "WorkSchedules",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }
    }
}
