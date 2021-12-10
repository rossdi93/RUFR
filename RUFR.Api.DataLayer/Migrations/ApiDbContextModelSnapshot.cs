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

            modelBuilder.Entity("MemberModelPriorityDirectionModel", b =>
                {
                    b.Property<long>("MemberModelsId")
                        .HasColumnType("bigint");

                    b.Property<long>("PriorityDirectionModelsId")
                        .HasColumnType("bigint");

                    b.HasKey("MemberModelsId", "PriorityDirectionModelsId");

                    b.HasIndex("PriorityDirectionModelsId");

                    b.ToTable("MemberModelPriorityDirectionModel");
                });

            modelBuilder.Entity("MemberModelProjectModel", b =>
                {
                    b.Property<long>("MemberModelsId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectModelsId")
                        .HasColumnType("bigint");

                    b.HasKey("MemberModelsId", "ProjectModelsId");

                    b.HasIndex("ProjectModelsId");

                    b.ToTable("MemberModelProjectModel");
                });

            modelBuilder.Entity("MemberModelTypesOfCooperationModel", b =>
                {
                    b.Property<long>("MemberModelsId")
                        .HasColumnType("bigint");

                    b.Property<long>("TypesOfCooperationModelsId")
                        .HasColumnType("bigint");

                    b.HasKey("MemberModelsId", "TypesOfCooperationModelsId");

                    b.HasIndex("TypesOfCooperationModelsId");

                    b.ToTable("MemberModelTypesOfCooperationModel");
                });

            modelBuilder.Entity("PriorityDirectionModelProjectModel", b =>
                {
                    b.Property<long>("PrioritiesId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProjectModelsId")
                        .HasColumnType("bigint");

                    b.HasKey("PrioritiesId", "ProjectModelsId");

                    b.HasIndex("ProjectModelsId");

                    b.ToTable("PriorityDirectionModelProjectModel");
                });

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

                    b.Property<string>("Description")
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

                    b.Property<bool>("IsDelete")
                        .HasColumnType("boolean");

                    b.Property<string>("Lang")
                        .HasColumnType("text");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("bytea");

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

            modelBuilder.Entity("RUFR.Api.Model.Models.UserModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MemberModelPriorityDirectionModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", null)
                        .WithMany()
                        .HasForeignKey("MemberModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.PriorityDirectionModel", null)
                        .WithMany()
                        .HasForeignKey("PriorityDirectionModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MemberModelProjectModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", null)
                        .WithMany()
                        .HasForeignKey("MemberModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.ProjectModel", null)
                        .WithMany()
                        .HasForeignKey("ProjectModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MemberModelTypesOfCooperationModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.MemberModel", null)
                        .WithMany()
                        .HasForeignKey("MemberModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.TypesOfCooperationModel", null)
                        .WithMany()
                        .HasForeignKey("TypesOfCooperationModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PriorityDirectionModelProjectModel", b =>
                {
                    b.HasOne("RUFR.Api.Model.Models.PriorityDirectionModel", null)
                        .WithMany()
                        .HasForeignKey("PrioritiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RUFR.Api.Model.Models.ProjectModel", null)
                        .WithMany()
                        .HasForeignKey("ProjectModelsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
