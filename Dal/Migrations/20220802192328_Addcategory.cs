using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class Addcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "addres",
                table: "factors");

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "titleCategory",
                table: "products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "factors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "products");

            migrationBuilder.DropColumn(
                name: "titleCategory",
                table: "products");

            migrationBuilder.DropColumn(
                name: "address",
                table: "factors");

            migrationBuilder.AddColumn<string>(
                name: "addres",
                table: "factors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
