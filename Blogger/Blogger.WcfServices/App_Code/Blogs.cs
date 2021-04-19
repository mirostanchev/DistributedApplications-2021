using Blogger.ApplicationServices;
using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Blogs" in code, svc and config file together.
public class Blogs : IBlogs
{
    private readonly BlogsManagementService service;

    public Blogs()
    {
        this.service = new BlogsManagementService();
    }

    public IEnumerable<BlogDto> GetBlogs()
    {
        return service.GetAll();
    }

    public int Save(string title, string content)
    {
        BlogDto blogDto = new BlogDto() { Title = title, Content = content };
        return service.Save(blogDto);
    }

    public int Delete(int id)
    {
        return service.Delete(id);
    }

    public int Edit(int id, string title, string content)
    {
        BlogDto blogDto = new BlogDto() 
        { 
            Id = id,
            Title = title,
            Content = content 
        };

        return service.Edit(blogDto);
    }

    public BlogDto GetByTitle(string title)
    {
        return service.GetByTitle(title);
    }
}
