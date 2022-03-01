using Microsoft.EntityFrameworkCore.Migrations;

namespace Versality.Migrations
{
    public partial class Four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TheProblemId",
                table: "Knowledge",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TheProblemId",
                table: "Knowledge");
        }
    }
}
