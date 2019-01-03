using Microsoft.EntityFrameworkCore.Migrations;

namespace villagecharacters.Migrations
{
    public partial class AddedVillageToCharactersRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VillageId",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VillagesId",
                table: "Characters",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_VillagesId",
                table: "Characters",
                column: "VillagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Villages_VillagesId",
                table: "Characters",
                column: "VillagesId",
                principalTable: "Villages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Villages_VillagesId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_VillagesId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "VillageId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "VillagesId",
                table: "Characters");
        }
    }
}
