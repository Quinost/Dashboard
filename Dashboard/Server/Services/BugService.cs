using Dashboard.Server.Context;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Dashboard.Server.Context.Entity;
using System.Collections.Generic;
using System;
using Dashboard.Shared;

namespace Dashboard.Server.Services
{
    public class BugService
    {
        private readonly DataContext context;

        public BugService(DataContext _context)
        {
            context = _context;
        }

        public async Task<BugsWithTotalCountModel> GetBugs(int startIndex, int count)
        {
            var retVal = new BugsWithTotalCountModel();
            try
            {
                retVal.Bugs = (await context.Bugs
                    .OrderBy(x => x.Id)
                    .Skip(startIndex)
                    .Take(count)
                    .AsNoTracking()
                    .ToListAsync()).ToBugModel();
                retVal.TotalCount = await context.Bugs.CountAsync();
            }
            catch (Exception ex)
            {
                await SaveBug(new BugEntity {  Message = ex.Message, System = "CORE API" });
            }
            return retVal;
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
