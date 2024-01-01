using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.API.Migrations
{
    /// <inheritdoc />
    public partial class updateappointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDateTime",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Appointments",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1394), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1395) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1398), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1403), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1413), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1405), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1409), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1418), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1361), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1488), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1470), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1490), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1481), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1493), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1478), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1484), new DateTime(2024, 1, 1, 17, 24, 6, 217, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1543), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1543) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("38160085-0064-4bd8-ac0f-f537e994c321"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1531), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1527), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1557), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1541), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1555), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("94126296-7f82-47aa-bb30-9acd9f034764"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1552), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1533), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1529), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1550), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"),
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1538), new DateTime(2024, 1, 1, 14, 24, 6, 217, DateTimeKind.Utc).AddTicks(1538) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Appointments");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDateTime",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }
    }
}
