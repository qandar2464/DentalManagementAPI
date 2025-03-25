﻿// <auto-generated />
using System;
using DentalManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DentalManagementAPI.Migrations
{
    [DbContext(typeof(DentalManagementContext))]
    partial class DentalManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DentalManagementAPI.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientID"));

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TreatmentID")
                        .HasColumnType("int");

                    b.HasKey("PatientID");

                    b.HasIndex("TreatmentID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("DentalManagementAPI.Models.Treatment", b =>
                {
                    b.Property<int>("TreatmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreatmentID"));

                    b.Property<string>("TreatmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TreatmentSpecialist")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TreatmentID");

                    b.ToTable("Treatments");
                });

            modelBuilder.Entity("DentalManagementAPI.Models.Patient", b =>
                {
                    b.HasOne("DentalManagementAPI.Models.Treatment", "Treatment")
                        .WithMany()
                        .HasForeignKey("TreatmentID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Treatment");
                });
#pragma warning restore 612, 618
        }
    }
}
