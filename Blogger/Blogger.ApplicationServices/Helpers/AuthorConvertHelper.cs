using Blogger.ApplicationServices.DTOs;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices.Helpers
{
    public static class AuthorConvertHelper
    {
        public static Author ToAuthorEntity(this AuthorDto authorDto)
        {
            return new Author()
            {
                Id = authorDto.Id,
                FirstName = authorDto.FirstName,
                LastName = authorDto.LastName,
                Email = authorDto.Email
            };
        }

        public static AuthorDto ToAuthorDto(this Author author)
        {
            return new AuthorDto()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email
            };
        }

        public static IEnumerable<AuthorDto> ToAuthorDtos(this IEnumerable<Author> authors)
        {
            return authors.Select(a => a.ToAuthorDto());
        }
    }
}
