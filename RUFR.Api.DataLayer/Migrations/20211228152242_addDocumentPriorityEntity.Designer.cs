﻿// <auto-generated />
using System;
using Api.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RUFR.Api.DataLayer.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211228152242_addDocumentPriorityEntity")]
    partial class addDocumentPriorityEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("RUFR.Api.Model.Models.DocumentModel", b =>
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

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<byte[]>("DocByte")
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

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

            modelBuilder.Entity("RUFR.Api.Model.Models.DocumentPriorityModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("DocumentModelId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("PriorityDirectionModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DocumentModelId");

                    b.HasIndex("PriorityDirectionModelId");

                    b.ToTable("DocumentPriorityModel");
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

                    b.Property<string>("Description")
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

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Countrys")
                        .HasColumnType("text");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("WebSite")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MemberModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberPriorityModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<long>("PriorityDirectionModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.HasIndex("PriorityDirectionModelId");

                    b.ToTable("MemberPriorityModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberTypesOfCooperationModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<long>("TypesOfCooperationModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.HasIndex("TypesOfCooperationModelId");

                    b.ToTable("MemberTypesOfCooperationModels");
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

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMain")
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

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PriorityDirectionModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectMemberModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.HasIndex("ProjectModelId");

                    b.ToTable("ProjectMemberModels");
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

                    b.Property<string>("Description")
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

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectPriorityModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("PriorityDirectionModelId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PriorityDirectionModelId");

                    b.HasIndex("ProjectModelId");

                    b.ToTable("ProjectPriorityModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.StatisticalInformationModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.ToTable("StatisticalInformationModels");
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

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypesOfCooperationModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserDocumentModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("DocumentModelId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<long>("UserModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DocumentModelId");

                    b.HasIndex("UserModelId");

                    b.ToTable("UserDocumentModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserMemberModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("MemberModelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<long>("UserModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MemberModelId");

                    b.HasIndex("UserModelId");

                    b.ToTable("UserMemberModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Pass")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserProjectModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<long>("ProjectModelId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserModelId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProjectModelId");

                    b.HasIndex("UserModelId");

                    b.ToTable("UserProjectModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.DocumentPriorityModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.DocumentModel", "DocumentModel")
                        .WithMany("DocumentPriorityModels")
                        .HasForeignKey("DocumentModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.PriorityDirectionModel", "PriorityDirectionModel")
                        .WithMany("DocumentPriorityModels")
                        .HasForeignKey("PriorityDirectionModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentModel");

                    b.Navigation("PriorityDirectionModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberPriorityModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("MemberPriorityModels")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.PriorityDirectionModel", "PriorityDirectionModel")
                        .WithMany("MemberPriorityModels")
                        .HasForeignKey("PriorityDirectionModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");

                    b.Navigation("PriorityDirectionModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberTypesOfCooperationModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("MemberTypesOfCooperationModels")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.TypesOfCooperationModel", "TypesOfCooperationModel")
                        .WithMany("MemberTypesOfCooperationModels")
                        .HasForeignKey("TypesOfCooperationModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");

                    b.Navigation("TypesOfCooperationModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectMemberModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("ProjectMemberModels")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.ProjectModel", "ProjectModel")
                        .WithMany("ProjectMemberModels")
                        .HasForeignKey("ProjectModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");

                    b.Navigation("ProjectModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectPriorityModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.PriorityDirectionModel", "PriorityDirectionModel")
                        .WithMany("ProjectPriorityModels")
                        .HasForeignKey("PriorityDirectionModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.ProjectModel", "ProjectModel")
                        .WithMany("ProjectPriorityModels")
                        .HasForeignKey("ProjectModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PriorityDirectionModel");

                    b.Navigation("ProjectModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.StatisticalInformationModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("StatisticalInformationModels")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserDocumentModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.DocumentModel", "DocumentModel")
                        .WithMany("UserDocumentModels")
                        .HasForeignKey("DocumentModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.UserModel", "UserModel")
                        .WithMany("UserDocumentModels")
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserMemberModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", "MemberModel")
                        .WithMany("UserMemberModels")
                        .HasForeignKey("MemberModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.UserModel", "UserModel")
                        .WithMany("UserMemberModels")
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MemberModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserProjectModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.ProjectModel", "ProjectModel")
                        .WithMany("UserProjectModels")
                        .HasForeignKey("ProjectModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.UserModel", "UserModel")
                        .WithMany("UserProjectModels")
                        .HasForeignKey("UserModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectModel");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.DocumentModel", b =>
                {
                    b.Navigation("DocumentPriorityModels");

                    b.Navigation("UserDocumentModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.MemberModel", b =>
                {
                    b.Navigation("MemberPriorityModels");

                    b.Navigation("MemberTypesOfCooperationModels");

                    b.Navigation("ProjectMemberModels");

                    b.Navigation("StatisticalInformationModels");

                    b.Navigation("UserMemberModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.PriorityDirectionModel", b =>
                {
                    b.Navigation("DocumentPriorityModels");

                    b.Navigation("MemberPriorityModels");

                    b.Navigation("ProjectPriorityModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.ProjectModel", b =>
                {
                    b.Navigation("ProjectMemberModels");

                    b.Navigation("ProjectPriorityModels");

                    b.Navigation("UserProjectModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.TypesOfCooperationModel", b =>
                {
                    b.Navigation("MemberTypesOfCooperationModels");
                });

            modelBuilder.Entity("RUFR.Api.Model.Models.UserModel", b =>
                {
                    b.Navigation("UserDocumentModels");

                    b.Navigation("UserMemberModels");

                    b.Navigation("UserProjectModels");
                });
#pragma warning restore 612, 618
        }
    }
}