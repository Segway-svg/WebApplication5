using Microsoft.AspNetCore.Mvc;
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

        // GetAll
        //[HttpGet("Get")]
        //public int GetOrders()
        //{
        //    return 5;
        //}


        // GetByID
        //[HttpGet("get")]
    }
}
