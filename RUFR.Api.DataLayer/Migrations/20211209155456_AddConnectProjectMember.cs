using Microsoft.EntityFrameworkCore.Migrations;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class AddConnectProjectMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_MemberModelProjectModel_ProjectModelsId",
                table: "MemberModelProjectModel",
                column: "ProjectModelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberModelProjectModel");
        }
    }
}
