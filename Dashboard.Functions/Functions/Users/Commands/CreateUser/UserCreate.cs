namespace Dashboard.Functions.Functions.Users.Commands.CreateUser;
public class UserCreate
{
    public string Username { get; set; }
    public string RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }
    public bool IsActive { get; set; }
    public int RoleId { get; set; }
}
