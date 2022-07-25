using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_1.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cats",
                table: "Cats");

            migrationBuilder.RenameTable(
                name: "Cats",
                newName: "T_Cats");

            migrationBuilder.AddColumn<int>(
                name: "Age1",
                table: "T_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Cats",
                table: "T_Cats",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Cats",
                table: "T_Cats");

            migrationBuilder.DropColumn(
                name: "Age1",
                table: "T_Books");

            migrationBuilder.RenameTable(
                name: "T_Cats",
                newName: "Cats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cats",
                table: "Cats",
                column: "Id");
        }
    }
}
