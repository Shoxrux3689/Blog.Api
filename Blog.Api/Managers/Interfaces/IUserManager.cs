using Blog.Api.Entities;
using Blog.Api.Models;

namespace Blog.Api.Managers.Interfaces;

public interface IUserManager
{
    public Task Register(CreateUserModel createUser);
    public Task<string> Login(LoginUserModel loginUser);
    public Task<UserModel?> GetUserByUsername(string username);
    public Task<UserModel?> GetUserById(Guid id);
    public Task<UserModel?> GetUserWithPosts();
    public Task Update(UpdateUser updateUser);
}
