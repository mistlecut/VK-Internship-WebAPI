using UserControlAPI.Bll.Models;

namespace UserControlAPI.Responses;

public record GetUsersResponse(
    UserModel[] Users);