﻿// <auto-generated />
using System;
using EasyMicroservices.CommentsMicroservice.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyMicroservices.CommentsMicroservice.Migrations
{
    [DbContext(typeof(CommentContext))]
    [Migration("20230927161213_update")]
    partial class update
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyMicroservices.CommentsMicroservice.Database.Entities.CommentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}