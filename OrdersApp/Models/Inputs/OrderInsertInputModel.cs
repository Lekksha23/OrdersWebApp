using System.ComponentModel.DataAnnotations;

namespace OrdersApp.Models
{
    public class OrderInsertInputModel
    {
        [Required(ErrorMessage = "Введите город отправителя")]
        public string CityOfSender { get; set; }

        [Required(ErrorMessage = "Введите адрес отправителя")]
        public string AddressOfSender { get; set; }

        [Required(ErrorMessage = "Введите город получателя")]
        public string CityOfRecipient { get; set; }

        [Required(ErrorMessage = "Введите адрес получателя")]
        public string AddressOfRecipient { get; set; }

        [Required(ErrorMessage = "Введите значение веса")]
        [Range(1, 80, ErrorMessage="Введите вес от 1 до 80 кг")]
        public double CargoWeight { get; set; }

        [Required(ErrorMessage = "Укажите дату отправки")]
        public DateTime DepartureDate { get; set; }
    }
}
