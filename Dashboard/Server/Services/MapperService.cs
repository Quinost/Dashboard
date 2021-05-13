using AutoMapper;
using Dashboard.Infrastructure.Entity;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Server.Services
{
    public class MapperService : Profile
    {
        public MapperService()
        {
            CreateMap<BugEntity, BugModel>();
            CreateMap<RoleEntity, RoleModel>();

            CreateMap<UserEntity, UserModel>()
                .ForMember(src => src.PasswordHash, x => x.MapFrom(v => v.Password))
                .ReverseMap();

            CreateMap<IdentityResult, string[]>()
                .ConvertUsing<ConvertToErrorArray>();
        }

        private class ConvertToErrorArray : ITypeConverter<IdentityResult, string[]>
        {
            string[] ITypeConverter<IdentityResult, string[]>.Convert(IdentityResult source, string[] destination, ResolutionContext context) 
                => source.Errors.Select(x => x.Code).ToArray();
        }
    }
}
