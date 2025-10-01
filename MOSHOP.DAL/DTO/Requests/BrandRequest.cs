using Microsoft.AspNetCore.Http;

namespace MOSHOP.DAL.DTO.Requests
{
    public class BrandRequest
    {
        public string Name { get; set; }
        public IFormFile MainImage { get; set; }
    }
}
