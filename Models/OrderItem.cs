﻿namespace ecommerce_Project.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Products? Product { get; set; }
        public int Quantity { get; set; }
    }

}
