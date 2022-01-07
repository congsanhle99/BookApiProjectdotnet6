using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApiProject.Migrations
{
    public partial class InitialBookUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FristName",
                table: "Reviewers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "FristName",
                table: "Authors",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Reviewers",
                newName: "FristName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Authors",
                newName: "FristName");
        }
    }
}
