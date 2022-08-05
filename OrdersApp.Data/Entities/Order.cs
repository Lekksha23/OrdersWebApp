namespace OrdersApp.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string CityOfSender { get; set; }
        public string AddressOfSender { get; set; }
        public string CityOfRecipient { get; set; }
        public string AddressOfRecipient { get; set; }
        public double CargoWeight { get; set; }
        public DateTime DepartureDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
