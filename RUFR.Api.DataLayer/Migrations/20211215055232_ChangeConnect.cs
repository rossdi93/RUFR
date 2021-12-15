using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class ChangeConnect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberModelPriorityDirectionModel");

            migrationBuilder.DropTable(
                name: "MemberModelProjectModel");

            migrationBuilder.DropTable(
                name: "MemberModelTypesOfCooperationModel");

            migrationBuilder.DropTable(
                name: "PriorityDirectionModelProjectModel");

            migrationBuilder.CreateTable(
                name: "MemberPriorityModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MemberModelId = table.Column<long>(type: "bigint", nullable: false),
                    PriorityDirectionModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberPriorityModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberPriorityModels_MemberModels_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberPriorityModels_PriorityDirectionModels_PriorityDirect~",
                        column: x => x.PriorityDirectionModelId,
                        principalTable: "PriorityDirectionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberTypesOfCooperationModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MemberModelId = table.Column<long>(type: "bigint", nullable: false),
                    TypesOfCooperationModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypesOfCooperationModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberTypesOfCooperationModels_MemberModels_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberTypesOfCooperationModels_TypesOfCooperationModels_Typ~",
                        column: x => x.TypesOfCooperationModelId,
                        principalTable: "TypesOfCooperationModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectMemberModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MemberModelId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectMemberModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectMemberModels_MemberModels_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectMemberModels_ProjectModels_ProjectModelId",
                        column: x => x.ProjectModelId,
                        principalTable: "ProjectModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPriorityModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PriorityDirectionModelId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectPriorityModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectPriorityModels_PriorityDirectionModels_PriorityDirec~",
                        column: x => x.PriorityDirectionModelId,
                        principalTable: "PriorityDirectionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectPriorityModels_ProjectModels_ProjectModelId",
                        column: x => x.ProjectModelId,
                        principalTable: "ProjectModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberPriorityModels_MemberModelId",
                table: "MemberPriorityModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberPriorityModels_PriorityDirectionModelId",
                table: "MemberPriorityModels",
                column: "PriorityDirectionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTypesOfCooperationModels_MemberModelId",
                table: "MemberTypesOfCooperationModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTypesOfCooperationModels_TypesOfCooperationModelId",
                table: "MemberTypesOfCooperationModels",
                column: "TypesOfCooperationModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMemberModels_MemberModelId",
                table: "ProjectMemberModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectMemberModels_ProjectModelId",
                table: "ProjectMemberModels",
                column: "ProjectModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPriorityModels_PriorityDirectionModelId",
                table: "ProjectPriorityModels",
                column: "PriorityDirectionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectPriorityModels_ProjectModelId",
                table: "ProjectPriorityModels",
                column: "ProjectModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberPriorityModels");

            migrationBuilder.DropTable(
                name: "MemberTypesOfCooperationModels");

            migrationBuilder.DropTable(
                name: "ProjectMemberModels");

            migrationBuilder.DropTable(
                name: "ProjectPriorityModels");

            migrationBuilder.CreateTable(
                name: "MemberModelPriorityDirectionModel",
                columns: table => new
                {
                    MemberModelsId = table.Column<long>(type: "bigint", nullable: false),
                    PriorityDirectionModelsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberModelPriorityDirectionModel", x => new { x.MemberModelsId, x.PriorityDirectionModelsId });
                    table.ForeignKey(
                        name: "FK_MemberModelPriorityDirectionModel_MemberModels_MemberModels~",
                        column: x => x.MemberModelsId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberModelPriorityDirectionModel_PriorityDirectionModels_P~",
                        column: x => x.PriorityDirectionModelsId,
                        principalTable: "PriorityDirectionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberModelProjectModel",
                columns: table => new
                {
                    MemberModelsId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectModelsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberModelProjectModel", x => new { x.MemberModelsId, x.ProjectModelsId });
                    table.ForeignKey(
                        name: "FK_MemberModelProjectModel_MemberModels_MemberModelsId",
                        column: x => x.MemberModelsId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberModelProjectModel_ProjectModels_ProjectModelsId",
                        column: x => x.ProjectModelsId,
                        principalTable: "ProjectModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberModelTypesOfCooperationModel",
                columns: table => new
                {
                    MemberModelsId = table.Column<long>(type: "bigint", nullable: false),
                    TypesOfCooperationModelsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberModelTypesOfCooperationModel", x => new { x.MemberModelsId, x.TypesOfCooperationModelsId });
                    table.ForeignKey(
                        name: "FK_MemberModelTypesOfCooperationModel_MemberModels_MemberModel~",
                        column: x => x.MemberModelsId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberModelTypesOfCooperationModel_TypesOfCooperationModels~",
                        column: x => x.TypesOfCooperationModelsId,
                        principalTable: "TypesOfCooperationModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PriorityDirectionModelProjectModel",
                columns: table => new
                {
                    PrioritiesId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectModelsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriorityDirectionModelProjectModel", x => new { x.PrioritiesId, x.ProjectModelsId });
                    table.ForeignKey(
                        name: "FK_PriorityDirectionModelProjectModel_PriorityDirectionModels_~",
                        column: x => x.PrioritiesId,
                        principalTable: "PriorityDirectionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriorityDirectionModelProjectModel_ProjectModels_ProjectMod~",
                        column: x => x.ProjectModelsId,
                        principalTable: "ProjectModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberModelPriorityDirectionModel_PriorityDirectionModelsId",
                table: "MemberModelPriorityDirectionModel",
                column: "PriorityDirectionModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberModelProjectModel_ProjectModelsId",
                table: "MemberModelProjectModel",
                column: "ProjectModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberModelTypesOfCooperationModel_TypesOfCooperationModels~",
                table: "MemberModelTypesOfCooperationModel",
                column: "TypesOfCooperationModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriorityDirectionModelProjectModel_ProjectModelsId",
                table: "PriorityDirectionModelProjectModel",
                column: "ProjectModelsId");
        }
    }
}
