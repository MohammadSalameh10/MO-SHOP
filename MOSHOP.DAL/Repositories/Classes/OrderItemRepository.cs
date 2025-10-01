using MOSHOP.DAL.Data;
using MOSHOP.DAL.Models;
using MOSHOP.DAL.Repositories.Interfaces;

namespace MOSHOP.DAL.Repositories.Classes
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddRangeAsync(List<OrderItem> Item)
        {
            await _context.OrderItems.AddRangeAsync(Item);
            await _context.SaveChangesAsync();
        }
    }
}
