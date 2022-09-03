using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class ewewe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "prodUserId",
                table: "products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_prodUserId",
                table: "products",
                column: "prodUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_prodUser_prodUserId",
                table: "products",
                column: "prodUserId",
                principalTable: "prodUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_prodUser_prodUserId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_prodUserId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "prodUserId",
                table: "products");
        }
    }
}
