﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WireFrames;

namespace WireFrame.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210718140751_AdminFlightBookAddedRegistration")]
    partial class AdminFlightBookAddedRegistration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WireFrames.Model.Airlines", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("F_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("airliness");
                });

            modelBuilder.Entity("WireFrames.Model.FlightInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("airlineId")
                        .HasColumnType("int");

                    b.Property<string>("briefInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("businessSeats")
                        .HasColumnType("int");

                    b.Property<decimal>("cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("destinationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("flightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instrumentUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("mealTypeId")
                        .HasColumnType("int");

                    b.Property<int>("nonBusinessSeats")
                        .HasColumnType("int");

                    b.Property<byte>("noofRows")
                        .HasColumnType("tinyint");

                    b.Property<int?>("scheduleTypesId")
                        .HasColumnType("int");

                    b.Property<int?>("sourceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("airlineId");

                    b.HasIndex("destinationId");

                    b.HasIndex("mealTypeId");

                    b.HasIndex("scheduleTypesId");

                    b.HasIndex("sourceId");

                    b.ToTable("flightInfos");
                });

            modelBuilder.Entity("WireFrames.Model.Meals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MealType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("mealss");
                });

            modelBuilder.Entity("WireFrames.Model.Places", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("plcs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("placess");
                });

            modelBuilder.Entity("WireFrames.Model.ScheduleType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("schType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("scheduleTypess");
                });

            modelBuilder.Entity("WireFrames.Model.FlightInfo", b =>
                {
                    b.HasOne("WireFrames.Model.Airlines", "airline")
                        .WithMany()
                        .HasForeignKey("airlineId");

                    b.HasOne("WireFrames.Model.Places", "destination")
                        .WithMany()
                        .HasForeignKey("destinationId");

                    b.HasOne("WireFrames.Model.Meals", "mealType")
                        .WithMany()
                        .HasForeignKey("mealTypeId");

                    b.HasOne("WireFrames.Model.ScheduleType", "scheduleTypes")
                        .WithMany()
                        .HasForeignKey("scheduleTypesId");

                    b.HasOne("WireFrames.Model.Places", "source")
                        .WithMany()
                        .HasForeignKey("sourceId");

                    b.Navigation("airline");

                    b.Navigation("destination");

                    b.Navigation("mealType");

                    b.Navigation("scheduleTypes");

                    b.Navigation("source");
                });
#pragma warning restore 612, 618
        }
    }
}