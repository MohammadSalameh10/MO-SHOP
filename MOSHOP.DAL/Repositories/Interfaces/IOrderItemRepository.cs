using MOSHOP.DAL.Models;

namespace MOSHOP.DAL.Repositories.Interfaces
{
    public interface IOrderItemRepository
    {
        Task AddRangeAsync(List<OrderItem> orderItem);
    }
}
