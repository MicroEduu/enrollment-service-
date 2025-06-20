﻿// <auto-generated />
using System;
using EnrollmentService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnrollmentService.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250611204742_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EnrollmentService.Models.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAluno")
                        .HasColumnType("int");

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAluno", "IdCurso")
                        .IsUnique();

                    b.ToTable("Matriculas");
                });
#pragma warning restore 612, 618
        }
    }
}
