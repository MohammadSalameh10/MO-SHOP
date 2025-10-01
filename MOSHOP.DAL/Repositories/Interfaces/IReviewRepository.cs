using MOSHOP.DAL.Models;

namespace MOSHOP.DAL.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        Task<bool> UserHasReviewedProductAsync(string userId, int productId);
        Task AddReviewAsync(Review request, string userId);
    }
}
