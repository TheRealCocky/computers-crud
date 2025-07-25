﻿// <auto-generated />
using System;
using Computer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Computer.Migrations
{
    [DbContext(typeof(ComputerContext))]
    [Migration("20250722001923_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Computer.Models.ComputerModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Audio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Battery")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Graphics")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Processor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Wireless")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Computers");
                });
#pragma warning restore 612, 618
        }
    }
}
