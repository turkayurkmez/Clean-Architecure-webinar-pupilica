using CleanArchitecure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecure.Application
{
    public class ProductService : IProductService
    {
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void ChangeProductImage(int productId, string imagePath)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void DiscountProduct(int productId, decimal discount)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void RateProduct(int productId, int rating, int customerId)
        {
            throw new NotImplementedException();
        }

        public List<Product> Search(string keyword)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
