using MOSHOP.DAL.DTO.Requests;
using MOSHOP.DAL.DTO.Responses;
using MOSHOP.DAL.Models;

namespace MOSHOP.BLL.Services.Interfaces
{
    public interface IBrandService : IGenericService<BrandRequest, BrandResponses, Brand>
    {
        Task<int> CreateFileAsync(BrandRequest request);
    }
}
