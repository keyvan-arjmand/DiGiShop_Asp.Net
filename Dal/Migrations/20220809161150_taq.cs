using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class taq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factors_users_userId",
                table: "factors");

            migrationBuilder.DropIndex(
                name: "IX_factors_userId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "factors");

            migrationBuilder.CreateTable(
                name: "prodUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(nullable: true),
                    FactorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prodUser_factors_FactorId",
                        column: x => x.FactorId,
                        principalTable: "factors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prodUser_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_prodUser_FactorId",
                table: "prodUser",
                column: "FactorId");

            migrationBuilder.CreateIndex(
                name: "IX_prodUser_userId",
                table: "prodUser",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prodUser");

            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "factors",
                type: "int",
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
    }
}
