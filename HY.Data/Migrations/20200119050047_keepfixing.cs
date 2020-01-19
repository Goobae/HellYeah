using Microsoft.EntityFrameworkCore.Migrations;

namespace HY.Data.Migrations
{
    public partial class keepfixing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HYEntityCommand_Entities_HYEntityId",
                table: "HYEntityCommand");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Entities_EntityId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_Entities_HYEntityId",
                table: "Relationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Relationships",
                table: "Relationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HYEntityCommand",
                table: "HYEntityCommand");

            migrationBuilder.RenameTable(
                name: "Relationships",
                newName: "EntityRelationships");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "EntityProperties");

            migrationBuilder.RenameTable(
                name: "HYEntityCommand",
                newName: "EntityCommands");

            migrationBuilder.RenameIndex(
                name: "IX_Relationships_HYEntityId",
                table: "EntityRelationships",
                newName: "IX_EntityRelationships_HYEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_EntityId",
                table: "EntityProperties",
                newName: "IX_EntityProperties_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_HYEntityCommand_HYEntityId",
                table: "EntityCommands",
                newName: "IX_EntityCommands_HYEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityRelationships",
                table: "EntityRelationships",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityProperties",
                table: "EntityProperties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntityCommands",
                table: "EntityCommands",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EntityCommands_Entities_HYEntityId",
                table: "EntityCommands",
                column: "HYEntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityProperties_Entities_EntityId",
                table: "EntityProperties",
                column: "EntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EntityRelationships_Entities_HYEntityId",
                table: "EntityRelationships",
                column: "HYEntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntityCommands_Entities_HYEntityId",
                table: "EntityCommands");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityProperties_Entities_EntityId",
                table: "EntityProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_EntityRelationships_Entities_HYEntityId",
                table: "EntityRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityRelationships",
                table: "EntityRelationships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityProperties",
                table: "EntityProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntityCommands",
                table: "EntityCommands");

            migrationBuilder.RenameTable(
                name: "EntityRelationships",
                newName: "Relationships");

            migrationBuilder.RenameTable(
                name: "EntityProperties",
                newName: "Properties");

            migrationBuilder.RenameTable(
                name: "EntityCommands",
                newName: "HYEntityCommand");

            migrationBuilder.RenameIndex(
                name: "IX_EntityRelationships_HYEntityId",
                table: "Relationships",
                newName: "IX_Relationships_HYEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityProperties_EntityId",
                table: "Properties",
                newName: "IX_Properties_EntityId");

            migrationBuilder.RenameIndex(
                name: "IX_EntityCommands_HYEntityId",
                table: "HYEntityCommand",
                newName: "IX_HYEntityCommand_HYEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relationships",
                table: "Relationships",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HYEntityCommand",
                table: "HYEntityCommand",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HYEntityCommand_Entities_HYEntityId",
                table: "HYEntityCommand",
                column: "HYEntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Entities_EntityId",
                table: "Properties",
                column: "EntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_Entities_HYEntityId",
                table: "Relationships",
                column: "HYEntityId",
                principalTable: "Entities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
