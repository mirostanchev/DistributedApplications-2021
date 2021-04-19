using Blogger.ApplicationServices.DTOs;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices.Helpers
{
    public static class CommentConvertHelper
    {
        public static Comment ToCommentEntity(this CommentDto commentDto)
        {
            return new Comment()
            {
                Id = commentDto.Id,
                Content = commentDto.Content,
                IsVisible = commentDto.IsVisible
            };
        }

        public static CommentDto ToCommentDto(this Comment comment)
        {
            return new CommentDto()
            {
                Id = comment.Id,
                Content = comment.Content,
                IsVisible = comment.IsVisible
            };
        }

        public static IEnumerable<CommentDto> ToCommentDtos(this IEnumerable<Comment> comments)
        {
            return comments.Select(c => c.ToCommentDto());
        }
    }
}
