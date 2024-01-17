using OrderModelsDb;
using OrderModelsDto;

namespace OrderMappers
{
    public class DbOrderMapper
    {
        public DbOrder Map(CreateOrderRequest request)
        {
            DbOrder dbOrder = new DbOrder()
            {
                Id = Guid.NewGuid(),
                senderCity = request.senderCity,
                senderAddress = request.senderAddress,
                customerCity = request.customerCity,
                customerAddress = request.customerAddress,
                packageWeight = request.packageWeight,
                deliveryDate = request.deliveryDate,
            };

            return dbOrder;
        }
    }
}
