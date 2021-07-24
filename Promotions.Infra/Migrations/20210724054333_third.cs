using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Promotions.Infra.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShardKey",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropColumn(
                name: "ShardKey",
                schema: "prm",
                table: "Keyword");

            migrationBuilder.DropColumn(
                name: "FileExtn",
                schema: "prm",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "ShardKey",
                schema: "prm",
                table: "Document");

            migrationBuilder.RenameColumn(
                name: "FileName",
                schema: "prm",
                table: "Document",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "prm",
                table: "Document",
                newName: "FileName");

            migrationBuilder.AddColumn<Guid>(
                name: "ShardKey",
                schema: "prm",
                table: "KeywordDocumentMapping",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShardKey",
                schema: "prm",
                table: "Keyword",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "FileExtn",
                schema: "prm",
                table: "Document",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ShardKey",
                schema: "prm",
                table: "Document",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
