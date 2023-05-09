using UserControlAPI.Bll.Models;

namespace UserControlAPI.Requests;

public record AddUsersRequest(
    string Login,
    string Password,
    GroupModel Group,
    StateModel State);