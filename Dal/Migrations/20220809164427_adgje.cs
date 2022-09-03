using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class adgje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prodUser_factors_FactorId",
                table: "prodUser");

            migrationBuilder.DropIndex(
                name: "IX_prodUser_FactorId",
                table: "prodUser");

            migrationBuilder.DropColumn(
                name: "FactorId",
                table: "prodUser");

            migrationBuilder.AddColumn<int>(
                name: "User_ProdId",
                table: "factors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_factors_User_ProdId",
                table: "factors",
                column: "User_ProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_factors_prodUser_User_ProdId",
                table: "factors",
                column: "User_ProdId",
                principalTable: "prodUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_prodUser_User_ProdId",
                table: "factors");

            migrationBuilder.DropIndex(
                name: "IX_factors_User_ProdId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "User_ProdId",
                table: "factors");

            migrationBuilder.AddColumn<int>(
                name: "FactorId",
                table: "prodUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_prodUser_FactorId",
                table: "prodUser",
                column: "FactorId");

            migrationBuilder.AddForeignKey(
                name: "FK_prodUser_factors_FactorId",
                table: "prodUser",
                column: "FactorId",
                principalTable: "factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
