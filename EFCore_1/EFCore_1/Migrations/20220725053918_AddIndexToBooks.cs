using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_1.Migrations
{
    public partial class AddIndexToBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_T_Books_NameTwo_AuthorName",
                table: "T_Books",
                columns: new[] { "NameTwo", "AuthorName" });

            migrationBuilder.CreateIndex(
                name: "IX_T_Books_Title",
                table: "T_Books",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_T_Books_NameTwo_AuthorName",
                table: "T_Books");

            migrationBuilder.DropIndex(
                name: "IX_T_Books_Title",
                table: "T_Books");
        }
    }
}
