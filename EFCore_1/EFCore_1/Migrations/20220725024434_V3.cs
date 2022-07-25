using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_1.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dog",
                table: "Dog");

            migrationBuilder.RenameTable(
                name: "Dog",
                newName: "Dogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Dogs",
                table: "Dogs");

            migrationBuilder.RenameTable(
                name: "Dogs",
                newName: "Dog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dog",
                table: "Dog",
                column: "Id");
        }
    }
}
