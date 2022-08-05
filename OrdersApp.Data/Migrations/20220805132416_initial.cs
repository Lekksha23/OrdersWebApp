using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrdersApp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityOfSender = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AddressOfSender = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CityOfRecipient = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AddressOfRecipient = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CargoWeight = table.Column<double>(type: "float", nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressOfRecipient", "AddressOfSender", "CargoWeight", "CityOfRecipient", "CityOfSender", "DepartureDate", "IsDeleted" },
                values: new object[] { 1, "ул. Пушкина, д 7, кв 35", "ул Ломоносова, д 39", 33.5, "Самара", "Санкт-Петербург", new DateTime(2022, 4, 23, 15, 30, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressOfRecipient", "AddressOfSender", "CargoWeight", "CityOfRecipient", "CityOfSender", "DepartureDate", "IsDeleted" },
                values: new object[] { 2, "ул. Пушкина, д 2, кв 7", "ул Ломоносова, д 39", 3.5, "Днепропетровск", "Санкт-Петербург", new DateTime(2022, 5, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressOfRecipient", "AddressOfSender", "CargoWeight", "CityOfRecipient", "CityOfSender", "DepartureDate", "IsDeleted" },
                values: new object[] { 3, "ул. Пушкина, д 23, кв 24", "ул Ломоносова, д 39", 60.700000000000003, "Челябинск", "Санкт-Петербург", new DateTime(2022, 4, 25, 14, 50, 0, 0, DateTimeKind.Unspecified), false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
