using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Dashboard.Shared;
using Dashboard.Infrastructure;
using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Models;

namespace Dashboard.Server.Services
{
    public class BugService
    {
        private readonly DataContext context;

        public BugService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Result<BugsWithTotalCountModel>> GetBugs(int startIndex, int count)
        {
            try
            {
                var retVal = new BugsWithTotalCountModel();
                retVal.Bugs = (await context.Bugs
                    .OrderBy(x => x.Id)
                    .Skip(startIndex)
                    .Take(count)
                    .AsNoTracking()
                    .ToListAsync()).ToBugModel();
                retVal.TotalCount = await context.Bugs.CountAsync();
                return Result<BugsWithTotalCountModel>.Success(retVal);
            }
            catch (Exception ex)
            {
                await SaveBug(new BugEntity {  Message = ex.Message, System = "CORE API" });
                return Result<BugsWithTotalCountModel>.Failed(ex.Message);
            }
        }

        public async Task SaveBug(BugEntity model)
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
