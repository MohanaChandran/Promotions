using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Promotions.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "prm");

            migrationBuilder.CreateTable(
                name: "Keyword",
                schema: "prm",
                columns: table => new
                {
                    KeyWordId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KeyWordName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keyword", x => x.KeyWordId);
                });

            migrationBuilder.CreateTable(
                name: "DOCUMENT",
                schema: "prm",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    URL = table.Column<string>(type: "text", nullable: true),
                    FileExtn = table.Column<string>(type: "text", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    KeyWordId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DOCUMENT", x => x.DocumentId);
                    table.ForeignKey(
                        name: "FK_DOCUMENT_Keyword_KeyWordId",
                        column: x => x.KeyWordId,
                        principalSchema: "prm",
                        principalTable: "Keyword",
                        principalColumn: "KeyWordId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeywordDocumentMapping",
                schema: "prm",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "integer", nullable: false),
                    KeywordId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeywordDocumentMapping", x => new { x.KeywordId, x.DocumentId });
                    table.ForeignKey(
                        name: "FK_KeywordDocumentMapping_DOCUMENT_DocumentId",
                        column: x => x.DocumentId,
                        principalSchema: "prm",
                        principalTable: "DOCUMENT",
                        principalColumn: "DocumentId");
                    table.ForeignKey(
                        name: "FK_KeywordDocumentMapping_Keyword_KeywordId",
                        column: x => x.KeywordId,
                        principalSchema: "prm",
                        principalTable: "Keyword",
                        principalColumn: "KeyWordId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DOCUMENT_KeyWordId",
                schema: "prm",
                table: "DOCUMENT",
                column: "KeyWordId");

            migrationBuilder.CreateIndex(
                name: "IX_KeywordDocumentMapping_DocumentId",
                schema: "prm",
                table: "KeywordDocumentMapping",
                column: "DocumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeywordDocumentMapping",
                schema: "prm");

            migrationBuilder.DropTable(
                name: "DOCUMENT",
                schema: "prm");

            migrationBuilder.DropTable(
                name: "Keyword",
                schema: "prm");
        }
    }
}
