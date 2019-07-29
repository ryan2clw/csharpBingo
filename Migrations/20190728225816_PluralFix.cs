using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaBingo.Migrations
{
    public partial class PluralFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BallMatch_Ball_BallId",
                table: "BallMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Cards_CardID",
                table: "Rows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ball",
                table: "Ball");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.RenameTable(
                name: "Ball",
                newName: "Balls");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balls",
                table: "Balls",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BallMatch_Balls_BallId",
                table: "BallMatch",
                column: "BallId",
                principalTable: "Balls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Card_CardID",
                table: "Rows",
                column: "CardID",
                principalTable: "Card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BallMatch_Balls_BallId",
                table: "BallMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_Rows_Card_CardID",
                table: "Rows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balls",
                table: "Balls");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.RenameTable(
                name: "Balls",
                newName: "Ball");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ball",
                table: "Ball",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BallMatch_Ball_BallId",
                table: "BallMatch",
                column: "BallId",
                principalTable: "Ball",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rows_Cards_CardID",
                table: "Rows",
                column: "CardID",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
