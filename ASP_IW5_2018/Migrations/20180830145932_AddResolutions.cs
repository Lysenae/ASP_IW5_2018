using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_IW5_2018.Migrations
{
    public partial class AddResolutions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhotoResolution_Photos_PhotoId",
                table: "PhotoResolution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhotoResolution",
                table: "PhotoResolution");

            migrationBuilder.RenameTable(
                name: "PhotoResolution",
                newName: "Resolutions");

            migrationBuilder.RenameIndex(
                name: "IX_PhotoResolution_PhotoId",
                table: "Resolutions",
                newName: "IX_Resolutions_PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resolutions",
                table: "Resolutions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resolutions_Photos_PhotoId",
                table: "Resolutions",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resolutions_Photos_PhotoId",
                table: "Resolutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resolutions",
                table: "Resolutions");

            migrationBuilder.RenameTable(
                name: "Resolutions",
                newName: "PhotoResolution");

            migrationBuilder.RenameIndex(
                name: "IX_Resolutions_PhotoId",
                table: "PhotoResolution",
                newName: "IX_PhotoResolution_PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhotoResolution",
                table: "PhotoResolution",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhotoResolution_Photos_PhotoId",
                table: "PhotoResolution",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
