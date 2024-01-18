using OrderModelsDb;
using OrderModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMappers
{
    public class DbGetOrderMapper
    {
        public OrdersInfo Map(DbOrder dbOrder)
        {
            OrdersInfo ordersInfo = new OrdersInfo()
            {
                Id = Guid.NewGuid(),
                senderCity = dbOrder.senderCity,
                senderAddress = dbOrder.senderAddress,
                customerCity = dbOrder.customerCity,
                customerAddress = dbOrder.customerAddress,
                packageWeight = dbOrder.packageWeight,
                deliveryDate = dbOrder.deliveryDate,
            };

            return ordersInfo;
        }
    }
}
