using Microsoft.EntityFrameworkCore.Migrations;

namespace Versality.Migrations
{
    public partial class eight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Knowledge_Sector_SectorId",
                table: "Knowledge");

            migrationBuilder.DropForeignKey(
                name: "FK_Knowledge_TheProblem_TheProblemId",
                table: "Knowledge");

            migrationBuilder.AlterColumn<int>(
                name: "TheProblemId",
                table: "Knowledge",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SectorId",
                table: "Knowledge",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Knowledge_Sector_SectorId",
                table: "Knowledge",
                column: "SectorId",
                principalTable: "Sector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Knowledge_TheProblem_TheProblemId",
                table: "Knowledge",
                column: "TheProblemId",
                principalTable: "TheProblem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Knowledge_Sector_SectorId",
                table: "Knowledge");

            migrationBuilder.DropForeignKey(
                name: "FK_Knowledge_TheProblem_TheProblemId",
                table: "Knowledge");

            migrationBuilder.AlterColumn<int>(
                name: "TheProblemId",
                table: "Knowledge",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SectorId",
                table: "Knowledge",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
