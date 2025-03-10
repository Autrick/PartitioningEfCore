﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PartitioningEfCore.database;

#nullable disable

namespace PartitioningEfCore.Migrations
{
    [DbContext(typeof(PartitiontestContext))]
    [Migration("20250306122016_second")]
    partial class second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PartitioningEfCore.database.PartTestTable", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<short>("Year")
                        .HasColumnType("smallint")
                        .HasColumnName("year");

                    b.Property<string>("Test")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("test");

                    b.Property<string>("Test2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Test3")
                        .HasColumnType("int");

                    b.HasKey("Id", "Year")
                        .HasName("PK__PartTest__8A1A4A07B5F1E9F5");

                    b.ToTable("PartTestTable", (string)null);

                    b
                        .HasAnnotation("Partition:FieldName", "Year")
                        .HasAnnotation("Partition:SchemaName", "TestMertSheme");
                });

            modelBuilder.Entity("PartitioningEfCore.database.TestTable", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<short>("Year")
                        .HasColumnType("smallint")
                        .HasColumnName("year");

                    b.Property<string>("Test")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("test");

                    b.Property<string>("Test2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Test3")
                        .HasColumnType("int");

                    b.HasKey("Id", "Year")
                        .HasName("PK__TestTabl__8A1A4A07B536F814");

                    b.ToTable("TestTable", (string)null);
                });

            modelBuilder.Entity("PartitioningEfCore.database.TestYear", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<short>("Year")
                        .HasColumnType("smallint");

                    b.Property<string>("Testfeld")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id", "Year");

                    b.ToTable("TestYears");

                    b
                        .HasAnnotation("Partition:FieldName", "Year")
                        .HasAnnotation("Partition:SchemaName", "TestMertSheme");
                });
#pragma warning restore 612, 618
        }
    }
}
