using Blogger.ApplicationServices.DTOs;
using Blogger.ApplicationServices.Helpers;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices
{
    public class CategoriesManagementService : BaseManagementService
    {
        public int Delete(int id)
        {
            try
            {
                Category category = context.Categories.Find(id);
                if (category == null)
                {
                    return -1;
                }

                context.Categories.Remove(category);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Edit(CategoryDto categoryDto)
        {
            try
            {
                Category category = context.Categories.Find(categoryDto.Id);
                if (category == null)
                {
                    return -1;
                }

                category.Name = categoryDto.Name;
                category.IsActive = categoryDto.IsActive;
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public CategoryDto GetByName(string name)
        {
            return context.Categories.AsNoTracking().SingleOrDefault(c => c.Name == name)?.ToCategoryDto(); ;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return context.Categories.AsNoTracking().AsEnumerable().ToCategoryDtos();
        }

        public int Save(CategoryDto categoryDto)
        {
            try
            {
                context.Categories.Add(categoryDto.ToCategoryEntity());
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
