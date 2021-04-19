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
    public class AuthorsManagementService : BaseManagementService
    {
        public int Delete(int id)
        {
            try
            {
                Author author = context.Authors.Find(id);
                if (author == null)
                {
                    return -1;
                }

                context.Authors.Remove(author);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Edit(AuthorDto authorDto)
        {
            try
            {
                Author author = context.Authors.Find(authorDto.Id);
                if (author == null)
                {
                    return -1;
                }

                author.FirstName = authorDto.FirstName;
                author.LastName = authorDto.LastName;
                author.Email = authorDto.Email;
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public AuthorDto GetByEmail(string email)
        {
            return context.Authors.AsNoTracking().SingleOrDefault(a => a.Email == email)?.ToAuthorDto(); ;
        }

        public IEnumerable<AuthorDto> GetAll()
        {
            return context.Authors.AsNoTracking().AsEnumerable().ToAuthorDtos();
        }

        public int Save(AuthorDto authorDto)
        {
            try
            {
                context.Authors.Add(authorDto.ToAuthorEntity());
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
