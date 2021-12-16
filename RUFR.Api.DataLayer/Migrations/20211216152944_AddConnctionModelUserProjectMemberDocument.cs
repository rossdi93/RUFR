using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class AddConnctionModelUserProjectMemberDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "Users",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "MemberModels",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "MemberModels",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StatisticalInformationModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MemberModelId = table.Column<long>(type: "bigint", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticalInformationModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatisticalInformationModels_MemberModels_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDocumentModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Position = table.Column<string>(type: "text", nullable: true),
                    UserModelId = table.Column<long>(type: "bigint", nullable: false),
                    DocumentModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDocumentModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDocumentModels_DocumentModels_DocumentModelId",
                        column: x => x.DocumentModelId,
                        principalTable: "DocumentModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDocumentModels_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMemberModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Position = table.Column<string>(type: "text", nullable: true),
                    UserModelId = table.Column<long>(type: "bigint", nullable: false),
                    MemberModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMemberModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMemberModels_MemberModels_MemberModelId",
                        column: x => x.MemberModelId,
                        principalTable: "MemberModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMemberModels_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProjectModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Position = table.Column<string>(type: "text", nullable: true),
                    UserModelId = table.Column<long>(type: "bigint", nullable: false),
                    ProjectModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjectModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProjectModels_ProjectModels_ProjectModelId",
                        column: x => x.ProjectModelId,
                        principalTable: "ProjectModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProjectModels_Users_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StatisticalInformationModels_MemberModelId",
                table: "StatisticalInformationModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDocumentModels_DocumentModelId",
                table: "UserDocumentModels",
                column: "DocumentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDocumentModels_UserModelId",
                table: "UserDocumentModels",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMemberModels_MemberModelId",
                table: "UserMemberModels",
                column: "MemberModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMemberModels_UserModelId",
                table: "UserMemberModels",
                column: "UserModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectModels_ProjectModelId",
                table: "UserProjectModels",
                column: "ProjectModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProjectModels_UserModelId",
                table: "UserProjectModels",
                column: "UserModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatisticalInformationModels");

            migrationBuilder.DropTable(
                name: "UserDocumentModels");

            migrationBuilder.DropTable(
                name: "UserMemberModels");

            migrationBuilder.DropTable(
                name: "UserProjectModels");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "MemberModels");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "MemberModels");
        }
    }
}
