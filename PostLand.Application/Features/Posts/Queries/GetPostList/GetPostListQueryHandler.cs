using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;

namespace PostLand.Application.Features.Posts.Queries.GetPostList
{
    public class GetPostListQueryHandler : IRequestHandler<GetPostListQuery, List<GetPostListVM>>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public GetPostListQueryHandler(IPostRepository postRepository , IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }


        public async Task<List<GetPostListVM>> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {
             var postList =await _postRepository.GetAllPostsAsync(true);
            return _mapper.Map<List<GetPostListVM>>(postList);
        }
    }
}
