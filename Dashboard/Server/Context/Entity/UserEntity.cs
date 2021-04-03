using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Server.Context.Entity
{
    public class UserEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
