using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class publishToGit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Кроссовки" },
                    { 2, "Футболки" },
                    { 3, "Шорты" },
                    { 4, "Аксессуары" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Nike" },
                    { 2, "Adidas" },
                    { 3, "Puma" },
                    { 4, "Helly Henson" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "CategoryId", "Code", "Count", "Desc", "Gender", "ManufacturerId", "Name", "PhotoPath", "Price" },
                values: new object[] { 1, 1, "CV0726-007", 23, "КРОССОВКИ NIKE M REACT VAPOR NXT CLY АРТИКУЛ: CV0726-007", 0, 1, "REACT VAPOR NXT CLY", "/Files/CV0726_007_preview.png", 7379.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Goods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
