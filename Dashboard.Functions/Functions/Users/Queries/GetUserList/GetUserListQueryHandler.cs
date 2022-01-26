using AutoMapper;
using Dashboard.Data;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Functions.Functions.Users.Queries.GetUserList;
public class GetUserListQueryHandler : IRequestHandler<GetUserListQuery, IEnumerable<UserRead>>
{
    private readonly DataContext context;
    private readonly IMapper mapper;

    public GetUserListQueryHandler(DataContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<UserRead>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
    {
        var usersList = await context.Users.AsNoTracking().ToListAsync();
        return mapper.Map<IEnumerable<UserRead>>(usersList);
    }
}
