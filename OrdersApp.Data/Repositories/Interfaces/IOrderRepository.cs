using OrdersApp.Data.Entities;

namespace OrdersApp.Data.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        IEnumerable<Order> GetAllOrders();
    }
}