using ApniDukaan.Core.Entities;
using ApniDukaan.Core.ResponseDTO;
using AutoMapper;

namespace ApniDukaan.Core.Mappers
{
    public class ApplicationUserToUserDTOMappingProfile : Profile
    {
        public ApplicationUserToUserDTOMappingProfile()
        {
            CreateMap<ApplicationUser, UserDTO>()
                .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PersonName, opt => opt.MapFrom(src => src.PersonName))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender));
        }
    }
}
