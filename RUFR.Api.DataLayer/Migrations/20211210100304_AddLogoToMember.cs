using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class AddLogoToMember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Logo",
                table: "MemberModels",
                type: "bytea",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Logo",
                table: "MemberModels");
        }
    }
}
