using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectTI.Migrations
{
    public partial class EmployeesAndVariables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<int>(type: "integer", nullable: false),
                    Boost = table.Column<float>(type: "real", nullable: false),
                    Bonuses = table.Column<int>(type: "integer", nullable: false),
                    Retentions = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Variables",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Cas = table.Column<int>(type: "integer", nullable: false),
                    Cass = table.Column<int>(type: "integer", nullable: false),
                    Tax = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variables", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Variables");
        }
    }
}
