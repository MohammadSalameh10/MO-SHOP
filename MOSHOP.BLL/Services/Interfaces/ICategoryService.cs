using MOSHOP.DAL.DTO.Requests;
using MOSHOP.DAL.DTO.Responses;
using MOSHOP.DAL.Models;

namespace MOSHOP.BLL.Services.Interfaces
{
    public interface ICategoryService : IGenericService<CategoryRequest, CategoryResponses, Category>
    {

    }
}
