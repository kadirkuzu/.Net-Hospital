﻿// <auto-generated />
using System;
using Hospital.API.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.API.Migrations
{
    [DbContext(typeof(HospitalDbContext))]
    [Migration("20231220010725_update-create-date")]
    partial class updatecreatedate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AppointmentDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Hospital.Models.Clinic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Clinics");

                    b.HasData(
                        new
                        {
                            Id = new Guid("eb6b54e5-48be-48b4-8907-490ab13648c8"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(1840),
                            DepartmentId = new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                            Name = "Kardiyoloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(1840)
                        },
                        new
                        {
                            Id = new Guid("6b936aed-3d63-4b02-ace8-b7ab4b7edb98"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2253),
                            DepartmentId = new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                            Name = "Nöroloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2253)
                        },
                        new
                        {
                            Id = new Guid("5a97f4f6-49f5-4571-b6ed-d31ae749f879"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2294),
                            DepartmentId = new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                            Name = "Genel Cerrahi",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2294)
                        },
                        new
                        {
                            Id = new Guid("178f1526-a8dc-4664-96ae-78201d26ca73"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2297),
                            DepartmentId = new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                            Name = "Ortopedi",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2297)
                        },
                        new
                        {
                            Id = new Guid("038860b2-9030-42b8-aabe-0015dfd787d4"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2299),
                            DepartmentId = new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                            Name = "Göz Hastalıkları",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2299)
                        },
                        new
                        {
                            Id = new Guid("389af84b-47a3-47f3-b13d-0551ddad1261"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2303),
                            DepartmentId = new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                            Name = "Kulak Burun Boğaz",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2303)
                        },
                        new
                        {
                            Id = new Guid("ae1609ef-a81f-4a38-b960-2557edfe5d89"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2305),
                            DepartmentId = new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                            Name = "Dermatoloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2306)
                        },
                        new
                        {
                            Id = new Guid("7073d4e7-08f3-40f3-88a2-b9b8526bd868"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2307),
                            DepartmentId = new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                            Name = "Radyoloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2308)
                        },
                        new
                        {
                            Id = new Guid("860534f3-f075-4135-ab73-e4770d7bd781"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2312),
                            DepartmentId = new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                            Name = "Nükleer Tıp",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2312)
                        },
                        new
                        {
                            Id = new Guid("95930205-0c05-48df-9af8-9c6ccaa72fba"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2315),
                            DepartmentId = new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                            Name = "Üroloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2315)
                        },
                        new
                        {
                            Id = new Guid("83698d36-f530-48a8-be2a-aaabb9cf0b10"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2317),
                            DepartmentId = new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                            Name = "Psikiyatri",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2317)
                        },
                        new
                        {
                            Id = new Guid("a76eafb3-b854-4f5c-9932-94b2d474d44a"),
                            CreatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2319),
                            DepartmentId = new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                            Name = "Çocuk Kardiyolojisi",
                            UpdatedDate = new DateTime(2023, 12, 20, 1, 7, 25, 468, DateTimeKind.Utc).AddTicks(2319)
                        });
                });

            modelBuilder.Entity("Hospital.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b385ba05-80a5-4506-ae84-267ceac1d2c5"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 466, DateTimeKind.Local).AddTicks(9380),
                            Name = "Dahiliye",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(724)
                        },
                        new
                        {
                            Id = new Guid("5c0f696d-f2df-4cb5-9c00-af62e6f150d9"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1235),
                            Name = "Cerrahi",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1237)
                        },
                        new
                        {
                            Id = new Guid("66e37f12-b526-4ac5-ae2f-43575a1c7780"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1250),
                            Name = "Göz Hastalıkları",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1250)
                        },
                        new
                        {
                            Id = new Guid("676db547-3439-40e1-b3d9-c11d554c585d"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1253),
                            Name = "Kulak Burun Boğaz",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1253)
                        },
                        new
                        {
                            Id = new Guid("ac6aa076-16df-4a32-9f63-dc45333c3fba"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1255),
                            Name = "Dermatoloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1256)
                        },
                        new
                        {
                            Id = new Guid("9e5b98f5-392f-4f7c-ba6c-ea729936c7af"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1263),
                            Name = "Radyoloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1263)
                        },
                        new
                        {
                            Id = new Guid("e0c96494-819f-451e-b684-dff2aed17b02"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1265),
                            Name = "Nükleer Tıp",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1266)
                        },
                        new
                        {
                            Id = new Guid("3f677574-0f3a-468f-b1df-00b1a29f8282"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1268),
                            Name = "Üroloji",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1268)
                        },
                        new
                        {
                            Id = new Guid("699d5895-2a50-4b52-ad05-6397ed824df6"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1271),
                            Name = "Psikiyatri",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1271)
                        },
                        new
                        {
                            Id = new Guid("a90ad436-5091-43aa-b287-cf6bd03e47df"),
                            CreatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1275),
                            Name = "Çocuk Sağlığı ve Hastalıkları",
                            UpdatedDate = new DateTime(2023, 12, 20, 4, 7, 25, 468, DateTimeKind.Local).AddTicks(1275)
                        });
                });

            modelBuilder.Entity("Hospital.Models.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClinicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Hospital.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Hospital.Models.WorkSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("WorkSchedules");
                });

            modelBuilder.Entity("Hospital.Models.Appointment", b =>
                {
                    b.HasOne("Hospital.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hospital.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Hospital.Models.Clinic", b =>
                {
                    b.HasOne("Hospital.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Hospital.Models.Doctor", b =>
                {
                    b.HasOne("Hospital.Models.Clinic", "Clinic")
                        .WithMany("Doctors")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("Hospital.Models.WorkSchedule", b =>
                {
                    b.HasOne("Hospital.Models.Doctor", "Doctor")
                        .WithMany("WorkSchedules")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Hospital.Models.Clinic", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Hospital.Models.Doctor", b =>
                {
                    b.Navigation("WorkSchedules");
                });

            modelBuilder.Entity("Hospital.Models.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
