using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class ProductRepository
    {
        private static ProductRepository repo = new ProductRepository();
        public static ProductRepository Current
        {
            get { return repo; }
        }
        private List<Product> data = new List<Product>
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return data;
        }
        public Product GetProduct(int id)
        {
            return data.FirstOrDefault(p => p.Id == id);
        }
    }
}