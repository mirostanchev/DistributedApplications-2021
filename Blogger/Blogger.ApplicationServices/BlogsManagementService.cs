using Blogger.ApplicationServices.DTOs;
using Blogger.ApplicationServices.Helpers;
using Blogger.Data.Contexts;
using Blogger.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices
{
    public class BlogsManagementService : BaseManagementService
    {
        public IEnumerable<BlogDto> GetAll()
        {
            return context.Blogs.AsNoTracking().AsEnumerable().ToBlogDtos();
        }

        public int Save(BlogDto blogDto)
        {
            try
            {
                context.Blogs.Add(blogDto.ToBlogEntity());
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Delete(int id)
        {
            try
            {
                Blog blog = context.Blogs.Find(id);
                if (blog == null)
                {
                    return -1;
                }

                context.Blogs.Remove(blog);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Edit(BlogDto blogDto)
        {
            try
            {
                Blog blog = context.Blogs.Find(blogDto.Id);
                if (blog == null)
                {
                    return -1;
                }

                blog.Title = blogDto.Title;
                blog.Content = blogDto.Content;
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public BlogDto GetByTitle(string title)
        {
            return context.Blogs.AsNoTracking().SingleOrDefault(b => b.Title == title)?.ToBlogDto(); ;
        }
    }
}
