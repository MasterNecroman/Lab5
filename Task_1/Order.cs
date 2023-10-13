using System;
using System.Collections.Generic;

namespace Task_1
{
    
    class Order : ISearchable
    {
        public int OrderId { get; set; } 
        public List<Product> Products { get; set; }
        public int Quantity { get; set; } 
        public double TotalPrice { get; set; } 
        public string Status { get; set; } 

        public Order(int orderId, List<Product> products, int quantity, double totalPrice, string status)
        {
            OrderId = orderId;
            Products = products;
            Quantity = quantity;
            TotalPrice = totalPrice;
            Status = status;
        }

        
        public List<Product> SearchByPrice(double maxPrice)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in Products)
            {
                if (product.Price <= maxPrice)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public List<Product> SearchByCategory(string category)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in Products)
            {
                if (product.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product);
                }
            }
            return result;
        }

        public List<Product> SearchByRating(int minRating)
        {
            List<Product> result = new List<Product>();
            foreach (Product product in Products)
            {
                if (product.Rating >= minRating)
                {
                    result.Add(product);
                }
            }
            return result;
        }
    }
}