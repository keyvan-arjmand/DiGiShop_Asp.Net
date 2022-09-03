using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class cdwq2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_prodsU_User_ProdId",
                table: "factors");

            migrationBuilder.DropIndex(
                name: "IX_factors_User_ProdId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "User_ProdId",
                table: "factors");

            migrationBuilder.AddColumn<int>(
                name: "FactorId",
                table: "prodsU",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_prodsU_FactorId",
                table: "prodsU",
                column: "FactorId");

            migrationBuilder.AddForeignKey(
                name: "FK_prodsU_factors_FactorId",
                table: "prodsU",
                column: "FactorId",
                principalTable: "factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_prodsU_factors_FactorId",
                table: "prodsU");

            migrationBuilder.DropIndex(
                name: "IX_prodsU_FactorId",
                table: "prodsU");

            migrationBuilder.DropColumn(
                name: "FactorId",
                table: "prodsU");

            migrationBuilder.AddColumn<int>(
                name: "User_ProdId",
                table: "factors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_factors_User_ProdId",
                table: "factors",
                column: "User_ProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_factors_prodsU_User_ProdId",
                table: "factors",
                column: "User_ProdId",
                principalTable: "prodsU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
