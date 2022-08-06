using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class nameprod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nameProduct",
                table: "products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nameProduct",
                table: "products");
        }
    }
}
