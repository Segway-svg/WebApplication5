using Microsoft.AspNetCore.Mvc;
using OrderData;
using OrderModelsDb;
using OrderModelsDto;

namespace OrderBusiness.Controllers
{
    [Route("[controller]")]
    public class OrderController : Controller
    {
        // Контейнер с одним или несколькими endpoint-ами
        [HttpPost("create")]
        public CreateOrderResponse Create(
            [FromBody] CreateOrderRequest request)
        {
            CreateOrderCommand command = new CreateOrderCommand();
            return command.Execute(request);
        }

        [HttpGet("Get")]
        public GetOrderResponse GetOrders()
        {
            GetOrderCommand command = new GetOrderCommand();
            return command.Execute();
            //OrderRepository orderRepository = new OrderRepository();
            //return orderRepository.GetOrders();
        }


        // GetByID
        //[HttpGet("get")]
    }
}
