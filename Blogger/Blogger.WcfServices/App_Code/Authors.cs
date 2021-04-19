using Blogger.ApplicationServices;
using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Authors" in code, svc and config file together.
public class Authors : IAuthors
{
    private readonly AuthorsManagementService service;

    public Authors()
    {
        this.service = new AuthorsManagementService();
    }

    public int Delete(int id)
    {
        return service.Delete(id);
    }

    public int Edit(int id, string firstName, string lastName, string email)
    {
        AuthorDto authorDto = new AuthorDto()
        {
            Id = id,
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };

        return service.Edit(authorDto);
    }

    public IEnumerable<AuthorDto> GetAuthors()
    {
        return service.GetAll();
    }

    public AuthorDto GetByEmail(string email)
    {
        return service.GetByEmail(email);
    }

    public int Save(string firstName, string lastName, string email)
    {
        AuthorDto authorDto = new AuthorDto() 
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
        return service.Save(authorDto);
    }
}
