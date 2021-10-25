using Microsoft.EntityFrameworkCore.Migrations;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class ChangeBindingEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriorityDirectionModels_MemberModels_MemberModelId",
                table: "PriorityDirectionModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PriorityDirectionModels_ProjectModels_ProjectModelId",
                table: "PriorityDirectionModels");

            migrationBuilder.DropForeignKey(
                name: "FK_TypesOfCooperationModels_MemberModels_MemberModelId",
                table: "TypesOfCooperationModels");

            migrationBuilder.DropIndex(
                name: "IX_TypesOfCooperationModels_MemberModelId",
                table: "TypesOfCooperationModels");

            migrationBuilder.DropIndex(
                name: "IX_PriorityDirectionModels_MemberModelId",
                table: "PriorityDirectionModels");

            migrationBuilder.DropIndex(
                name: "IX_PriorityDirectionModels_ProjectModelId",
                table: "PriorityDirectionModels");

            migrationBuilder.DropColumn(
                name: "MemberModelId",
                table: "TypesOfCooperationModels");

            migrationBuilder.DropColumn(
                name: "MemberModelId",
                table: "PriorityDirectionModels");

            migrationBuilder.DropColumn(
                name: "ProjectModelId",
                table: "PriorityDirectionModels");

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
                name: "IX_MemberModelTypesOfCooperationModel_TypesOfCooperationModels~",
                table: "MemberModelTypesOfCooperationModel",
                column: "TypesOfCooperationModelsId");

            migrationBuilder.CreateIndex(
                name: "IX_PriorityDirectionModelProjectModel_ProjectModelsId",
                table: "PriorityDirectionModelProjectModel",
                column: "ProjectModelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberModelPriorityDirectionModel");

            migrationBuilder.DropTable(
                name: "MemberModelTypesOfCooperationModel");

            migrationBuilder.DropTable(
                name: "PriorityDirectionModelProjectModel");

            migrationBuilder.AddColumn<long>(
                name: "MemberModelId",
                table: "TypesOfCooperationModels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MemberModelId",
                table: "PriorityDirectionModels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ProjectModelId",
                table: "PriorityDirectionModels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfCooperationModels_MemberModelId",
                table: "TypesOfCooperationModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PriorityDirectionModels_MemberModelId",
                table: "PriorityDirectionModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PriorityDirectionModels_ProjectModelId",
                table: "PriorityDirectionModels",
                column: "ProjectModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriorityDirectionModels_MemberModels_MemberModelId",
                table: "PriorityDirectionModels",
                column: "MemberModelId",
                principalTable: "MemberModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PriorityDirectionModels_ProjectModels_ProjectModelId",
                table: "PriorityDirectionModels",
                column: "ProjectModelId",
                principalTable: "ProjectModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypesOfCooperationModels_MemberModels_MemberModelId",
                table: "TypesOfCooperationModels",
                column: "MemberModelId",
                principalTable: "MemberModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
