using UserControlAPI.Bll.Models.Enums;

namespace UserControlAPI.Bll.Models;

public record StateModel(
    int Id,
    StateCode Code,
    string Description);