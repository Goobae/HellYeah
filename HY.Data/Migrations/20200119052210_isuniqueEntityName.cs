using Microsoft.EntityFrameworkCore.Migrations;

namespace HY.Data.Migrations
{
    public partial class isuniqueEntityName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Entities_EntityName",
                table: "Entities");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_EntityName",
                table: "Entities",
                column: "EntityName",
                unique: true,
                filter: "[EntityName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Entities_EntityName",
                table: "Entities");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_EntityName",
                table: "Entities",
                column: "EntityName");
        }
    }
}
