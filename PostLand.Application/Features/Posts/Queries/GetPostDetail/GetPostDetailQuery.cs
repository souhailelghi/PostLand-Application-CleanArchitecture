using MediatR;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailQuery : IRequest<GetPostDetailVm>
    {
        public Guid PostId { get; set; }
    }
}
