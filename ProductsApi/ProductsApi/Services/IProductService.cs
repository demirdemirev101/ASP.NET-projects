using ProductsApi.Data;

namespace ProductsApi.Services
{
    public interface IProductService
    {
        public List<Product>GetAllProducts();
        public Product GetById(int id);
        Product CreateProduct(string name, string description);
        void EditProduct(int id, Product product);
        void EditProductPartially(int id, Product product);
        Product DeleteProduct(int id);
    }
}
