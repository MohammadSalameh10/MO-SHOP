using MOSHOP.BLL.Services.Interfaces;
using MOSHOP.DAL.DTO.Requests;
using MOSHOP.DAL.DTO.Responses;
using MOSHOP.DAL.Models;
using MOSHOP.DAL.Repositories.Interfaces;

namespace MOSHOP.BLL.Services.Classes
{
    public class CategoryService : GenericService<CategoryRequest, CategoryResponses, Category>, ICategoryService
    {
        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {

        }

    }
}
