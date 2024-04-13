using System;

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaffronSlice.Infrastructure.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Orders",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false),
                Created = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Orders", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "PizzaTypes",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                Category = table.Column<string>(type: "TEXT", nullable: false),
                Ingredients = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_PizzaTypes", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Pizzas",
            columns: table => new
            {
                Id = table.Column<string>(type: "TEXT", nullable: false),
                PizzaTypeId = table.Column<string>(type: "TEXT", nullable: false),
                Size = table.Column<string>(type: "TEXT", nullable: false),
                Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Pizzas", x => x.Id);
                table.ForeignKey(
                    name: "FK_Pizzas_PizzaTypes_PizzaTypeId",
                    column: x => x.PizzaTypeId,
                    principalTable: "PizzaTypes",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "OrderDetails",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false),
                OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                PizzaId = table.Column<string>(type: "TEXT", nullable: false),
                Quantity = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_OrderDetails", x => x.Id);
                table.ForeignKey(
                    name: "FK_OrderDetails_Orders_OrderId",
                    column: x => x.OrderId,
                    principalTable: "Orders",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_OrderDetails_Pizzas_PizzaId",
                    column: x => x.PizzaId,
                    principalTable: "Pizzas",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_OrderDetails_OrderId",
            table: "OrderDetails",
            column: "OrderId");

        migrationBuilder.CreateIndex(
            name: "IX_OrderDetails_PizzaId",
            table: "OrderDetails",
            column: "PizzaId");

        migrationBuilder.CreateIndex(
            name: "IX_Pizzas_PizzaTypeId",
            table: "Pizzas",
            column: "PizzaTypeId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "OrderDetails");

        migrationBuilder.DropTable(
            name: "Orders");

        migrationBuilder.DropTable(
            name: "Pizzas");

        migrationBuilder.DropTable(
            name: "PizzaTypes");
    }
}
