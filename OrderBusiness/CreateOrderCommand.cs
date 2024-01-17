using OrderModelsDto;
using OrderValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderMappers;
using OrderModelsDb;
using OrderData;
using System.ComponentModel;

namespace OrderBusiness
{
    public class CreateOrderCommand
    {
        public CreateOrderResponse Execute(CreateOrderRequest request)
        {
            CreateOrderResponse response = new CreateOrderResponse();

            CreateOrderRequestValidatior validator = new();

            FluentValidation.Results.ValidationResult validationResult = validator.Validate(request);

            if (!validationResult.IsValid)
            {
                new ArgumentException("Ошибка во входных данных");
            }

            DbOrderMapper mapper = new DbOrderMapper();
            DbOrder dbOrder = mapper.Map(request);

            OrderRepository orderRepository = new OrderRepository();

            return new CreateOrderResponse()
            {
                Id = orderRepository.CreateOrder(mapper.Map(request)),
                IsSuccess = true,
                Errors = new List<string>()
            };
        }
    }
}
