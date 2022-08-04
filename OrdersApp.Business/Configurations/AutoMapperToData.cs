using AutoMapper;
using OrdersApp.Business.Models;
using OrdersApp.Data.Entities;

namespace OrdersApp.Business.Configurations
{
    internal class AutoMapperToData : Profile
    {
        public AutoMapperToData()
        {
            CreateMap<Order, OrderModel>().ReverseMap();
        }

    }
}
