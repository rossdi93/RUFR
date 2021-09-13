using Microsoft.EntityFrameworkCore.Migrations;

namespace RUFR.Api.DataLayer.Migrations
{
    public partial class addAtributeToTypeOfCooperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypesOfCooperationModels_MemberModels_MemberModelId",
                table: "TypesOfCooperationModels");

            migrationBuilder.AlterColumn<long>(
                name: "MemberModelId",
                table: "TypesOfCooperationModels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TypesOfCooperationModels_MemberModels_MemberModelId",
                table: "TypesOfCooperationModels",
                column: "MemberModelId",
                principalTable: "MemberModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypesOfCooperationModels_MemberModels_MemberModelId",
                table: "TypesOfCooperationModels");

            migrationBuilder.AlterColumn<long>(
                name: "MemberModelId",
                table: "TypesOfCooperationModels",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_TypesOfCooperationModels_MemberModels_MemberModelId",
                table: "TypesOfCooperationModels",
                column: "MemberModelId",
                principalTable: "MemberModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
