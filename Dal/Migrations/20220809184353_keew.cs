using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class keew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BeusersId",
                table: "factors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FactorCode",
                table: "factors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_factors_BeusersId",
                table: "factors",
                column: "BeusersId");

            migrationBuilder.AddForeignKey(
                name: "FK_factors_users_BeusersId",
                table: "factors",
                column: "BeusersId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_users_BeusersId",
                table: "factors");

            migrationBuilder.DropIndex(
                name: "IX_factors_BeusersId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "BeusersId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "FactorCode",
                table: "factors");
        }
    }
}
