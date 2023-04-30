using System.ComponentModel.DataAnnotations;

namespace Dashboard.Infrastructure.Entity;
public class RoleEntity
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}
