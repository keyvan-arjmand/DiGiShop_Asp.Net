using Microsoft.EntityFrameworkCore.Migrations;

namespace Dal.Migrations
{
    public partial class lastRevelotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FactorCode",
                table: "prodsU",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FactorCode",
                table: "prodsU");
        }
    }
}
