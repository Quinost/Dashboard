namespace Dashboard.Functions.Functions.Bugs.Queries.GetBugsList;
public class GetBugsQueryHandler : IRequestHandler<GetBugsListQuery, BugsWithCountRead>
{
    private readonly DataContext context;
    private readonly IMapper mapper;

    public GetBugsQueryHandler(DataContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    public async Task<BugsWithCountRead> Handle(GetBugsListQuery request, CancellationToken cancellationToken)
    {
        var retVal = new BugsWithCountRead();
        var bugsList = await context.Bugs
            .OrderBy(x => x.Id)
            .Skip(request.StartIndex)
            .Take(request.Count)
            .AsNoTracking()
            .ToListAsync();
        retVal.Bugs = mapper.Map<IEnumerable<BugRead>>(bugsList);
        retVal.TotalCount = await context.Bugs.CountAsync(cancellationToken);
        return retVal;
    }
}
