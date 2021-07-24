using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Promotions.Infra.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "prm",
                table: "Document",
                columns: new[] { "DocumentId", "CreatedBy", "CreatedDate", "ModifiedDate", "Name", "URL" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8287), new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8309), "Marketing", "https://www.facebook.com/" },
                    { 2, 0, new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8355), new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8358), "Marketing", "https://www.Google.com/" },
                    { 3, 0, new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8373), new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8375), "Travel", "https://www.MakeMyTrip.com/" },
                    { 4, 0, new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8388), new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8391), "Finance", "https://www.MoneyControl.com/" },
                    { 5, 0, new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8406), new DateTime(2021, 7, 24, 5, 51, 42, 506, DateTimeKind.Utc).AddTicks(8409), "Finance", "https://www.ICICI.com/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "prm",
                table: "Document",
                keyColumn: "DocumentId",
                keyValue: 5);
        }
    }
}
