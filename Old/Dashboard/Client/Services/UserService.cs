using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using System.Net.Http.Json;

namespace Dashboard.Client.Services;
public class UserService : IUserService
{
    private readonly HttpClient httpClient;

    public UserService(HttpClient _httpClient)
    {
        httpClient = _httpClient;
    }

    public async Task<List<UserModel>> GetUsers()
    {
        return await httpClient.GetFromJsonAsync<List<UserModel>>("api/users");
    }

    public async Task<List<RoleModel>> GetRoles()
    {
        return await httpClient.GetFromJsonAsync<List<RoleModel>>("api/users/roles");
    }

    public async Task UpdateUser(UserModel user)
    {
        await httpClient.PostAsJsonAsync("api/users", user);
    }

    public async Task AddUser(UserModel user)
    {
        await httpClient.PutAsJsonAsync("api/users", user);
    }
}
