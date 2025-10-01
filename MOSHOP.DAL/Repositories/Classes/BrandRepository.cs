using MOSHOP.DAL.Data;
using MOSHOP.DAL.Models;
using MOSHOP.DAL.Repositories.Interfaces;

namespace MOSHOP.DAL.Repositories.Classes
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {

        public BrandRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
