using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModelsDto
{
    public class OrdersInfo
    {
        public Guid Id { get; set; }
        public string senderCity { get; set; }
        public string senderAddress { get; set; }
        public string customerCity { get; set; }
        public string customerAddress { get; set; }
        public double packageWeight { get; set; }
        public DateTime deliveryDate { get; set; }
    }
}
