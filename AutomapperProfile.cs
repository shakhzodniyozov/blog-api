using AutoMapper;

namespace blog_api;

public class AutomapperProfile : Profile
{
    public AutomapperProfile()
    {
        CreateMap<CreatePostDto, Post>();
        CreateMap<Post, PostDto>();
        CreateMap<UpdatePostDto, Post>();
        CreateMap<User, UserDto>();
    }
}
