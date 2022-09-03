using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class dwd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_prodUser_User_ProdId",
                table: "factors");

            migrationBuilder.DropForeignKey(
                name: "FK_products_prodUser_prodUserId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_prodUser_users_userId",
                table: "prodUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prodUser",
                table: "prodUser");

            migrationBuilder.RenameTable(
                name: "prodUser",
                newName: "prodsU");

            migrationBuilder.RenameIndex(
                name: "IX_prodUser_userId",
                table: "prodsU",
                newName: "IX_prodsU_userId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prodsU",
                table: "prodsU",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_factors_prodsU_User_ProdId",
                table: "factors",
                column: "User_ProdId",
                principalTable: "prodsU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_prodsU_users_userId",
                table: "prodsU",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_prodsU_prodUserId",
                table: "products",
                column: "prodUserId",
                principalTable: "prodsU",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_prodsU_User_ProdId",
                table: "factors");

            migrationBuilder.DropForeignKey(
                name: "FK_prodsU_users_userId",
                table: "prodsU");

            migrationBuilder.DropForeignKey(
                name: "FK_products_prodsU_prodUserId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_prodsU",
                table: "prodsU");

            migrationBuilder.RenameTable(
                name: "prodsU",
                newName: "prodUser");

            migrationBuilder.RenameIndex(
                name: "IX_prodsU_userId",
                table: "prodUser",
                newName: "IX_prodUser_userId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_prodUser",
                table: "prodUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_factors_prodUser_User_ProdId",
                table: "factors",
                column: "User_ProdId",
                principalTable: "prodUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_products_prodUser_prodUserId",
                table: "products",
                column: "prodUserId",
                principalTable: "prodUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_prodUser_users_userId",
                table: "prodUser",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
