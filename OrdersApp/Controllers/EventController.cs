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

        /// <summary>
        /// A form for adding a new order
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(OrderInsertInputModel order)
        {
            if (ModelState.IsValid)
            {
                //var orderModel = _mapper.Map<OrderModel>(order);
                //_orderService.AddOrder(orderModel);
                return RedirectToAction(_ordersUrl);
            }
            return View();
        }

        /// <summary>
        /// A form with all orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Orders()
        {
            var orders = new List<OrderModel>() {
                new OrderModel {
                Number = 23,
                AddressOfRecipient = "Samara",
                AddressOfSender = "Bugaga",
                CityOfRecipient = "SPB",
                CityOfSender = "Yoy",
                CargoWeight = 35.6,
                DepartureDate = new DateTime(2022, 4, 23, 15, 30, 00)
                },
                new OrderModel {
                Number = 23,
                AddressOfRecipient = "Samara",
                AddressOfSender = "Bugaga",
                CityOfRecipient = "SPB",
                CityOfSender = "Yoy",
                CargoWeight = 35.6,
                DepartureDate = new DateTime(2022, 4, 23, 15, 30, 00)
                }
            };
            var outputs = _mapper.Map<List<OrderOutputModel>>(orders);
            return View(outputs);
        }
    }
}
