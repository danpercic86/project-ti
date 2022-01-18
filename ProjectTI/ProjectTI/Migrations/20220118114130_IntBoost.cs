using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTI.Migrations
{
    public partial class IntBoost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Boost",
                table: "Employees",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Boost",
                table: "Employees",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
