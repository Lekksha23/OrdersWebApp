using System.ComponentModel.DataAnnotations;

namespace OrdersApp.Models
{
    public class OrderInsertInputModel
    {
        [Required(ErrorMessage ="Пожалуйста, введите название города")]
        [MaxLength(50, ErrorMessage="Такого города не существует")]
        public string CityOfSender { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите адрес отправителя")]
        [MaxLength(100, ErrorMessage = "Введите правильный адрес")]
        public string AddressOfSender { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите название города")]
        [MaxLength(50, ErrorMessage = "Такого города не существует")]
        public string CityOfRecipient { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите адрес получателя")]
        [MaxLength(100, ErrorMessage = "Введите правильный адрес")]
        public string AddressOfRecipient { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите вес груза")]
        [Range(0.1, 100, ErrorMessage="Введите вес от 0.1 до 100 кг")]
        public double CargoWeight { get; set; }

        [Required(ErrorMessage = "Пожалуйста, заполните дату")]
        public DateTime DepartureDate { get; set; }
    }
}
