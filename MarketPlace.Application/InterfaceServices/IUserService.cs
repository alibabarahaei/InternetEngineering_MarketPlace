using MarketPlace.Application.DTOs.Account;
using MarketPlace.Domain.Models.User;
using Microsoft.AspNetCore.Identity;

namespace MarketPlace.Application.InterfaceServices
{
    public interface IUserService : IAsyncDisposable
    {

        Task<IdentityResult> RegisterUserAsync(RegisterUserDTO registerUserDTO);
        Task<IdentityUser> IsUserNameInUseAsync(string userName);
        Task<IdentityUser> IsEmailInUseAsync(string email);
        Task<SignInResult> LoginUserAsync(LoginUserDTO loginUserDTO);
        Task LogOutUserAsync();
        Task<string> GenerateEmailConfirmationTokenAsync(EmailConfirmationDTO emailConfirmationDTO);
        Task<IdentityResult> EditProfileAsync(EditProfileDTO editProfileDTO);
        Task<ApplicationUser> GetUserAsync(GetUserDTO getuserDTO);

        Task<IdentityResult> ChangePasswordAsync(ChangepasswordDTO changepasswordDTO);

    }
}
