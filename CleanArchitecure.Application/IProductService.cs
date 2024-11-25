using CleanArchitecure.Domain;

namespace CleanArchitecure.Application
{
    public interface IProductService
    {

        //Uygulamam, ürün nesnesiyle ........ yapar. 
        List<Product> GetProducts();
        void RateProduct(int productId, int rating,int customerId);
        void DiscountProduct(int productId, decimal discount);
        void UpdateProduct(Product product);
        void AddProduct(Product product);
        void DeleteProduct(int productId);
        List<Product> Search(string keyword);

        void ChangeProductImage(int productId, string imagePath);



    }
}