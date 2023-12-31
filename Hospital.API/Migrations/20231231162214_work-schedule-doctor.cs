using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.API.Migrations
{
    /// <inheritdoc />
    public partial class workscheduledoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkSchedules_Doctors_DoctorId",
                table: "WorkSchedules");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "WorkSchedules",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.InsertData(
                table: "WorkSchedules",
                columns: new[] { "Id", "CreatedDate", "Day", "DoctorId", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4842), 3, null, new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4843) },
                    { new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4331), 1, null, new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4331) },
                    { new Guid("38160085-0064-4bd8-ac0f-f537e994c321"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4803), 2, null, new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4804) },
                    { new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4796), 1, null, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4797) },
                    { new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4854), 5, null, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4854) },
                    { new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4841), 3, null, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4841) },
                    { new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4852), 5, null, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4853) },
                    { new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4839), 3, null, new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4839) },
                    { new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4848), 4, null, new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 9, 30, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4848) },
                    { new Guid("94126296-7f82-47aa-bb30-9acd9f034764"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4845), 4, null, new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 8, 30, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4845) },
                    { new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4851), 5, null, new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4851) },
                    { new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4834), 2, null, new TimeSpan(0, 17, 30, 0, 0), new TimeSpan(0, 9, 30, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4834) },
                    { new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4802), 1, null, new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4802) },
                    { new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4850), 4, null, new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 10, 30, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4850) },
                    { new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4837), 2, null, new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 10, 30, 0, 0), new DateTime(2023, 12, 31, 16, 22, 14, 505, DateTimeKind.Utc).AddTicks(4837) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkSchedules_Doctors_DoctorId",
                table: "WorkSchedules",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkSchedules_Doctors_DoctorId",
                table: "WorkSchedules");

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("0c58466a-8559-4249-a83c-a3064d03f8ab"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("28a8033a-01bf-46ec-90f9-69005a6cbd76"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("38160085-0064-4bd8-ac0f-f537e994c321"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("3a82bcfd-4b6a-4361-8736-eced0dea0ea4"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("55ccbd89-e20e-422f-b614-ba3ff67b2394"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("580c0024-b1ac-4be7-a253-bcf62f1d2e4e"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("73b146ed-f452-4dc9-809c-b0c99349b8f3"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("898bd61c-a0c9-4d3e-a766-91fd9334883e"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("8e2d6ca3-9df7-45f1-b105-42165081a668"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("94126296-7f82-47aa-bb30-9acd9f034764"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("c0f50486-c9a3-41dd-968c-fdbccc643493"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d079adc8-cbfa-4ec5-8bd7-1fa525a500cf"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("d9ac0b92-2653-4424-ab51-ebfc93ed53c0"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("dec376af-cbce-43f7-893c-eea954ecfc36"));

            migrationBuilder.DeleteData(
                table: "WorkSchedules",
                keyColumn: "Id",
                keyValue: new Guid("e86dd92d-6533-4648-96ef-ee3853088a77"));

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorId",
                table: "WorkSchedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_WorkSchedules_Doctors_DoctorId",
                table: "WorkSchedules",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
