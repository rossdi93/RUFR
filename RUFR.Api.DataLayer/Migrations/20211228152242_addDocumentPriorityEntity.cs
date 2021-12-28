using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class addDocumentPriorityEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "DocumentModels",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentPriorityModel",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DocumentModelId = table.Column<long>(type: "bigint", nullable: false),
                    PriorityDirectionModelId = table.Column<long>(type: "bigint", nullable: false),
                    EnrollmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentPriorityModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentPriorityModel_DocumentModels_DocumentModelId",
                        column: x => x.DocumentModelId,
                        principalTable: "DocumentModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentPriorityModel_PriorityDirectionModels_PriorityDirec~",
                        column: x => x.PriorityDirectionModelId,
                        principalTable: "PriorityDirectionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentPriorityModel_DocumentModelId",
                table: "DocumentPriorityModel",
                column: "DocumentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentPriorityModel_PriorityDirectionModelId",
                table: "DocumentPriorityModel",
                column: "PriorityDirectionModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentPriorityModel");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "DocumentModels");
        }
    }
}
