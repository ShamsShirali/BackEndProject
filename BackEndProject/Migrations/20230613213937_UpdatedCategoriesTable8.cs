using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackEndProject.Migrations
{
    public partial class UpdatedCategoriesTable8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMega",
                table: "Categories",
                newName: "Mega");

            migrationBuilder.RenameColumn(
                name: "IsHidden",
                table: "Categories",
                newName: "Hidden");

            migrationBuilder.RenameColumn(
                name: "IsChild",
                table: "Categories",
                newName: "Child");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mega",
                table: "Categories",
                newName: "IsMega");

            migrationBuilder.RenameColumn(
                name: "Hidden",
                table: "Categories",
                newName: "IsHidden");

            migrationBuilder.RenameColumn(
                name: "Child",
                table: "Categories",
                newName: "IsChild");
        }
    }
}
