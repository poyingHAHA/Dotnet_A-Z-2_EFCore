using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_6_1To1.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "T_Deliveries",
                newName: "CompanyName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "T_Deliveries",
                newName: "Name");
        }
    }
}
