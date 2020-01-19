using Microsoft.EntityFrameworkCore.Migrations;

namespace HY.Data.Migrations
{
    public partial class fixTHeSHit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "EntityName" },
                values: new object[] { -1, "TEST" });

            migrationBuilder.CreateIndex(
                name: "IX_Properties_EntityId",
                table: "Properties",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Entities_EntityId",
                table: "Properties",
                column: "EntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Entities_EntityId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_EntityId",
                table: "Properties");

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
