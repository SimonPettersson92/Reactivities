using System.Linq;
using AutoMapper;
using Domain;

namespace Application.Activities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Activity, ActivityDTO>();
            CreateMap<UserActivity, AttendeeDTO>()
                .ForMember(dest => dest.Username, options => options.MapFrom(source => source.AppUser.UserName))
                .ForMember(dest => dest.DisplayName, options => options.MapFrom(source => source.AppUser.DisplayName))
                .ForMember(dest => dest.Image, options => options.MapFrom(source => source.AppUser.Photos.FirstOrDefault(x => x.IsMain).Url));
        }
    }
}