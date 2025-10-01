using Microsoft.AspNetCore.Http;
using MOSHOP.DAL.DTO.Requests;
using MOSHOP.DAL.DTO.Responses;

namespace MOSHOP.BLL.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<UserResponse> LoginAsync(LoginRequest loginRequest);
        Task<UserResponse> RegisterAsync(RegisterRequest registerRequest, HttpRequest request);
        Task<string> ConfirmEmailAsync(string token, string userId);
        Task<bool> ForgotPasswordAsync(ForgotPasswordRequest request);
        Task<bool> ResetPasswordAsync(ResetPasswordRequest request);

    }
}
