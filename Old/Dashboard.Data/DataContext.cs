using Dashboard.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<BugEntity> Bugs { get; set; }

    public DbSet<RoleEntity> Roles { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        AddDefaultUser(modelBuilder);
        AddBugs(modelBuilder);
        AddRoles(modelBuilder);
    }

    private static void AddRoles(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoleEntity>().HasData(new RoleEntity { Id = 1, Name = "Basic" });
        modelBuilder.Entity<RoleEntity>().HasData(new RoleEntity { Id = 2, Name = "Administrator" });
    }

    private static void AddBugs(ModelBuilder modelBuilder)
    {
        var list = new List<BugEntity>();
        for (int i = 1; i < 70; i++)
        {
            list.Add(new BugEntity
            {
                Id = i,
                Message = "Error number: " + i,
                System = "System number: " +  Guid.NewGuid(),
                Date = DateTime.Now
            });
        }
        modelBuilder.Entity<BugEntity>().HasData(list);
    }

    private static void AddDefaultUser(ModelBuilder modelBuilder)
    {
        var defaultAdmin = new UserEntity
        {
            Id = Guid.NewGuid(),
            Username = "AdminUser",
            IsActive = true,
            RoleId = 2,
            RefreshToken = String.Empty,
        };
        defaultAdmin.Password = new PasswordHasher<UserEntity>().HashPassword(defaultAdmin, "securePass");
        modelBuilder.Entity<UserEntity>().HasData(defaultAdmin);

        var defaultBasic = new UserEntity
        {
            Id = Guid.NewGuid(),
            Username = "BasicUser",
            IsActive = true,
            RoleId = 1,
            RefreshToken = String.Empty,
        };
        defaultBasic.Password = new PasswordHasher<UserEntity>().HashPassword(defaultBasic, "securePass");
        modelBuilder.Entity<UserEntity>().HasData(defaultBasic);
    }
}