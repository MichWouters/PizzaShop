using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaShop.Migrations
{
    public partial class moreIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Olives", 6 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { true, "Mozarella", 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Gouda", 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { true, "Parmesan", 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { false, "Salami", 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { false, "Bacon", 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { false, "Merguez", 2 });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "DateCreated", "DateModified", "IsVegetarian", "ModifiedBy", "Name", "Type" },
                values: new object[,]
                {
                    { 20, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Vinegar", 7 },
                    { 19, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Olive Oil", 7 },
                    { 18, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "BBQ Sauce", 7 },
                    { 17, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Green peppers", 5 },
                    { 15, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Squid", 3 },
                    { 16, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Onion", 5 },
                    { 13, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Anchovie", 3 },
                    { 14, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Salmon", 3 },
                    { 12, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Salt", 4 },
                    { 11, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Pepper", 4 },
                    { 10, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, "Thyme", 4 },
                    { 9, new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Chicken", 2 }
                });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "IngredientId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "PizzaIngredients",
                columns: new[] { "Id", "IngredientId", "PizzaId" },
                values: new object[,]
                {
                    { 11, 1, 3 },
                    { 12, 2, 3 },
                    { 13, 3, 3 },
                    { 14, 6, 3 },
                    { 15, 7, 3 },
                    { 16, 8, 3 }
                });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 19, 1 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 19, 2 });

            migrationBuilder.InsertData(
                table: "PizzaIngredients",
                columns: new[] { "Id", "IngredientId", "PizzaId" },
                values: new object[,]
                {
                    { 17, 17, 3 },
                    { 18, 19, 3 },
                    { 19, 20, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Mozarella", 1 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { false, "Salami", 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Thyme", 4 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { false, "Chicken", 2 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { true, "Anchovie", 3 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { true, "Onion", 5 });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                columns: new[] { "IsVegetarian", "Name", "Type" },
                values: new object[] { true, "BBQ Sauce", 7 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "IngredientId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 1, 3 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 4, 3 });

            migrationBuilder.UpdateData(
                table: "PizzaIngredients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IngredientId", "PizzaId" },
                values: new object[] { 5, 3 });
        }
    }
}
