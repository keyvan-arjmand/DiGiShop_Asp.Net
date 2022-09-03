using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class final12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "prodsU");

            migrationBuilder.AddColumn<int>(
                name: "BeusersId",
                table: "factors",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "factors",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "fctorprod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactorCode = table.Column<int>(nullable: false),
                    productsid = table.Column<int>(nullable: false),
                    FactorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fctorprod", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fctorprod_factors_FactorId",
                        column: x => x.FactorId,
                        principalTable: "factors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_factors_BeusersId",
                table: "factors",
                column: "BeusersId");

            migrationBuilder.CreateIndex(
                name: "IX_fctorprod_FactorId",
                table: "fctorprod",
                column: "FactorId");

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

            migrationBuilder.DropTable(
                name: "fctorprod");

            migrationBuilder.DropIndex(
                name: "IX_factors_BeusersId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "BeusersId",
                table: "factors");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "factors");

            migrationBuilder.CreateTable(
                name: "prodsU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactorCode = table.Column<int>(type: "int", nullable: false),
                    FactorId = table.Column<int>(type: "int", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prodsU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prodsU_factors_FactorId",
                        column: x => x.FactorId,
                        principalTable: "factors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prodsU_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_prodsU_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_prodsU_FactorId",
                table: "prodsU",
                column: "FactorId");

            migrationBuilder.CreateIndex(
                name: "IX_prodsU_productId",
                table: "prodsU",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_prodsU_userId",
                table: "prodsU",
                column: "userId");
        }
    }
}
