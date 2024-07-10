using AutoMapper;
using MediatR;
using PostLand.Application.Contracts;
using PostLand.Domain.Entites;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        
           
        public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            Post post = _mapper.Map<Post>(request);

            CreatePostCommandValidator validator = new CreatePostCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Post is not valid");
            }


            await _postRepository.AddAsync(post);
            return post.Id;
        }
    }
}
