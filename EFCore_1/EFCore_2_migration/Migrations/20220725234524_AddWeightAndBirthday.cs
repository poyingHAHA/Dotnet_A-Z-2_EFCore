using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_2_migration.Migrations
{
    public partial class AddWeightAndBirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "T_People",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "T_People",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "T_People");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "T_People");
        }
    }
}
