using AutoMapper;
using OrdersApp.Business.Models;
using OrdersApp.Data.Repositories;

namespace OrdersApp.Business
{
    public class OrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {

        }

        public List<OrderModel> GetAllOrders()
        {
            var entities = _orderRepository.GetAllOrders();
            return _mapper.Map<List<OrderModel>>(entities);
        }

        //public int AddOrder(OrderModel orderModel)
        //{

        //}

    }
}
