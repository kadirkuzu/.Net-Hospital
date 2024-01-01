using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.API.Migrations
{
    /// <inheritdoc />
    public partial class lastupdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId1",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PatientId1",
                table: "Appointments");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8632), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8630), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8636), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8628), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8647), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8657), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8651), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8655), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8661), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8638), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8617), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8722), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8705), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8712), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8727), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8714), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8691), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 1, 1, 21, 37, 48, 430, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8777), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8777) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8757), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("38160085-0064-4bd8-ac0f-f537e994c321"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8768), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8764), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8789), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8775), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8787), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8774), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("94126296-7f82-47aa-bb30-9acd9f034764"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8781), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8786), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8769), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8766), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8772), new DateTime(2024, 1, 1, 18, 37, 48, 430, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments");

            migrationBuilder.AlterColumn<Guid>(
                name: "PatientId",
                table: "Appointments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "PatientId1",
                table: "Appointments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8327), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8310), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8306), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8334), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8348), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8340), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8345), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8352), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8331), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8290), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8417), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8425) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8437), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8454), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 1, 21, 12, 10, 174, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8537), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8537) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8499), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("38160085-0064-4bd8-ac0f-f537e994c321"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8519), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8509), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8558), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8534), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8555), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8531), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8546), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("94126296-7f82-47aa-bb30-9acd9f034764"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8541), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8552), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8522), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8516), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8549), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8526), new DateTime(2024, 1, 1, 18, 12, 10, 174, DateTimeKind.Utc).AddTicks(8526) });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId1",
                table: "Appointments",
                column: "PatientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId1",
                table: "Appointments",
                column: "PatientId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
