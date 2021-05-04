using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Dashboard.Shared;
using Dashboard.Infrastructure;
using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Models;
using Dashboard.Server.Services.Interfaces;

namespace Dashboard.Server.Services
{
    public class BugService : IBugService
    {
        private readonly DataContext context;

        public BugService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Result<BugsWithCountModel>> GetBugs(int startIndex, int count)
        {
            try
            {
                var retVal = new BugsWithCountModel();
                retVal.Bugs = (await context.Bugs
                    .OrderBy(x => x.Id)
                    .Skip(startIndex)
                    .Take(count)
                    .AsNoTracking()
                    .ToListAsync()).ToBugModel();
                retVal.TotalCount = await context.Bugs.CountAsync();
                return Result<BugsWithCountModel>.Success(retVal);
            }
            catch (Exception ex)
            {
                await SaveBug(new BugEntity {  Message = ex.Message, System = "CORE API" });
                return Result<BugsWithCountModel>.Failed(ex.Message);
            }
        }


        public async Task SaveBug(string message, string system) 
            => await SaveBug(new BugEntity { Message = message, System = system });

        public async Task SaveBug(string message, string system, DateTime date)
            => await SaveBug(new BugEntity { Message = message, System = system, Date = date });

        private async Task SaveBug(BugEntity model)
        {
            try
            {
                context.Bugs.Add(model);
                await context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while saving bug: " + ex.Message);
            }
        }
    }
}
