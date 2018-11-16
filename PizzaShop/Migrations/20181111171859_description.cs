using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace PizzaShop.Migrations
{
    public partial class description : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pizzas",
                nullable: true);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pizzas");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 243, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 245, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 245, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 9, 43, 40, 245, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 245, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 245, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 245, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 10, 30, 10, 43, 40, 245, DateTimeKind.Local));
        }
    }
}