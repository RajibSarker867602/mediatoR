using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Data
{
    public interface IDataAccess
    {
        List<Product> GetProducts();
        Product InsertProduct(string name, double price);
    }
}
