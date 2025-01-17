﻿// <auto-generated />
using System;
using CodeFirst1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602164101_RelationStudentAndroom")]
    partial class RelationStudentAndroom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst1.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int?>("roomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("roomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CodeFirst1.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Fatma@hotmail.com",
                            FirstName = "Fatma",
                            LastName = "Alqhtnay"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Housh@hotmail.com",
                            FirstName = "Housh",
                            LastName = "Alqhtnay"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Abdulaziz@hotmail.com",
                            FirstName = "Abdulaziz",
                            LastName = "Alqhtnay"
                        });
                });

            modelBuilder.Entity("CodeFirst1.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("subject");
                });

            modelBuilder.Entity("CodeFirst1.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CodeFirst1.Models.Room", b =>
                {
                    b.HasOne("CodeFirst1.Models.Room", "room")
                        .WithMany()
                        .HasForeignKey("roomId");
                });

            modelBuilder.Entity("CodeFirst1.Models.Subject", b =>
                {
                    b.HasOne("CodeFirst1.Models.Subject", null)
                        .WithMany("subjects")
                        .HasForeignKey("SubjectId");

                    b.HasOne("CodeFirst1.Models.Teacher", null)
                        .WithMany("subjects")
                        .HasForeignKey("TeacherId");
                });
#pragma warning restore 612, 618
        }
    }
}
