using UserControlAPI.Bll.Models;

namespace UserControlAPI.Bll.Services.Interfaces;

public interface IUserControlService
{
    Task AddUser(UserModel user);

    Task DeleteUser(int userId);

    Task<UserModel[]> GetUsers(int[] usersIds);
}