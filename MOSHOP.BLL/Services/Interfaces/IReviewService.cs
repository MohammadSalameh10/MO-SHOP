using MOSHOP.DAL.DTO.Requests;

namespace MOSHOP.BLL.Services.Interfaces
{
    public interface IReviewService
    {
        Task<bool> AddReviewAsync(ReviewRequest reviewRequest, string userId);
    }
}
