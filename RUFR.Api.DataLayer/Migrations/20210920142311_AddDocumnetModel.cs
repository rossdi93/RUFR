using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class AddDocumnetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "ProjectModels",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "NewsModels",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "HistoryOfSuccessModels",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lang",
                table: "EventModels",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Author = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    DocByte = table.Column<byte[]>(type: "bytea", nullable: true),
                    Lang = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsDelete = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentModels");

            migrationBuilder.DropColumn(
                name: "Lang",
                table: "ProjectModels");

            migrationBuilder.DropColumn(
                name: "Lang",
                table: "NewsModels");

            migrationBuilder.DropColumn(
                name: "Lang",
                table: "HistoryOfSuccessModels");

            migrationBuilder.DropColumn(
                name: "Lang",
                table: "EventModels");
        }
    }
}
