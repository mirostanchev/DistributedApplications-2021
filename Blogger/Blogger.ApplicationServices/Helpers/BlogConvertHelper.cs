using Blogger.ApplicationServices.DTOs;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices.Helpers
{
    public static class BlogConvertHelper
    {
        public static Blog ToBlogEntity(this BlogDto blogDto)
        {
            return new Blog()
            {
                Id = blogDto.Id,
                Title = blogDto.Title,
                Content = blogDto.Content
            };
        }

        public static BlogDto ToBlogDto(this Blog blog)
        {
            return new BlogDto()
            {
                Id = blog.Id,
                Title = blog.Title,
                Content = blog.Content
            };
        }

        public static IEnumerable<BlogDto> ToBlogDtos(this IEnumerable<Blog> blogs)
        {
            return blogs.Select(b => b.ToBlogDto());
        }
    }
}
