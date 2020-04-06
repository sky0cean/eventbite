using Microsoft.EntityFrameworkCore.Migrations;

namespace EventCatalogApi.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "catalog_date_hilo",
                incrementBy: 10);

            migrationBuilder.CreateSequence(
                name: "catalog_price_hilo",
                incrementBy: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "CatalogPrices",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CatalogPrices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "CatalogDates",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CatalogDates",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CatalogDateId",
                table: "Catalog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CatalogPriceId",
                table: "Catalog",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_CatalogDateId",
                table: "Catalog",
                column: "CatalogDateId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_CatalogPriceId",
                table: "Catalog",
                column: "CatalogPriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogDates_CatalogDateId",
                table: "Catalog",
                column: "CatalogDateId",
                principalTable: "CatalogDates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogPrices_CatalogPriceId",
                table: "Catalog",
                column: "CatalogPriceId",
                principalTable: "CatalogPrices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogDates_CatalogDateId",
                table: "Catalog");

            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogPrices_CatalogPriceId",
                table: "Catalog");

            migrationBuilder.DropIndex(
                name: "IX_Catalog_CatalogDateId",
                table: "Catalog");

            migrationBuilder.DropIndex(
                name: "IX_Catalog_CatalogPriceId",
                table: "Catalog");

            migrationBuilder.DropSequence(
                name: "catalog_date_hilo");

            migrationBuilder.DropSequence(
                name: "catalog_price_hilo");

            migrationBuilder.DropColumn(
                name: "CatalogDateId",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "CatalogPriceId",
                table: "Catalog");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "CatalogPrices",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CatalogPrices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Date",
                table: "CatalogDates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CatalogDates",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
