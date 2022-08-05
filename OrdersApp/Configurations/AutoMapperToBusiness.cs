using AutoMapper;
using OrdersApp.Business.Models;
using OrdersApp.Models;

namespace OrdersApp.Configurations
{
    public class AutoMapperToBusiness : Profile
    {
        public AutoMapperToBusiness()
        {
            CreateMap<OrderInsertInputModel, OrderModel>();
            CreateMap<OrderModel, OrderOutputModel>();
        }
    }
}
