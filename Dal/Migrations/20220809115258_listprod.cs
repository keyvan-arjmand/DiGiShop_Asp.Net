using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class listprod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_factors_FactorId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_FactorId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "FactorId",
                table: "products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FactorId",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_FactorId",
                table: "products",
                column: "FactorId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_factors_FactorId",
                table: "products",
                column: "FactorId",
                principalTable: "factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
