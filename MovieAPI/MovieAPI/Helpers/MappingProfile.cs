using AutoMapper;
using MovieAPI.Dtos;

namespace MovieAPI.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Map entre Movie et MovieDetailsDto
            CreateMap<Movie, MovieDetailsDto>();

            // Map entre MovieDto et Movie, avec une configuration spécifique pour ignorer le champ Poster
            CreateMap<MovieDto, Movie>()
                .ForMember(src => src.Poster, opt => opt.Ignore());
        }
    }
}
