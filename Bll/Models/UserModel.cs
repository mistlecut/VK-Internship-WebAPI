using UserControlAPI.Bll.Models.Enums;

namespace UserControlAPI.Bll.Models;

public record UserModel(
    string Login,
    string Password,
    GroupModel Group,
    StateModel State);