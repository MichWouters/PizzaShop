using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaShop.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Customers_CustomerID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_CustomerID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "IdDelivery",
                table: "OrderDetails",
                newName: "IsDelivery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDelivery",
                table: "OrderDetails",
                newName: "IdDelivery");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CustomerID",
                table: "OrderDetails",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Customers_CustomerID",
                table: "OrderDetails",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
