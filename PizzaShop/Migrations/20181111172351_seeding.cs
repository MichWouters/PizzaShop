using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaShop.Migrations
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "Description",
                value: "The traditional toppings on a Margherita pizza are fresh basil, fresh tomatoes, olive oil, sea salt, garlic, and mozzarella. Typically, the tomatoes are sliced and scattered across the dough before finely chopped garlic and basil are sprinkled on, followed by rounds of thinly sliced cheese. The pizza is drizzled lightly with olive oil and sea salt just before baking, and when well made, it is crisp without any trace of greasiness.");

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2,
                column: "Description",
                value: "If you've ever wished your pepperoni pizza had more pepperoni on it, then this pizza is for you! This oven-fresh pizza has 50% more pepperoni than our average pizza pie.");

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3,
                column: "Description",
                value: "Meat lover's pizza is the perfect game day pizza, packed with pepperoni, Italian sausage, ham, bacon, season pork and beef.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 309, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 17, 18, 59, 310, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 11, 11, 18, 18, 59, 310, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2,
                column: "Description",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3,
                column: "Description",
                value: null);
        }
    }
}
