namespace Dashboard.Functions.Functions.Users.Queries.GetRoleList;
public class GetRoleListQueryHandler : IRequestHandler<GetRoleListQuery, IEnumerable<RoleRead>>
{
    private readonly DataContext context;
    private readonly IMapper mapper;

    public GetRoleListQueryHandler(DataContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }
    public async Task<IEnumerable<RoleRead>> Handle(GetRoleListQuery request, CancellationToken cancellationToken)
    {
        var rolesList = await context.Roles.ToListAsync();
        return mapper.Map<IEnumerable<RoleRead>>(rolesList);
    }
}
