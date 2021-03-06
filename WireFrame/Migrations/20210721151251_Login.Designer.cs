// <auto-generated />
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
    [Migration("20210721151251_Login")]
    partial class Login
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WireFrame.Model.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("confirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("contactNo")
                        .HasColumnType("int");

                    b.Property<bool>("isUser")
                        .HasColumnType("bit");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("registrations");
                });

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

                    b.Property<string>("airline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("briefInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("businessSeats")
                        .HasColumnType("int");

                    b.Property<decimal>("cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("flightNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instrumentUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mealType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nonBusinessSeats")
                        .HasColumnType("int");

                    b.Property<byte>("noofRows")
                        .HasColumnType("tinyint");

                    b.Property<string>("scheduleTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

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
#pragma warning restore 612, 618
        }
    }
}
