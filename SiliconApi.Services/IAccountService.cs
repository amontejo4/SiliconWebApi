using APSiliconApiICore.Common.DTO.Request;
using SiliconApi.Common.DTO.Request;
using SiliconApi.Data.Entities;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiliconApi.Services
{
    public interface IAccountService
    {
        Task SignUpAsync(SignUpRequest suRequest);

        Task<(User user, string accessToken, string refreshToken)> LoginAsync(LoginRequest loginRequest);

        Task LogoutAsync(string accessToken, ClaimsIdentity claimsIdentity);

        Task<ClaimsPrincipal> GetPrincipalFromExpiredTokenAsync(string token);

        Task GetRefreshTokenAsync(RefreshTokenRequest refreshToken, ClaimsPrincipal principal);
                       
        Task<User> UpdateProfileAsync(UpdateProfileRequest updateProfile, ClaimsIdentity claimsIdentity);

        Task<bool> ValidateTokenAsync(string token);

        Task<User> GetUserAsync(int userId);
        
    }
}