using Blogger.ApplicationServices;
using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Comments" in code, svc and config file together.
public class Comments : IComments
{
    private readonly CommentsManagementService service;

    public Comments()
    {
        this.service = new CommentsManagementService();
    }

    public int Delete(int id)
    {
        return service.Delete(id);
    }

    public int Edit(int id, string content, bool isVisible)
    {
        CommentDto commentDto = new CommentDto()
        {
            Id = id,
            Content = content,
            IsVisible = isVisible
        };

        return service.Edit(commentDto);
    }

    public CommentDto GetById(int id)
    {
        return service.GetById(id);
    }

    public IEnumerable<CommentDto> GetComments()
    {
        return service.GetAll();
    }

    public int Save(string content, bool isVisible)
    {
        CommentDto commentDto = new CommentDto()
        {
            Content = content,
            IsVisible = isVisible
        };
        return service.Save(commentDto);
    }
}
