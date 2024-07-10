using PostLand.Domain.Entites;

namespace PostLand.Application.Contracts
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync(bool includeCategory );

        Task<Post> GetListByTagIdAsync(Guid id, bool includeCategory);
    }
}
