﻿using AuthUserToken.Domain.Model.Entity;
using AuthUserToken.Domain.Model.Request;

namespace AuthUserToken.Domain.Interface.Repository
{
    public interface IUserRepository
    {
        Task<User> RegisterUserAsync(User user);
        Task<User> LoginUserAsync(UserLoginRequest request);

        Task<User> GetUserByIdAsync(int idUser);
        Task<User> GetUserByEmailAsync(string email);
        Task<User> GetUserByNickNameAsync(string nickName);

        Task<User> UpdateUserAsync(User user);
    }
}