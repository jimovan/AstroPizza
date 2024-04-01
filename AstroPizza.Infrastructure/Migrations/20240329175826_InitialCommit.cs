using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AstroPizza.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "DateCreated", "DateLastModified", "IsVegetarian", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(4947), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(4992), false, "Pepperoni" },
                    { 2, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(4995), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(4996), false, "Ham" },
                    { 3, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(4998), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(4999), false, "Chicken" },
                    { 4, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5001), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5003), false, "Spicy Beef" },
                    { 5, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5005), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5006), false, "Bacon" },
                    { 6, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5008), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5009), false, "Mexican Chicken" },
                    { 7, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5013), true, "Peppers" },
                    { 8, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5015), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5016), true, "Sweetcorn" },
                    { 9, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5018), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5020), true, "Mushrooms" },
                    { 10, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5021), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5023), true, "Olives" },
                    { 11, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5025), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5026), true, "Pineapple" },
                    { 12, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5028), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5030), true, "Jalapenos" },
                    { 13, new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5032), new DateTime(2024, 3, 29, 17, 58, 26, 705, DateTimeKind.Local).AddTicks(5033), true, "Onions" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toppings");
        }
    }
}
