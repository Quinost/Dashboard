using System;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Infrastructure.Entity
{
    public class BugEntity
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string System { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
