using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coloring.Infrastructure.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ColorImages_AppUserId",
                table: "ColorImages",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorImages_ColorTypeId",
                table: "ColorImages",
                column: "ColorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorImages_ImageAreaId",
                table: "ColorImages",
                column: "ImageAreaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorImages_AspNetUsers_AppUserId",
                table: "ColorImages",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorImages_AspNetUsers_AppUserId",
                table: "ColorImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorImages_ColorTypes_ColorTypeId",
                table: "ColorImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorImages_ImageAreas_ImageAreaId",
                table: "ColorImages");

            migrationBuilder.DropIndex(
                name: "IX_ColorImages_AppUserId",
                table: "ColorImages");

            migrationBuilder.DropIndex(
                name: "IX_ColorImages_ColorTypeId",
                table: "ColorImages");

            migrationBuilder.DropIndex(
                name: "IX_ColorImages_ImageAreaId",
                table: "ColorImages");
        }
    }
}
