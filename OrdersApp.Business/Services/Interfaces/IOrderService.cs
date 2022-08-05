using OrdersApp.Business.Models;

namespace OrdersApp.Business.Services.Interfaces
{
    public interface IOrderService
    {
        void AddOrder(OrderModel orderModel);
        List<OrderModel> GetAllOrders();
    }
}