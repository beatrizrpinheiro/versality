using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Versality.Migrations
{
    public partial class Forum : Migration
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

            migrationBuilder.CreateTable(
                name: "Forum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forum", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.DropTable(
                name: "Forum");

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
    }
}
