using FluentValidation;
using OrderModelsDto;

namespace OrderValidation
{
    public class CreateOrderRequestValidatior : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderRequestValidatior()
        {
            RuleFor(request => request.senderCity)
                .Cascade(CascadeMode.Stop)
                .MinimumLength(3)
                .WithMessage("senderCity must be longer than 3 letters");

            RuleFor(request => request.senderAddress)
                .Cascade(CascadeMode.Stop)
                .MinimumLength(3)
                .WithMessage("senderAddress must be longer than 3 letters");

            RuleFor(request => request.customerCity)
                .Cascade(CascadeMode.Stop)
                .MinimumLength(3)
                .WithMessage("Customer City must be longer than 3 letters");

            RuleFor(request => request.customerAddress)
                .Cascade(CascadeMode.Stop)
                .MinimumLength(3)
                .WithMessage("Customer address must be longer than 3 letters");

            RuleFor(request => request.packageWeight)
                .Cascade(CascadeMode.Stop)
                .LessThan(0)
                .WithMessage("Package weight must be greater than 0");

            RuleFor(request => request.deliveryDate)
                .Cascade(CascadeMode.Stop)
                .Must(deliveryDate => deliveryDate != DateTime.MinValue)
                //.Equal(DateTime.MinValue)
                .WithMessage("Incorrect delivery date");
        }
    }
}
