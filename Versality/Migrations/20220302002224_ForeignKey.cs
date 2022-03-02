using Microsoft.EntityFrameworkCore.Migrations;

namespace Versality.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_SectorId",
                table: "Knowledge",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_TheProblemId",
                table: "Knowledge",
                column: "TheProblemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Knowledge_Sector_SectorId",
                table: "Knowledge",
                column: "SectorId",
                principalTable: "Sector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Knowledge_TheProblem_TheProblemId",
                table: "Knowledge",
                column: "TheProblemId",
                principalTable: "TheProblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Knowledge_Sector_SectorId",
                table: "Knowledge");

            migrationBuilder.DropForeignKey(
                name: "FK_Knowledge_TheProblem_TheProblemId",
                table: "Knowledge");

            migrationBuilder.DropIndex(
                name: "IX_Knowledge_SectorId",
                table: "Knowledge");

            migrationBuilder.DropIndex(
                name: "IX_Knowledge_TheProblemId",
                table: "Knowledge");
        }
    }
}
