using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_1.Migrations
{
    public partial class AddBirdHAHAHA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "T_Books",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameTwo",
                table: "T_Books",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BirdHAHAHA",
                columns: table => new
                {
                    Number = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirdHAHAHA", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirdHAHAHA");

            migrationBuilder.DropColumn(
                name: "NameTwo",
                table: "T_Books");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "T_Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);
        }
    }
}
