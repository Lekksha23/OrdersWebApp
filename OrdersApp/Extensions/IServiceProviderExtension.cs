using OrdersApp.Business;
using OrdersApp.Business.Services.Interfaces;
using OrdersApp.Configurations;
using OrdersApp.Data.Repositories;
using OrdersApp.Business.Configurations;

namespace OrdersApp.Extensions
{
    public static class IServiceProviderExtension
    {
        public static void RegisterOrdersAppServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
        }

        public static void RegisterOrdersAppRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
        }

        public static void RegisterOrdersAppAutomappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperToBusiness), typeof(AutoMapperToData));
        }
    }
}
