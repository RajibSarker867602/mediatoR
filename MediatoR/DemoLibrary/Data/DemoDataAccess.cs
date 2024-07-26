using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Data
{
    public class DemoDataAccess : IDataAccess
    {
        private List<Product> products;
        public DemoDataAccess()
        {
            products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 80000 });
            products.Add(new Product { Id = 2, Name = "Mouse", Price = 500 });
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product InsertProduct(string name, double price)
        {
            var product = new Product { Id = products.Max(c => c.Id) + 1, Name = name, Price = price };
            products.Add(product);
            return product;
        }
    }
}
