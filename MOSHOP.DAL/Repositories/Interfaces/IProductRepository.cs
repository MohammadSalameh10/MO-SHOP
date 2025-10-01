using MOSHOP.DAL.Models;

namespace MOSHOP.DAL.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task DecreaseQuantityAsync(List<(int productId, int quantity)> items);
        List<Product> GetAllProductsWithImage();
    }
}
