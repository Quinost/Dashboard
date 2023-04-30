using AutoMapper;
using Dashboard.Functions.Functions.Bugs.Queries.GetBugsList;
using Dashboard.Functions.Functions.Users.Queries.GetRoleList;
using Dashboard.Functions.Functions.Users.Queries.GetUserList;
using Dashboard.Infrastructure.Entity;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;

namespace Dashboard.Infrastructure;
public class MapperService : Profile
{
    public MapperService()
    {
        CreateMap<BugEntity, BugModel>();
        CreateMap<RoleEntity, RoleModel>();

        CreateMap<UserEntity, UserModel>()
            .ReverseMap();

        CreateMap<IdentityResult, string[]>()
            .ConvertUsing<ConvertToErrorArray>();

        CreateMap<BugsWithCountRead, BugsWithCountModel>().ForMember(dst => dst.Bugs, opt => opt.MapFrom<IEnumerable<BugRead>>(src => src.Bugs));
        CreateMap<BugRead, BugModel>();
        CreateMap<BugEntity, BugRead>();

        CreateMap<UserEntity, UserRead>();
        CreateMap<UserRead, UserModel>();

        CreateMap<RoleRead, RoleModel>();
        CreateMap<RoleEntity, RoleRead>();
    }

    private class ConvertToErrorArray : ITypeConverter<IdentityResult, string[]>
    {
        string[] ITypeConverter<IdentityResult, string[]>.Convert(IdentityResult source, string[] destination, ResolutionContext context)
            => source.Errors.Select(x => x.Code).ToArray();
    }
}
