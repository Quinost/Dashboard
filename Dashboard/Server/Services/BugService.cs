using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using Dashboard.Shared;
using Dashboard.Infrastructure;
using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Models;
using Dashboard.Server.Services.Interfaces;
using AutoMapper;
using System.Collections.Generic;

namespace Dashboard.Server.Services
{
    public class BugService : IBugService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BugService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<BugsWithCountModel>> GetBugs(int startIndex, int count)
        {
            try
            {
                var retVal = new BugsWithCountModel();
                var bugsList = await _context.Bugs
                    .OrderBy(x => x.Id)
                    .Skip(startIndex)
                    .Take(count)
                    .AsNoTracking()
                    .ToListAsync();
                retVal.Bugs = _mapper.Map<IList<BugModel>>(bugsList);
                retVal.TotalCount = await _context.Bugs.CountAsync();
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
                _context.Bugs.Add(model);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while saving bug: " + ex.Message);
            }
        }
    }
}
