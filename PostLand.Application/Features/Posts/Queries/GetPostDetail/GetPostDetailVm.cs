﻿using PostLand.Application.Features.Posts.Queries.GetPostList;
using PostLand.Domain.Entites;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public CategoryDto Category { get; set; }
    }
}
