﻿using System.ComponentModel.DataAnnotations;

namespace OrderModelsDto
{
    public class CreateOrderResponse
    {
        public Guid? Id { get; set; } 
    
        public bool IsSuccess { get; set; }

        public List<string> Errors { get; set; } = new List<string>();
    }
}
