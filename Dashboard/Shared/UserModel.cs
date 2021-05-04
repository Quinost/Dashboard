using System;

namespace Dashboard.Shared
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
    }
}
