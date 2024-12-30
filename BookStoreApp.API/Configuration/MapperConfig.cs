using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Model.Author;

namespace BookStoreApp.API.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
           // CreateMap<Author, AuthorCreateDto>();
        }
    }
}
