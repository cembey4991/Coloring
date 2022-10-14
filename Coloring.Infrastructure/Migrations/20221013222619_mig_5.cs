using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coloring.Infrastructure.Migrations
{
    public partial class mig_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorImages_ColorTypes_ColorTypeId",
                table: "ColorImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorImages_ImageAreas_ImageAreaId",
                table: "ColorImages");

            migrationBuilder.DropIndex(
                name: "IX_ColorImages_ColorTypeId",
                table: "ColorImages");

            migrationBuilder.DropIndex(
                name: "IX_ColorImages_ImageAreaId",
                table: "ColorImages");

            migrationBuilder.DropColumn(
                name: "ColorTypeId",
                table: "ColorImages");

            migrationBuilder.DropColumn(
                name: "ImageAreaId",
                table: "ColorImages");

            migrationBuilder.AddColumn<string>(
                name: "ImageAreaColor",
                table: "ColorImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageAreaColor",
                table: "ColorImages");

            migrationBuilder.AddColumn<int>(
                name: "ColorTypeId",
                table: "ColorImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ImageAreaId",
                table: "ColorImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ColorImages_ColorTypeId",
                table: "ColorImages",
                column: "ColorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorImages_ImageAreaId",
                table: "ColorImages",
                column: "ImageAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorImages_ColorTypes_ColorTypeId",
                table: "ColorImages",
                column: "ColorTypeId",
                principalTable: "ColorTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorImages_ImageAreas_ImageAreaId",
                table: "ColorImages",
                column: "ImageAreaId",
                principalTable: "ImageAreas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
