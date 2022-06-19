using AutoMapper;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using SiliconApi.Common.DTO.Response;
using SiliconApi.Data.Entities;
using System.Net;

namespace APICore.API.Utils
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserResponse>();
        }
    }
}