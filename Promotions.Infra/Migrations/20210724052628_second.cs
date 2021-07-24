using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Promotions.Infra.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DOCUMENT_Keyword_KeyWordId",
                schema: "prm",
                table: "DOCUMENT");

            migrationBuilder.DropForeignKey(
                name: "FK_KeywordDocumentMapping_DOCUMENT_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DOCUMENT",
                schema: "prm",
                table: "DOCUMENT");

            migrationBuilder.DropIndex(
                name: "IX_DOCUMENT_KeyWordId",
                schema: "prm",
                table: "DOCUMENT");

            migrationBuilder.DropColumn(
                name: "KeyWordId",
                schema: "prm",
                table: "DOCUMENT");

            migrationBuilder.RenameTable(
                name: "DOCUMENT",
                schema: "prm",
                newName: "Document",
                newSchema: "prm");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                schema: "prm",
                table: "KeywordDocumentMapping",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "prm",
                table: "KeywordDocumentMapping",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "prm",
                table: "KeywordDocumentMapping",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ShardKey",
                schema: "prm",
                table: "KeywordDocumentMapping",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                schema: "prm",
                table: "Keyword",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "prm",
                table: "Keyword",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "prm",
                table: "Keyword",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ShardKey",
                schema: "prm",
                table: "Keyword",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                schema: "prm",
                table: "Document",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "prm",
                table: "Document",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "prm",
                table: "Document",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ShardKey",
                schema: "prm",
                table: "Document",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document",
                schema: "prm",
                table: "Document",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_KeywordDocumentMapping_Document_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping",
                column: "DocumentId",
                principalSchema: "prm",
                principalTable: "Document",
                principalColumn: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KeywordDocumentMapping_Document_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document",
                schema: "prm",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropColumn(
                name: "ShardKey",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "prm",
                table: "Keyword");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "prm",
                table: "Keyword");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "prm",
                table: "Keyword");

            migrationBuilder.DropColumn(
                name: "ShardKey",
                schema: "prm",
                table: "Keyword");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "prm",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "prm",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "prm",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "ShardKey",
                schema: "prm",
                table: "Document");

            migrationBuilder.RenameTable(
                name: "Document",
                schema: "prm",
                newName: "DOCUMENT",
                newSchema: "prm");

            migrationBuilder.AddColumn<int>(
                name: "KeyWordId",
                schema: "prm",
                table: "DOCUMENT",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DOCUMENT",
                schema: "prm",
                table: "DOCUMENT",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_DOCUMENT_KeyWordId",
                schema: "prm",
                table: "DOCUMENT",
                column: "KeyWordId");

            migrationBuilder.AddForeignKey(
                name: "FK_DOCUMENT_Keyword_KeyWordId",
                schema: "prm",
                table: "DOCUMENT",
                column: "KeyWordId",
                principalSchema: "prm",
                principalTable: "Keyword",
                principalColumn: "KeyWordId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KeywordDocumentMapping_DOCUMENT_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping",
                column: "DocumentId",
                principalSchema: "prm",
                principalTable: "DOCUMENT",
                principalColumn: "DocumentId");
        }
    }
}
