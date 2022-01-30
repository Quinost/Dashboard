using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.Components;

namespace Dashboard.Client.Pages.Administartor;

public partial class Users
{
    [Inject] private IUserService userService { get; set; }

    public List<UserModel> UserList { get; set; } = new List<UserModel>();
    public List<RoleModel> RoleList { get; set; } = new List<RoleModel>();
    protected override async Task OnInitializedAsync()
    {
        RoleList = await userService.GetRoles();
        UserList = await userService.GetUsers();
    }
}
