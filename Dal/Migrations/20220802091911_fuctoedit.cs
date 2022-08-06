using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class fuctoedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "addres",
                table: "factors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "totalPrice",
                table: "factors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "factors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_factors_userId",
                table: "factors",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_factors_users_userId",
                table: "factors",
                column: "userId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_users_userId",
                table: "factors");

            migrationBuilder.DropIndex(
                name: "IX_factors_userId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "addres",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "totalPrice",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "factors");
        }
    }
}
