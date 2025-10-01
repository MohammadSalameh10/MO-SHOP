using Microsoft.AspNetCore.Http;
using MOSHOP.DAL.DTO.Requests;
using MOSHOP.DAL.DTO.Responses;

namespace MOSHOP.BLL.Services.Interfaces
{
    public interface ICheckOutService
    {
        Task<CheckOutResponse> ProcsessPaymentAsync(CheckOutRequest request, string UserId, HttpRequest httpRequest);

        Task<bool> HandlePaymentSuccessAsync(int orderId);
    }
}
