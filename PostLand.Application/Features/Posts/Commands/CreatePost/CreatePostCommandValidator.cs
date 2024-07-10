using FluentValidation;

namespace PostLand.Application.Features.Posts.Commands.CreatePost
{
    public class CreatePostCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreatePostCommandValidator() {
            RuleFor(v => v.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);


            RuleFor(v => v.Content)
                .NotEmpty()
                .NotNull();
              
        }

    }
}
