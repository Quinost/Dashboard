using Dashboard.Server.Context.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dashboard.Server.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options ) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var defaultUser = new UserEntity
            {
                Id = Guid.NewGuid(),
                Username = "Dashboard"
            };
            defaultUser.Password = new PasswordHasher<UserEntity>().HashPassword(defaultUser, "securePass");
            modelBuilder.Entity<UserEntity>().HasData(defaultUser);
        }
        public DbSet<UserEntity> Users { get; set; }

    }
}
