﻿using Microsoft.AspNetCore.Identity;
using VirtualVisaCenter.Shared.DTOs;
using VirtualVisaCenter.Shared.Entities;

namespace VirualVisaCenter.API.Helpers
{
    public interface IUserHelper
    {

        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AdduserAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<SignInResult> LoginAsync(LoginDTO model);

        Task LogoutAsync();




        Task<IdentityResult> ChangePasswordAsync(User user, string currentPassword, string newPassword);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<User> GetUserAsync(Guid userId);
        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<string> GeneratePasswordResetTokenAsync(User user);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);



    }
}
