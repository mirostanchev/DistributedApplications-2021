using Blogger.ApplicationServices.DTOs;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices.Helpers
{
    public static class CategoryConvertHelper
    {
        public static Category ToCategoryEntity(this CategoryDto category)
        {
            return new Category()
            {
                Id = category.Id,
                Name = category.Name,
                IsActive = category.IsActive,
            };
        }

        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
                IsActive = category.IsActive,
            };
        }

        public static IEnumerable<CategoryDto> ToCategoryDtos(this IEnumerable<Category> categories)
        {
            return categories.Select(c => c.ToCategoryDto());
        }
    }
}
