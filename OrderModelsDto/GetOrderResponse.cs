﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModelsDto
{
    public class GetOrderResponse
    {
        public bool IsSuccess { get; set; }
        public string Error { get; set; }
        public List<OrdersInfo> OrdersInfo { get; set; }
    }
}
