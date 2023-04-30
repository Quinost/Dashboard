using System.ComponentModel.DataAnnotations;

namespace Dashboard.Infrastructure.Entity;
public class UserEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Username { get; set; }
    public string Password { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiry { get; set; }
    public bool IsActive { get; set; }
    public int RoleId { get; set; }
    public RoleEntity Role { get; set; }
}