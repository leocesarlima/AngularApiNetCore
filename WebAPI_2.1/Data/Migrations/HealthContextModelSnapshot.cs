﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_2._1.Data;

namespace WebAPI_2._1.Data.Migrations
{
    [DbContext(typeof(HealthContext))]
    partial class HealthContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI_2._1.Models.Ailment", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PatientId");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Ailments");
                });

            modelBuilder.Entity("WebAPI_2._1.Models.Medication", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Doses");

                    b.Property<int?>("PatientId");

                    b.HasKey("Name");

                    b.HasIndex("PatientId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("WebAPI_2._1.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("WebAPI_2._1.Models.Ailment", b =>
                {
                    b.HasOne("WebAPI_2._1.Models.Patient")
                        .WithMany("Ailments")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("WebAPI_2._1.Models.Medication", b =>
                {
                    b.HasOne("WebAPI_2._1.Models.Patient")
                        .WithMany("Medications")
                        .HasForeignKey("PatientId");
                });
#pragma warning restore 612, 618
        }
    }
}