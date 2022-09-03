using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class dwdq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fctorprod_factors_FactorId",
                table: "fctorprod");

            migrationBuilder.RenameColumn(
                name: "FactorId",
                table: "fctorprod",
                newName: "factorid");

            migrationBuilder.RenameIndex(
                name: "IX_fctorprod_FactorId",
                table: "fctorprod",
                newName: "IX_fctorprod_factorid");

            migrationBuilder.AlterColumn<int>(
                name: "factorid",
                table: "fctorprod",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_fctorprod_factors_factorid",
                table: "fctorprod",
                column: "factorid",
                principalTable: "factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_fctorprod_factors_factorid",
                table: "fctorprod");

            migrationBuilder.RenameColumn(
                name: "factorid",
                table: "fctorprod",
                newName: "FactorId");

            migrationBuilder.RenameIndex(
                name: "IX_fctorprod_factorid",
                table: "fctorprod",
                newName: "IX_fctorprod_FactorId");

            migrationBuilder.AlterColumn<int>(
                name: "FactorId",
                table: "fctorprod",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_fctorprod_factors_FactorId",
                table: "fctorprod",
                column: "FactorId",
                principalTable: "factors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
