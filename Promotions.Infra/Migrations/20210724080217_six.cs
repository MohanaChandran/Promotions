using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Promotions.Infra.Migrations
{
    public partial class six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KeyWordName",
                schema: "prm",
                table: "Keyword",
                newName: "Name");

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9563), new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9645), new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9663), new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9666) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9680), new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9682) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9697), new DateTime(2021, 7, 24, 8, 2, 16, 867, DateTimeKind.Utc).AddTicks(9700) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "prm",
                table: "Keyword",
                newName: "KeyWordName");

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(698), new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(721) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(765), new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(789), new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(811), new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(814) });

            migrationBuilder.UpdateData(
                schema: "prm",
                table: "Document",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(833), new DateTime(2021, 7, 24, 6, 48, 34, 271, DateTimeKind.Utc).AddTicks(836) });
        }
    }
}
