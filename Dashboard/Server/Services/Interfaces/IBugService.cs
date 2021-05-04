using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Models;
using Dashboard.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Interfaces
{
    public interface IBugService
    {
        Task<Result<BugsWithCountModel>> GetBugs(int startIndex, int count);
        Task SaveBug(string message, string system, DateTime date);
        Task SaveBug(string message, string system);
    }
}
