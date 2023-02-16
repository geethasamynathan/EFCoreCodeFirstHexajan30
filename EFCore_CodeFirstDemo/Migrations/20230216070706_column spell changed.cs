using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_CodeFirstDemo.Migrations
{
    public partial class columnspellchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeapertmentName",
                table: "Departments",
                newName: "DepartmentName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Departments",
                newName: "DeapertmentName");
        }
    }
}
