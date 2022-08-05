using AutoMapper;
using OrdersApp.Business.Models;
using OrdersApp.Business.Services.Interfaces;
using OrdersApp.Data.Entities;
using OrdersApp.Data.Repositories;

namespace OrdersApp.Business
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public List<OrderModel> GetAllOrders()
        {
            var entities = _orderRepository.GetAllOrders();
            return _mapper.Map<List<OrderModel>>(entities);
        }

        public void AddOrder(OrderModel orderModel)
        {
            var order = _mapper.Map<Order>(orderModel);
            _orderRepository.AddOrder(order);
        }
    }
}
