using Microsoft.EntityFrameworkCore;
using OrdersApp.Data.Entities;

namespace OrdersApp.Data
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Number = 1,
                    CityOfSender = "Санкт-Петербург",
                    AddressOfSender = "ул Ломоносова, д 39",
                    CityOfRecipient = "Самара",
                    AddressOfRecipient = "ул. Пушкина, д 7, кв 35",
                    CargoWeight = 33.5,
                    DepartureDate = new DateTime(2022, 4, 23, 15, 30, 00)
                },
                new Order
                {
                    Number = 2,
                    CityOfSender = "Санкт-Петербург",
                    AddressOfSender = "ул Ломоносова, д 39",
                    CityOfRecipient = "Днепропетровск",
                    AddressOfRecipient = "ул. Пушкина, д 2, кв 7",
                    CargoWeight = 3.5,
                    DepartureDate = new DateTime(2022, 5, 2, 12, 15, 00)
                },
                new Order
                {
                    Number = 3,
                    CityOfSender = "Санкт-Петербург",
                    AddressOfSender = "ул Ломоносова, д 39", 
                    CityOfRecipient = "Челябинск",
                    AddressOfRecipient = "ул. Пушкина, д 23, кв 24",
                    CargoWeight = 60.7,
                    DepartureDate = new DateTime(2022, 4, 25, 14, 50, 00)
                });
        }
    }
}
