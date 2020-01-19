using Microsoft.EntityFrameworkCore.Migrations;

namespace HY.Data.Migrations
{
    public partial class addValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "EntityProperties");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "EntityProperties",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PropertyName",
                table: "EntityProperties",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EntityPropertyValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntityPropertyId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityPropertyValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityPropertyValues_EntityProperties_EntityPropertyId",
                        column: x => x.EntityPropertyId,
                        principalTable: "EntityProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "EntityName" },
                values: new object[] { 1, "Task" });

            migrationBuilder.InsertData(
                table: "EntityProperties",
                columns: new[] { "Id", "EntityId", "ParentId", "PropertyName", "PropretyTypeId" },
                values: new object[,]
                {
                    { 1, 1, 0, "Description", 0 },
                    { 2, 1, 0, "DateCreated", 4 },
                    { 3, 1, 0, "DateCreated", 4 },
                    { 4, 1, 0, "TaskList", 6 }
                });

            migrationBuilder.InsertData(
                table: "EntityProperties",
                columns: new[] { "Id", "EntityId", "ParentId", "PropertyName", "PropretyTypeId" },
                values: new object[,]
                {
                    { 5, 1, 4, "TaskListItem", 7 },
                    { 8, 1, 4, "TaskListItem", 7 }
                });

            migrationBuilder.InsertData(
                table: "EntityPropertyValues",
                columns: new[] { "Id", "EntityPropertyId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Test" },
                    { 2, 2, "1/19/2020 10:28:08 AM" },
                    { 3, 3, "1/19/2020 10:28:08 AM" }
                });

            migrationBuilder.InsertData(
                table: "EntityProperties",
                columns: new[] { "Id", "EntityId", "ParentId", "PropertyName", "PropretyTypeId" },
                values: new object[,]
                {
                    { 6, 1, 5, "Description", 3 },
                    { 7, 1, 5, "Completed", 0 },
                    { 9, 1, 8, "Description", 3 },
                    { 10, 1, 8, "Completed", 0 }
                });

            migrationBuilder.InsertData(
                table: "EntityPropertyValues",
                columns: new[] { "Id", "EntityPropertyId", "Value" },
                values: new object[,]
                {
                    { 4, 6, "Read Book" },
                    { 5, 7, "False" },
                    { 6, 9, "Run 5 miles" },
                    { 7, 10, "False" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntityProperties_Id",
                table: "EntityProperties",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EntityProperties_ParentId",
                table: "EntityProperties",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityPropertyValues_EntityPropertyId",
                table: "EntityPropertyValues",
                column: "EntityPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityProperties_EntityProperties_ParentId",
                table: "EntityProperties",
                column: "ParentId",
                principalTable: "EntityProperties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityProperties_EntityProperties_ParentId",
                table: "EntityProperties");

            migrationBuilder.DropTable(
                name: "EntityPropertyValues");

            migrationBuilder.DropIndex(
                name: "IX_EntityProperties_Id",
                table: "EntityProperties");

            migrationBuilder.DropIndex(
                name: "IX_EntityProperties_ParentId",
                table: "EntityProperties");

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EntityProperties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "EntityProperties");

            migrationBuilder.DropColumn(
                name: "PropertyName",
                table: "EntityProperties");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "EntityProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "EntityName" },
                values: new object[] { -1, "TEST" });
        }
    }
}
