﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalPOCService.database;

#nullable disable

namespace finalPOCService.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240328091154_phase5")]
    partial class phase5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("User", b =>
                {
                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("userName");

                    b.ToTable("users");
                });

            modelBuilder.Entity("finalPOCService.models.Employee", b =>
                {
                    b.Property<int>("empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empid"));

                    b.Property<string>("empDesig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("empPhoneNo")
                        .HasColumnType("int");

                    b.Property<int>("empSal")
                        .HasColumnType("int");

                    b.HasKey("empid");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("finalPOCService.models.Movie", b =>
                {
                    b.Property<int>("mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("mid"));

                    b.Property<string>("movieCast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("movieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("movieYear")
                        .HasColumnType("int");

                    b.HasKey("mid");

                    b.ToTable("movies");
                });
#pragma warning restore 612, 618
        }
    }
}
