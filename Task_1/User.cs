using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_1
{
    interface ISearchable
    {
        List<Product> SearchByPrice(double maxPrice);
        List<Product> SearchByCategory(string category);
        List<Product> SearchByRating(int minRating);
    }

    class User : ISearchable
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Product> PurchaseHistory { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            PurchaseHistory = new List<Product>();
        }

        public void AddToPurchaseHistory(Product product)
        {
            PurchaseHistory.Add(product);
        }

        public List<Product> SearchByPrice(double maxPrice)
        {
            return PurchaseHistory
                .Where(product => product.Price <= maxPrice)
                .ToList();
        }

        public List<Product> SearchByCategory(string category)
        {
            return PurchaseHistory
                .Where(product => product.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<Product> SearchByRating(int minRating)
        {
            return PurchaseHistory
                .Where(product => product.Rating >= minRating)
                .ToList();
        }
    }
}