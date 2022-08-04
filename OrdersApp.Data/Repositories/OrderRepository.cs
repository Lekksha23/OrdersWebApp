using OrdersApp.Data.Entities;

namespace OrdersApp.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersAppContext _dbContext;

        public OrderRepository(OrdersAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Order> GetAllOrders() => _dbContext.Orders.Where(o => !o.IsDeleted).ToList();

        public void AddOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            Save();
        }

        private void Save() => _dbContext.SaveChanges();
    }
}
