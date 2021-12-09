using Microsoft.EntityFrameworkCore.Migrations;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class AddContextToMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "MemberModels",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "MemberModels");
        }
    }
}
