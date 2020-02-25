using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FamousBeanPortal.Migrations
{
    public partial class EmptyLocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    MealId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    MealName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    NutritionValues = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderedTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Products = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    OrderAmount = table.Column<decimal>(nullable: false),
                    OrderStatus = table.Column<string>(nullable: true),
                    DeviceInfo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserType = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Locations = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
