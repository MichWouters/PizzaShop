using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaShop.Data.Migrations
{
    public partial class carts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pizzas",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pizzas",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PizzaId",
                table: "OrderDetails",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    PizzaId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 12, 25, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pizzas",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pizzas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PizzaId",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Customers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Customers",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 10,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 21,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "PizzaId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2018, 11, 24, 23, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pizzas_PizzaId",
                table: "OrderDetails",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "PizzaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
