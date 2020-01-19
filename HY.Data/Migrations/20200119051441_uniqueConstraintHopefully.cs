using Microsoft.EntityFrameworkCore.Migrations;

namespace HY.Data.Migrations
{
    public partial class uniqueConstraintHopefully : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EntityName",
                table: "Entities",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Entities_EntityName",
                table: "Entities",
                column: "EntityName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Entities_EntityName",
                table: "Entities");

            migrationBuilder.AlterColumn<string>(
                name: "EntityName",
                table: "Entities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
