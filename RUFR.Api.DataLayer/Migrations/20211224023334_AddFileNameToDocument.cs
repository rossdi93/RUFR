using Microsoft.EntityFrameworkCore.Migrations;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class AddFileNameToDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "DocumentModels",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "DocumentModels");
        }
    }
}
