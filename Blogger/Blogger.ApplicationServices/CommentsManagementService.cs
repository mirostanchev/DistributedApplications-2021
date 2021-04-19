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
    public class CommentsManagementService : BaseManagementService
    {
        public int Delete(int id)
        {
            try
            {
                Comment comment = context.Comments.Find(id);
                if (comment == null)
                {
                    return -1;
                }

                context.Comments.Remove(comment);
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Edit(CommentDto commentDto)
        {
            try
            {
                Comment comment = context.Comments.Find(commentDto.Id);
                if (comment == null)
                {
                    return -1;
                }

                comment.Content = commentDto.Content;
                comment.IsVisible = commentDto.IsVisible;
                context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public CommentDto GetById(int id)
        {
            return context.Comments.AsNoTracking().SingleOrDefault(c => c.Id == id)?.ToCommentDto(); ;
        }

        public IEnumerable<CommentDto> GetAll()
        {
            return context.Comments.AsNoTracking().AsEnumerable().ToCommentDtos();
        }

        public int Save(CommentDto commentDto)
        {
            try
            {
                context.Comments.Add(commentDto.ToCommentEntity());
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
