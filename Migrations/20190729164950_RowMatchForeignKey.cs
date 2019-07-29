using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaBingo.Migrations
{
    public partial class RowMatchForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RowId",
                table: "Match",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Match_RowId",
                table: "Match",
                column: "RowId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Rows_RowId",
                table: "Match",
                column: "RowId",
                principalTable: "Rows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Rows_RowId",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_RowId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "RowId",
                table: "Match");
        }
    }
}
