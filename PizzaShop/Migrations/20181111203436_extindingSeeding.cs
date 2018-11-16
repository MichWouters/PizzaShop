using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PizzaShop.Migrations
{
    public partial class extindingSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc), "margherita.jpg" });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc), "pepperoni.jpg" });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(2018, 11, 10, 23, 0, 0, 0, DateTimeKind.Utc), "meatlovers.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 311, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 17, 23, 51, 312, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 23, 51, 312, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3,
                columns: new[] { "DateCreated", "Image" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}