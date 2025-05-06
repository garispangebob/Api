using Api.Core.Entities;

namespace Api.Core.Interfaces.Services;

public interface IUserService : IBaseService<User>
{
    Task<bool> AuthorizeUser(User user);
    Task<bool> ChangePassword(User user, string oldPassword, string newPassword);
    Task<bool> GetCrptTokenForUser(User user);
    Task<User> GenerateSecurityToken(User user);
    Task<User> GetUserByLogin(string login);
}