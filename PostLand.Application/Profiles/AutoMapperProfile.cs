using AutoMapper;
using PostLand.Application.Features.Posts.Queries.GetPostList;
using PostLand.Domain.Entites;

namespace PostLand.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
          CreateMap<Post, GetPostListVM>().ReverseMap();
        }
        
    }
}
