using Blogger.ApplicationServices;
using Blogger.ApplicationServices.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Categories" in code, svc and config file together.
public class Categories : ICategories
{
    private readonly CategoriesManagementService service;

    public Categories()
    {
        this.service = new CategoriesManagementService();
    }

    public int Delete(int id)
    {
        return service.Delete(id);
    }

    public int Edit(int id, string name, bool isActive)
    {
        return service.Edit(new CategoryDto() { Id = id, Name = name, IsActive = isActive });
    }

    public CategoryDto GetByName(string name)
    {
        return service.GetByName(name);
    }

    public IEnumerable<CategoryDto> GetCategories()
    {
        return service.GetAll();
    }

    public int Save(string name, bool isActive)
    {
        return service.Save(new CategoryDto() { Name = name, IsActive = isActive });
    }
}
