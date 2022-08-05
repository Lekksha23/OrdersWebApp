using OrdersApp.Business.Models;

namespace OrdersApp.Business.Services.Interfaces
{
    public interface IOrderService
    {
        int AddOrder(OrderModel orderModel);
        List<OrderModel> GetAllOrders();
    }
}