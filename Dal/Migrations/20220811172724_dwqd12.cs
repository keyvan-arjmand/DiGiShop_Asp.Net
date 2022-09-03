using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class dwqd12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_prodsU_prodUserId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_prodUserId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "prodUserId",
                table: "products");

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "prodsU",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_prodsU_productId",
                table: "prodsU",
                column: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK_prodsU_products_productId",
                table: "prodsU",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prodsU_products_productId",
                table: "prodsU");

            migrationBuilder.DropIndex(
                name: "IX_prodsU_productId",
                table: "prodsU");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "prodsU");

            migrationBuilder.AddColumn<int>(
                name: "prodUserId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_prodUserId",
                table: "products",
                column: "prodUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_prodsU_prodUserId",
                table: "products",
                column: "prodUserId",
                principalTable: "prodsU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
