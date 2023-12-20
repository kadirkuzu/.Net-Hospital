using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.API.Migrations
{
    /// <inheritdoc />
    public partial class addseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "WorkSchedules",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Patients",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Doctors",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Clinics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Appointments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2675), "Üroloji", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2675) },
                    { new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2656), "Cerrahi", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2658) },
                    { new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2661), "Göz Hastalıkları", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2661) },
                    { new Guid("676db547-3439-40e1-b3d9-c11d554c585d"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2663), "Kulak Burun Boğaz", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2664) },
                    { new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2685), "Psikiyatri", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2686) },
                    { new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2671), "Radyoloji", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2671) },
                    { new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2688), "Çocuk Sağlığı ve Hastalıkları", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2689) },
                    { new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2665), "Dermatoloji", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2666) },
                    { new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"), new DateTime(2023, 12, 20, 1, 35, 53, 258, DateTimeKind.Local).AddTicks(9115), "Dahiliye", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2037) },
                    { new Guid("e0c96494-819f-451e-b684-dff2aed17b02"), new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2673), "Nükleer Tıp", new DateTime(2023, 12, 20, 1, 35, 53, 260, DateTimeKind.Local).AddTicks(2673) }
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "CreatedDate", "DepartmentId", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"), "Göz Hastalıkları", null },
                    { new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"), "Ortopedi", null },
                    { new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("676db547-3439-40e1-b3d9-c11d554c585d"), "Kulak Burun Boğaz", null },
                    { new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"), "Genel Cerrahi", null },
                    { new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"), "Nöroloji", null },
                    { new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"), "Radyoloji", null },
                    { new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"), "Psikiyatri", null },
                    { new Guid("860534f3-f075-4135-ab73-e4770d7bd781"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e0c96494-819f-451e-b684-dff2aed17b02"), "Nükleer Tıp", null },
                    { new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"), "Üroloji", null },
                    { new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"), "Çocuk Kardiyolojisi", null },
                    { new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"), "Dermatoloji", null },
                    { new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"), "Kardiyoloji", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("860534f3-f075-4135-ab73-e4770d7bd781"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"));

            migrationBuilder.DeleteData(
                table: "Clinics",
                keyColumn: "Id",
                keyValue: new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("676db547-3439-40e1-b3d9-c11d554c585d"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("e0c96494-819f-451e-b684-dff2aed17b02"));

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "WorkSchedules");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Clinics");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Appointments");
        }
    }
}
