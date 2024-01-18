using OrderData;
using OrderMappers;
using OrderModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBusiness
{
    public class GetOrderCommand
    {
        public GetOrderResponse Execute()
        {
            OrderRepository orderRepository = new OrderRepository();

            GetOrderResponse response = new GetOrderResponse();

            DbGetOrderMapper orderMapper = new DbGetOrderMapper();

            if (orderRepository.GetOrders().Count == 0)
            {
                return new GetOrderResponse()
                {
                    IsSuccess = false,
                    Error = "Orders data base is empty",
                    OrdersInfo = null
                };
            }

            response.OrdersInfo = new List<OrdersInfo>();

            foreach (var order in orderRepository.GetOrders())
            {
                response.OrdersInfo.Add(orderMapper.Map(order));
            }

            return new GetOrderResponse()
            {
                IsSuccess = true,
                Error = "",
                OrdersInfo = response.OrdersInfo
            };
        }
    }
}
