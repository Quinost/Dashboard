using Dashboard.Server.Context.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Dashboard.Server.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options ) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BugEntity> Bugs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddDefaultUser(modelBuilder);
            AddBugs(modelBuilder);
        }

        private static void AddBugs(ModelBuilder modelBuilder)
        {
            var list = new List<BugEntity>();
            int startNumber = 0;
            for (int i = 1; i < 500; i++)
            {
                if (i % 50 == 0)
                    startNumber = i;
                list.Add(new BugEntity
                {
                    Id = i,
                    Message = "Error number: " + i,
                    System = "System number: " + startNumber,
                    Date = DateTime.Now
                });
            }
            modelBuilder.Entity<BugEntity>().HasData(list);
        }

        private static void AddDefaultUser(ModelBuilder modelBuilder)
        {
            var defaultUser = new UserEntity
            {
                Id = Guid.NewGuid(),
                Username = "Dashboard"
            };
            defaultUser.Password = new PasswordHasher<UserEntity>().HashPassword(defaultUser, "securePass");
            modelBuilder.Entity<UserEntity>().HasData(defaultUser);
        }
    }
}
