using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Promotions.Infra.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KeywordDocumentMapping",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropIndex(
                name: "IX_KeywordDocumentMapping_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.RenameColumn(
                name: "KeyWordId",
                schema: "prm",
                table: "Keyword",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DocumentId",
                schema: "prm",
                table: "Document",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                schema: "prm",
                table: "KeywordDocumentMapping",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KeywordDocumentMapping",
                schema: "prm",
                table: "KeywordDocumentMapping",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4466), new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4543), new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4562), new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4565) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4579), new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4596), new DateTime(2021, 7, 24, 6, 48, 34, 60, DateTimeKind.Utc).AddTicks(4599) });

            migrationBuilder.CreateIndex(
                name: "IX_KeywordDocumentMapping_DocumentId_KeywordId",
                schema: "prm",
                table: "KeywordDocumentMapping",
                columns: new[] { "DocumentId", "KeywordId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KeywordDocumentMapping_KeywordId",
                schema: "prm",
                table: "KeywordDocumentMapping",
                column: "KeywordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_KeywordDocumentMapping",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropIndex(
                name: "IX_KeywordDocumentMapping_DocumentId_KeywordId",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropIndex(
                name: "IX_KeywordDocumentMapping_KeywordId",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "prm",
                table: "KeywordDocumentMapping");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "prm",
                table: "Keyword",
                newName: "KeyWordId");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "prm",
                table: "Document",
                newName: "DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KeywordDocumentMapping",
                schema: "prm",
                table: "KeywordDocumentMapping",
                columns: new[] { "KeywordId", "DocumentId" });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9668), new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9697) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9740), new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9762), new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9766) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9782), new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9803), new DateTime(2021, 7, 24, 5, 51, 42, 682, DateTimeKind.Utc).AddTicks(9806) });

            migrationBuilder.CreateIndex(
                name: "IX_KeywordDocumentMapping_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping",
                column: "DocumentId");
        }
    }
}
