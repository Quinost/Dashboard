namespace Dashboard.Functions.Functions.Users.Queries.GetUserList;
public class UserRead
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }
    public bool IsActive { get; set; }
    public int RoleId { get; set; }
}
