using OrderDataProvider;
using OrderModelsDb;

namespace OrderData
{
    public class OrderRepository
    {
        //public bool DoesTheSameAddressExist(string address)
        //{
        //    using (OrderDbContext context = new OrderDbContext())
        //    {
        //        return context.Orders.Any(o => o.senderAddress == "");
        //    }
        //}

        public List<DbOrder> GetOrders()
        {
            using (OrderDbContext context = new OrderDbContext())
            {
                return context.LSO.ToList();
            }    
        }

        public Guid CreateOrder(DbOrder order)
        {
            using (OrderDbContext context = new OrderDbContext())
            {
                context.LSO.Add(order);
                context.SaveChanges();
                return order.Id;
            }
        }

        //public DbOrder GetOrderById()
        //{
        //    using (OrderDbContext context = new OrderDbContext())
        //    {
        //        return;
        //    }
        //}
    }
}
