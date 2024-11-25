using CleanArchitecure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Application
{
    public class FakeProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            return new List<Product> {
                new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 100, StockCount = 10, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 200, StockCount = 20, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 3, Name = "Product 3", Description = "Description 3", Price = 300, StockCount = 30, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 4, Name = "Product 4", Description = "Description 4", Price = 400, StockCount = 40, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Product { Id = 5, Name = "Product 5", Description = "Description 5", Price = 500, StockCount = 50, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            };
        }
    }
}
