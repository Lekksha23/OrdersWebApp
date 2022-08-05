using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrdersApp.Business.Models;
using OrdersApp.Business.Services.Interfaces;
using OrdersApp.Models;

namespace OrdersApp.Controllers
{
    public class EventController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        private const string _ordersUrl = "Orders";

        public EventController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        // Screen for adding an order
        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }

        // Screen for adding an order
        [HttpPost]
        public IActionResult Order(OrderInsertInputModel order)
        {
            if (ModelState.IsValid)
            {
                var orderModel = _mapper.Map<OrderModel>(order);
                _orderService.AddOrder(orderModel);
                return RedirectToAction(_ordersUrl);
            }
            return View();
        }

        // Get all orders
        [HttpGet]
        public IActionResult Orders()
        {
            var orders = _orderService.GetAllOrders();
            var outputs = _mapper.Map<List<OrderOutputModel>>(orders);
            return View(outputs);
        }
    }
}
