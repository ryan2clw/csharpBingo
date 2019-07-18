using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaBingo.Migrations
{
    public partial class NumbersUpdatedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            DateTime now = DateTime.Now;
            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "BingoNumbers",
                nullable: false,
                defaultValue: now);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Updated",
                table: "BingoNumbers");
        }
    }
}
