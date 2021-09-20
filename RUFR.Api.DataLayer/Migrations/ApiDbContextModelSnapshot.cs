﻿// <auto-generated />
using System;
using Api.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RUFR.Api.DataLayer.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("RUFR.Api.Model.Models.DocumentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<byte[]>("DocByte")
                        .HasColumnType("bytea");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DocumentModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.EventModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Theme")
                        .HasColumnType("text");

                    b.Property<int>("TypeEven")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("EventModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.HistoryOfSuccessModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Countrys")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("TypesOfHistory")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("HistoryOfSuccessModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Countrys")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MemberModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.NewsModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Theme")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("NewsModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.PriorityDirectionModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("ProjectModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.HasIndex("ProjectModelId");

                    b.ToTable("PriorityDirectionModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Countrys")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ProjectStage")
                        .HasColumnType("integer");

                    b.Property<int>("TypeOfProject")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ProjectModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.TypesOfCooperationModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.ToTable("TypesOfCooperationModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Admin")
                        .HasColumnType("boolean");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Pass")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.PriorityDirectionModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("Priorities")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.ProjectModel", "ProjectModel")
                        .WithMany("Priorities")
                        .HasForeignKey("ProjectModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");

                    b.Navigation("ProjectModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.TypesOfCooperationModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("TypesOfCooperationModels")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberModel", b =>
                {
                    b.Navigation("Priorities");

                    b.Navigation("TypesOfCooperationModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectModel", b =>
                {
                    b.Navigation("Priorities");
                });
#pragma warning restore 612, 618
        }
    }
}
