using PostLand.Domain.Entites;

namespace PostLand.Application.Features.Posts.Queries.GetPostList
{
    public class GetPostListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public CategoryDto Category { get; set; }
    }
}
