﻿namespace ECommerce.API.Models
{
    public class CreateProductRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
    
}
