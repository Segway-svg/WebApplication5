using System.ComponentModel.DataAnnotations;

namespace OrderModelsDto
{
    public class CreateOrderRequest
    {
        [Required]
        public string senderCity { get; set; }
        [Required]
        public string senderAddress { get; set; }
        [Required]
        public string customerCity { get; set; }
        [Required]
        public string customerAddress { get; set; }
        public double packageWeight { get; set; }
        public DateTime deliveryDate { get; set; }
    }
}
